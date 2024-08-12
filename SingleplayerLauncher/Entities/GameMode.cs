using System.Collections.Generic;
using static SingleplayerLauncher.Names.GameMode;

namespace SingleplayerLauncher.Model
{
    public class GameMode
    {

        public string Name { get; private set; }
        public int Id { get; private set; } // integer used in the .ini config

        // private constructor
        GameMode() { }

        // static members
        public static GameMode Survival = new()
        {
            Name = SURVIVAL,
            Id = 1
        };
        public static GameMode Endless = new()
        {
            Name = ENDLESS,
            Id = 5
        };
        public static GameMode WeeklyChallenge = new()
        {
            Name = WEEKLY_CHALLENGE,
            Id = 1
        };

        public static Dictionary<string, GameMode> GameModes = new()
        {
            { SURVIVAL, Survival },
            { ENDLESS, Endless },
            // { WEEKLY_CHALLENGE, WeeklyChallenge },
        };

    }
}
