namespace SingleplayerLauncher.Model
{
    class Endless : IBattleground
    {
        public string Name { get; private set; }

        public Map Map { get; set; }

        public GameMode GameMode { get; set; } = GameMode.Endless;

        public Difficulty Difficulty { get; set; }

        public int StartingCoin { get; set; }
    }
}
