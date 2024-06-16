using SingleplayerLauncher.GameFiles;

namespace SingleplayerLauncher.Mods
{
    public class SellTrapsAnytime : Mod
    {
        readonly private byte[] UNIQUE_BYTES_REFERENCE = { 0x00, 0x04, 0x27, 0x07, 0x33, 0x02, 0x9A, 0x38, 0x3A, 0x1A, 0x38, 0x3A, 0x1B, 0x79, 0x41, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x16, 0x19, 0x00, 0xED, 0x34, 0x00, 0x00, 0x09, 0x00, 0xB2, 0x9D, 0x00, 0x00, 0x00, 0x01, 0xB2, 0x9D, 0x00, 0x00, 0x38, 0x3A, 0x24, 0x01, 0x16, 0x04, 0x27, 0x04 };
        readonly private int OFFSET_FROM_UNIQUE_BYTES = 0;

        private const int CHANGE_INDEX = 0x0F172B8;
        public override bool InstallMod()
        {
            UPKFile.ApplyModification(UNIQUE_BYTES_REFERENCE, CHANGE_INDEX, OFFSET_FROM_UNIQUE_BYTES, (byte)39);
            return true;
        }

        public override bool UninstallMod()
        {
            UPKFile.ApplyModification(UNIQUE_BYTES_REFERENCE, CHANGE_INDEX, OFFSET_FROM_UNIQUE_BYTES, (byte)40);
            return true;
        }
    }
}