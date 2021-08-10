namespace SingleplayerLauncher.Mods
{
    public class Hardcore : Mod
    {
        private const int CHANGE_INDEX = 0x1102F88;

        public override bool InstallMod()
        {
            UPKFile.OverrideSingleByte(1, CHANGE_INDEX);
            return true;
        }

        public override bool UninstallMod()
        {
            UPKFile.OverrideSingleByte(0, CHANGE_INDEX);
            return true;
        }
    }
}