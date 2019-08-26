using System;

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
        private int objectOffset { get; set; }
        public UPKFile UPKFile { get; set; }
        private byte[] skinPattern;
        public string skin { get; set; }

        public string[] loadout { get; set; } // Could be it's own class if we get Guardians and Traits to work.
        private byte[] loadoutHeader;

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
        private static readonly byte[] SkinPatternMaximilian = new byte[] { 0x52, 0x1E, 0x00, 0x00,
                                                                            0x00, 0x00, 0x00, 0x00,
                                                                            0x6B, 0x66, 0x00, 0x00,
                                                                            0x00, 0x00, 0x00, 0x00,
                                                                            0x04, 0x00, 0x00, 0x00,
                                                                            0x00, 0x00, 0x00, 0x00
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

        private void ApplySkin()
        {
            int skinIndex = UPKFile.FindBytesKMP(SkinPatternMaximilian, HeroObjectOffsetMaximilian) + SkinPatternMaximilian.Length;
            UPKFile.OverrideBytes(Resources.skins[NameMaximilian][skin], skinIndex);
        }

        public void ApplyLoadoutChanges()
        {
            ApplyTrapsGear();
            //ApplyGuardians();
            //ApplyTraits();
            ApplySkin();
        }

        private void ApplyTrapsGear()
        {
            if (loadout == null || loadout.Length != 9)
                throw new Exception("9 traps/gear must be used");

            int startIndex = UPKFile.FindBytesKMP(LoadoutHeaderMaximilian, HeroObjectOffsetMaximilian) + LoadoutHeaderMaximilian.Length;
            int endIndex = UPKFile.FindBytesKMP(StartHeaderAfterLoadoutMaximilian, HeroObjectOffsetMaximilian);

            // Where the actual array of the loadout starts is + 12 bytes from the loadout header.
            // Array Size in bytes // Array (start?) index // Array number of elements
            // 4 + 4 + 4
            int arrayOffset = 12;

            // Less than 9 slots are setup so we set them up to 9 and insert+remove bytes
            if (endIndex - startIndex < 12 * 4)
            {
                UPKFile.OverrideSingleByte((byte)(LoadoutSlotsNumber + 1) * LoadoutSlotByteSize, startIndex); // Array Size
                UPKFile.OverrideSingleByte((byte)LoadoutSlotsNumber, startIndex + 8); // Array Element Count ( the 4 bytes inbetween are "index 0")

                // Add new slots (2 slots)
                UPKFile.InsertZeroedBytes(startIndex + arrayOffset + 8, 2 * LoadoutSlotByteSize);

                // Remove 8 bytes to make space for 2 slots
                int removeIndex = UPKFile.FindBytesKMP(IconToRemoveFromFileBytes, HeroObjectOffsetMaximilian);
                int nBytesRemove = 2 * LoadoutSlotByteSize;
                UPKFile.RemoveBytes(removeIndex, nBytesRemove);

                // set to 0 the icon field (20 bytes remaining, we removed 8)
                UPKFile.OverrideBytes(UPKFile.CreateZeroedByteArray(IconToRemoveFromFileBytes.Length - nBytesRemove), removeIndex);
            }

            // Convert and apply Loadout
            byte[] loadoutBytes = ConvertLoadoutToBytes(loadout);
            UPKFile.OverrideBytes(loadoutBytes, startIndex + arrayOffset);           
        }

        private byte[] ConvertLoadoutToBytes(string[] loadout)
        {
            byte[] loadoutBytes = new byte[LoadoutSlotsNumber * LoadoutSlotByteSize];

            for (int i = 0; i < loadout.Length; i++)
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

                for (int j = 0; j < LoadoutSlotByteSize; j++)
                {
                    loadoutBytes[i * LoadoutSlotByteSize + j] = slotBytes[j];
                }
            }

            return loadoutBytes;
        }
    }
}
