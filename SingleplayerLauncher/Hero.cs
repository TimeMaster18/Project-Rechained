using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SingleplayerLauncher
{

    public sealed class Hero
    {
        private static readonly Hero instance = new Hero();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit /Singleton
        static Hero() {}
        private Hero() {}

        public static Hero Instance
        {
            get
            {
                return instance;
            }
        }

        public string name { get; set; }
        private int objectOffset;
        private ConfigFile UPKFile;
        private byte[] skinPattern;
        public string skin { get; set; }

        public string[] Loadout { get; set; } // Could be it's own class if we get Guardians and Traits to work.
        private byte[] LoadoutHeader;

        private const int LoadoutSlotByteSize = 4;
        private const int LoadoutSlotsNumber = 9; 

        // TODO Add resource file with the rest of heroes and remove this (and use above ones)
        private const string NameMaximilian = "Maximilian";
        private int HeroObjectOffsetMaximilian = 0x28AB495; // Within the file offset where it starts
        private const string SpitfireGameUPKMaximilian = "..//SpitfireGame//CookedPCConsole//SpitfireGame.upk";
        private static readonly byte[] LoadoutHeaderMaximilian = new byte[] {   0xC6, 0x2C, 0x00, 0x00,
                                                                                0x00, 0x00, 0x00, 0x00,
                                                                                0xC5, 0x07, 0x00, 0x00,
                                                                                0x00, 0x00, 0x00, 0x00
                                                                                };
        private static readonly byte[] StartHeaderAfterLoadoutMaximilian = new byte[] { 0xF3, 0x2C, 0x00, 0x00,
                                                                                        0x00, 0x00, 0x00, 0x00,
                                                                                        0xC5, 0x07, 0x00, 0x00,
                                                                                        0x00, 0x00, 0x00, 0x00
                                                                                        };
        private static readonly byte[] WavesHeaderMaximillian = new byte[] {    0xF3, 0x2c, 0x00, 0x00,
                                                                                0x00, 0x00, 0x00, 0x00
                                                                                };
        private static readonly byte[] SkinPatternMaximilian = new byte[] { 0x5F, 0x0D, 0x00, 0x00,
                                                                            0x00, 0x00, 0x00, 0x00,
                                                                            0x6B, 0x66, 0x00, 0x00,
                                                                            0x00, 0x00, 0x00, 0x00,
                                                                            0x04, 0x00, 0x00, 0x00,
                                                                            0x00, 0x00, 0x00, 0x00,
                                                                            0xDC, 0x56
                                                                            };
        private static readonly byte[] IconToRemoveFromFileBytes = new byte[] { 0x30, 0x6E, 0x00, 0x00,
                                                                                0x00, 0x00, 0x00, 0x00,
                                                                                0x6B, 0x66, 0x00, 0x00,
                                                                                0x00, 0x00, 0x00, 0x00,
                                                                                0x04, 0x00, 0x00, 0x00,
                                                                                0x05, 0x00, 0x00, 0x00,
                                                                                0x41, 0xCC, 0x02, 0x00
                                                                                };
        private static readonly byte[] StartHeaderAfterGuardiansMaximillian = new byte[] { };

        public override void SaveLoadout(t)
        {
            // I think this method isn't needed anymore

            foreach (var loadoutSlot in comBoxLoadoutSlots)
            {
                var selected = loadoutSlot.Text;
                if (Resources.traps.ContainsKey(selected))
                {
                    loadoutSlotsBytes.Add(Resources.traps[selected]);
                }
                else
                {
                    loadoutSlotsBytes.Add(Resources.gear[selected]);
                }

            }
            bytes = loadoutSlotsBytes;

            MessageBox.Show("Saving your changes. Please wait.");
            UPKFile.Save(SpitfireGameUPK, Bytes);

            MessageBox.Show("Finished");
        }

        private void SetSkin(byte[] skin)
        {
            /*int index = -1;
            foreach(byte[] b in Resources.skins["Maximilian"].Values)
            {
                var tmp = skinHeader.ToList();
                tmp.AddRange(b);
                index = FindBytes(Bytes, tmp.ToArray());
                if (index != -1)
                    break;
            }*/

            int index = FindBytes(Bytes, skinPattern, startPosition) - 4;
            if (index == -1)
                throw new Exception("Can't find skin address");
            //MessageBox.Show(index.ToString());
            //Size of bytes the array will hold
            for (int i = 0; i < skin.Length; i++)
            {
                Bytes[index + i] = skin[i];
            }

            FindAndOverrideBytes();
        }

        /*Next update we will use this in the loadout editor to default the comboboxes to the traps the player is using
public override Dictionary<byte[], string> GetTraps()
{
   Dictionary<byte[], string> Dic = new Dictionary<byte[], string>();
   int index = FindBytes(Bytes, trapHeader);
   for (int i = 0; i < 9; i++)
   {
       byte[] trap = Bytes.ToList().GetRange(index + 28 + (i * 4), 4).ToArray();
       if (trap[0] == 0xF3)
           break;
       var t = Resources.traps[trap];
       Dic.Add(trap,t);
   }
   return Dic;
}*/

        public void ApplyLoadout(UPKFile UPKFile)
        {

            ApplyTrapsGear(UPKFile);
            //ApplyGuardians();
            //ApplyTraits();
            ApplySkin();
        }

        private void ApplyTrapsGear(UPKFile upkFile)
        {
            if (Loadout == null || Loadout.Length != 9)
                throw new Exception("9 traps/gear must be used");

            int startIndex = upkFile.FindBytes(LoadoutHeaderMaximilian, HeroObjectOffsetMaximilian);
            int endIndex = upkFile.FindBytes(StartHeaderAfterLoadoutMaximilian, HeroObjectOffsetMaximilian) - StartHeaderAfterLoadoutMaximilian.Length;

            byte[] loadoutBytes = ConvertLoadoutToBytes(Loadout);
            // Array Size in bytes // Array (start?) index // Array number of elements
            // 4 + 4 + 4
            int arrayOffset = 12;

            // Less than 9 slots are setup so we set them up to 9 and insert+remove bytes
            if (endIndex - startIndex < 12 * 4)
            {
                upkFile.OverrideSingleByte((byte)(LoadoutSlotsNumber + 1) * LoadoutSlotByteSize, startIndex); // Array Size
                upkFile.OverrideSingleByte((byte)LoadoutSlotsNumber, startIndex + 8); // Array Element Count

                int removeIndex = upkFile.FindBytes(IconToRemoveFromFileBytes, HeroObjectOffsetMaximilian);
                int nBytesRemove = IconToRemoveFromFileBytes.Length;
                upkFile.RemoveBytes(removeIndex, nBytesRemove);

                upkFile.InsertZeroedBytes();
            }


            

            upkFile.OverrideBytes(loadoutBytes, startIndex + arrayOffset);


            int c = 0;
            foreach (var bs in traps)
            {
                //0xF3 is the beginning of the next code so if we hit it we need to insert new bytes instead of replacing old bytes
                if (Bytes[index + 28 + c] == 0xF3)
                {
                    var tmpBytes = new List<byte>(Bytes);
                    tmpBytes.InsertRange(index + 28 + c, bs);
                    Bytes = tmpBytes.ToArray();
                }
                else
                {
                    //insert the bytes
                    for (int i = 0; i < bs.Length; i++)
                    {
                        Bytes[index + 28 + i + c] = bs[i];
                    }
                }
                c += 4;
            }
        }

        private byte[] ConvertLoadoutToBytes(string[] loadout)
        {
            byte[] loadoutBytes = new byte[LoadoutSlotsNumber * LoadoutSlotByteSize];

            for (int i = 0; i < loadout.Length; i+=LoadoutSlotByteSize)
            {
                byte[] slotBytes = new byte[LoadoutSlotByteSize];

                if (Resources.traps.ContainsKey(loadout[i]))
                {
                    slotBytes = Resources.traps[loadout[i]];
                }
                else
                {
                    slotBytes = Resources.gear[loadout[i]];
                }

                for (int j = i; j < LoadoutSlotByteSize; j++)
                {
                    loadoutBytes[j] = slotBytes[j];
                }
            }

            return loadoutBytes;
        }
    }
}
