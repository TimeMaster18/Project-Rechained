using System;
using System.Collections.Generic;
using static SingleplayerLauncher.Model.Map;

namespace SingleplayerLauncher.Model
{
    class Siege : IBattleground
    {
        public string Name { get; private set; }

        public Map Map { get; set; }
        public GameMode GameMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Difficulty Difficulty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int StartingCoin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public TimeSpan ParTime => throw new NotImplementedException();

        public static Siege CliffsideClashSiege = new Siege()
        {
            Name = "Cliffside Clash",
            Map = SiegeCliffsideClash
        };

        public static Siege UnchainedFortressSiege = new Siege()
        {
            Name = "Unchained Fortress",
            Map = SiegeUnchainedFortress
        };

        public static Dictionary<string, Siege> SiegeBattlegrounds = new Dictionary<string, Siege>
        {
            { CliffsideClash.Name, CliffsideClashSiege },
            { UnchainedFortress.Name, UnchainedFortressSiege },
        };

    }
}
