using System.Collections.Generic;
using static SingleplayerLauncher.Names.Difficulty;
using static SingleplayerLauncher.Names.Map;

namespace SingleplayerLauncher.Model
{
    public class Map
    {
        private const int _6000_COIN = 6000;
        private const int _9000_COIN = 9000;

        public string Name { get; private set; }
        public string UmapCode { get; private set; }
        public int StartingCoin { get; private set; } = _9000_COIN;

        public string[] SurvivalAvailableMapNames { get; private set; }

        public bool HasEndlessAvailable { get; private set; } = false;

        // private constructor
        Map() { }

        // static members
        public static Map AcademySewers = new Map()
        {
            Name = ACADEMY_SEWERS,
            UmapCode = "PvE_Sewers.umap",
            SurvivalAvailableMapNames = new string[] { RIFT_LORD },
        };
        public static Map ArchmageLibrary = new Map()
        {
            Name = ARCHMAGE_LIBRARY,
            UmapCode = "PvE_AcademyLibrary.umap",
            SurvivalAvailableMapNames = new string[] { APPRENTICE },
        };
        public static Map Avalanche = new Map()
        {
            Name = AVALANCHE,
            UmapCode = "PvE_Avalanche.umap",
            SurvivalAvailableMapNames = new string[] { MASTER, RIFT_LORD },
            HasEndlessAvailable = true,
        };
        public static Map BanquetHall = new Map()
        {
            Name = BANQUET_HALL,
            UmapCode = "PvE_BanquetHall.umap",
            SurvivalAvailableMapNames = new string[] { APPRENTICE, WAR_MAGE, RIFT_LORD },
            HasEndlessAvailable = true,
        };
        public static Map CastleGates = new Map()
        {
            Name = CASTLE_GATES,
            UmapCode = "PvE_ASN_CastleGates.umap",
            SurvivalAvailableMapNames = new string[] { MASTER, RIFT_LORD },
            StartingCoin = _6000_COIN,
        };
        public static Map CliffsideClash = new Map()
        {
            Name = CLIFFSIDE_CLASH,
            UmapCode = "PvE_2Lane.umap",
            SurvivalAvailableMapNames = new string[] { APPRENTICE, MASTER },
        };
        public static Map Confluence = new Map()
        {
            Name = CONFLUENCE,
            UmapCode = "PvE_AcademyCanals.umap",
            SurvivalAvailableMapNames = new string[] { RIFT_LORD },
        };
        public static Map CrogonKeep = new Map()
        {
            Name = CROGON_KEEP,
            UmapCode = "PvE_CrogonKeep.umap",
            SurvivalAvailableMapNames = new string[] { WAR_MAGE, MASTER, RIFT_LORD },
            HasEndlessAvailable = true,
        };
        public static Map DocksAtEventide = new Map()
        {
            Name = DOCKS_AT_EVENTIDE,
            UmapCode = "PvE_SUR_Pirates.umap",
            SurvivalAvailableMapNames = new string[] { MASTER },
            HasEndlessAvailable = true,
        };
        public static Map EventideFortress = new Map()
        {
            Name = EVENTIDE_FORTRESS,
            UmapCode = "PvE_Surrounded.umap",
            SurvivalAvailableMapNames = new string[] { RIFT_LORD },
        };
        public static Map EventideRamparts = new Map()
        {
            Name = EVENTIDE_RAMPARTS,
            UmapCode = "PvE_SUR_NorthernClans.umap",
            SurvivalAvailableMapNames = new string[] { APPRENTICE, WAR_MAGE },
        };
        public static Map Frostbite = new Map()
        {
            Name = FROSTBITE,
            UmapCode = "PvE_FrostBite.umap",
            SurvivalAvailableMapNames = new string[] { MASTER, RIFT_LORD },
            HasEndlessAvailable = true,
        };
        public static Map GatesOfThuricvod = new Map()
        {
            Name = GATES_OF_THURICVOD,
            UmapCode = "PvE_Corridors.umap",
            SurvivalAvailableMapNames = new string[] { WAR_MAGE, RIFT_LORD },
        };
        public static Map Highlands = new Map()
        {
            Name = HIGHLANDS,
            UmapCode = "PvE_Highlands.umap",
            SurvivalAvailableMapNames = new string[] { APPRENTICE, WAR_MAGE, RIFT_LORD },
            HasEndlessAvailable = true,
        };
        public static Map MaximumSecurity = new Map()
        {
            Name = MAXIMUM_SECURITY,
            UmapCode = "PvE_AcademyDungeon.umap",
            SurvivalAvailableMapNames = new string[] { RIFT_LORD },
        };
        public static Map MidnightMarket = new Map()
        {
            Name = MIDNIGHT_MARKET,
            UmapCode = "PvE_ASN_NightMarket.umap",
            SurvivalAvailableMapNames = new string[] { WAR_MAGE, RIFT_LORD },
            StartingCoin = _6000_COIN,
        };
        public static Map Orcatraz = new Map()
        {
            Name = ORCATRAZ,
            UmapCode = "PvE_Orcatraz.umap",
            SurvivalAvailableMapNames = new string[] { MASTER },
        };
        public static Map OrcriLa = new Map()
        {
            Name = ORCRI_LA,
            UmapCode = "PvE_OrcVil_Temple.umap",
            SurvivalAvailableMapNames = new string[] { MASTER },
        };
        public static Map RestrictedSection = new Map()
        {
            Name = RESTRICTED_SECTION,
            UmapCode = "PvE_RestrictedSection.umap",
            SurvivalAvailableMapNames = new string[] { WAR_MAGE, RIFT_LORD },
        };
        public static Map RiftmakersTemple = new Map()
        {
            Name = RIFTMAKERS_TEMPLE,
            UmapCode = "PvE_AcademyTemple.umap",
            SurvivalAvailableMapNames = new string[] { APPRENTICE },
            StartingCoin = _6000_COIN,
        };
        public static Map SharkIsland = new Map()
        {
            Name = SHARK_ISLAND,
            UmapCode = "PvE_SharkIsle.umap",
            SurvivalAvailableMapNames = new string[] { WAR_MAGE, MASTER },
            HasEndlessAvailable = true,
        };
        public static Map StablesAtEventide = new Map()
        {
            Name = STABLES_AT_EVENTIDE,
            UmapCode = "PvE_SUR_JungleTribe.umap",
            SurvivalAvailableMapNames = new string[] { WAR_MAGE, MASTER },
        };
        public static Map StormDrain = new Map()
        {
            Name = STORM_DRAIN,
            UmapCode = "PvE_Flushed.umap",
            SurvivalAvailableMapNames = new string[] { MASTER },
        };
        public static Map TempleGraveyard = new Map()
        {
            Name = TEMPLE_GRAVEYARD,
            UmapCode = "PvE_Mausoleum.umap",
            SurvivalAvailableMapNames = new string[] { WAR_MAGE, RIFT_LORD },
        };
        public static Map TheBaths = new Map()
        {
            Name = THE_BATHS,
            UmapCode = "PvE_Baths.umap",
            SurvivalAvailableMapNames = new string[] { APPRENTICE, RIFT_LORD },
            StartingCoin = _6000_COIN,
            HasEndlessAvailable = true,
        };
        public static Map TheFallingFolly = new Map()
        {
            Name = THE_FALLING_FOLLY,
            UmapCode = "PvE_Towering.umap",
            SurvivalAvailableMapNames = new string[] { MASTER },
        };
        public static Map TheWall = new Map()
        {
            Name = THE_WALL,
            UmapCode = "PvE_TheWall.umap",
            SurvivalAvailableMapNames = new string[] { WAR_MAGE, MASTER },
            HasEndlessAvailable = true,
        };
        public static Map ThroneRoom = new Map()
        {
            Name = THRONE_ROOM,
            UmapCode = "PvE_ThroneRoom.umap",
            SurvivalAvailableMapNames = new string[] { APPRENTICE, WAR_MAGE, RIFT_LORD },
            HasEndlessAvailable = true,
        };
        public static Map ThuricvodVillage = new Map()
        {
            Name = THURICVOD_VILLAGE,
            UmapCode = "PvE_Gap.umap",
            SurvivalAvailableMapNames = new string[] { WAR_MAGE },
            HasEndlessAvailable = true,
        };
        public static Map TrainingGrounds = new Map()
        {
            Name = TRAINING_GROUNDS,
            UmapCode = "PvE_TrainingGrounds.umap",
            SurvivalAvailableMapNames = new string[] { APPRENTICE, WAR_MAGE, MASTER },
        };
        public static Map UnchainedFortress = new Map()
        {
            Name = UNCHAINED_FORTRESS,
            UmapCode = "PvE_OneWay.umap",
            SurvivalAvailableMapNames = new string[] { APPRENTICE, MASTER },
        };
        public static Map WaterGarden = new Map()
        {
            Name = WATER_GARDEN,
            UmapCode = "PvE_ASN_WaterGarden.umap",
            SurvivalAvailableMapNames = new string[] { APPRENTICE, MASTER },
            StartingCoin = _6000_COIN,
        };

        // Maps { Name, umap }
        public static Dictionary<string, Map> Maps = new Dictionary<string, Map>
        {
            { ACADEMY_SEWERS, AcademySewers},
            { ARCHMAGE_LIBRARY, ArchmageLibrary},
            { AVALANCHE, Avalanche},
            { BANQUET_HALL, BanquetHall},
            { CASTLE_GATES, CastleGates},
            { CLIFFSIDE_CLASH, CliffsideClash},
            { CONFLUENCE, Confluence},
            { CROGON_KEEP, CrogonKeep},
            { DOCKS_AT_EVENTIDE, DocksAtEventide},
            { EVENTIDE_FORTRESS, EventideFortress},
            { EVENTIDE_RAMPARTS, EventideRamparts},
            { FROSTBITE, Frostbite},
            { GATES_OF_THURICVOD, GatesOfThuricvod},
            { HIGHLANDS, Highlands},
            { MAXIMUM_SECURITY, MaximumSecurity},
            { MIDNIGHT_MARKET, MidnightMarket},
            { ORCATRAZ, Orcatraz},
            { ORCRI_LA, OrcriLa},
            { RESTRICTED_SECTION, RestrictedSection},
            { RIFTMAKERS_TEMPLE, RiftmakersTemple},
            { SHARK_ISLAND, SharkIsland},
            { STABLES_AT_EVENTIDE, StablesAtEventide},
            { STORM_DRAIN, StormDrain},
            { TEMPLE_GRAVEYARD, TempleGraveyard},
            { THE_BATHS, TheBaths},
            { THE_FALLING_FOLLY, TheFallingFolly},
            { THE_WALL, TheWall},
            { THRONE_ROOM, ThroneRoom},
            { THURICVOD_VILLAGE, ThuricvodVillage},
            { TRAINING_GROUNDS, TrainingGrounds},
            { UNCHAINED_FORTRESS, UnchainedFortress},
            { WATER_GARDEN, WaterGarden},
        };
    }


}
