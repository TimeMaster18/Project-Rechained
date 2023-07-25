namespace SingleplayerLauncher.Model
{
    public interface IBattleground
    {
        string Name { get; }
        Map Map { get; set; }
        GameMode GameMode { get; set; }
        Difficulty Difficulty { get; set; }
        int StartingCoin { get; set; }
    }
}
