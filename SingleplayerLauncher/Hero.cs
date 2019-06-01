using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SingleplayerLauncher
{

    public abstract class Hero
    {
        protected int fileLength = 0;
        public abstract void SetTraps(List<byte[]> traps);
        public abstract Dictionary<byte[], string> GetTraps();
        public static string SpitfireGameUPK = "..//SpitfireGame//CookedPCConsole//SpitfireGame.upk";
        protected static int FindBytes(byte[] haystack, byte[] needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (match(haystack, needle, i))
                {
                    return i;
                }
            }
            return -1;
        }

        protected static bool match(byte[] haystack, byte[] needle, int start)
        {
            if (needle.Length + start > haystack.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < needle.Length; i++)
                {
                    if (needle[i] != haystack[i + start])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        private static byte[] bytes;
        protected static byte[] Bytes {
            get
            {
                if(bytes == null)
                    bytes = ReadAllBytes(SpitfireGameUPK);
                return bytes;
            }
            set {
                bytes = value;
            }
        }
        protected static byte[] ReadAllBytes(string fileName)
        {
            byte[] buffer = null;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
            }
            return buffer;
        }
    }
    public class Max : Hero
    {
        byte[] trapHeader;
        public Max()
        {
            trapHeader = new byte[] { 0xC6, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC5, 0x07, 0x00, 0x00 };
        }
        //Next update we will use this in the loadout editor to default the comboboxes to the traps the player is using
        public override Dictionary<byte[], string> GetTraps()
        {
            Dictionary<byte[], string> Dic = new Dictionary<byte[], string>();
            int index = FindBytes(Bytes, trapHeader);
            for (int i = 0; i < 9; i++)
            {
                byte[] trap = Bytes.ToList().GetRange(index + 28 + (i * 4), 4).ToArray();
                if (trap[0] == 0xF3)
                    break;
                var t = Traps.AllTraps[trap];
                Dic.Add(trap,t);
            }
            return Dic;
        }

        public override void SetTraps(List<byte[]> traps)
        {
            if (traps.Count() != 9)
                throw new Exception("9 traps/gear must be used");
            //Find a icon for one of the unused gamemodes and delete it's code to make room for the extra traps
            byte[] b = new byte[] { 0x30, 0x6E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x6B, 0x66, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x41, 0xCC, 0x02, 0x00 };
            int removeIdx = FindBytes(Bytes, b);
            if (removeIdx > -1)
            {
                var tmpBytes = new List<byte>(Bytes);
                tmpBytes.RemoveRange(removeIdx, b.Count());
                //insert 0 bytes so it doesn't crash from having less bytes than game expects
                tmpBytes.InsertRange(removeIdx, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                Bytes = tmpBytes.ToArray();
            }
            int index = FindBytes(Bytes, trapHeader);
            //Size of bytes the array will hold
            Bytes[index + 16] = (byte)((traps.Count() + 1) * 4);
            //number of items in array
            Bytes[index + 24] = (byte)traps.Count();
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
            File.WriteAllBytes(SpitfireGameUPK, Bytes);
        }
    }
    public class Smolder : Hero
    {
        byte[] inventoryArchType;
        byte[] trapHeader;
        public Smolder()
        {
            inventoryArchType = new byte[] { 0xC5, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC5, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0xB8, 0x37, 0x02, 0x00 };

            trapHeader = new byte[] { 0xC6, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC5, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, (byte)(10 * 4), 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, (byte)9, 0x00, 0x00, 0x00 };
        }

        public override Dictionary<byte[], string> GetTraps()
        {
            Dictionary<byte[], string> Dic = new Dictionary<byte[], string>();
            int index = FindBytes(Bytes, inventoryArchType);
            for (int i = 0; i < 9; i++)
            {
                byte[] trap = Bytes.ToList().GetRange(index + 28 + (i * 4), 4).ToArray();
                if (trap[0] == 0xF3)
                    break;
                var t = Traps.AllTraps[trap];
                Dic.Add(trap, t);
            }
            return Dic;
        }

        public override void SetTraps(List<byte[]> traps)
        {
            if (traps.Count() != 9)
                throw new Exception("9 traps/gear must be used");
            long length = Bytes.Length;

            var tmpBytes = new List<byte>();
            int index = FindBytes(Bytes, inventoryArchType) + inventoryArchType.Length;
            tmpBytes = Bytes.ToList();
            tmpBytes.InsertRange(index, trapHeader);
            Bytes = tmpBytes.ToArray();
            int c = 0;
            foreach (var bs in traps)
            {
                //return FindBytes("SpitfireGame.upk", new byte[] { 0xC6, 0x2C, 0x00, 0x00 }).ToString();
                //bytes = ReadAllBytes("SpitfireGame.upk");

                tmpBytes = new List<byte>(Bytes);
                tmpBytes.InsertRange(index + (trapHeader.Length) + c, bs);
                Bytes = tmpBytes.ToArray();

                c += 4;
            }
            byte[] bytesToRemove = new byte[] { 0x30, 0x6E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x6B, 0x66, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x1D, 0xCC, 0x02, 0x00 };//28 bytes
            int removeIdx = FindBytes(Bytes, bytesToRemove);
            if (removeIdx > -1)
            {
                tmpBytes = new List<byte>(Bytes);
                tmpBytes.RemoveRange(removeIdx, bytesToRemove.Count());
                Bytes = tmpBytes.ToArray();
            }
            //bytesToRemove = new byte[] { 0x82, 0x54, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC5, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00, 0x87, 0x35, 0x02, 0x00, 0x80, 0x35, 0x02, 0x00, 0x73, 0x35, 0x02, 0x00, 0x6C, 0x35, 0x02, 0x00, 0x4E, 0x35, 0x02, 0x00, 0x43, 0x35, 0x02, 0x00 };//52 bytes
            bytesToRemove = new byte[] { 0x82, 0x54, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC5, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00, 0x87, 0x35, 0x02, 0x00, 0x80, 0x35, 0x02, 0x00, 0x73, 0x35, 0x02, 0x00, 0x6C, 0x35, 0x02, 0x00, 0x4E, 0x35, 0x02, 0x00, 0x43, 0x35, 0x02, 0x00 };//52 bytes
            removeIdx = FindBytes(Bytes, bytesToRemove);
            if (removeIdx > -1)
            {
                tmpBytes = new List<byte>(Bytes);
                tmpBytes.RemoveRange(removeIdx, bytesToRemove.Count());
                Bytes = tmpBytes.ToArray();
            }
            if(Bytes.Length != length)
            {
                tmpBytes = new List<byte>(Bytes);
                
                tmpBytes.InsertRange(tmpBytes.Count() - 1,new byte[]{ 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                Bytes = tmpBytes.ToArray();
            }
            File.WriteAllBytes(SpitfireGameUPK, Bytes);
        }
    }
}
