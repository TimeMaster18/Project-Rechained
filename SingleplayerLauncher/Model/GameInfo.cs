using System.Collections.Generic;

namespace SingleplayerLauncher.Model
{
    public sealed class GameInfo
    {
        private static readonly GameInfo instance = new();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit /Singleton
        static GameInfo() { }
        private GameInfo() { }

        public static GameInfo Instance => instance;


        public static SurvivalLoadout SurvivalLoadout { get; set; } = new SurvivalLoadout();
        public static SiegeLoadout SiegeLoadout { get; set; } = new SiegeLoadout();
        public IBattleground SurvivalBattleground { get; set; } = new Survival();
        public IBattleground SiegeBattleground { get; set; } = new Siege();

        public int PlayerCount { get; set; } = 1;
        public List<SiegeLoadout> AllyBotsLoadouts { get; set; } = [];
    }
}
