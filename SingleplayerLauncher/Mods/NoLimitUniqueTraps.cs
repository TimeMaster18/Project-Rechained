using SingleplayerLauncher.GameFiles;

namespace SingleplayerLauncher.Mods
{
    public class NoLimitUniqueTraps : Mod
    {
        readonly private byte[] UNIQUE_BYTES_REFERENCE = { 0x37, 0x65, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xB6, 0xC4, 0x00, 0x00, 0x37, 0x65, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xB7, 0xC4, 0x00, 0x00, 0x5F, 0xB0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1A, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        readonly private int OFFSET_FROM_UNIQUE_BYTES = 0;

        private const int CHANGE_INDEX = 0x16157FE; // ( 5F B0 00 00 ): UseCountLimiter

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