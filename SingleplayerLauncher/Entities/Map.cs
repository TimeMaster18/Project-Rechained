using System.Collections.Generic;
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
        public int TrapCap { get; private set; } = 85;

        public bool HasEndlessAvailable { get; private set; } = false;

        // private constructor
        Map() { }

        // static members
        public static Map AcademySewers = new Map()
        {
            Name = ACADEMY_SEWERS,
            UmapCode = "PvE_Sewers.umap",
            TrapCap = 85,
        };
        public static Map ArchmageLibrary = new Map()
        {
            Name = ARCHMAGE_LIBRARY,
            UmapCode = "PvE_AcademyLibrary.umap",
            TrapCap = 85,
        };
        public static Map Avalanche = new Map()
        {
            Name = AVALANCHE,
            UmapCode = "PvE_Avalanche.umap",
            HasEndlessAvailable = true,
            TrapCap = 120,
        };
        public static Map BanquetHall = new Map()
        {
            Name = BANQUET_HALL,
            UmapCode = "PvE_BanquetHall.umap",
            HasEndlessAvailable = true,
            TrapCap = 85,
        };
        public static Map CastleGates = new Map()
        {
            Name = CASTLE_GATES,
            UmapCode = "PvE_ASN_CastleGates.umap",
            StartingCoin = _6000_COIN,
            TrapCap = 85,
        };
        public static Map CliffsideClash = new Map()
        {
            Name = CLIFFSIDE_CLASH,
            UmapCode = "PvE_2Lane.umap",
            TrapCap = 85,
        };
        public static Map Confluence = new Map()
        {
            Name = CONFLUENCE,
            UmapCode = "PvE_AcademyCanals.umap",
            TrapCap = 85,
        };
        public static Map CrogonKeep = new Map()
        {
            Name = CROGON_KEEP,
            UmapCode = "PvE_CrogonKeep.umap",
            HasEndlessAvailable = true,
            TrapCap = 100,
        };
        public static Map DocksAtEventide = new Map()
        {
            Name = DOCKS_AT_EVENTIDE,
            UmapCode = "PvE_SUR_Pirates.umap",
            HasEndlessAvailable = true,
            TrapCap = 90,
        };
        public static Map EventideFortress = new Map()
        {
            Name = EVENTIDE_FORTRESS,
            UmapCode = "PvE_Surrounded.umap",
            TrapCap = 120,
        };
        public static Map EventideRamparts = new Map()
        {
            Name = EVENTIDE_RAMPARTS,
            UmapCode = "PvE_SUR_NorthernClans.umap",
            TrapCap = 100,
        };
        public static Map Frostbite = new Map()
        {
            Name = FROSTBITE,
            UmapCode = "PvE_FrostBite.umap",
            HasEndlessAvailable = true,
            TrapCap = 110,
        };
        public static Map GatesOfThuricvod = new Map()
        {
            Name = GATES_OF_THURICVOD,
            UmapCode = "PvE_Corridors.umap",
            TrapCap = 100,
        };
        public static Map Highlands = new Map()
        {
            Name = HIGHLANDS,
            UmapCode = "PvE_Highlands.umap",
            HasEndlessAvailable = true,
            TrapCap = 110,
        };
        public static Map MaximumSecurity = new Map()
        {
            Name = MAXIMUM_SECURITY,
            UmapCode = "PvE_AcademyDungeon.umap",
            TrapCap = 85,
        };
        public static Map MidnightMarket = new Map()
        {
            Name = MIDNIGHT_MARKET,
            UmapCode = "PvE_ASN_NightMarket.umap",
            StartingCoin = _6000_COIN,
            TrapCap = 85,
        };
        public static Map Orcatraz = new Map()
        {
            Name = ORCATRAZ,
            UmapCode = "PvE_Orcatraz.umap",
            TrapCap = 85,
        };
        public static Map OrcriLa = new Map()
        {
            Name = ORCRI_LA,
            UmapCode = "PvE_OrcVil_Temple.umap",
            TrapCap = 85,
        };
        public static Map RestrictedSection = new Map()
        {
            Name = RESTRICTED_SECTION,
            UmapCode = "PvE_RestrictedSection.umap",
            TrapCap = 85,
        };
        public static Map RiftmakersTemple = new Map()
        {
            Name = RIFTMAKERS_TEMPLE,
            UmapCode = "PvE_AcademyTemple.umap",
            StartingCoin = _6000_COIN,
            TrapCap = 60,
        };
        public static Map SharkIsland = new Map()
        {
            Name = SHARK_ISLAND,
            UmapCode = "PvE_SharkIsle.umap",
            HasEndlessAvailable = true,
            TrapCap = 120,
        };
        public static Map StablesAtEventide = new Map()
        {
            Name = STABLES_AT_EVENTIDE,
            UmapCode = "PvE_SUR_JungleTribe.umap",
            TrapCap = 120,
        };
        public static Map StormDrain = new Map()
        {
            Name = STORM_DRAIN,
            UmapCode = "PvE_Flushed.umap",
            TrapCap = 85,
        };
        public static Map TempleGraveyard = new Map()
        {
            Name = TEMPLE_GRAVEYARD,
            UmapCode = "PvE_Mausoleum.umap",
            TrapCap = 85,
        };
        public static Map TheBaths = new Map()
        {
            Name = THE_BATHS,
            UmapCode = "PvE_Baths.umap",
            StartingCoin = _6000_COIN,
            HasEndlessAvailable = true,
            TrapCap = 85,
        };
        public static Map TheFallingFolly = new Map()
        {
            Name = THE_FALLING_FOLLY,
            UmapCode = "PvE_Towering.umap",
            TrapCap = 85,
        };
        public static Map TheWall = new Map()
        {
            Name = THE_WALL,
            UmapCode = "PvE_TheWall.umap",
            HasEndlessAvailable = true,
            TrapCap = 120,
        };
        public static Map ThroneRoom = new Map()
        {
            Name = THRONE_ROOM,
            UmapCode = "PvE_ThroneRoom.umap",
            HasEndlessAvailable = true,
            TrapCap = 85,
        };
        public static Map ThuricvodVillage = new Map()
        {
            Name = THURICVOD_VILLAGE,
            UmapCode = "PvE_Gap.umap",
            HasEndlessAvailable = true,
            TrapCap = 85,
        };
        public static Map TrainingGrounds = new Map()
        {
            Name = TRAINING_GROUNDS,
            UmapCode = "PvE_TrainingGrounds.umap",
            TrapCap = 90,
        };
        public static Map UnchainedFortress = new Map()
        {
            Name = UNCHAINED_FORTRESS,
            UmapCode = "PvE_OneWay.umap",
            TrapCap = 85,
        };
        public static Map WaterGarden = new Map()
        {
            Name = WATER_GARDEN,
            UmapCode = "PvE_ASN_WaterGarden.umap",
            StartingCoin = _6000_COIN,
            TrapCap = 85,
        };


        public static Map SiegeCliffsideClash = new Map()
        {
            Name = CLIFFSIDE_CLASH,
            UmapCode = "2LaneMountain.umap",
            TrapCap = 85,
        };
        public static Map SiegeUnchainedFortress = new Map()
        {
            Name = UNCHAINED_FORTRESS,
            UmapCode = "OneWay.umap",
            TrapCap = 85,
        };

        public static Map SiegeTutorial = new Map()
        {
            Name = SIEGE_TUTORIAL,
            UmapCode = "TutorialSiege.umap"
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

        public static Dictionary<string, Map> SiegeMaps = new Dictionary<string, Map>
        {
            { CLIFFSIDE_CLASH, SiegeCliffsideClash},
            // { HIGHLANDS, SiegeHighlands},
            { UNCHAINED_FORTRESS, SiegeUnchainedFortress},
        };
    }


}
