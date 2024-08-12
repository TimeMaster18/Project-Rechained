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

        public static Siege CliffsideClashSiege = new()
        {
            Name = "Cliffside Clash",
            Map = SiegeCliffsideClash
        };

        public static Siege UnchainedFortressSiege = new()
        {
            Name = "Unchained Fortress",
            Map = SiegeUnchainedFortress
        };

        public static Dictionary<string, Siege> SiegeBattlegrounds = new()
        {
            { CliffsideClash.Name, CliffsideClashSiege },
            { UnchainedFortress.Name, UnchainedFortressSiege },
        };

    }
}
