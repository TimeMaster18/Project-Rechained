namespace SingleplayerLauncher.Mods
{
    public abstract class Mod
    {
        public string Name { get; private set; }

        internal static UPKFile UPKFile { get; set; }

        public bool IsEnabled { get; set; } = false;

        public int Value { get; set; } = 0;

        public abstract bool InstallMod();
        public abstract bool UninstallMod();
    }
}
