namespace SingleplayerLauncher.Mods
{
    public class AdditionalHeroWeapon : Mod
    {
        public new string Value { get; set; }

        public override bool InstallMod()
        {
            return true;
        }

        public override bool UninstallMod()
        {
            return true;
        }
    }
}
