using System.Collections.Generic;
using static SingleplayerLauncher.Names.Hero;
using static SingleplayerLauncher.Names.Skin;

namespace SingleplayerLauncher.Model
{
    public class Skin : LoadoutItem
    {
        public string PlayerSkinName { private set; get; }
        public byte[] SpitfireGameIdBytes { private set; get; }

        // private constructor
        Skin() { }

        // static members
        public static Skin OzielDefault = new Skin()
        {
            Id = 1,
            Name = OZIEL_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinAncestor000",
            SpitfireGameIdBytes = new byte[] { 0x63, 0xFF, 0xFF, 0xFF },
        };
        public static Skin BloodRune = new Skin()
        {
            Id = 2,
            Name = BLOOD_RUNE,
            PlayerSkinName = "SpitfireGame.RPlayerSkinAncestor001",
            SpitfireGameIdBytes = new byte[] { 0x4A, 0xFD, 0xFF, 0xFF },
        };
        public static Skin StringTheory = new Skin()
        {
            Id = 3,
            Name = STRING_THEORY,
            PlayerSkinName = "SpitfireGame.RPlayerSkinAncestor003",
            SpitfireGameIdBytes = new byte[] { 0x49, 0xFD, 0xFF, 0xFF },
        };
        public static Skin KnightWalker = new Skin()
        {
            Id = 4,
            Name = KNIGHT_WALKER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinAncestor005",
            SpitfireGameIdBytes = new byte[] { 0x48, 0xFD, 0xFF, 0xFF },
        };
        public static Skin ZoeyDefault = new Skin()
        {
            Id = 5,
            Name = ZOEY_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinApprentice000",
            SpitfireGameIdBytes = new byte[] { 0x63, 0xFF, 0xFF, 0xFF },
        };
        public static Skin SchoolDaze = new Skin()
        {
            Id = 6,
            Name = SCHOOL_DAZE,
            PlayerSkinName = "SpitfireGame.RPlayerSkinApprentice001",
            SpitfireGameIdBytes = new byte[] { 0xD9, 0xFC, 0xFF, 0xFF },
        };
        public static Skin PrettyLittleStitches = new Skin()
        {
            Id = 7,
            Name = PRETTY_LITTLE_STITCHES,
            PlayerSkinName = "SpitfireGame.RPlayerSkinApprentice003",
            SpitfireGameIdBytes = new byte[] { 0xD8, 0xFC, 0xFF, 0xFF },
        };
        public static Skin JurassicJourney = new Skin()
        {
            Id = 8,
            Name = JURASSIC_JOURNEY,
            PlayerSkinName = "SpitfireGame.RPlayerSkinApprentice005",
            SpitfireGameIdBytes = new byte[] { 0xD7, 0xFC, 0xFF, 0xFF },
        };
        public static Skin BionkaDefault = new Skin()
        {
            Id = 9,
            Name = BIONKA_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBallAndChain000",
            SpitfireGameIdBytes = new byte[] { 0x54, 0xDF, 0x00, 0x00 },
        };
        public static Skin LizardQueen = new Skin()
        {
            Id = 10,
            Name = LIZARD_QUEEN,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBallAndChain001",
            SpitfireGameIdBytes = new byte[] { 0x56, 0xDF, 0x00, 0x00 },
        };
        public static Skin Fluffalump = new Skin()
        {
            Id = 11,
            Name = FLUFFALUMP,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBallAndChain003",
            SpitfireGameIdBytes = new byte[] { 0x58, 0xDF, 0x00, 0x00 },
        };
        public static Skin BionkaBunny = new Skin()
        {
            Id = 12,
            Name = BIONKA_BUNNY,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBallAndChain008",
            SpitfireGameIdBytes = new byte[] { 0x5A, 0xDF, 0x00, 0x00 },
        };
        public static Skin BlackpawEnchantedArmor = new Skin()
        {
            Id = 13,
            Name = BLACKPAW_ENCHANTED_ARMOR,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBlackpaw000",
            SpitfireGameIdBytes = new byte[] { 0x19, 0xFE, 0xFF, 0xFF },
        };
        public static Skin PawOfTheDead = new Skin()
        {
            Id = 14,
            Name = PAW_OF_THE_DEAD,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBlackpaw001",
            SpitfireGameIdBytes = new byte[] { 0x18, 0xFE, 0xFF, 0xFF },
        };
        public static Skin BlackpawDefault = new Skin()
        {
            Id = 15,
            Name = BLACKPAW_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBlackpaw002",
            SpitfireGameIdBytes = new byte[] { 0x87, 0xFF, 0xFF, 0xFF },
        };
        public static Skin TutuDloo = new Skin()
        {
            Id = 16,
            Name = TUTU_DLOO,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBlackpaw005",
            SpitfireGameIdBytes = new byte[] { 0x17, 0xFE, 0xFF, 0xFF },
        };
        public static Skin PrideOfThePack = new Skin()
        {
            Id = 17,
            Name = PRIDE_OF_THE_PACK,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBlackpaw007",
            SpitfireGameIdBytes = new byte[] { 0x16, 0xFE, 0xFF, 0xFF },
        };
        public static Skin Runeclaw = new Skin()
        {
            Id = 18,
            Name = RUNECLAW,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBlackpaw009",
            SpitfireGameIdBytes = new byte[] { 0x15, 0xFE, 0xFF, 0xFF },
        };
        public static Skin Blackscale = new Skin()
        {
            Id = 19,
            Name = BLACKSCALE,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBlackpaw012",
            SpitfireGameIdBytes = new byte[] { 0x14, 0xFE, 0xFF, 0xFF },
        };
        public static Skin DragonThrall = new Skin()
        {
            Id = 20,
            Name = DRAGON_THRALL,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBlackpaw014",
            SpitfireGameIdBytes = new byte[] { 0x13, 0xFE, 0xFF, 0xFF },
        };
        public static Skin BloodpsikeDefault = new Skin()
        {
            Id = 21,
            Name = BLOODPSIKE_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBloodspike000",
            SpitfireGameIdBytes = new byte[] { 0x86, 0xFF, 0xFF, 0xFF },
        };
        public static Skin GrizzlyKill = new Skin()
        {
            Id = 22,
            Name = GRIZZLY_KILL,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBloodspike001",
            SpitfireGameIdBytes = new byte[] { 0xD8, 0xFD, 0xFF, 0xFF },
        };
        public static Skin BreakerOfMolds = new Skin()
        {
            Id = 23,
            Name = BREAKER_OF_MOLDS,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBloodspike003",
            SpitfireGameIdBytes = new byte[] { 0xD7, 0xFD, 0xFF, 0xFF },
        };
        public static Skin BloodAppetit = new Skin()
        {
            Id = 24,
            Name = BLOOD_APPETIT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBloodspike005",
            SpitfireGameIdBytes = new byte[] { 0xD6, 0xFD, 0xFF, 0xFF },
        };
        public static Skin GreenGuillotine = new Skin()
        {
            Id = 25,
            Name = GREEN_GUILLOTINE,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBloodspike007",
            SpitfireGameIdBytes = new byte[] { 0xD5, 0xFD, 0xFF, 0xFF },
        };
        public static Skin LaughingToDeath = new Skin()
        {
            Id = 26,
            Name = LAUGHING_TO_DEATH,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBloodspike011",
            SpitfireGameIdBytes = new byte[] { 0xD4, 0xFD, 0xFF, 0xFF },
        };
        public static Skin BrassDefault = new Skin()
        {
            Id = 27,
            Name = BRASS_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBrass000",
            SpitfireGameIdBytes = new byte[] { 0x4E, 0xFF, 0xFF, 0xFF },
        };
        public static Skin GunsGearsNLace = new Skin()
        {
            Id = 28,
            Name = GUNS_GEARS_N_LACE,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBrass001",
            SpitfireGameIdBytes = new byte[] { 0x02, 0xFD, 0xFF, 0xFF },
        };
        public static Skin BombshellBattalion = new Skin()
        {
            Id = 29,
            Name = BOMBSHELL_BATTALION,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBrass004",
            SpitfireGameIdBytes = new byte[] { 0x01, 0xFD, 0xFF, 0xFF },
        };
        public static Skin HogarthEnchantedArmor = new Skin()
        {
            Id = 30,
            Name = HOGARTH_ENCHANTED_ARMOR,
            PlayerSkinName = "SpitfireGame.RPlayerSkinHogarth000",
            SpitfireGameIdBytes = new byte[] { 0x8C, 0xDF, 0x00, 0x00 },
        };
        public static Skin GodOfPlunder = new Skin()
        {
            Id = 31,
            Name = GOD_OF_PLUNDER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinHogarth001",
            SpitfireGameIdBytes = new byte[] { 0x8E, 0xDF, 0x00, 0x00 },
        };
        public static Skin HogarthDefault = new Skin()
        {
            Id = 32,
            Name = HOGARTH_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinHogarth002",
            SpitfireGameIdBytes = new byte[] { 0x90, 0xDF, 0x00, 0x00 },
        };
        public static Skin LumberingJack = new Skin()
        {
            Id = 33,
            Name = LUMBERING_JACK,
            PlayerSkinName = "SpitfireGame.RPlayerSkinHogarth005",
            SpitfireGameIdBytes = new byte[] { 0x92, 0xDF, 0x00, 0x00 },
        };
        public static Skin HogarthDefaultGold = new Skin()
        {
            Id = 34,
            Name = HOGARTH_DEFAULT_GOLD,
            PlayerSkinName = "SpitfireGame.RPlayerSkinHogarth007",
            SpitfireGameIdBytes = new byte[] { 0x94, 0xDF, 0x00, 0x00 },
        };
        public static Skin IceArmor = new Skin()
        {
            Id = 35,
            Name = ICE_ARMOR,
            PlayerSkinName = "SpitfireGame.RPlayerSkinHogarth009",
            SpitfireGameIdBytes = new byte[] { 0x96, 0xDF, 0x00, 0x00 },
        };
        public static Skin ImperialGoldenWarrior = new Skin()
        {
            Id = 36,
            Name = IMPERIAL_GOLDEN_WARRIOR,
            PlayerSkinName = "SpitfireGame.RPlayerSkinHogarth011",
            SpitfireGameIdBytes = new byte[] { 0x98, 0xDF, 0x00, 0x00 },
        };
        public static Skin BeachedBod = new Skin()
        {
            Id = 37,
            Name = BEACHED_BOD,
            PlayerSkinName = "SpitfireGame.RPlayerSkinHogarth013",
            SpitfireGameIdBytes = new byte[] { 0x9A, 0xDF, 0x00, 0x00 },
        };
        public static Skin BlackThane = new Skin()
        {
            Id = 38,
            Name = BLACK_THANE,
            PlayerSkinName = "SpitfireGame.RPlayerSkinHogarth018",
            SpitfireGameIdBytes = new byte[] { 0x9E, 0xDF, 0x00, 0x00 },
        };
        public static Skin TheSchling = new Skin()
        {
            Id = 39,
            Name = THE_SCHLING,
            PlayerSkinName = "SpitfireGame.RPlayerSkinHogarth022",
            SpitfireGameIdBytes = new byte[] { 0xA0, 0xDF, 0x00, 0x00 },
        };
        public static Skin DragonWard = new Skin()
        {
            Id = 40,
            Name = DRAGON_WARD,
            PlayerSkinName = "SpitfireGame.RPlayerSkinHogarth024",
            SpitfireGameIdBytes = new byte[] { 0xA2, 0xDF, 0x00, 0x00 },
        };
        public static Skin DeadeyeDefault = new Skin()
        {
            Id = 41,
            Name = DEADEYE_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinLadyDeadEye000",
            SpitfireGameIdBytes = new byte[] { 0x6B, 0xFF, 0xFF, 0xFF },
        };
        public static Skin PrettyPunk = new Skin()
        {
            Id = 42,
            Name = PRETTY_PUNK,
            PlayerSkinName = "SpitfireGame.RPlayerSkinLadyDeadEye001",
            SpitfireGameIdBytes = new byte[] { 0xE6, 0xFC, 0xFF, 0xFF },
        };
        public static Skin TheGoodTheBadAndTheDeadeye = new Skin()
        {
            Id = 43,
            Name = THE_GOOD_THE_BAD_AND_THE_DEADEYE,
            PlayerSkinName = "SpitfireGame.RPlayerSkinLadyDeadEye003",
            SpitfireGameIdBytes = new byte[] { 0xE5, 0xFC, 0xFF, 0xFF },
        };
        public static Skin MidnightDefault = new Skin()
        {
            Id = 44,
            Name = MIDNIGHT_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinMidnight001",
            SpitfireGameIdBytes = new byte[] { 0x7D, 0xFF, 0xFF, 0xFF },
        };
        public static Skin HiddenTiger = new Skin()
        {
            Id = 45,
            Name = HIDDEN_TIGER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinMidnight000",
            SpitfireGameIdBytes = new byte[] { 0xC2, 0xFD, 0xFF, 0xFF },
        };
        public static Skin MidnightDefaultGold = new Skin()
        {
            Id = 46,
            Name = MIDNIGHT_DEFAULT_GOLD,
            PlayerSkinName = "SpitfireGame.RPlayerSkinMidnight003",
            SpitfireGameIdBytes = new byte[] { 0xC1, 0xFD, 0xFF, 0xFF },
        };
        public static Skin CatBurglar = new Skin()
        {
            Id = 47,
            Name = CAT_BURGLAR,
            PlayerSkinName = "SpitfireGame.RPlayerSkinMidnight007",
            SpitfireGameIdBytes = new byte[] { 0xC0, 0xFD, 0xFF, 0xFF },
        };
        public static Skin ShiverMeWhiskers = new Skin()
        {
            Id = 48,
            Name = SHIVER_ME_WHISKERS,
            PlayerSkinName = "SpitfireGame.RPlayerSkinMidnight009",
            SpitfireGameIdBytes = new byte[] { 0xBF, 0xFD, 0xFF, 0xFF },
        };
        public static Skin WuXingAzureAssassin = new Skin()
        {
            Id = 49,
            Name = WU_XING_AZURE_ASSASSIN,
            PlayerSkinName = "SpitfireGame.RPlayerSkinMidnight011",
            SpitfireGameIdBytes = new byte[] { 0xBE, 0xFD, 0xFF, 0xFF },
        };
        public static Skin DobbinDefault = new Skin()
        {
            Id = 50,
            Name = DOBBIN_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinProspector000",
            SpitfireGameIdBytes = new byte[] { 0x77, 0xFF, 0xFF, 0xFF },
        };
        public static Skin GoldRush = new Skin()
        {
            Id = 51,
            Name = GOLD_RUSH,
            PlayerSkinName = "SpitfireGame.RPlayerSkinProspector001",
            SpitfireGameIdBytes = new byte[] { 0xA6, 0xFD, 0xFF, 0xFF },
        };
        public static Skin DobbinDefaultGold = new Skin()
        {
            Id = 52,
            Name = DOBBIN_DEFAULT_GOLD,
            PlayerSkinName = "SpitfireGame.RPlayerSkinProspector003",
            SpitfireGameIdBytes = new byte[] { 0xA5, 0xFD, 0xFF, 0xFF },
        };
        public static Skin ElCavador = new Skin()
        {
            Id = 53,
            Name = EL_CAVADOR,
            PlayerSkinName = "SpitfireGame.RPlayerSkinProspector005",
            SpitfireGameIdBytes = new byte[] { 0xA4, 0xFD, 0xFF, 0xFF },
        };
        public static Skin SantasLittleHelper = new Skin()
        {
            Id = 54,
            Name = SANTAS_LITTLE_HELPER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinProspector007",
            SpitfireGameIdBytes = new byte[] { 0xA3, 0xFD, 0xFF, 0xFF },
        };
        public static Skin ScurvyRumrudder = new Skin()
        {
            Id = 55,
            Name = SCURVY_RUMRUDDER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinScurvy000",
            SpitfireGameIdBytes = new byte[] { 0xD8, 0xDF, 0x00, 0x00 },
        };
        public static Skin IvyEnchantedArmor = new Skin()
        {
            Id = 56,
            Name = IVY_ENCHANTED_ARMOR,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSheElf000",
            SpitfireGameIdBytes = new byte[] { 0xDA, 0xDF, 0x00, 0x00 },
        };
        public static Skin Valkyrie = new Skin()
        {
            Id = 57,
            Name = VALKYRIE,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSheElf001",
            SpitfireGameIdBytes = new byte[] { 0xDC, 0xDF, 0x00, 0x00 },
        };
        public static Skin IvyDefault = new Skin()
        {
            Id = 58,
            Name = IVY_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSheElf002",
            SpitfireGameIdBytes = new byte[] { 0xDE, 0xDF, 0x00, 0x00 },
        };
        public static Skin FlowerFriend = new Skin()
        {
            Id = 59,
            Name = FLOWER_FRIEND,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSheElf005",
            SpitfireGameIdBytes = new byte[] { 0xE0, 0xDF, 0x00, 0x00 },
        };
        public static Skin IvyDefaultGold = new Skin()
        {
            Id = 60,
            Name = IVY_DEFAULT_GOLD,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSheElf007",
            SpitfireGameIdBytes = new byte[] { 0xE2, 0xDF, 0x00, 0x00 },
        };
        public static Skin ImperialRubyArcher = new Skin()
        {
            Id = 61,
            Name = IMPERIAL_RUBY_ARCHER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSheElf009",
            SpitfireGameIdBytes = new byte[] { 0xE4, 0xDF, 0x00, 0x00 },
        };
        public static Skin WickedWarden = new Skin()
        {
            Id = 62,
            Name = WICKED_WARDEN,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSheElf014",
            SpitfireGameIdBytes = new byte[] { 0xE8, 0xDF, 0x00, 0x00 },
        };
        public static Skin Grovewatch = new Skin()
        {
            Id = 63,
            Name = GROVEWATCH,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSheElf016",
            SpitfireGameIdBytes = new byte[] { 0xEA, 0xDF, 0x00, 0x00 },
        };
        public static Skin DragonTamer = new Skin()
        {
            Id = 64,
            Name = DRAGON_TAMER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSheElf018",
            SpitfireGameIdBytes = new byte[] { 0xEC, 0xDF, 0x00, 0x00 },
        };
        public static Skin SmolderDefault = new Skin()
        {
            Id = 65,
            Name = SMOLDER_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSmolder000",
            SpitfireGameIdBytes = new byte[] { 0xF2, 0xDF, 0x00, 0x00 },
        };
        public static Skin HelterSwelter = new Skin()
        {
            Id = 66,
            Name = HELTER_SWELTER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSmolder001",
            SpitfireGameIdBytes = new byte[] { 0xF4, 0xDF, 0x00, 0x00 },
        };
        public static Skin SmolderDefaultWhiteHair = new Skin()
        {
            Id = 67,
            Name = SMOLDER_DEFAULT_WHITE_HAIR,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSmolder003",
            SpitfireGameIdBytes = new byte[] { 0xF6, 0xDF, 0x00, 0x00 },
        };
        public static Skin Elite = new Skin()
        {
            Id = 68,
            Name = ELITE,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSmolder005",
            SpitfireGameIdBytes = new byte[] { 0xF8, 0xDF, 0x00, 0x00 },
        };
        public static Skin KillAuea = new Skin()
        {
            Id = 69,
            Name = KILL_AUEA,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSmolder006",
            SpitfireGameIdBytes = new byte[] { 0xFA, 0xDF, 0x00, 0x00 },
        };
        public static Skin FireAlarmFemme = new Skin()
        {
            Id = 70,
            Name = FIRE_ALARM_FEMME,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSmolder008",
            SpitfireGameIdBytes = new byte[] { 0xFC, 0xDF, 0x00, 0x00 },
        };
        public static Skin Firestarter = new Skin()
        {
            Id = 71,
            Name = FIRESTARTER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSmolder0010",
            SpitfireGameIdBytes = new byte[] { 0xFE, 0xDF, 0x00, 0x00 },
        };
        public static Skin WuXingDragonMage = new Skin()
        {
            Id = 72,
            Name = WU_XING_DRAGON_MAGE,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSmolder0012",
            SpitfireGameIdBytes = new byte[] { 0x00, 0xE0, 0x00, 0x00 },
        };
        public static Skin ViolentVintage = new Skin()
        {
            Id = 73,
            Name = VIOLENT_VINTAGE,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress000",
            SpitfireGameIdBytes = new byte[] { 0x02, 0xE0, 0x00, 0x00 },
        };
        public static Skin GabriellaEnchantedArmor = new Skin()
        {
            Id = 74,
            Name = GABRIELLA_ENCHANTED_ARMOR,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress002",
            SpitfireGameIdBytes = new byte[] { 0x04, 0xE0, 0x00, 0x00 },
        };
        public static Skin BloodQueen = new Skin()
        {
            Id = 75,
            Name = BLOOD_QUEEN,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress003",
            SpitfireGameIdBytes = new byte[] { 0x06, 0xE0, 0x00, 0x00 },
        };
        public static Skin GabriellaDefault = new Skin()
        {
            Id = 76,
            Name = GABRIELLA_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress004",
            SpitfireGameIdBytes = new byte[] { 0x08, 0xE0, 0x00, 0x00 },
        };
        public static Skin FrightfullyDelightful = new Skin()
        {
            Id = 77,
            Name = FRIGHTFULLY_DELIGHTFUL,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress007",
            SpitfireGameIdBytes = new byte[] { 0x0A, 0xE0, 0x00, 0x00 },
        };
        public static Skin GabriellaDefaultRed = new Skin()
        {
            Id = 78,
            Name = GABRIELLA_DEFAULT_RED,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress009",
            SpitfireGameIdBytes = new byte[] { 0x0C, 0xE0, 0x00, 0x00 },
        };
        public static Skin LifeInPlastic = new Skin()
        {
            Id = 79,
            Name = LIFE_IN_PLASTIC,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress011",
            SpitfireGameIdBytes = new byte[] { 0x0E, 0xE0, 0x00, 0x00 },
        };
        public static Skin ArchmageOfTheOrder = new Skin()
        {
            Id = 80,
            Name = ARCHMAGE_OF_THE_ORDER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress013",
            SpitfireGameIdBytes = new byte[] { 0x10, 0xE0, 0x00, 0x00 },
        };
        public static Skin MistressOfIllusion = new Skin()
        {
            Id = 81,
            Name = MISTRESS_OF_ILLUSION,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress015",
            SpitfireGameIdBytes = new byte[] { 0x12, 0xE0, 0x00, 0x00 },
        };
        public static Skin PromisingProdigy = new Skin()
        {
            Id = 82,
            Name = PROMISING_PRODIGY,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress017",
            SpitfireGameIdBytes = new byte[] { 0x14, 0xE0, 0x00, 0x00 },
        };
        public static Skin IDreamOfGabby = new Skin()
        {
            Id = 83,
            Name = I_DREAM_OF_GABBY,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress019",
            SpitfireGameIdBytes = new byte[] { 0x16, 0xE0, 0x00, 0x00 },
        };
        public static Skin MiracleWorker = new Skin()
        {
            Id = 84,
            Name = MIRACLE_WORKER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress021",
            SpitfireGameIdBytes = new byte[] { 0x18, 0xE0, 0x00, 0x00 },
        };
        public static Skin WinterWitch = new Skin()
        {
            Id = 85,
            Name = WINTER_WITCH,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress023",
            SpitfireGameIdBytes = new byte[] { 0x1A, 0xE0, 0x00, 0x00 },
        };
        public static Skin SkullNinja = new Skin()
        {
            Id = 86,
            Name = SKULL_NINJA,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress024",
            SpitfireGameIdBytes = new byte[] { 0x1C, 0xE0, 0x00, 0x00 },
        };
        public static Skin EvilWays = new Skin()
        {
            Id = 87,
            Name = EVIL_WAYS,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress026",
            SpitfireGameIdBytes = new byte[] { 0x1E, 0xE0, 0x00, 0x00 },
        };
        public static Skin DragonCharmer = new Skin()
        {
            Id = 88,
            Name = DRAGON_CHARMER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSorceress028",
            SpitfireGameIdBytes = new byte[] { 0x20, 0xE0, 0x00, 0x00 },
        };
        public static Skin FirstEyeBlind = new Skin()
        {
            Id = 89,
            Name = FIRST_EYE_BLIND,
            PlayerSkinName = "SpitfireGame.RPlayerSkinStinkeye000",
            SpitfireGameIdBytes = new byte[] { 0x68, 0xFF, 0xFF, 0xFF },
        };
        public static Skin StinkeyeDefault = new Skin()
        {
            Id = 90,
            Name = STINKEYE_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinStinkeye002",
            SpitfireGameIdBytes = new byte[] { 0xF8, 0xFC, 0xFF, 0xFF },
        };
        public static Skin StinkeyeDefaultAlt = new Skin()
        {
            Id = 91,
            Name = STINKEYE_DEFAULT_ALT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinStinkeye003",
            SpitfireGameIdBytes = new byte[] { 0xF7, 0xFC, 0xFF, 0xFF },
        };
        public static Skin EnfantTerrible = new Skin()
        {
            Id = 92,
            Name = ENFANT_TERRIBLE,
            PlayerSkinName = "SpitfireGame.RPlayerSkinStinkeye008",
            SpitfireGameIdBytes = new byte[] { 0xF6, 0xFC, 0xFF, 0xFF },
        };
        public static Skin FloatyFun = new Skin()
        {
            Id = 93,
            Name = FLOATY_FUN,
            PlayerSkinName = "SpitfireGame.RPlayerSkinStinkeye010",
            SpitfireGameIdBytes = new byte[] { 0xF5, 0xFC, 0xFF, 0xFF },
        };
        public static Skin TemperDefault = new Skin()
        {
            Id = 94,
            Name = TEMPER_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinTemper000",
            SpitfireGameIdBytes = new byte[] { 0x60, 0xFF, 0xFF, 0xFF },
        };
        public static Skin ForgedFury = new Skin()
        {
            Id = 95,
            Name = FORGED_FURY,
            PlayerSkinName = "SpitfireGame.RPlayerSkinTemper001",
            SpitfireGameIdBytes = new byte[] { 0xD6, 0xFC, 0xFF, 0xFF },
        };
        public static Skin PrizedCow = new Skin()
        {
            Id = 96,
            Name = PRIZED_COW,
            PlayerSkinName = "SpitfireGame.RPlayerSkinTemper003",
            SpitfireGameIdBytes = new byte[] { 0xD5, 0xFC, 0xFF, 0xFF },
        };
        public static Skin CygnusDefault = new Skin()
        {
            Id = 97,
            Name = CYGNUS_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinTheMaster000",
            SpitfireGameIdBytes = new byte[] { 0x68, 0xFF, 0xFF, 0xFF },
        };
        public static Skin Adventurer = new Skin()
        {
            Id = 98,
            Name = ADVENTURER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinTheMaster001",
            SpitfireGameIdBytes = new byte[] { 0x23, 0xFD, 0xFF, 0xFF },
        };
        public static Skin CygnusDefaultRed = new Skin()
        {
            Id = 99,
            Name = CYGNUS_DEFAULT_RED,
            PlayerSkinName = "SpitfireGame.RPlayerSkinTheMaster003",
            SpitfireGameIdBytes = new byte[] { 0x22, 0xFD, 0xFF, 0xFF },
        };
        /* Has no model, it doesn't work
        public static Skin CygnusUnknown = new Skin()
        {
        	Id = 100,
            Name = CYGNUS_UNKNOWN,
            CodeName = "RPlayerSkinTheMaster005",
            Id = new byte[] { 0x21, 0xFD, 0xFF, 0xFF },
        };
        */
        public static Skin OldCodger = new Skin()
        {
            Id = 101,
            Name = OLD_CODGER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinTheMaster007",
            SpitfireGameIdBytes = new byte[] { 0x20, 0xFD, 0xFF, 0xFF },
        };
        public static Skin RoadMaster = new Skin()
        {
            Id = 102,
            Name = ROAD_MASTER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinTheMaster010",
            SpitfireGameIdBytes = new byte[] { 0x1F, 0xFD, 0xFF, 0xFF },
        };
        public static Skin TundraDefault = new Skin()
        {
            Id = 103,
            Name = TUNDRA_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinTundra000",
            SpitfireGameIdBytes = new byte[] { 0x71, 0xFF, 0xFF, 0xFF },
        };
        public static Skin WarChief = new Skin()
        {
            Id = 104,
            Name = WAR_CHIEF,
            PlayerSkinName = "SpitfireGame.RPlayerSkinTundra001",
            SpitfireGameIdBytes = new byte[] { 0x6E, 0xFD, 0xFF, 0xFF },
        };
        public static Skin BigLebearski = new Skin()
        {
            Id = 105,
            Name = BIG_LEBEARSKI,
            PlayerSkinName = "SpitfireGame.RPlayerSkinTundra004",
            SpitfireGameIdBytes = new byte[] { 0x6D, 0xFD, 0xFF, 0xFF },
        };
        public static Skin KingOfArctos = new Skin()
        {
            Id = 106,
            Name = KING_OF_ARCTOS,
            PlayerSkinName = "SpitfireGame.RPlayerSkinTundra006",
            SpitfireGameIdBytes = new byte[] { 0x6C, 0xFD, 0xFF, 0xFF },
        };
        public static Skin ImperialGoldenMage = new Skin()
        {
            Id = 107,
            Name = IMPERIAL_GOLDEN_MAGE,
            PlayerSkinName = "SpitfireGame.RPlayerSkinTundra008",
            SpitfireGameIdBytes = new byte[] { 0x6B, 0xFD, 0xFF, 0xFF },
        };
        public static Skin LuckyTunic = new Skin()
        {
            Id = 108,
            Name = LUCKY_TUNIC,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage000",
            SpitfireGameIdBytes = new byte[] { 0x4A, 0xE0, 0x00, 0x00 },
        };
        public static Skin MaximillianEnchantedArmor = new Skin()
        {
            Id = 109,
            Name = MAXIMILLIAN_ENCHANTED_ARMOR,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage003",
            SpitfireGameIdBytes = new byte[] { 0x4C, 0xE0, 0x00, 0x00 },
        };
        public static Skin KnightsWatch = new Skin()
        {
            Id = 110,
            Name = KNIGHTS_WATCH,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage004",
            SpitfireGameIdBytes = new byte[] { 0x4E, 0xE0, 0x00, 0x00 },
        };
        public static Skin MaximillianDefault = new Skin()
        {
            Id = 111,
            Name = MAXIMILLIAN_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage005",
            SpitfireGameIdBytes = new byte[] { 0x50, 0xE0, 0x00, 0x00 },
        };
        public static Skin OrcSlayer = new Skin()
        {
            Id = 112,
            Name = ORC_SLAYER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage006",
            SpitfireGameIdBytes = new byte[] { 0x52, 0xE0, 0x00, 0x00 },
        };
        public static Skin CardboardSamurai = new Skin()
        {
            Id = 113,
            Name = CARDBOARD_SAMURAI,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage007",
            SpitfireGameIdBytes = new byte[] { 0x54, 0xE0, 0x00, 0x00 },
        };
        public static Skin ScaredCrow = new Skin()
        {
            Id = 114,
            Name = SCARED_CROW,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage012",
            SpitfireGameIdBytes = new byte[] { 0x56, 0xE0, 0x00, 0x00 },
        };
        public static Skin LionHeart = new Skin()
        {
            Id = 115,
            Name = LION_HEART,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage014",
            SpitfireGameIdBytes = new byte[] { 0x58, 0xE0, 0x00, 0x00 },
        };
        public static Skin RobinHood = new Skin()
        {
            Id = 116,
            Name = ROBIN_HOOD,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage016",
            SpitfireGameIdBytes = new byte[] { 0x5A, 0xE0, 0x00, 0x00 },
        };
        public static Skin Paximillian = new Skin()
        {
            Id = 117,
            Name = PAXIMILLIAN,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage018",
            SpitfireGameIdBytes = new byte[] { 0x5C, 0xE0, 0x00, 0x00 },
        };
        public static Skin MaximillianLegendaryDefault = new Skin()
        {
            Id = 118,
            Name = MAXIMILLIAN_LEGENDARY_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage020",
            SpitfireGameIdBytes = new byte[] { 0x5E, 0xE0, 0x00, 0x00 },
        };
        public static Skin ChampionOfTheOrder = new Skin()
        {
            Id = 119,
            Name = CHAMPION_OF_THE_ORDER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage022",
            SpitfireGameIdBytes = new byte[] { 0x60, 0xE0, 0x00, 0x00 },
        };
        public static Skin JamezRipher = new Skin()
        {
            Id = 120,
            Name = JAMEZ_RIPHER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage025",
            SpitfireGameIdBytes = new byte[] { 0x62, 0xE0, 0x00, 0x00 },
        };
        public static Skin WinterWarrior = new Skin()
        {
            Id = 121,
            Name = WINTER_WARRIOR,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage027",
            SpitfireGameIdBytes = new byte[] { 0x64, 0xE0, 0x00, 0x00 },
        };
        public static Skin Boomstick = new Skin()
        {
            Id = 122,
            Name = BOOMSTICK,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage029",
            SpitfireGameIdBytes = new byte[] { 0x66, 0xE0, 0x00, 0x00 },
        };
        public static Skin Backdraft = new Skin()
        {
            Id = 123,
            Name = BACKDRAFT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage030",
            SpitfireGameIdBytes = new byte[] { 0x68, 0xE0, 0x00, 0x00 },
        };
        public static Skin DragonSlayer = new Skin()
        {
            Id = 124,
            Name = DRAGON_SLAYER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage032",
            SpitfireGameIdBytes = new byte[] { 0x6A, 0xE0, 0x00, 0x00 },
        };
        public static Skin SummerOfStunning = new Skin()
        {
            Id = 125,
            Name = SUMMER_OF_STUNNING,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage034",
            SpitfireGameIdBytes = new byte[] { 0x6C, 0xE0, 0x00, 0x00 },
        };
        public static Skin RedScarf = new Skin()
        {
            Id = 126,
            Name = RED_SCARF,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage036",
            SpitfireGameIdBytes = new byte[] { 0x6E, 0xE0, 0x00, 0x00 },
        };
        public static Skin YellowScarf = new Skin()
        {
            Id = 127,
            Name = YELLOW_SCARF,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage038",
            SpitfireGameIdBytes = new byte[] { 0x70, 0xE0, 0x00, 0x00 },
        };
        public static Skin BlueScarf = new Skin()
        {
            Id = 128,
            Name = BLUE_SCARF,
            PlayerSkinName = "SpitfireGame.RPlayerSkinWarmage040",
            SpitfireGameIdBytes = new byte[] { 0x72, 0xE0, 0x00, 0x00 },
        };
        public static Skin YiLinDefault = new Skin()
        {
            Id = 129,
            Name = YI_LIN_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinYiLin000",
            SpitfireGameIdBytes = new byte[] { 0x77, 0xFF, 0xFF, 0xFF },
        };
        public static Skin SentinelOfTheOrder = new Skin()
        {
            Id = 130,
            Name = SENTINEL_OF_THE_ORDER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinYiLin001",
            SpitfireGameIdBytes = new byte[] { 0xE0, 0xFD, 0xFF, 0xFF },
        };
        public static Skin SlayingInTheRain = new Skin()
        {
            Id = 131,
            Name = SLAYING_IN_THE_RAIN,
            PlayerSkinName = "SpitfireGame.RPlayerSkinYiLin004",
            SpitfireGameIdBytes = new byte[] { 0xDF, 0xFD, 0xFF, 0xFF },
        };
        public static Skin YuleLin = new Skin()
        {
            Id = 132,
            Name = YULE_LIN,
            PlayerSkinName = "SpitfireGame.RPlayerSkinYiLin006",
            SpitfireGameIdBytes = new byte[] { 0xDE, 0xFD, 0xFF, 0xFF },
        };


        // SIR WINSTON
        public static Skin DarkPaladin = new Skin()
        {
            Id = 133,
            Name = DARK_PALADIN,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSirWinston000",
            SpitfireGameIdBytes = new byte[] { 0xEE, 0xDF, 0x00, 0x00 },
        };
        public static Skin WinstonDefault = new Skin()
        {
            Id = 134,
            Name = WINSTON_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinSirWinston002",
            SpitfireGameIdBytes = new byte[] { 0xF0, 0xDF, 0x00, 0x00 },
        };


        // CHANG'E
        public static Skin ChangEDefault = new Skin()
        {
            Id = 135,
            Name = CHANG_E_DEFAULT,
            PlayerSkinName = "SpitfireGame.RPlayerSkinChangE000",
            SpitfireGameIdBytes = new byte[] { 0x80, 0xDF, 0x00, 0x00 },
        };


        // CHICKEN
        public static Skin Chicken = new Skin()
        {
            Id = 136,
            Name = CHICKEN,
            PlayerSkinName = "SpitfireGame.RPlayerSkinPolymorph000",
            SpitfireGameIdBytes = new byte[] { 0xC8, 0xDF, 0x00, 0x00 },
        };
        public static Skin ChickenWithTrainers = new Skin()
        {
            Id = 137,
            Name = CHICKEN_WITH_TRAINERS,
            PlayerSkinName = "SpitfireGame.RPlayerSkinPolymorph001",
            SpitfireGameIdBytes = new byte[] { 0xCA, 0xDF, 0x00, 0x00 },
        };


        // MERCENARIES
        public static Skin PrideAssassin = new Skin()
        {
            Id = 138,
            Name = PRIDE_ASSASSIN,
            PlayerSkinName = "SpitfireGame.RPlayerSkinPrideAssassin000",
            SpitfireGameIdBytes = new byte[] { 0xCC, 0xDF, 0x00, 0x00 },
        };
        public static Skin BouncerBear = new Skin()
        {
            Id = 139,
            Name = BOUNCER_BEAR,
            PlayerSkinName = "SpitfireGame.RPlayerSkinBouncerBear000",
            SpitfireGameIdBytes = new byte[] { 0x78, 0xDF, 0x00, 0x00 },
        };
        public static Skin ImageHuman = new Skin()
        {
            Id = 140,
            Name = IMAGE_HUMAN,
            PlayerSkinName = "SpitfireGame.RPlayerSkiniMage000",
            SpitfireGameIdBytes = new byte[] { 0xA6, 0xDF, 0x00, 0x00 },
        };
        public static Skin ImageArcane = new Skin()
        {
            Id = 141,
            Name = IMAGE_ARCANE,
            PlayerSkinName = "SpitfireGame.RPlayerSkiniMage001",
            SpitfireGameIdBytes = new byte[] { 0xA8, 0xDF, 0x00, 0x00 },
        };
        public static Skin ImageLightning = new Skin()
        {
            Id = 142,
            Name = IMAGE_LIGHTNING,
            PlayerSkinName = "SpitfireGame.RPlayerSkiniMage002",
            SpitfireGameIdBytes = new byte[] { 0xAA, 0xDF, 0x00, 0x00 },
        };
        public static Skin ImageIce = new Skin()
        {
            Id = 143,
            Name = IMAGE_ICE,
            PlayerSkinName = "SpitfireGame.RPlayerSkiniMage003",
            SpitfireGameIdBytes = new byte[] { 0xAC, 0xDF, 0x00, 0x00 },
        };
        public static Skin ImageFire = new Skin()
        {
            Id = 144,
            Name = IMAGE_FIRE,
            PlayerSkinName = "SpitfireGame.RPlayerSkiniMage004",
            SpitfireGameIdBytes = new byte[] { 0xAE, 0xDF, 0x00, 0x00 },
        };
        public static Skin ChaoticKobold = new Skin()
        {
            Id = 145,
            Name = CHAOTIC_KOBOLD,
            PlayerSkinName = "SpitfireGame.RPlayerSkinChaoticKobold000",
            SpitfireGameIdBytes = new byte[] { 0x82, 0xDF, 0x00, 0x00 },
        };
        public static Skin DwarfPriest = new Skin()
        {
            Id = 146,
            Name = DWARF_PRIEST,
            PlayerSkinName = "SpitfireGame.RPlayerSkinDwarfPriest000",
            SpitfireGameIdBytes = new byte[] { 0x88, 0xDF, 0x00, 0x00 },
        };
        public static Skin GnollBreeder = new Skin()
        {
            Id = 147,
            Name = GNOLL_BREEDER,
            PlayerSkinName = "SpitfireGame.RPlayerSkinGnollBreeder000",
            SpitfireGameIdBytes = new byte[] { 0x8A, 0xDF, 0x00, 0x00 },
        };

        public static Skin[] OzielSkins = new Skin[] { OzielDefault, BloodRune, StringTheory, KnightWalker };
        public static Skin[] ZoeySkins = new Skin[] { ZoeyDefault, SchoolDaze, PrettyLittleStitches, JurassicJourney };
        public static Skin[] BionkaSkins = new Skin[] { BionkaDefault, LizardQueen, Fluffalump, BionkaBunny };
        public static Skin[] BlackpawSkins = new Skin[] { BlackpawDefault, BlackpawEnchantedArmor, PawOfTheDead, TutuDloo, PrideOfThePack, Runeclaw, Blackscale, DragonThrall };
        public static Skin[] BloodspikeSkins = new Skin[] { BloodpsikeDefault, GrizzlyKill, BreakerOfMolds, BloodAppetit, GreenGuillotine, LaughingToDeath };
        public static Skin[] BrassSkins = new Skin[] { BrassDefault, GunsGearsNLace, BombshellBattalion };
        public static Skin[] HogarthSkins = new Skin[] { HogarthDefault, HogarthEnchantedArmor, GodOfPlunder, LumberingJack, HogarthDefaultGold, IceArmor, ImperialGoldenWarrior, BeachedBod, BlackThane, TheSchling, DragonWard };
        public static Skin[] DeadeyeSkins = new Skin[] { DeadeyeDefault, PrettyPunk, TheGoodTheBadAndTheDeadeye, };
        public static Skin[] MidnightSkins = new Skin[] { MidnightDefault, HiddenTiger, MidnightDefaultGold, CatBurglar, ShiverMeWhiskers, WuXingAzureAssassin, };
        public static Skin[] DobbinSkins = new Skin[] { DobbinDefault, GoldRush, DobbinDefaultGold, ElCavador, SantasLittleHelper, };
        public static Skin[] IvySkins = new Skin[] { IvyEnchantedArmor, IvyDefault, Valkyrie, FlowerFriend, IvyDefaultGold, ImperialRubyArcher, WickedWarden, Grovewatch, DragonTamer, };
        public static Skin[] SmolderSkins = new Skin[] { SmolderDefault, HelterSwelter, SmolderDefaultWhiteHair, Elite, KillAuea, FireAlarmFemme, Firestarter, WuXingDragonMage, };
        public static Skin[] GabriellaSkins = new Skin[] { GabriellaDefault, ViolentVintage, GabriellaEnchantedArmor, BloodQueen, FrightfullyDelightful, GabriellaDefaultRed, LifeInPlastic, ArchmageOfTheOrder, MistressOfIllusion, PromisingProdigy, IDreamOfGabby, MiracleWorker, WinterWitch, SkullNinja, EvilWays, DragonCharmer, };
        public static Skin[] StinkeyeSkins = new Skin[] { StinkeyeDefault, FirstEyeBlind, StinkeyeDefaultAlt, EnfantTerrible, FloatyFun, };
        public static Skin[] TemperSkins = new Skin[] { TemperDefault, ForgedFury, PrizedCow };
        public static Skin[] CygnusSkins = new Skin[] { CygnusDefault, Adventurer, CygnusDefaultRed, OldCodger, RoadMaster, };
        public static Skin[] TundraSkins = new Skin[] { TundraDefault, WarChief, BigLebearski, KingOfArctos, ImperialGoldenMage, };
        public static Skin[] MaximilianSkins = new Skin[] { MaximillianDefault, LuckyTunic, MaximillianEnchantedArmor, KnightsWatch, OrcSlayer, CardboardSamurai, ScaredCrow, LionHeart, RobinHood, Paximillian, MaximillianLegendaryDefault, ChampionOfTheOrder, JamezRipher, WinterWarrior, Boomstick, Backdraft, DragonSlayer, SummerOfStunning, RedScarf, YellowScarf, BlueScarf, };
        public static Skin[] YiLinSkins = new Skin[] { YiLinDefault, SentinelOfTheOrder, SlayingInTheRain, YuleLin, };
        public static Skin[] OtherSkins = new Skin[] { DarkPaladin, WinstonDefault, ChangEDefault, Chicken, ChickenWithTrainers, };
        public static Skin[] MercenarySkins = new Skin[] { PrideAssassin, BouncerBear, ImageHuman, ImageArcane, ImageLightning, ImageIce, ImageFire, ChaoticKobold, DwarfPriest, GnollBreeder, ScurvyRumrudder, };

        public static Dictionary<string, Skin[]> SkinsByHeroName = new Dictionary<string, Skin[]>
        {
            { OZIEL , OzielSkins },
            { ZOEY , ZoeySkins },
            { BIONKA , BionkaSkins },
            { BLACKPAW , BlackpawSkins },
            { BLOODSPIKE , BloodspikeSkins },
            { BRASS , BrassSkins },
            { HOGARTH , HogarthSkins },
            { DEADEYE , DeadeyeSkins },
            { MIDNIGHT , MidnightSkins },
            { DOBBIN , DobbinSkins },
            { IVY , IvySkins },
            { SMOLDER , SmolderSkins },
            { GABRIELLA , GabriellaSkins },
            { STINKEYE , StinkeyeSkins },
            { TEMPER , TemperSkins },
            { CYGNUS , CygnusSkins },
            { TUNDRA , TundraSkins },
            { MAXIMILIAN , MaximilianSkins },
        };

        public static Dictionary<string, Skin> Skins = new Dictionary<string, Skin>
        {
            { OZIEL_DEFAULT, OzielDefault },
            { BLOOD_RUNE, BloodRune },
            { STRING_THEORY, StringTheory },
            { KNIGHT_WALKER, KnightWalker },
            { ZOEY_DEFAULT, ZoeyDefault },
            { SCHOOL_DAZE, SchoolDaze },
            { PRETTY_LITTLE_STITCHES, PrettyLittleStitches },
            { JURASSIC_JOURNEY, JurassicJourney },
            { BIONKA_DEFAULT, BionkaDefault },
            { LIZARD_QUEEN, LizardQueen },
            { FLUFFALUMP, Fluffalump },
            { BIONKA_BUNNY, BionkaBunny },
            { BLACKPAW_ENCHANTED_ARMOR, BlackpawEnchantedArmor },
            { PAW_OF_THE_DEAD, PawOfTheDead },
            { BLACKPAW_DEFAULT, BlackpawDefault },
            { TUTU_DLOO, TutuDloo },
            { PRIDE_OF_THE_PACK, PrideOfThePack },
            { RUNECLAW, Runeclaw },
            { BLACKSCALE, Blackscale },
            { DRAGON_THRALL, DragonThrall },
            { BLOODPSIKE_DEFAULT, BloodpsikeDefault },
            { GRIZZLY_KILL, GrizzlyKill },
            { BREAKER_OF_MOLDS, BreakerOfMolds },
            { BLOOD_APPETIT, BloodAppetit },
            { GREEN_GUILLOTINE, GreenGuillotine },
            { LAUGHING_TO_DEATH, LaughingToDeath },
            { BRASS_DEFAULT, BrassDefault },
            { GUNS_GEARS_N_LACE, GunsGearsNLace },
            { BOMBSHELL_BATTALION, BombshellBattalion },
            { HOGARTH_ENCHANTED_ARMOR, HogarthEnchantedArmor },
            { GOD_OF_PLUNDER, GodOfPlunder },
            { HOGARTH_DEFAULT, HogarthDefault },
            { LUMBERING_JACK, LumberingJack },
            { HOGARTH_DEFAULT_GOLD, HogarthDefaultGold },
            { ICE_ARMOR, IceArmor },
            { IMPERIAL_GOLDEN_WARRIOR, ImperialGoldenWarrior },
            { BEACHED_BOD, BeachedBod },
            { BLACK_THANE, BlackThane },
            { THE_SCHLING, TheSchling },
            { DRAGON_WARD, DragonWard },
            { DEADEYE_DEFAULT, DeadeyeDefault },
            { PRETTY_PUNK, PrettyPunk },
            { THE_GOOD_THE_BAD_AND_THE_DEADEYE, TheGoodTheBadAndTheDeadeye },
            { HIDDEN_TIGER, HiddenTiger },
            { MIDNIGHT_DEFAULT, MidnightDefault },
            { MIDNIGHT_DEFAULT_GOLD, MidnightDefaultGold },
            { CAT_BURGLAR, CatBurglar },
            { SHIVER_ME_WHISKERS, ShiverMeWhiskers },
            { WU_XING_AZURE_ASSASSIN, WuXingAzureAssassin },
            { DOBBIN_DEFAULT, DobbinDefault },
            { GOLD_RUSH, GoldRush },
            { DOBBIN_DEFAULT_GOLD, DobbinDefaultGold },
            { EL_CAVADOR, ElCavador },
            { SANTAS_LITTLE_HELPER, SantasLittleHelper },
            { SCURVY_RUMRUDDER, ScurvyRumrudder },
            { IVY_ENCHANTED_ARMOR, IvyEnchantedArmor },
            { VALKYRIE, Valkyrie },
            { IVY_DEFAULT, IvyDefault },
            { FLOWER_FRIEND, FlowerFriend },
            { IVY_DEFAULT_GOLD, IvyDefaultGold },
            { IMPERIAL_RUBY_ARCHER, ImperialRubyArcher },
            { WICKED_WARDEN, WickedWarden },
            { GROVEWATCH, Grovewatch },
            { DRAGON_TAMER, DragonTamer },
            { SMOLDER_DEFAULT, SmolderDefault },
            { HELTER_SWELTER, HelterSwelter },
            { SMOLDER_DEFAULT_WHITE_HAIR, SmolderDefaultWhiteHair },
            { ELITE, Elite },
            { KILL_AUEA, KillAuea },
            { FIRE_ALARM_FEMME, FireAlarmFemme },
            { FIRESTARTER, Firestarter },
            { WU_XING_DRAGON_MAGE, WuXingDragonMage },
            { VIOLENT_VINTAGE, ViolentVintage },
            { GABRIELLA_ENCHANTED_ARMOR, GabriellaEnchantedArmor },
            { BLOOD_QUEEN, BloodQueen },
            { GABRIELLA_DEFAULT, GabriellaDefault },
            { FRIGHTFULLY_DELIGHTFUL, FrightfullyDelightful },
            { GABRIELLA_DEFAULT_RED, GabriellaDefaultRed },
            { LIFE_IN_PLASTIC, LifeInPlastic },
            { ARCHMAGE_OF_THE_ORDER, ArchmageOfTheOrder },
            { MISTRESS_OF_ILLUSION, MistressOfIllusion },
            { PROMISING_PRODIGY, PromisingProdigy },
            { I_DREAM_OF_GABBY, IDreamOfGabby },
            { MIRACLE_WORKER, MiracleWorker },
            { WINTER_WITCH, WinterWitch },
            { SKULL_NINJA, SkullNinja },
            { EVIL_WAYS, EvilWays },
            { DRAGON_CHARMER, DragonCharmer },
            { FIRST_EYE_BLIND, FirstEyeBlind },
            { STINKEYE_DEFAULT, StinkeyeDefault },
            { STINKEYE_DEFAULT_ALT, StinkeyeDefaultAlt },
            { ENFANT_TERRIBLE, EnfantTerrible },
            { FLOATY_FUN, FloatyFun },
            { TEMPER_DEFAULT, TemperDefault },
            { FORGED_FURY, ForgedFury },
            { PRIZED_COW, PrizedCow },
            { CYGNUS_DEFAULT, CygnusDefault },
            { ADVENTURER, Adventurer },
            { CYGNUS_DEFAULT_RED, CygnusDefaultRed },
            { OLD_CODGER, OldCodger },
            { ROAD_MASTER, RoadMaster },
            { TUNDRA_DEFAULT, TundraDefault },
            { WAR_CHIEF, WarChief },
            { BIG_LEBEARSKI, BigLebearski },
            { KING_OF_ARCTOS, KingOfArctos },
            { IMPERIAL_GOLDEN_MAGE, ImperialGoldenMage },
            { LUCKY_TUNIC, LuckyTunic },
            { MAXIMILLIAN_ENCHANTED_ARMOR, MaximillianEnchantedArmor },
            { KNIGHTS_WATCH, KnightsWatch },
            { MAXIMILLIAN_DEFAULT, MaximillianDefault },
            { ORC_SLAYER, OrcSlayer },
            { CARDBOARD_SAMURAI, CardboardSamurai },
            { SCARED_CROW, ScaredCrow },
            { LION_HEART, LionHeart },
            { ROBIN_HOOD, RobinHood },
            { PAXIMILLIAN, Paximillian },
            { MAXIMILLIAN_LEGENDARY_DEFAULT, MaximillianLegendaryDefault },
            { CHAMPION_OF_THE_ORDER, ChampionOfTheOrder },
            { JAMEZ_RIPHER, JamezRipher },
            { WINTER_WARRIOR, WinterWarrior },
            { BOOMSTICK, Boomstick },
            { BACKDRAFT, Backdraft },
            { DRAGON_SLAYER, DragonSlayer },
            { SUMMER_OF_STUNNING, SummerOfStunning },
            { RED_SCARF, RedScarf },
            { YELLOW_SCARF, YellowScarf },
            { BLUE_SCARF, BlueScarf },
            { YI_LIN_DEFAULT, YiLinDefault },
            { SENTINEL_OF_THE_ORDER, SentinelOfTheOrder },
            { SLAYING_IN_THE_RAIN, SlayingInTheRain },
            { YULE_LIN, YuleLin },
            { DARK_PALADIN, DarkPaladin },
            { WINSTON_DEFAULT, WinstonDefault },
            { CHANG_E_DEFAULT, ChangEDefault },
            { CHICKEN, Chicken },
            { CHICKEN_WITH_TRAINERS, ChickenWithTrainers },
            { PRIDE_ASSASSIN, PrideAssassin },
            { BOUNCER_BEAR, BouncerBear },
            { IMAGE_HUMAN, ImageHuman },
            { IMAGE_ARCANE, ImageArcane },
            { IMAGE_LIGHTNING, ImageLightning },
            { IMAGE_ICE, ImageIce },
            { IMAGE_FIRE, ImageFire },
            { CHAOTIC_KOBOLD, ChaoticKobold },
            { DWARF_PRIEST, DwarfPriest },
            { GNOLL_BREEDER, GnollBreeder },
        };



        public static Dictionary<int, Skin> SkinsById = new Dictionary<int, Skin>
        {
            { OzielDefault.Id, OzielDefault },
            { BloodRune.Id, BloodRune },
            { StringTheory.Id, StringTheory },
            { KnightWalker.Id, KnightWalker },
            { ZoeyDefault.Id, ZoeyDefault },
            { SchoolDaze.Id, SchoolDaze },
            { PrettyLittleStitches.Id, PrettyLittleStitches },
            { JurassicJourney.Id, JurassicJourney },
            { BionkaDefault.Id, BionkaDefault },
            { LizardQueen.Id, LizardQueen },
            { Fluffalump.Id, Fluffalump },
            { BionkaBunny.Id, BionkaBunny },
            { BlackpawEnchantedArmor.Id, BlackpawEnchantedArmor },
            { PawOfTheDead.Id, PawOfTheDead },
            { BlackpawDefault.Id, BlackpawDefault },
            { TutuDloo.Id, TutuDloo },
            { PrideOfThePack.Id, PrideOfThePack },
            { Runeclaw.Id, Runeclaw },
            { Blackscale.Id, Blackscale },
            { DragonThrall.Id, DragonThrall },
            { BloodpsikeDefault.Id, BloodpsikeDefault },
            { GrizzlyKill.Id, GrizzlyKill },
            { BreakerOfMolds.Id, BreakerOfMolds },
            { BloodAppetit.Id, BloodAppetit },
            { GreenGuillotine.Id, GreenGuillotine },
            { LaughingToDeath.Id, LaughingToDeath },
            { BrassDefault.Id, BrassDefault },
            { GunsGearsNLace.Id, GunsGearsNLace },
            { BombshellBattalion.Id, BombshellBattalion },
            { HogarthEnchantedArmor.Id, HogarthEnchantedArmor },
            { GodOfPlunder.Id, GodOfPlunder },
            { HogarthDefault.Id, HogarthDefault },
            { LumberingJack.Id, LumberingJack },
            { HogarthDefaultGold.Id, HogarthDefaultGold },
            { IceArmor.Id, IceArmor },
            { ImperialGoldenWarrior.Id, ImperialGoldenWarrior },
            { BeachedBod.Id, BeachedBod },
            { BlackThane.Id, BlackThane },
            { TheSchling.Id, TheSchling },
            { DragonWard.Id, DragonWard },
            { DeadeyeDefault.Id, DeadeyeDefault },
            { PrettyPunk.Id, PrettyPunk },
            { TheGoodTheBadAndTheDeadeye.Id, TheGoodTheBadAndTheDeadeye },
            { HiddenTiger.Id, HiddenTiger },
            { MidnightDefault.Id, MidnightDefault },
            { MidnightDefaultGold.Id, MidnightDefaultGold },
            { CatBurglar.Id, CatBurglar },
            { ShiverMeWhiskers.Id, ShiverMeWhiskers },
            { WuXingAzureAssassin.Id, WuXingAzureAssassin },
            { DobbinDefault.Id, DobbinDefault },
            { GoldRush.Id, GoldRush },
            { DobbinDefaultGold.Id, DobbinDefaultGold },
            { ElCavador.Id, ElCavador },
            { SantasLittleHelper.Id, SantasLittleHelper },
            { ScurvyRumrudder.Id, ScurvyRumrudder },
            { IvyEnchantedArmor.Id, IvyEnchantedArmor },
            { Valkyrie.Id, Valkyrie },
            { IvyDefault.Id, IvyDefault },
            { FlowerFriend.Id, FlowerFriend },
            { IvyDefaultGold.Id, IvyDefaultGold },
            { ImperialRubyArcher.Id, ImperialRubyArcher },
            { WickedWarden.Id, WickedWarden },
            { Grovewatch.Id, Grovewatch },
            { DragonTamer.Id, DragonTamer },
            { SmolderDefault.Id, SmolderDefault },
            { HelterSwelter.Id, HelterSwelter },
            { SmolderDefaultWhiteHair.Id, SmolderDefaultWhiteHair },
            { Elite.Id, Elite },
            { KillAuea.Id, KillAuea },
            { FireAlarmFemme.Id, FireAlarmFemme },
            { Firestarter.Id, Firestarter },
            { WuXingDragonMage.Id, WuXingDragonMage },
            { ViolentVintage.Id, ViolentVintage },
            { GabriellaEnchantedArmor.Id, GabriellaEnchantedArmor },
            { BloodQueen.Id, BloodQueen },
            { GabriellaDefault.Id, GabriellaDefault },
            { FrightfullyDelightful.Id, FrightfullyDelightful },
            { GabriellaDefaultRed.Id, GabriellaDefaultRed },
            { LifeInPlastic.Id, LifeInPlastic },
            { ArchmageOfTheOrder.Id, ArchmageOfTheOrder },
            { MistressOfIllusion.Id, MistressOfIllusion },
            { PromisingProdigy.Id, PromisingProdigy },
            { IDreamOfGabby.Id, IDreamOfGabby },
            { MiracleWorker.Id, MiracleWorker },
            { WinterWitch.Id, WinterWitch },
            { SkullNinja.Id, SkullNinja },
            { EvilWays.Id, EvilWays },
            { DragonCharmer.Id, DragonCharmer },
            { FirstEyeBlind.Id, FirstEyeBlind },
            { StinkeyeDefault.Id, StinkeyeDefault },
            { StinkeyeDefaultAlt.Id, StinkeyeDefaultAlt },
            { EnfantTerrible.Id, EnfantTerrible },
            { FloatyFun.Id, FloatyFun },
            { TemperDefault.Id, TemperDefault },
            { ForgedFury.Id, ForgedFury },
            { PrizedCow.Id, PrizedCow },
            { CygnusDefault.Id, CygnusDefault },
            { Adventurer.Id, Adventurer },
            { CygnusDefaultRed.Id, CygnusDefaultRed },
            { OldCodger.Id, OldCodger },
            { RoadMaster.Id, RoadMaster },
            { TundraDefault.Id, TundraDefault },
            { WarChief.Id, WarChief },
            { BigLebearski.Id, BigLebearski },
            { KingOfArctos.Id, KingOfArctos },
            { ImperialGoldenMage.Id, ImperialGoldenMage },
            { LuckyTunic.Id, LuckyTunic },
            { MaximillianEnchantedArmor.Id, MaximillianEnchantedArmor },
            { KnightsWatch.Id, KnightsWatch },
            { MaximillianDefault.Id, MaximillianDefault },
            { OrcSlayer.Id, OrcSlayer },
            { CardboardSamurai.Id, CardboardSamurai },
            { ScaredCrow.Id, ScaredCrow },
            { LionHeart.Id, LionHeart },
            { RobinHood.Id, RobinHood },
            { Paximillian.Id, Paximillian },
            { MaximillianLegendaryDefault.Id, MaximillianLegendaryDefault },
            { ChampionOfTheOrder.Id, ChampionOfTheOrder },
            { JamezRipher.Id, JamezRipher },
            { WinterWarrior.Id, WinterWarrior },
            { Boomstick.Id, Boomstick },
            { Backdraft.Id, Backdraft },
            { DragonSlayer.Id, DragonSlayer },
            { SummerOfStunning.Id, SummerOfStunning },
            { RedScarf.Id, RedScarf },
            { YellowScarf.Id, YellowScarf },
            { BlueScarf.Id, BlueScarf },
            { YiLinDefault.Id, YiLinDefault },
            { SentinelOfTheOrder.Id, SentinelOfTheOrder },
            { SlayingInTheRain.Id, SlayingInTheRain },
            { YuleLin.Id, YuleLin },
            { DarkPaladin.Id, DarkPaladin },
            { WinstonDefault.Id, WinstonDefault },
            { ChangEDefault.Id, ChangEDefault },
            { Chicken.Id, Chicken },
            { ChickenWithTrainers.Id, ChickenWithTrainers },
            { PrideAssassin.Id, PrideAssassin },
            { BouncerBear.Id, BouncerBear },
            { ImageHuman.Id, ImageHuman },
            { ImageArcane.Id, ImageArcane },
            { ImageLightning.Id, ImageLightning },
            { ImageIce.Id, ImageIce },
            { ImageFire.Id, ImageFire },
            { ChaoticKobold.Id, ChaoticKobold },
            { DwarfPriest.Id, DwarfPriest },
            { GnollBreeder.Id, GnollBreeder },
        };

        public static Skin GetById(int id)
        {
            if (SkinsById.TryGetValue(id, out var skin))
            {
                return skin;
            }
            return new Skin { Id = 0, Name = "Unknown" };
        }
    }
}
