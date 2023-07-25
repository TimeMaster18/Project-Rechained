namespace SingleplayerLauncher.Model
{
    class Survival : IBattleground
    {
        public string Name { get; private set; }

        public Map Map { get; set; }

        public GameMode GameMode { get; set; } = GameMode.Survival;

        public Difficulty Difficulty { get; set; }

        public int StartingCoin { get; set; }
    }
}
