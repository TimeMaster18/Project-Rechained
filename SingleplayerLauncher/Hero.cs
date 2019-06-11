using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SingleplayerLauncher
{

    public abstract class Hero
    {
        protected int fileLength = 0;
        public abstract void SetTraps(List<byte[]> traps);
        public abstract void SetSkin(byte[] skin);
        public abstract void SaveHero();
        //public abstract Dictionary<byte[], string> GetTraps();
        public const string SpitfireGameUPK = "..//SpitfireGame//CookedPCConsole//SpitfireGame.upk";
        protected int FindBytes(byte[] haystack, byte[] needle)
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

        protected bool match(byte[] haystack, byte[] needle, int start)
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
        private byte[] bytes;
        protected byte[] Bytes {
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
        protected byte[] ReadAllBytes(string fileName)
        {
            FileInfo info = new FileInfo(fileName);
            if (info.Length == 100225213)
            {
                MessageBox.Show("Decompressing your SpitfireGame.upk, please wait.");

                if (!File.Exists(@".//UE Extractor//SpitfireGame.upk"))
                    File.Copy(fileName, @".//UE Extractor//SpitfireGame.upk");

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = Path.GetFileName(".//UE Extractor//decompress.exe");
                psi.WorkingDirectory = Path.GetDirectoryName(".//UE Extractor//decompress.exe");
                psi.Arguments = "\"" + Path.GetFileName(@".//UE Extractor//SpitfireGame.upk") + "\"";
                Process process = Process.Start(psi);
                process.WaitForExit();
                File.Delete(fileName);
                File.Move(".//UE Extractor//unpacked//SpitfireGame.upk", fileName);
                MessageBox.Show("Finished decompressing your file.");
            }
            byte[] buffer = null;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
            }
            fileLength = buffer.Length;
            return buffer;
        }
    }
    public class Max : Hero
    {
        byte[] trapHeader;
        byte[] skinPattern;
        public Max()
        {
            trapHeader = new byte[] { 0xC6, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC5, 0x07, 0x00, 0x00 };
            skinPattern = new byte[] { 0x5F, 0x0D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x6B, 0x66, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xDC, 0x56 };
        }

        public override void SaveHero()
        {
            if(fileLength != Bytes.Length)
            {
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
            }
            MessageBox.Show("Saving your changes. Please wait.");
            File.WriteAllBytes(SpitfireGameUPK, Bytes);

            MessageBox.Show("Finished");
        }

        public override void SetSkin(byte[] skin)
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

            int index = FindBytes(Bytes, skinPattern) - 4;
            if (index == -1)
                throw new Exception("Can't find skin address");
            //MessageBox.Show(index.ToString());
            //Size of bytes the array will hold
            for (int i = 0; i < skin.Length; i++)
            {
                Bytes[index + i] = skin[i];
            }
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

        public override void SetTraps(List<byte[]> traps)
        {
            if (traps.Count() != 9)
                throw new Exception("9 traps/gear must be used");
            
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
        }
    }
}
