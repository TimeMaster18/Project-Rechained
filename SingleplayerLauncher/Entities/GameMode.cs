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
        public static GameMode Survival = new GameMode()
        {
            Name = SURVIVAL,
            Id = 1
        };
        public static GameMode Endless = new GameMode()
        {
            Name = ENDLESS,
            Id = 5
        };
        public static GameMode WeeklyChallenge = new GameMode()
        {
            Name = WEEKLY_CHALLENGE,
            Id = 1
        };

        public static Dictionary<string, GameMode> GameModes = new Dictionary<string, GameMode>
        {
            { SURVIVAL, Survival },
            { ENDLESS, Endless },
            // { WEEKLY_CHALLENGE, WeeklyChallenge },
        };

    }
}
