namespace SingleplayerLauncher.Mods
{
    public class TrapsInTraps : Mod
    {
        public override bool InstallMod()
        {
            UPKFile.OverrideSingleByte(0, 0x15444BC);
            return true;
        }

        public override bool UninstallMod()
        {
            UPKFile.OverrideSingleByte(1, 0x15444BC);
            return true;
        }
    }
}
