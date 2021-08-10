using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleplayerLauncher.Mods
{
    static class Mods
    {
        // static members
        public static Mod NoTrapCap = new NoTrapCap();
        public static Mod NoLimitUniqueTraps = new NoLimitUniqueTraps();
        public static Mod TrapsAnySurface = new TrapsAnySurface();
        public static Mod TrapsInTraps = new TrapsInTraps();
        public static Mod NoTrapGrid = new NoTrapGrid();
        public static Mod GodMode = new GodMode();
        public static Mod Hardcore = new Hardcore();

        public readonly static List<Mod> ModList = new List<Mod>
        {
            NoTrapCap,
            NoLimitUniqueTraps,
            TrapsAnySurface,
            TrapsInTraps,
            NoTrapGrid,
            GodMode,
            Hardcore,
        };
    }
}
