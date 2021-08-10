namespace SingleplayerLauncher.Mods
{
    public class TrapsAnySurface : Mod
    {
        private const int CHANGE_INDEX_1 = 0x154453A;
        private const int CHANGE_INDEX_2 = 0x1544459;
        private const int CHANGE_INDEX_3 = 0x1544D37;

        public override bool InstallMod()
        {
            UPKFile.OverrideBytes(new byte[] { 0xF1, 0x6F }, CHANGE_INDEX_1);
            UPKFile.OverrideBytes(new byte[] { 0xFA, 0x6F }, CHANGE_INDEX_2);
            UPKFile.OverrideBytes(new byte[] { 0x16, 0x70 }, CHANGE_INDEX_3);
            return true;
        }

        public override bool UninstallMod()
        {
            UPKFile.OverrideBytes(new byte[] { 0x32, 0x65 }, CHANGE_INDEX_1);
            UPKFile.OverrideBytes(new byte[] { 0x3B, 0x57 }, CHANGE_INDEX_2);
            UPKFile.OverrideBytes(new byte[] { 0xE4, 0x0F }, CHANGE_INDEX_3);
            return true;
        }
    }
}