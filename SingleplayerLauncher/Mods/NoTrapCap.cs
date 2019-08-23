using SingleplayerLauncher.Mods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleplayerLauncher.Mods
{
    public class NoTrapCap:Mod
    {
        public NoTrapCap(UPKFile UPKFile) : base(UPKFile)
        {

        }

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
