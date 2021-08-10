﻿namespace SingleplayerLauncher.Mods
{
    public abstract class Mod
    {
        internal static UPKFile UPKFile { get; set; }

        public bool IsEnabled { get; set; } = false;

        public abstract bool InstallMod();
        public abstract bool UninstallMod();
    }
}
