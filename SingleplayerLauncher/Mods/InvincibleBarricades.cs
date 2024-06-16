using SingleplayerLauncher.GameFiles;

namespace SingleplayerLauncher.Mods
{
    public class InvincibleBarricades : Mod
    {
        readonly private byte[] UNIQUE_BYTES_REFERENCE = { 0x00, 0x00, 0x00, 0x00, 0x6E, 0x4B, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xCB, 0x15, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1A, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        readonly private int OFFSET_FROM_UNIQUE_BYTES = 0;

        private const int CHANGE_INDEX = 0x184631A; // ( CB 15 00 00 ): CanBeDamaged

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