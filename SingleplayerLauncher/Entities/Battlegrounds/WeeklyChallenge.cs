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

        /* We don't know how to get all the challenge special effects to work...
         * 
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

        public static WeeklyChallenge DoTheTrapShuffle = new WeeklyChallenge()
        {
            Name = DO_THE_TRAP_SHUFFLE,
            CodeName = "WCMausoleum01",
            Map = TempleGraveyard,
            AvailableHeroes = new Hero[] { Cygnus, Blackpaw, Tundra },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value, 
                SlotItems = new SlotItem[] { RingOfStorms, FireWallBracers, Barricade, Brimstone, TempleAlarmGong, BoomBarrelRoller, WallBlades, Haymaker },
                TrapTier = 1,
                Guardians = new Guardian[] { MoonGuardian, PriestGuardian },
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 30000,
            ParTime = new TimeSpan(0, 6, 0),
            Description = "In this challenge, you start with all the trap money you're going to get, and your main weapon does no damage. Use your traps, abilities, and gear to stop the waves of Unchained minions!",
            SpecialConditions = "Only coin from starting coin. Hero Primary Attacks deal no damage.",
        };

        public static WeeklyChallenge DodgeCity = new WeeklyChallenge()
        {
            Name = DODGE_CITY,
            CodeName = "WCMausoleum01",
            Map = GatesOfThuricvod,
            AvailableHeroes = new Hero[] { Gabriella, Zoey, Smolder },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value, 
                SlotItems = new SlotItem[] { RingOfStorms, FlipTrap, FloorSpikes, Grinder, ShockZapper, WallBlades },
                TrapTier = 1,
                Guardians = new Guardian[] { MoonGuardian },
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 7, 30),
            Description = "Ranged minions roam this battleground backed up by their heavy friends. Your hero better learn how to duck and dodge to complete this challenge.",
            SpecialConditions = "Having fun dodging all the projectiles.",
        };

        public static WeeklyChallenge Doublets = new WeeklyChallenge()
        {
            Name = DOUBLETS,
            CodeName = "WCMausoleum01",
            Map = Orcatraz,
            AvailableHeroes = new Hero[] { Temper, Tundra, Zoey },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { MendingRoot, RingOfStorms, TarTrap, FlipTrap, FloorSpikes, ArrowWall, DragonsLance },
                TrapTier = 1,
                Guardians = new Guardian[] { JailerGuardian, DeckhandGuardian },
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 6, 0),
            Description = "No, you're NOT seeing double. In this weekly challenge, waves double in size each wave for 5 waves. Do you think your hero can stop this prison break?",
            SpecialConditions = "Amount of minions double with each wave.",
        };

        public static WeeklyChallenge FreezedToMeetYou = new WeeklyChallenge()
        {
            Name = FREEZED_TO_MEET_YOU,
            CodeName = "WCMausoleum01",
            Map = Orcatraz,
            AvailableHeroes = new Hero[] { Tundra, Hogarth, Zoey },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { IceAmulet, MagesClover, Barricade, IceVent, IceShard, IcicleImpaler, SawOfArctos, ManaWell },
                TrapTier = 1,
                Guardians = new Guardian[] { MoonGuardian },
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 6000,
            ParTime = new TimeSpan(0, 7, 15),
            Description = "It's all ice, ice, baby! All the enemies on this level deal frost damage, and so do all the heroes and traps. Do you have what it takes to thaw this challenge out?",
            SpecialConditions = "Fighting Ice minions with Ice Heroes and Ice Traps.",
        };

        public static WeeklyChallenge FunWithPsysics = new WeeklyChallenge()
        {
            Name = FUN_WITH_PHYSICS,
            CodeName = "WCMausoleum01",
            Map = ThuricvodVillage,
            AvailableHeroes = new Hero[] { Gabriella, Zoey, Ivy },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { GnomishRepairKit, FlipTrap, PushTrap, SpikeWall, Haymaker },
                TrapTier = 1,
                Guardians = new Guardian[] { MoonGuardian },
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 6, 15),
            Description = "Give your enemies a physics lesson. Achieve victory with only physics traps to beat this challenge.",
            SpecialConditions = "Only physics traps.",
        };

        public static WeeklyChallenge GottaGoFast = new WeeklyChallenge()
        {
            Name = GOTTA_GO_FAST,
            CodeName = "WCMausoleum01",
            Map = Orcatraz,
            AvailableHeroes = new Hero[] { Temper, Cygnus, Dobbin },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { RingOfStorms, MendingRoot, TarTrap, FlipTrap, FloorSpikes, ArrowWall, DragonsLance },
                TrapTier = 1,
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 4, 0),
            Description = "Everyone's in a hurry in this weekly challenge. Both minions and heroes move at increased speed, but don't count on getting a break for your hero to catch its breath, This challenge has NO go breaks.",
            SpecialConditions = "Faster Heroes and Minions. No Go-Breaks.",
        };

        public static WeeklyChallenge GrandFinale = new WeeklyChallenge()
        {
            Name = GRAND_FINALE,
            CodeName = "WCMausoleum01",
            Map = MidnightMarket,
            AvailableHeroes = new Hero[] { Zoey, Maximilian, Ivy },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { BoomBarrel, ViscousTar, GreatWallBarricade, PowerGenerator, CoinForge, HealingWell, ManaWell, Decoy },
                TrapTier = 1,
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 6000,
            ParTime = new TimeSpan(0, 5, 0),
            Description = "Chain boom barrel explosions together to defeat the Wu Xing dynasty.",
            SpecialConditions = "Only Boom Barrel as damage trap and support traps.",
        };

        public static WeeklyChallenge ImTheBossNow = new WeeklyChallenge()
        {
            Name = IM_THE_BOSS_NOW,
            CodeName = "WCMausoleum01",
            Map = TheBaths,
            AvailableHeroes = new Hero[] { Deadeye, Cygnus, Midnight },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { MendingRoot, BGHArrowWall, BGHCeilingBallista, BGHShockZapper },
                TrapTier = 1,
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 6000,
            ParTime = new TimeSpan(0, 4, 0),
            Description = "This challange pits you against numerous bosses. Take them down using big game traps.",
            SpecialConditions = "Big Game Hunting traps only, only Bosses spawn.",
        };

        public static WeeklyChallenge InferiorityComplex = new WeeklyChallenge()
        {
            Name = INFERIORITY_COMPLEX,
            CodeName = "WCMausoleum01",
            Map = TheFaillingFolly,
            AvailableHeroes = new Hero[] { Hogarth, Bloodspike, Bionka },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { RingOfLastStand, RingOfStorms, Barricade, SpikeWall, PushTrap, BoomBarrel, FlipTrap, PowerupDamage, ConcussivePounder },
                TrapTier = 1,
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 6, 0),
            Description = "Assert your superiority by surviving this challenge as a melee hero with 1 health. Keep your eyes peeled for archers!",
            SpecialConditions = "Players have 1 HP.",
        };

        public static WeeklyChallenge KeepYourDistance = new WeeklyChallenge()
        {
            Name = KEEP_YOUR_DISTANCE,
            CodeName = "WCMausoleum01",
            Map = TrainingGrounds,
            AvailableHeroes = new Hero[] { Deadeye, Maximilian, Ivy },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { RingOfStorms, FireWallBracers, Barricade, TarTrap, Brimstone, SpitfireWall, Grinder, DragonsLance, ManaWell },
                TrapTier = 1,
                Guardians = new Guardian[] { MoonGuardian, QuartermasterGuardian },
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 10, 30),
            Description = "This challenge puts a large aura around your Hero that heals minions. Defeat the minions at long range.",
            SpecialConditions = "Healing aura around the Hero.",
        };

        public static WeeklyChallenge LibraryRinth = new WeeklyChallenge()
        {
            Name = LIBRARY_RINTH,
            CodeName = "WCMausoleum01",
            Map = ArchmageLibrary,
            AvailableHeroes = new Hero[] { Cygnus, Smolder, Oziel },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { RingOfStorms, FireWallBracers, Barricade, TarTrap },
                TrapTier = 1,
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 10, 0),
            Description = "Use barricades to turn this library into a bookshelf maze if you want a chance to win this weekly challenge!",
            SpecialConditions = "No damage traps, only Barricade and Tar.",
        };

        public static WeeklyChallenge MemoryLanes = new WeeklyChallenge()
        {
            Name = MEMORY_LANES,
            CodeName = "WCMausoleum01",
            Map = WaterGarden,
            AvailableHeroes = new Hero[] { Maximilian, Zoey, Ivy },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { Brimstone, FloorSpikes },
                TrapTier = 1,
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 6000,
            ParTime = new TimeSpan(0, 4, 0),
            Description = "Survive a single wave without using the minimap. You'll need to use your memory to keep track of where enemies are coming from.",
            SpecialConditions = "1 wave, no minimap.",
        };

        public static WeeklyChallenge OffTheChain = new WeeklyChallenge()
        {
            Name = OFF_THE_CHAIN,
            CodeName = "WCMausoleum01",
            Map = MaximumSecurity,
            AvailableHeroes = new Hero[] { Oziel, Cygnus, Bloodspike },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { MagesClover, FireWallBracers, Barricade, Decoy, SummonerTrap, ArcandeBowlingBall, OverloardTrap, SawOfArctos },
                TrapTier = 1,
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 6, 40),
            Description = "Your hero will have to stay Unchained to tackle all the heavy units and bosses this challenge throws at you. Luckily, some Unchained drops will help you along the way. Make sure to pick them up and keep your Unchained meter glowing and going.",
            SpecialConditions = "Extra drops of unchained pickups.",
        };

        public static WeeklyChallenge OneAndDone = new WeeklyChallenge()
        {
            Name = ONE_AND_DONE,
            CodeName = "WCMausoleum01",
            Map = RestrictedSection,
            AvailableHeroes = new Hero[] { Cygnus, Maximilian, Zoey },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { IceAmulet, MendingRoot, Barricade, CeilingBallista, FloorSpikes, PushTrap, Grinder, SpikeWall, TarTrap },
                TrapTier = 1,
                Guardians = new Guardian[] { MoonGuardian, PriestGuardian },
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 10, 0),
            Description = "In this challenge, your rift starts out with one rift point left before it fails. Keep ALL enemies out of it or you'll be "one and done!"",
            SpecialConditions = "1 Rift Point.",
        };

        public static WeeklyChallenge PlayingWithFire = new WeeklyChallenge()
        {
            Name = PLAYING_WITH_FIRE,
            CodeName = "WCMausoleum01",
            Map = BanquetHall,
            AvailableHeroes = new Hero[] { Hogarth, Ivy, Zoey },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { Mending, ShieldPowerup, PowerupDamage, HealingWell, ManaWell, BGHBallista },
                TrapTier = 1,
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 5, 30),
            Description = "Start at battle level 3 equipped with only coin and mostly non-damage dealing traps in this weekly challenge. Minions are exceptionally lethal and come from unstable rifts at every angle too. Don't let this challenge burn you out!",
            SpecialConditions = "Start at lvl 3. High Damage minions and support traps only.",
        };

        public static WeeklyChallenge PurpleMaze = new WeeklyChallenge()
        {
            Name = PURPLE_MAZE,
            CodeName = "WCMausoleum01",
            Map = EventideFortress,
            AvailableHeroes = new Hero[] { Gabriella, Oziel, Stinkeye },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { MagesClover, MendingRoot, Barricade, GreatWallBarricade, ViscousTar, CursedGround, Brimstone, WallCharger, ShockZapper },
                TrapTier = 1,
                Guardians = new Guardian[] { DragonGuardian, FriarGuardian },
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 12, 0),
            Description = "Purple it up with OMD!U's arcane-pòwered heroes and maze it up with totally free barricades and traps. But be prepared; this challenge features HUGE waves of minions after the first wave.",
            SpecialConditions = "Free Traps, arcane heroes and huge waves.",
        };

        public static WeeklyChallenge RiftInstability = new WeeklyChallenge()
        {
            Name = RIFT_INSTABILITY,
            CodeName = "WCMausoleum01",
            Map = StablesAtEventide,
            AvailableHeroes = new Hero[] { Bionka, Tundra, Blackpaw },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { RingOfStorms, ArrowWall, ViscousTar, CeilingBallista, FloorSpikes, FlipTrap },
                TrapTier = 1,
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 5, 30),
            Description = "Something has gone terribly wrong with the rifts at this jungle fortress. Stop the unstable rifts and the enemies controlling them.",
            SpecialConditions = "Unstable rifts spawning all over, nothing spawns from regular portals.",
        };

        public static WeeklyChallenge RollingInIt = new WeeklyChallenge()
        {
            Name = ROLLING_IN_IT,
            CodeName = "WCMausoleum01",
            Map = AcademySewers,
            AvailableHeroes = new Hero[] { Dobbin, Cygnus, Smolder },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { MagesClover, MendingRoot, GreatWallBarricade, CeilingBallista, Brimstone, Haymaker, ShockZapper, SpikeWall, ViscousTar },
                TrapTier = 1,
                Guardians = new Guardian[] { MoonGuardian, SunGuardian },
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 8, 0),
            Description = "You'll need to be rolling in it to afford these traps. Good things come to those who wait.",
            SpecialConditions = "Coin only from starting coin and coin pickups.",
        };

        public static WeeklyChallenge TheMercsLitter = new WeeklyChallenge()
        {
            Name = THE_MERCS_LITTER,
            CodeName = "WCMausoleum01",
            Map = Confluence,
            AvailableHeroes = new Hero[] { Maximilian, Hogarth, Ivy },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { FlameBracers, RingOfLastStand, Barricade, BGHArrowWall, BGHBallista, BGHShockZapper },
                TrapTier = 1,
                Guardians = new Guardian[] { DeckhandGuardian },
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 6, 0),
            Description = "Battle enemy mercenaries and their tiny kobold friends in this weekly challenge.",
            SpecialConditions = "Kobolds and Mercenaries only. No damage traps other than Big Game Hunting Traps...",  
        };

        public static WeeklyChallenge VanishingAct = new WeeklyChallenge()
        {
            Name = VANISHING_ACT,
            CodeName = "WCMausoleum01",
            Map = Frostbite,
            AvailableHeroes = new Hero[] { Gabriella, Ivy, Zoey },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { MendingRoot, ArcaneBubbleBlower, TarTrap, FlipTrap, FloorSpikes, SpitfireWall, DragonsLance },
                TrapTier = 1,
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 7, 30),
            Description = "Sneaky, invisible enemies are trying to overtake Frostbite Fortress in this weekly challenge. Damage them to knock them into visibility and defeat them.",
            SpecialConditions = "Invisible minions. Traps still target them, they are revealed on hit.",
        };

        public static WeeklyChallenge WeCanRebuildIt = new WeeklyChallenge()
        {
            Name = WE_CAN_REBUILD_IT,
            CodeName = "WCMausoleum01",
            Map = DocksAtEventide,
            AvailableHeroes = new Hero[] { Stinkeye, Gabriella, Midnight },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { MagesClover, MendingRoot, Barricade, ViscousTar, FlipTrap, WallBlades, ShockZapper },
                TrapTier = 1,
                Guardians = new Guardian[] { DeckhandGuardian, SunGuardian },
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 8, 20),
            Description = "Be prepared to build and rebuild your killboxes to deal with waves of every minion and boss type Centre has to offer. You'll have to think quickly about your strategy to complete this challenge!",
            SpecialConditions = "None",
        };

        public static WeeklyChallenge YourOwnDevices = new WeeklyChallenge()
        {
            Name = YOUR_OWN_DEVICES,
            CodeName = "WCMausoleum01",
            Map = TheWall,
            AvailableHeroes = new Hero[] { Smolder, Midnight, Oziel },
            Loadout = new Loadout()
            {
                Dye = Dyes.ElementAt(Random.Next(Dyes.Count)).Value,
                // Skin = Skins.ElementAt(Random.Next(Skins.Count)).Value,  
                SlotItems = new SlotItem[] { RingOfStorms, IceAmulet, GreatWallBarricade },
                TrapTier = 1,
                Guardians = new Guardian[] { MoonGuardian, SunGuardian },
            },
            AccountLevel = 1,
            EnemyLevel = 1,
            StartingCoin = 9000,
            ParTime = new TimeSpan(0, 7, 30),
            Description = "Use the Great Wall Barricade and little else but your hero's abilities to keep enemies out of your rift in this challenge. Don't forget to bring some gear!",
            SpecialConditions = "Only Gear and Abilities, 10x mana regeneration.",
        };
        */
    }


}
