using SingleplayerLauncher.GameFiles;

namespace SingleplayerLauncher.Mods
{
    public class NoTrapCap : Mod
    {
        readonly private byte[] UNIQUE_BYTES_REFERENCE = { 0x00, 0x00, 0x00, 0x6B, 0x66, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1D, 0xEE, 0x00, 0x00, 0x35, 0x16, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1A, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 };
        readonly private int OFFSET_FROM_UNIQUE_BYTES = 74;

        private const int CHANGE_INDEX = 0x15444A3;

        public override bool InstallMod()
        {
            UPKFile.ApplyModification(UNIQUE_BYTES_REFERENCE, CHANGE_INDEX, OFFSET_FROM_UNIQUE_BYTES, (byte)0);
            return true;
        }

        public override bool UninstallMod()
        {
            UPKFile.ApplyModification(UNIQUE_BYTES_REFERENCE, CHANGE_INDEX, OFFSET_FROM_UNIQUE_BYTES, (byte)1);
            return true;
        }
    }
}
