using System;
using System.Collections.Generic;
using static SingleplayerLauncher.Model.Map;
using static SingleplayerLauncher.Names.Difficulty;

namespace SingleplayerLauncher.Model
{
    class Survival : IBattleground
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Map Map { get; set; }

        public GameMode GameMode { get; set; } = GameMode.Survival;

        public Difficulty Difficulty { get; set; } = new Difficulty();

        public int StartingCoin { get; set; }
        public TimeSpan ParTime { get; private set; }
        public int WaveCount { get; private set; }

        public static Survival TheBathsApprentice = new()
        {
            Id = 1,
            Name = "The Baths",
            Map = TheBaths,
            Difficulty = new Difficulty()
            {
                AccountLevel = 01,
                EnemyLevel = 01,
                TrapTier = 1,
            },
            WaveCount = 6,
            ParTime = new TimeSpan(0, 8, 00),
        };

        public static Survival EventideRampartsApprentice = new()
        {
            Id = 2,
            Name = "Eventide Ramparts",
            Map = EventideRamparts,
            Difficulty = new Difficulty()
            {
                AccountLevel = 02,
                EnemyLevel = 02,
                TrapTier = 1,
            },
            WaveCount = 8,
            ParTime = new TimeSpan(0, 10, 00),
        };

        public static Survival BanquetHallApprentice = new()
        {
            Id = 3,
            Name = "Banquet Hall",
            Map = BanquetHall,
            Difficulty = new Difficulty()
            {
                AccountLevel = 04,
                EnemyLevel = 04,
                TrapTier = 1,
            },
            WaveCount = 6,
            ParTime = new TimeSpan(0, 7, 30),
        };

        public static Survival CliffsideClashApprentice = new()
        {
            Id = 4,
            Name = "Cliffside Clash",
            Map = CliffsideClash,
            Difficulty = new Difficulty()
            {
                AccountLevel = 05,
                EnemyLevel = 05,
                TrapTier = 2,
            },
            WaveCount = 6,
            ParTime = new TimeSpan(0, 10, 50),
        };

        public static Survival ThroneRoomApprentice = new()
        {
            Id = 5,
            Name = "Throne Room",
            Map = ThroneRoom,
            Difficulty = new Difficulty()
            {
                AccountLevel = 06,
                EnemyLevel = 06,
                TrapTier = 2,
            },
            WaveCount = 8,
            ParTime = new TimeSpan(0, 9, 35),
        };

        public static Survival WaterGardenApprentice = new()
        {
            Id = 6,
            Name = "Water Garden",
            Map = WaterGarden,
            Difficulty = new Difficulty()
            {
                AccountLevel = 07,
                EnemyLevel = 07,
                TrapTier = 2,
            },
            WaveCount = 6,
            ParTime = new TimeSpan(0, 7, 00),
        };

        public static Survival UnchainedFortressApprentice = new()
        {
            Id = 7,
            Name = "Unchained Fortress",
            Map = UnchainedFortress,
            Difficulty = new Difficulty()
            {
                AccountLevel = 08,
                EnemyLevel = 08,
                TrapTier = 2,
            },
            WaveCount = 6,
            ParTime = new TimeSpan(0, 8, 50),
        };

        public static Survival HighlandsApprentice = new()
        {
            Id = 8,
            Name = "Highlands",
            Map = Highlands,
            Difficulty = new Difficulty()
            {
                AccountLevel = 09,
                EnemyLevel = 09,
                TrapTier = 2,
            },
            WaveCount = 6,
            ParTime = new TimeSpan(0, 9, 15),
        };

        public static Survival TrainingGroundsApprentice = new()
        {
            Id = 9,
            Name = "Training Grounds",
            Map = TrainingGrounds,
            Difficulty = new Difficulty()
            {
                AccountLevel = 10,
                EnemyLevel = 10,
                TrapTier = 2,
            },
            WaveCount = 7,
            ParTime = new TimeSpan(0, 9, 50),
        };

        public static Survival EventideRampartsWarMage = new()
        {
            Id = 10,
            Name = "Eventide Ramparts",
            Map = EventideRamparts,
            Difficulty = new Difficulty()
            {
                AccountLevel = 12,
                EnemyLevel = 12,
                TrapTier = 2,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 13, 30),
        };

        public static Survival TempleGraveyardWarMage = new()
        {
            Id = 11,
            Name = "Temple Graveyard",
            Map = TempleGraveyard,
            Difficulty = new Difficulty()
            {
                AccountLevel = 13,
                EnemyLevel = 13,
                TrapTier = 2,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 11, 30),
        };

        public static Survival BanquetHallWarMage = new()
        {
            Id = 12,
            Name = "Banquet Hall",
            Map = BanquetHall,
            Difficulty = new Difficulty()
            {
                AccountLevel = 14,
                EnemyLevel = 14,
                TrapTier = 2,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 12, 45),
        };

        public static Survival GatesOfThuricvodWarMage = new()
        {
            Id = 13,
            Name = "Gates of Thuricvod",
            Map = GatesOfThuricvod,
            Difficulty = new Difficulty()
            {
                AccountLevel = 15,
                EnemyLevel = 15,
                TrapTier = 2,
            },
            WaveCount = 8,
            ParTime = new TimeSpan(0, 7, 05),
        };

        public static Survival TheWallWarMage = new()
        {
            Id = 14,
            Name = "The Wall",
            Map = TheWall,
            Difficulty = new Difficulty()
            {
                AccountLevel = 16,
                EnemyLevel = 16,
                TrapTier = 2,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 15, 00),
        };

        public static Survival MidnightMarketWarMage = new()
        {
            Id = 15,
            Name = "Midnight Market",
            Map = MidnightMarket,
            Difficulty = new Difficulty()
            {
                AccountLevel = 17,
                EnemyLevel = 17,
                TrapTier = 2,
            },
            WaveCount = 8,
            ParTime = new TimeSpan(0, 8, 30),
        };

        public static Survival TrainingGroundsWarMage = new()
        {
            Id = 16,
            Name = "Training Grounds",
            Map = TrainingGrounds,
            Difficulty = new Difficulty()
            {
                AccountLevel = 18,
                EnemyLevel = 18,
                TrapTier = 2,
            },
            WaveCount = 9,
            ParTime = new TimeSpan(0, 11, 45),
        };

        public static Survival ThuricvodVillageWarMage = new()
        {
            Id = 17,
            Name = "Thuricvod Village",
            Map = ThuricvodVillage,
            Difficulty = new Difficulty()
            {
                AccountLevel = 19,
                EnemyLevel = 19,
                TrapTier = 2,
            },
            WaveCount = 8,
            ParTime = new TimeSpan(0, 9, 15),
        };

        public static Survival ThroneRoomWarMage = new()
        {
            Id = 18,
            Name = "Throne Room",
            Map = ThroneRoom,
            Difficulty = new Difficulty()
            {
                AccountLevel = 20,
                EnemyLevel = 20,
                TrapTier = 2,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 14, 30),
        };

        public static Survival CrogonKeepWarMage = new()
        {
            Id = 19,
            Name = "Crogon Keep",
            Map = CrogonKeep,
            Difficulty = new Difficulty()
            {
                AccountLevel = 21,
                EnemyLevel = 21,
                TrapTier = 3,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 14, 00),
        };

        public static Survival SharkIslandWarMage = new()
        {
            Id = 20,
            Name = "Shark Island",
            Map = SharkIsland,
            Difficulty = new Difficulty()
            {
                AccountLevel = 23,
                EnemyLevel = 23,
                TrapTier = 3,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 12, 30),
        };

        public static Survival StablesAtEventideWarMage = new()
        {
            Id = 21,
            Name = "Stables at Eventide",
            Map = StablesAtEventide,
            Difficulty = new Difficulty()
            {
                AccountLevel = 24,
                EnemyLevel = 24,
                TrapTier = 3,
            },
            WaveCount = 8,
            ParTime = new TimeSpan(0, 10, 30),
        };

        public static Survival HighlandsWarMage = new()
        {
            Id = 22,
            Name = "Highlands",
            Map = Highlands,
            Difficulty = new Difficulty()
            {
                AccountLevel = 25,
                EnemyLevel = 25,
                TrapTier = 3,
            },
            WaveCount = 8,
            ParTime = new TimeSpan(0, 12, 45),
        };

        public static Survival RestrictedSectionWarMage = new()
        {
            Id = 23,
            Name = "Restricted Section",
            Map = RestrictedSection,
            Difficulty = new Difficulty()
            {
                AccountLevel = 25,
                EnemyLevel = 25,
                TrapTier = 3,
            },
            WaveCount = 8,
            ParTime = new TimeSpan(0, 10, 30),
        };

        public static Survival CliffsideClashMaster = new()
        {
            Id = 24,
            Name = "Cliffside Clash",
            Map = CliffsideClash,
            Difficulty = new Difficulty()
            {
                AccountLevel = 26,
                EnemyLevel = 26,
                TrapTier = 3,
            },
            WaveCount = 9,
            ParTime = new TimeSpan(0, 14, 35),
        };

        public static Survival TheFallingFollyMaster = new()
        {
            Id = 25,
            Name = "The Falling Folly",
            Map = TheFallingFolly,
            Difficulty = new Difficulty()
            {
                AccountLevel = 27,
                EnemyLevel = 27,
                TrapTier = 3,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 12, 40),
        };

        public static Survival FrostbiteMaster = new()
        {
            Id = 26,
            Name = "Frostbite",
            Map = Frostbite,
            Difficulty = new Difficulty()
            {
                AccountLevel = 28,
                EnemyLevel = 28,
                TrapTier = 3,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 12, 15),
        };

        public static Survival OrcatrazMaster = new()
        {
            Id = 27,
            Name = "Orcatraz",
            Map = Orcatraz,
            Difficulty = new Difficulty()
            {
                AccountLevel = 30,
                EnemyLevel = 30,
                TrapTier = 4,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 13, 15),
        };

        public static Survival UnchainedFortressMaster = new()
        {
            Id = 28,
            Name = "Unchained Fortress",
            Map = UnchainedFortress,
            Difficulty = new Difficulty()
            {
                AccountLevel = 32,
                EnemyLevel = 32,
                TrapTier = 4,
            },
            WaveCount = 12,
            ParTime = new TimeSpan(0, 15, 30),
        };

        public static Survival WaterGardenMaster = new()
        {
            Id = 29,
            Name = "Water Garden",
            Map = WaterGarden,
            Difficulty = new Difficulty()
            {
                AccountLevel = 33,
                EnemyLevel = 33,
                TrapTier = 4,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 12, 15),
        };

        public static Survival TrainingGroundsMaster = new()
        {
            Id = 30,
            Name = "Training Grounds",
            Map = TrainingGrounds,
            Difficulty = new Difficulty()
            {
                AccountLevel = 35,
                EnemyLevel = 35,
                TrapTier = 4,
            },
            WaveCount = 11,
            ParTime = new TimeSpan(0, 15, 00),
        };

        public static Survival StormDrainMaster = new()
        {
            Id = 31,
            Name = "Storm Drain",
            Map = StormDrain,
            Difficulty = new Difficulty()
            {
                AccountLevel = 36,
                EnemyLevel = 36,
                TrapTier = 4,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 14, 30),
        };

        public static Survival StablesAtEventideMaster = new()
        {
            Id = 32,
            Name = "Stables at Eventide",
            Map = StablesAtEventide,
            Difficulty = new Difficulty()
            {
                AccountLevel = 37,
                EnemyLevel = 37,
                TrapTier = 4,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 13, 00),
        };

        public static Survival TheWallMaster = new()
        {
            Id = 33,
            Name = "The Wall",
            Map = TheWall,
            Difficulty = new Difficulty()
            {
                AccountLevel = 39,
                EnemyLevel = 39,
                TrapTier = 4,
            },
            WaveCount = 12,
            ParTime = new TimeSpan(0, 15, 00),
        };

        public static Survival AvalancheMaster = new()
        {
            Id = 34,
            Name = "Avalanche",
            Map = Avalanche,
            Difficulty = new Difficulty()
            {
                AccountLevel = 40,
                EnemyLevel = 40,
                TrapTier = 5,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 15, 30),
        };

        public static Survival CastleGatesMaster = new()
        {
            Id = 35,
            Name = "Castle Gates",
            Map = CastleGates,
            Difficulty = new Difficulty()
            {
                AccountLevel = 41,
                EnemyLevel = 41,
                TrapTier = 5,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 11, 00),
        };

        public static Survival DocksAtEventideMaster = new()
        {
            Id = 36,
            Name = "Docks at Eventide",
            Map = DocksAtEventide,
            Difficulty = new Difficulty()
            {
                AccountLevel = 42,
                EnemyLevel = 42,
                TrapTier = 5,
            },
            WaveCount = 10,
            ParTime = new TimeSpan(0, 13, 45),
        };

        public static Survival CrogonKeepMaster = new()
        {
            Id = 37,
            Name = "Crogon Keep",
            Map = CrogonKeep,
            Difficulty = new Difficulty()
            {
                AccountLevel = 43,
                EnemyLevel = 43,
                TrapTier = 5,
            },
            WaveCount = 12,
            ParTime = new TimeSpan(0, 18, 00),
        };

        public static Survival OrcriLaMASTER = new()
        {
            Id = 38,
            Name = "Orcri-La",
            Map = OrcriLa,
            Difficulty = new Difficulty()
            {
                AccountLevel = 44,
                EnemyLevel = 44,
                TrapTier = 5,
            },
            WaveCount = 12,
            ParTime = new TimeSpan(0, 13, 00),
        };

        public static Survival SharkIslandMaster = new()
        {
            Id = 39,
            Name = "Shark Island",
            Map = SharkIsland,
            Difficulty = new Difficulty()
            {
                AccountLevel = 45,
                EnemyLevel = 45,
                TrapTier = 5,
            },
            WaveCount = 12,
            ParTime = new TimeSpan(0, 18, 00),
        };

        public static Survival TheBathsRiftLord = new()
        {
            Id = 40,
            Name = "The Baths",
            Map = TheBaths,
            Difficulty = new Difficulty()
            {
                AccountLevel = 46,
                EnemyLevel = 46,
                TrapTier = 5,
            },
            WaveCount = 14,
            ParTime = new TimeSpan(0, 12, 00),
        };

        public static Survival MaximumSecurityRiftLord = new()
        {
            Id = 41,
            Name = "Maximum Security",
            Map = MaximumSecurity,
            Difficulty = new Difficulty()
            {
                AccountLevel = 48,
                EnemyLevel = 48,
                TrapTier = 5,
            },
            WaveCount = 14,
            ParTime = new TimeSpan(0, 16, 45),
        };

        public static Survival ThroneRoomRiftLord = new()
        {
            Id = 42,
            Name = "Throne Room",
            Map = ThroneRoom,
            Difficulty = new Difficulty()
            {
                AccountLevel = 50,
                EnemyLevel = 50,
                TrapTier = 6,
            },
            WaveCount = 12,
            ParTime = new TimeSpan(0, 15, 45),
        };

        public static Survival RestrictedSectionRiftLord = new()
        {
            Id = 43,
            Name = "Restricted Section",
            Map = RestrictedSection,
            Difficulty = new Difficulty()
            {
                AccountLevel = 52,
                EnemyLevel = 52,
                TrapTier = 6,
            },
            WaveCount = 14,
            ParTime = new TimeSpan(0, 15, 00),
        };

        public static Survival MidnightMarketRiftLord = new()
        {
            Id = 44,
            Name = "Midnight Market",
            Map = MidnightMarket,
            Difficulty = new Difficulty()
            {
                AccountLevel = 53,
                EnemyLevel = 53,
                TrapTier = 6,
            },
            WaveCount = 12,
            ParTime = new TimeSpan(0, 12, 00),
        };

        public static Survival BanquetHallRiftLord = new()
        {
            Id = 45,
            Name = "Banquet Hall",
            Map = BanquetHall,
            Difficulty = new Difficulty()
            {
                AccountLevel = 55,
                EnemyLevel = 55,
                TrapTier = 6,
            },
            WaveCount = 12,
            ParTime = new TimeSpan(0, 13, 45),
        };

        public static Survival ConfluenceRiftLord = new()
        {
            Id = 46,
            Name = "Confluence",
            Map = Confluence,
            Difficulty = new Difficulty()
            {
                AccountLevel = 57,
                EnemyLevel = 57,
                TrapTier = 6,
            },
            WaveCount = 14,
            ParTime = new TimeSpan(0, 15, 30),
        };

        public static Survival FrostbiteRiftLord = new()
        {
            Id = 47,
            Name = "Frostbite",
            Map = Frostbite,
            Difficulty = new Difficulty()
            {
                AccountLevel = 59,
                EnemyLevel = 59,
                TrapTier = 6,
            },
            WaveCount = 12,
            ParTime = new TimeSpan(0, 13, 45),
        };

        public static Survival GatesOfThuricvodRiftLord = new()
        {
            Id = 48,
            Name = "Gates of Thuricvod",
            Map = GatesOfThuricvod,
            Difficulty = new Difficulty()
            {
                AccountLevel = 62,
                EnemyLevel = 62,
                TrapTier = 7,
            },
            WaveCount = 12,
            ParTime = new TimeSpan(0, 13, 15),
        };

        public static Survival TempleGraveyardRiftLord = new()
        {
            Id = 49,
            Name = "Temple Graveyard",
            Map = TempleGraveyard,
            Difficulty = new Difficulty()
            {
                AccountLevel = 63,
                EnemyLevel = 63,
                TrapTier = 7,
            },
            WaveCount = 12,
            ParTime = new TimeSpan(0, 14, 00),
        };

        public static Survival HighlandsRiftLord = new()
        {
            Id = 50,
            Name = "Highlands",
            Map = Highlands,
            Difficulty = new Difficulty()
            {
                AccountLevel = 65,
                EnemyLevel = 65,
                TrapTier = 7,
            },
            WaveCount = 14,
            ParTime = new TimeSpan(0, 19, 45),
        };

        public static Survival AvalancheRiftLord = new()
        {
            Id = 51,
            Name = "Avalanche",
            Map = Avalanche,
            Difficulty = new Difficulty()
            {
                AccountLevel = 66,
                EnemyLevel = 66,
                TrapTier = 7,
            },
            WaveCount = 12,
            ParTime = new TimeSpan(0, 17, 45),
        };

        public static Survival CastleGatesRiftLord = new()
        {
            Id = 52,
            Name = "Castle Gates",
            Map = CastleGates,
            Difficulty = new Difficulty()
            {
                AccountLevel = 67,
                EnemyLevel = 67,
                TrapTier = 7,
            },
            WaveCount = 12,
            ParTime = new TimeSpan(0, 14, 00),
        };

        public static Survival AcademySewersRiftLord = new()
        {
            Id = 53,
            Name = "Academy Sewers",
            Map = AcademySewers,
            Difficulty = new Difficulty()
            {
                AccountLevel = 68,
                EnemyLevel = 68,
                TrapTier = 7,
            },
            WaveCount = 14,
            ParTime = new TimeSpan(0, 13, 30),
        };

        public static Survival CrogonKeepRiftLord = new()
        {
            Id = 54,
            Name = "Crogon Keep",
            Map = CrogonKeep,
            Difficulty = new Difficulty()
            {
                AccountLevel = 70,
                EnemyLevel = 70,
                TrapTier = 7,
            },
            WaveCount = 14,
            ParTime = new TimeSpan(0, 22, 45),
        };

        public static Survival EventideFortressRiftLord = new()
        {
            Id = 55,
            Name = "Eventide Fortress",
            Map = EventideFortress,
            Difficulty = new Difficulty()
            {
                AccountLevel = 75,
                EnemyLevel = 75,
                TrapTier = 7,
            },
            WaveCount = 14,
            ParTime = new TimeSpan(0, 20, 15),
        };


        public static Dictionary<string, Survival> SurvivalApprenticeBattlegrounds = new()
        {
            { TheBaths.Name, TheBathsApprentice },
            { EventideRamparts.Name, EventideRampartsApprentice },
            { BanquetHall.Name, BanquetHallApprentice },
            { CliffsideClash.Name, CliffsideClashApprentice },
            { ThroneRoom.Name, ThroneRoomApprentice },
            { WaterGarden.Name, WaterGardenApprentice },
            { UnchainedFortress.Name, UnchainedFortressApprentice },
            { Highlands.Name, HighlandsApprentice },
            { TrainingGrounds.Name, TrainingGroundsApprentice },
        };

        public static Dictionary<string, Survival> SurvivalWarMageBattlegrounds = new()
        {
            { EventideRamparts.Name, EventideRampartsWarMage },
            { TempleGraveyard.Name, TempleGraveyardWarMage },
            { BanquetHall.Name, BanquetHallWarMage },
            { GatesOfThuricvod.Name, GatesOfThuricvodWarMage },
            { TheWall.Name, TheWallWarMage },
            { MidnightMarket.Name, MidnightMarketWarMage },
            { TrainingGrounds.Name, TrainingGroundsWarMage },
            { ThuricvodVillage.Name, ThuricvodVillageWarMage },
            { ThroneRoom.Name, ThroneRoomWarMage },
            { CrogonKeep.Name, CrogonKeepWarMage },
            { SharkIsland.Name, SharkIslandWarMage },
            { StablesAtEventide.Name, StablesAtEventideWarMage },
            { Highlands.Name, HighlandsWarMage },
            { RestrictedSection.Name, RestrictedSectionWarMage },
        };

        public static Dictionary<string, Survival> SurvivalMasterBattlegrounds = new()
        {
            { CliffsideClash.Name, CliffsideClashMaster },
            { TheFallingFolly.Name, TheFallingFollyMaster },
            { Frostbite.Name, FrostbiteMaster },
            { Orcatraz.Name, OrcatrazMaster },
            { UnchainedFortress.Name, UnchainedFortressMaster },
            { WaterGarden.Name, WaterGardenMaster },
            { TrainingGrounds.Name, TrainingGroundsMaster },
            { StormDrain.Name, StormDrainMaster },
            { StablesAtEventide.Name, StablesAtEventideMaster },
            { TheWall.Name, TheWallMaster },
            { Avalanche.Name, AvalancheMaster },
            { CastleGates.Name, CastleGatesMaster },
            { DocksAtEventide.Name, DocksAtEventideMaster },
            { CrogonKeep.Name, CrogonKeepMaster },
            { OrcriLa.Name, OrcriLaMASTER },
            { SharkIsland.Name, SharkIslandMaster },
        };

        public static Dictionary<string, Survival> SurvivalRiftLordBattlegrounds = new()
        {
            { TheBaths.Name, TheBathsRiftLord },
            { MaximumSecurity.Name, MaximumSecurityRiftLord },
            { ThroneRoom.Name, ThroneRoomRiftLord },
            { RestrictedSection.Name, RestrictedSectionRiftLord },
            { MidnightMarket.Name, MidnightMarketRiftLord },
            { BanquetHall.Name, BanquetHallRiftLord },
            { Confluence.Name, ConfluenceRiftLord },
            { Frostbite.Name, FrostbiteRiftLord },
            { GatesOfThuricvod.Name, GatesOfThuricvodRiftLord },
            { TempleGraveyard.Name, TempleGraveyardRiftLord },
            { Highlands.Name, HighlandsRiftLord },
            { Avalanche.Name, AvalancheRiftLord },
            { CastleGates.Name, CastleGatesRiftLord },
            { AcademySewers.Name, AcademySewersRiftLord },
            { CrogonKeep.Name, CrogonKeepRiftLord },
            { EventideFortress.Name, EventideFortressRiftLord },
        };

        public static Dictionary<string, Dictionary<string, Survival>> SurvivalBattlegroundsByDifficulty = new()
        {
            { APPRENTICE, SurvivalApprenticeBattlegrounds },
            { WAR_MAGE, SurvivalWarMageBattlegrounds },
            { MASTER, SurvivalMasterBattlegrounds },
            { RIFT_LORD, SurvivalRiftLordBattlegrounds }
        };

    }
}
