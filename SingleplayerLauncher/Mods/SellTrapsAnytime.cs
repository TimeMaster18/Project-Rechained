namespace SingleplayerLauncher.Mods
{
    public class SellTrapsAnytime : Mod
    {
        private const int CHANGE_INDEX = 0x0F172B8;

        public override bool InstallMod()
        {
            UPKFile.OverrideSingleByte(39, CHANGE_INDEX);
            return true;
        }

        public override bool UninstallMod()
        {
            UPKFile.OverrideSingleByte(40, CHANGE_INDEX);
            return true;
        }
    }
}