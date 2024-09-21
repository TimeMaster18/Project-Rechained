using static ProjectRechained.Entities.Names.BotDifficulty;
using SingleplayerLauncher.Model;
using System.Collections.Generic;

namespace ProjectRechained.Entities
{
    internal class BotDifficulty
    {
        public string Name { get; private set; }
        public int BotLevel { get; private set; }
        public SiegeLoadout[] botLoadouts { get; private set; }
        public int TrapTier { get; private set; }

        private BotDifficulty(string name, int botLevel, int trapTier, SiegeLoadout[] loadouts)
        {
            Name = name;
            BotLevel = botLevel;
            TrapTier = trapTier;
            botLoadouts = loadouts;
        }

        public static readonly BotDifficulty Easy = new(
            EASY,
            1,
            1,
            [
                BotLoadout.BaseMaximilian,
                BotLoadout.BaseGabriella,
                BotLoadout.BaseOziel,
                BotLoadout.BaseIvy,
                BotLoadout.BaseHogarth
            ]
        );

        public static readonly BotDifficulty Normal = new(
            NORMAL,
            2,
            1,
            [
                BotLoadout.BaseMaximilian,
                BotLoadout.BaseGabriella,
                BotLoadout.BaseOziel,
                BotLoadout.BaseIvy,
                BotLoadout.BaseHogarth
            ]
        );

        public static readonly BotDifficulty Hard = new(
            HARD,
            3,
            1,
            [
                BotLoadout.BaseMaximilian,
                BotLoadout.BaseGabriella,
                BotLoadout.BaseOziel,
                BotLoadout.BaseIvy,
                BotLoadout.BaseHogarth
            ]
        );

        public static readonly BotDifficulty Nightmare = new(
            NIGHTMARE,
            4,
            1,
            [
                BotLoadout.BaseMaximilian,
                BotLoadout.BaseGabriella,
                BotLoadout.BaseOziel,
                BotLoadout.BaseIvy,
                BotLoadout.BaseHogarth
            ]
        );

        public static readonly Dictionary<string, BotDifficulty> BotDifficultiesByName = new()
        {
            { EASY, Easy },
            { NORMAL, Normal },
            { HARD, Hard },
            { NIGHTMARE, Nightmare }
        };

    }
}
