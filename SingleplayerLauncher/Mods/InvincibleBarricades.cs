namespace SingleplayerLauncher.Mods
{
    public class InvincibleBarricades : Mod
    {
        private const int CHANGE_INDEX = 0x184631A; // ( CB 15 00 00 ): CanBeDamaged

        public override bool InstallMod()
        {
            UPKFile.OverrideSingleByte(0, CHANGE_INDEX);
            return true;
        }

        public override bool UninstallMod()
        {
            UPKFile.OverrideSingleByte(1, CHANGE_INDEX);
            return true;
        }
    }
}