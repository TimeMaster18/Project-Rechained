﻿namespace SingleplayerLauncher.Mods
{
    public class NoTrapCap : Mod
    {
        public override bool InstallMod()
        {
            UPKFile.OverrideSingleByte(0, 0x15444A3);
            return true;
        }

        public override bool UninstallMod()
        {
            UPKFile.OverrideSingleByte(1, 0x15444A3);
            return true;
        }
    }
}
