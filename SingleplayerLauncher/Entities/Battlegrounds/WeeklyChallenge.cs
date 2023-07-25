using System;
using System.Linq;
using static SingleplayerLauncher.Model.Dye;
using static SingleplayerLauncher.Model.Gear;
using static SingleplayerLauncher.Model.Map;
using static SingleplayerLauncher.Model.Trap;
using static SingleplayerLauncher.Names.WeeklyChallenge;

namespace SingleplayerLauncher.Model
{
    public class WeeklyChallenge : IBattleground
    {
        public string Name { get; private set; }
        public Map Map { get; set; }
        public GameMode GameMode { get; set; } = GameMode.WeeklyChallenge;
        public string CodeName { get; private set; }
        public Hero[] AvailableHeroes { get; private set; }
        public Loadout Loadout { get; private set; }
        public Difficulty Difficulty { get; set; } = new Difficulty()
        {
            TrapTier = 1,
            AccountLevel = 1,
            EnemyLevel = 1,
        };
        public int StartingCoin { get; set; }
        public TimeSpan ParTime { get; private set; }
        public string Description { get; private set; }
        public string SpecialConditions { get; private set; }

        // private constructor
        WeeklyChallenge() { }

        static readonly Random Random = new Random();
        // static members
        public static WeeklyChallenge AlmsForThePoor = new WeeklyChallenge()
        {
            Name = ALMS_FOR_THE_POOR,
            CodeName = "WCMausoleum01",
            Map = TempleGraveyard,
            AvailableHeroes = new Hero[] { Hero.Hogarth, Hero.Blackpaw, Hero.Smolder },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,
                SlotItems = new SlotItem[] { LightningRing, MagesClover, GreatWallBarricade, TarTrap, ArcanePhaser, IcicleImpaler, ArrowWall, WebSpinner, LightningRod },
            },
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 11, 0),
            Description = "Your hero will have to rely on handouts in this challenge. Once the hero's starting coin runs out, the only coin generated in the level is the coin that drops with each wave--no coin from combos, kills, or abilities. Don't forget to pick up coin!",
            SpecialConditions = "Only coin from starting coin and pickups.",
        };
    }


}
