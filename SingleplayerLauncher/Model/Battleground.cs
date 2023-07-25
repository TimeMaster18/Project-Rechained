namespace SingleplayerLauncher.Model
{
    public class Battleground : IBattleground
    {
        public string Name { get; private set; } = "CUSTOM";

        public Map Map { get; set; }

        public GameMode GameMode { get; set; }

        public Difficulty Difficulty { get; set; }

        public int StartingCoin { get; set; }
    }
}
