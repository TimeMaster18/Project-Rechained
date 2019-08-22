using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SingleplayerLauncher.Mods
{
    public abstract class Mod
    {
        internal UPKFile UPKFile { get; set; }
        public Mod(UPKFile UPKFile)
        {
            this.UPKFile = UPKFile;
        }
        public abstract bool InstallMod();
        public abstract bool UninstallMod();
    }
}
