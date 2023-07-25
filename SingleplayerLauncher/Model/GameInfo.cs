namespace SingleplayerLauncher.Model
{
    public sealed class GameInfo
    {
        private static readonly GameInfo instance = new GameInfo();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit /Singleton
        static GameInfo() { }
        private GameInfo() { }

        public static GameInfo Instance => instance;


        public static Loadout Loadout { get; set; } = new Loadout();
        public IBattleground Battleground { get; set; } = new Survival();
    }
}
