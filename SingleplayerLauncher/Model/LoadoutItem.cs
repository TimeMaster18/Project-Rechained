namespace SingleplayerLauncher.Model
{
    public abstract class LoadoutItem
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string SiegeName { get; protected set; }
        public string Description { get; protected set; }
        public string SiegeDescription { get; protected set; }
    }
}
