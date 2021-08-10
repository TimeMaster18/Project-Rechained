﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static SingleplayerLauncher.Names.Skin;
using static SingleplayerLauncher.Names.Hero;

namespace SingleplayerLauncher.Model
{
	public class Skin
	{
		public string Name { private set; get; }
		public string CodeName { private set; get; }
		public byte[] HexSpitfireGameUPK { private set; get; }

		// private constructor
		Skin() { }

		// static members
		public static Skin OzielDefault = new Skin()
		{
			Name = OZIEL_DEFAULT,
			CodeName = "RPlayerSkinAncestor000",
			HexSpitfireGameUPK = new byte[] { 0x44, 0xDF, 0x00, 0x00 },
		};
		public static Skin BloodRune = new Skin()
		{
			Name = BLOOD_RUNE,
			CodeName = "RPlayerSkinAncestor001",
			HexSpitfireGameUPK = new byte[] { 0x46, 0xDF, 0x00, 0x00 },
		};
		public static Skin StringTheory = new Skin()
		{
			Name = STRING_THEORY,
			CodeName = "RPlayerSkinAncestor003",
			HexSpitfireGameUPK = new byte[] { 0x48, 0xDF, 0x00, 0x00 },
		};
		public static Skin KnightWalker = new Skin()
		{
			Name = KNIGHT_WALKER,
			CodeName = "RPlayerSkinAncestor005",
			HexSpitfireGameUPK = new byte[] { 0x4A, 0xDF, 0x00, 0x00 },
		};
		public static Skin ZoeyDefault = new Skin()
		{
			Name = ZOEY_DEFAULT,
			CodeName = "RPlayerSkinApprentice000",
			HexSpitfireGameUPK = new byte[] { 0x4C, 0xDF, 0x00, 0x00 },
		};
		public static Skin SchoolDaze = new Skin()
		{
			Name = SCHOOL_DAZE,
			CodeName = "RPlayerSkinApprentice001",
			HexSpitfireGameUPK = new byte[] { 0x4E, 0xDF, 0x00, 0x00 },
		};
		public static Skin PrettyLittleStitches = new Skin()
		{
			Name = PRETTY_LITTLE_STITCHES,
			CodeName = "RPlayerSkinApprentice003",
			HexSpitfireGameUPK = new byte[] { 0x50, 0xDF, 0x00, 0x00 },
		};
		public static Skin JurassicJourney = new Skin()
		{
			Name = JURASSIC_JOURNEY,
			CodeName = "RPlayerSkinApprentice005",
			HexSpitfireGameUPK = new byte[] { 0x52, 0xDF, 0x00, 0x00 },
		};
		public static Skin BionkaDefault = new Skin()
		{
			Name = BIONKA_DEFAULT,
			CodeName = "RPlayerSkinBallAndChain000",
			HexSpitfireGameUPK = new byte[] { 0x54, 0xDF, 0x00, 0x00 },
		};
		public static Skin LizardQueen = new Skin()
		{
			Name = LIZARD_QUEEN,
			CodeName = "RPlayerSkinBallAndChain001",
			HexSpitfireGameUPK = new byte[] { 0x56, 0xDF, 0x00, 0x00 },
		};
		public static Skin Fluffalump = new Skin()
		{
			Name = FLUFFALUMP,
			CodeName = "RPlayerSkinBallAndChain003",
			HexSpitfireGameUPK = new byte[] { 0x58, 0xDF, 0x00, 0x00 },
		};
		public static Skin BionkaBunny = new Skin()
		{
			Name = BIONKA_BUNNY,
			CodeName = "RPlayerSkinBallAndChain008",
			HexSpitfireGameUPK = new byte[] { 0x5A, 0xDF, 0x00, 0x00 },
		};
		public static Skin BlackpawEnchantedArmor = new Skin()
		{
			Name = BLACKPAW_ENCHANTED_ARMOR,
			CodeName = "RPlayerSkinBlackpaw000",
			HexSpitfireGameUPK = new byte[] { 0x5C, 0xDF, 0x00, 0x00 },
		};
		public static Skin PawOfTheDead = new Skin()
		{
			Name = PAW_OF_THE_DEAD,
			CodeName = "RPlayerSkinBlackpaw001",
			HexSpitfireGameUPK = new byte[] { 0x5E, 0xDF, 0x00, 0x00 },
		};
		public static Skin BlackpawDefault = new Skin()
		{
			Name = BLACKPAW_DEFAULT,
			CodeName = "RPlayerSkinBlackpaw002",
			HexSpitfireGameUPK = new byte[] { 0x60, 0xDF, 0x00, 0x00 },
		};
		public static Skin TutuDloo = new Skin()
		{
			Name = TUTU_DLOO,
			CodeName = "RPlayerSkinBlackpaw005",
			HexSpitfireGameUPK = new byte[] { 0x62, 0xDF, 0x00, 0x00 },
		};
		public static Skin PrideOfThePack = new Skin()
		{
			Name = PRIDE_OF_THE_PACK,
			CodeName = "RPlayerSkinBlackpaw007",
			HexSpitfireGameUPK = new byte[] { 0x64, 0xDF, 0x00, 0x00 },
		};
		public static Skin Runeclaw = new Skin()
		{
			Name = RUNECLAW,
			CodeName = "RPlayerSkinBlackpaw009",
			HexSpitfireGameUPK = new byte[] { 0x66, 0xDF, 0x00, 0x00 },
		};
		public static Skin Blackscale = new Skin()
		{
			Name = BLACKSCALE,
			CodeName = "RPlayerSkinBlackpaw012",
			HexSpitfireGameUPK = new byte[] { 0x68, 0xDF, 0x00, 0x00 },
		};
		public static Skin DragonThrall = new Skin()
		{
			Name = DRAGON_THRALL,
			CodeName = "RPlayerSkinBlackpaw014",
			HexSpitfireGameUPK = new byte[] { 0x6A, 0xDF, 0x00, 0x00 },
		};
		public static Skin BloodpsikeDefault = new Skin()
		{
			Name = BLOODPSIKE_DEFAULT,
			CodeName = "RPlayerSkinBloodspike000",
			HexSpitfireGameUPK = new byte[] { 0x6C, 0xDF, 0x00, 0x00 },
		};
		public static Skin GrizzlyKill = new Skin()
		{
			Name = GRIZZLY_KILL,
			CodeName = "RPlayerSkinBloodspike001",
			HexSpitfireGameUPK = new byte[] { 0x6E, 0xDF, 0x00, 0x00 },
		};
		public static Skin BreakerOfMolds = new Skin()
		{
			Name = BREAKER_OF_MOLDS,
			CodeName = "RPlayerSkinBloodspike003",
			HexSpitfireGameUPK = new byte[] { 0x70, 0xDF, 0x00, 0x00 },
		};
		public static Skin BloodAppetit = new Skin()
		{
			Name = BLOOD_APPETIT,
			CodeName = "RPlayerSkinBloodspike005",
			HexSpitfireGameUPK = new byte[] { 0x72, 0xDF, 0x00, 0x00 },
		};
		public static Skin GreenGuillotine = new Skin()
		{
			Name = GREEN_GUILLOTINE,
			CodeName = "RPlayerSkinBloodspike007",
			HexSpitfireGameUPK = new byte[] { 0x74, 0xDF, 0x00, 0x00 },
		};
		public static Skin LaughingToDeath = new Skin()
		{
			Name = LAUGHING_TO_DEATH,
			CodeName = "RPlayerSkinBloodspike011",
			HexSpitfireGameUPK = new byte[] { 0x76, 0xDF, 0x00, 0x00 },
		};
		public static Skin BrassDefault = new Skin()
		{
			Name = BRASS_DEFAULT,
			CodeName = "RPlayerSkinBrass000",
			HexSpitfireGameUPK = new byte[] { 0x7A, 0xDF, 0x00, 0x00 },
		};
		public static Skin GunsGearsNLace = new Skin()
		{
			Name = GUNS_GEARS_N_LACE,
			CodeName = "RPlayerSkinBrass001",
			HexSpitfireGameUPK = new byte[] { 0x7C, 0xDF, 0x00, 0x00 },
		};
		public static Skin BombshellBattalion = new Skin()
		{
			Name = BOMBSHELL_BATTALION,
			CodeName = "RPlayerSkinBrass004",
			HexSpitfireGameUPK = new byte[] { 0x7E, 0xDF, 0x00, 0x00 },
		};
		public static Skin HogarthEnchantedArmor = new Skin()
		{
			Name = HOGARTH_ENCHANTED_ARMOR,
			CodeName = "RPlayerSkinHogarth000",
			HexSpitfireGameUPK = new byte[] { 0x8C, 0xDF, 0x00, 0x00 },
		};
		public static Skin GodOfPlunder = new Skin()
		{
			Name = GOD_OF_PLUNDER,
			CodeName = "RPlayerSkinHogarth001",
			HexSpitfireGameUPK = new byte[] { 0x8E, 0xDF, 0x00, 0x00 },
		};
		public static Skin HogarthDefault = new Skin()
		{
			Name = HOGARTH_DEFAULT,
			CodeName = "RPlayerSkinHogarth002",
			HexSpitfireGameUPK = new byte[] { 0x90, 0xDF, 0x00, 0x00 },
		};
		public static Skin LumberingJack = new Skin()
		{
			Name = LUMBERING_JACK,
			CodeName = "RPlayerSkinHogarth005",
			HexSpitfireGameUPK = new byte[] { 0x92, 0xDF, 0x00, 0x00 },
		};
		public static Skin HogarthDefaultGold = new Skin()
		{
			Name = HOGARTH_DEFAULT_GOLD,
			CodeName = "RPlayerSkinHogarth007",
			HexSpitfireGameUPK = new byte[] { 0x94, 0xDF, 0x00, 0x00 },
		};
		public static Skin IceArmor = new Skin()
		{
			Name = ICE_ARMOR,
			CodeName = "RPlayerSkinHogarth009",
			HexSpitfireGameUPK = new byte[] { 0x96, 0xDF, 0x00, 0x00 },
		};
		public static Skin ImperialGoldenWarrior = new Skin()
		{
			Name = IMPERIAL_GOLDEN_WARRIOR,
			CodeName = "RPlayerSkinHogarth011",
			HexSpitfireGameUPK = new byte[] { 0x98, 0xDF, 0x00, 0x00 },
		};
		public static Skin BeachedBod = new Skin()
		{
			Name = BEACHED_BOD,
			CodeName = "RPlayerSkinHogarth013",
			HexSpitfireGameUPK = new byte[] { 0x9A, 0xDF, 0x00, 0x00 },
		};
		public static Skin BlackThane = new Skin()
		{
			Name = BLACK_THANE,
			CodeName = "RPlayerSkinHogarth018",
			HexSpitfireGameUPK = new byte[] { 0x9E, 0xDF, 0x00, 0x00 },
		};
		public static Skin TheSchling = new Skin()
		{
			Name = THE_SCHLING,
			CodeName = "RPlayerSkinHogarth022",
			HexSpitfireGameUPK = new byte[] { 0xA0, 0xDF, 0x00, 0x00 },
		};
		public static Skin DragonWard = new Skin()
		{
			Name = DRAGON_WARD,
			CodeName = "RPlayerSkinHogarth024",
			HexSpitfireGameUPK = new byte[] { 0xA2, 0xDF, 0x00, 0x00 },
		};
		public static Skin DeadeyeDefault = new Skin()
		{
			Name = DEADEYE_DEFAULT,
			CodeName = "RPlayerSkinLadyDeadEye000",
			HexSpitfireGameUPK = new byte[] { 0xB4, 0xDF, 0x00, 0x00 },
		};
		public static Skin PrettyPunk = new Skin()
		{
			Name = PRETTY_PUNK,
			CodeName = "RPlayerSkinLadyDeadEye001",
			HexSpitfireGameUPK = new byte[] { 0xB6, 0xDF, 0x00, 0x00 },
		};
		public static Skin TheGoodTheBadAndTheDeadeye = new Skin()
		{
			Name = THE_GOOD_THE_BAD_AND_THE_DEADEYE,
			CodeName = "RPlayerSkinLadyDeadEye003",
			HexSpitfireGameUPK = new byte[] { 0xB8, 0xDF, 0x00, 0x00 },
		};
		public static Skin HiddenTiger = new Skin()
		{
			Name = HIDDEN_TIGER,
			CodeName = "RPlayerSkinMidnight000",
			HexSpitfireGameUPK = new byte[] { 0xBA, 0xDF, 0x00, 0x00 },
		};
		public static Skin MidnightDefault = new Skin()
		{
			Name = MIDNIGHT_DEFAULT,
			CodeName = "RPlayerSkinMidnight001",
			HexSpitfireGameUPK = new byte[] { 0xBC, 0xDF, 0x00, 0x00 },
		};
		public static Skin MidnightDefaultGold = new Skin()
		{
			Name = MIDNIGHT_DEFAULT_GOLD,
			CodeName = "RPlayerSkinMidnight003",
			HexSpitfireGameUPK = new byte[] { 0xBE, 0xDF, 0x00, 0x00 },
		};
		public static Skin CatBurglar = new Skin()
		{
			Name = CAT_BURGLAR,
			CodeName = "RPlayerSkinMidnight007",
			HexSpitfireGameUPK = new byte[] { 0xC2, 0xDF, 0x00, 0x00 },
		};
		public static Skin ShiverMeWhiskers = new Skin()
		{
			Name = SHIVER_ME_WHISKERS,
			CodeName = "RPlayerSkinMidnight009",
			HexSpitfireGameUPK = new byte[] { 0xC4, 0xDF, 0x00, 0x00 },
		};
		public static Skin WuXingAzureAssassin = new Skin()
		{
			Name = WU_XING_AZURE_ASSASSIN,
			CodeName = "RPlayerSkinMidnight011",
			HexSpitfireGameUPK = new byte[] { 0xC6, 0xDF, 0x00, 0x00 },
		};
		public static Skin DobbinDefault = new Skin()
		{
			Name = DOBBIN_DEFAULT,
			CodeName = "RPlayerSkinProspector000",
			HexSpitfireGameUPK = new byte[] { 0xCE, 0xDF, 0x00, 0x00 },
		};
		public static Skin GoldRush = new Skin()
		{
			Name = GOLD_RUSH,
			CodeName = "RPlayerSkinProspector001",
			HexSpitfireGameUPK = new byte[] { 0xD0, 0xDF, 0x00, 0x00 },
		};
		public static Skin DobbinDefaultGold = new Skin()
		{
			Name = DOBBIN_DEFAULT_GOLD,
			CodeName = "RPlayerSkinProspector003",
			HexSpitfireGameUPK = new byte[] { 0xD2, 0xDF, 0x00, 0x00 },
		};
		public static Skin ElCavador = new Skin()
		{
			Name = EL_CAVADOR,
			CodeName = "RPlayerSkinProspector005",
			HexSpitfireGameUPK = new byte[] { 0xD4, 0xDF, 0x00, 0x00 },
		};
		public static Skin SantasLittleHelper = new Skin()
		{
			Name = SANTAS_LITTLE_HELPER,
			CodeName = "RPlayerSkinProspector007",
			HexSpitfireGameUPK = new byte[] { 0xD6, 0xDF, 0x00, 0x00 },
		};
		public static Skin ScurvyRumrudder = new Skin()
		{
			Name = SCURVY_RUMRUDDER,
			CodeName = "RPlayerSkinScurvy000",
			HexSpitfireGameUPK = new byte[] { 0xD8, 0xDF, 0x00, 0x00 },
		};
		public static Skin DobbinEnchantedArmor = new Skin()
		{
			Name = DOBBIN_ENCHANTED_ARMOR,
			CodeName = "RPlayerSkinSheElf000",
			HexSpitfireGameUPK = new byte[] { 0xDA, 0xDF, 0x00, 0x00 },
		};
		public static Skin Valkyrie = new Skin()
		{
			Name = VALKYRIE,
			CodeName = "RPlayerSkinSheElf001",
			HexSpitfireGameUPK = new byte[] { 0xDC, 0xDF, 0x00, 0x00 },
		};
		public static Skin IvyDefault = new Skin()
		{
			Name = IVY_DEFAULT,
			CodeName = "RPlayerSkinSheElf002",
			HexSpitfireGameUPK = new byte[] { 0xDE, 0xDF, 0x00, 0x00 },
		};
		public static Skin FlowerFriend = new Skin()
		{
			Name = FLOWER_FRIEND,
			CodeName = "RPlayerSkinSheElf005",
			HexSpitfireGameUPK = new byte[] { 0xE0, 0xDF, 0x00, 0x00 },
		};
		public static Skin IvyDefaultGold = new Skin()
		{
			Name = IVY_DEFAULT_GOLD,
			CodeName = "RPlayerSkinSheElf007",
			HexSpitfireGameUPK = new byte[] { 0xE2, 0xDF, 0x00, 0x00 },
		};
		public static Skin ImperialRubyArcher = new Skin()
		{
			Name = IMPERIAL_RUBY_ARCHER,
			CodeName = "RPlayerSkinSheElf009",
			HexSpitfireGameUPK = new byte[] { 0xE4, 0xDF, 0x00, 0x00 },
		};
		public static Skin WickedWarden = new Skin()
		{
			Name = WICKED_WARDEN,
			CodeName = "RPlayerSkinSheElf014",
			HexSpitfireGameUPK = new byte[] { 0xE8, 0xDF, 0x00, 0x00 },
		};
		public static Skin Grovewatch = new Skin()
		{
			Name = GROVEWATCH,
			CodeName = "RPlayerSkinSheElf016",
			HexSpitfireGameUPK = new byte[] { 0xEA, 0xDF, 0x00, 0x00 },
		};
		public static Skin DragonTamer = new Skin()
		{
			Name = DRAGON_TAMER,
			CodeName = "RPlayerSkinSheElf018",
			HexSpitfireGameUPK = new byte[] { 0xEC, 0xDF, 0x00, 0x00 },
		};
		public static Skin SmolderDefault = new Skin()
		{
			Name = SMOLDER_DEFAULT,
			CodeName = "RPlayerSkinSmolder000",
			HexSpitfireGameUPK = new byte[] { 0xF2, 0xDF, 0x00, 0x00 },
		};
		public static Skin HelterSwelter = new Skin()
		{
			Name = HELTER_SWELTER,
			CodeName = "RPlayerSkinSmolder001",
			HexSpitfireGameUPK = new byte[] { 0xF4, 0xDF, 0x00, 0x00 },
		};
		public static Skin SmolderDefaultWhiteHair = new Skin()
		{
			Name = SMOLDER_DEFAULT_WHITE_HAIR,
			CodeName = "RPlayerSkinSmolder003",
			HexSpitfireGameUPK = new byte[] { 0xF6, 0xDF, 0x00, 0x00 },
		};
		public static Skin Elite = new Skin()
		{
			Name = ELITE,
			CodeName = "RPlayerSkinSmolder005",
			HexSpitfireGameUPK = new byte[] { 0xF8, 0xDF, 0x00, 0x00 },
		};
		public static Skin KillAuea = new Skin()
		{
			Name = KILL_AUEA,
			CodeName = "RPlayerSkinSmolder006",
			HexSpitfireGameUPK = new byte[] { 0xFA, 0xDF, 0x00, 0x00 },
		};
		public static Skin FireAlarmFemme = new Skin()
		{
			Name = FIRE_ALARM_FEMME,
			CodeName = "RPlayerSkinSmolder008",
			HexSpitfireGameUPK = new byte[] { 0xFC, 0xDF, 0x00, 0x00 },
		};
		public static Skin Firestarter = new Skin()
		{
			Name = FIRESTARTER,
			CodeName = "RPlayerSkinSmolder0010",
			HexSpitfireGameUPK = new byte[] { 0xFE, 0xDF, 0x00, 0x00 },
		};
		public static Skin WuXingDragonMage = new Skin()
		{
			Name = WU_XING_DRAGON_MAGE,
			CodeName = "RPlayerSkinSmolder0012",
			HexSpitfireGameUPK = new byte[] { 0x00, 0xE0, 0x00, 0x00 },
		};
		public static Skin ViolentVintage = new Skin()
		{
			Name = VIOLENT_VINTAGE,
			CodeName = "RPlayerSkinSorceress000",
			HexSpitfireGameUPK = new byte[] { 0x02, 0xE0, 0x00, 0x00 },
		};
		public static Skin GabriellaEnchantedArmor = new Skin()
		{
			Name = GABRIELLA_ENCHANTED_ARMOR,
			CodeName = "RPlayerSkinSorceress002",
			HexSpitfireGameUPK = new byte[] { 0x04, 0xE0, 0x00, 0x00 },
		};
		public static Skin BloodQueen = new Skin()
		{
			Name = BLOOD_QUEEN,
			CodeName = "RPlayerSkinSorceress003",
			HexSpitfireGameUPK = new byte[] { 0x06, 0xE0, 0x00, 0x00 },
		};
		public static Skin GabriellaDefault = new Skin()
		{
			Name = GABRIELLA_DEFAULT,
			CodeName = "RPlayerSkinSorceress004",
			HexSpitfireGameUPK = new byte[] { 0x08, 0xE0, 0x00, 0x00 },
		};
		public static Skin FrightfullyDelightful = new Skin()
		{
			Name = FRIGHTFULLY_DELIGHTFUL,
			CodeName = "RPlayerSkinSorceress007",
			HexSpitfireGameUPK = new byte[] { 0x0A, 0xE0, 0x00, 0x00 },
		};
		public static Skin GabriellaDefaultRed = new Skin()
		{
			Name = GABRIELLA_DEFAULT_RED,
			CodeName = "RPlayerSkinSorceress009",
			HexSpitfireGameUPK = new byte[] { 0x0C, 0xE0, 0x00, 0x00 },
		};
		public static Skin LifeInPlastic = new Skin()
		{
			Name = LIFE_IN_PLASTIC,
			CodeName = "RPlayerSkinSorceress011",
			HexSpitfireGameUPK = new byte[] { 0x0E, 0xE0, 0x00, 0x00 },
		};
		public static Skin ArchmageOfTheOrder = new Skin()
		{
			Name = ARCHMAGE_OF_THE_ORDER,
			CodeName = "RPlayerSkinSorceress013",
			HexSpitfireGameUPK = new byte[] { 0x10, 0xE0, 0x00, 0x00 },
		};
		public static Skin MistressOfIllusion = new Skin()
		{
			Name = MISTRESS_OF_ILLUSION,
			CodeName = "RPlayerSkinSorceress015",
			HexSpitfireGameUPK = new byte[] { 0x12, 0xE0, 0x00, 0x00 },
		};
		public static Skin PromisingProdigy = new Skin()
		{
			Name = PROMISING_PRODIGY,
			CodeName = "RPlayerSkinSorceress017",
			HexSpitfireGameUPK = new byte[] { 0x14, 0xE0, 0x00, 0x00 },
		};
		public static Skin IDreamOfGabby = new Skin()
		{
			Name = I_DREAM_OF_GABBY,
			CodeName = "RPlayerSkinSorceress019",
			HexSpitfireGameUPK = new byte[] { 0x16, 0xE0, 0x00, 0x00 },
		};
		public static Skin MiracleWorker = new Skin()
		{
			Name = MIRACLE_WORKER,
			CodeName = "RPlayerSkinSorceress021",
			HexSpitfireGameUPK = new byte[] { 0x18, 0xE0, 0x00, 0x00 },
		};
		public static Skin WinterWitch = new Skin()
		{
			Name = WINTER_WITCH,
			CodeName = "RPlayerSkinSorceress023",
			HexSpitfireGameUPK = new byte[] { 0x1A, 0xE0, 0x00, 0x00 },
		};
		public static Skin SkullNinja = new Skin()
		{
			Name = SKULL_NINJA,
			CodeName = "RPlayerSkinSorceress024",
			HexSpitfireGameUPK = new byte[] { 0x1C, 0xE0, 0x00, 0x00 },
		};
		public static Skin EvilWays = new Skin()
		{
			Name = EVIL_WAYS,
			CodeName = "RPlayerSkinSorceress026",
			HexSpitfireGameUPK = new byte[] { 0x1E, 0xE0, 0x00, 0x00 },
		};
		public static Skin DragonCharmer = new Skin()
		{
			Name = DRAGON_CHARMER,
			CodeName = "RPlayerSkinSorceress028",
			HexSpitfireGameUPK = new byte[] { 0x20, 0xE0, 0x00, 0x00 },
		};
		public static Skin FirstEyeBlind = new Skin()
		{
			Name = FIRST_EYE_BLIND,
			CodeName = "RPlayerSkinStinkeye000",
			HexSpitfireGameUPK = new byte[] { 0x22, 0xE0, 0x00, 0x00 },
		};
		public static Skin StinkeyeDefault = new Skin()
		{
			Name = STINKEYE_DEFAULT,
			CodeName = "RPlayerSkinStinkeye002",
			HexSpitfireGameUPK = new byte[] { 0x24, 0xE0, 0x00, 0x00 },
		};
		public static Skin StinkeyeDefaultAlt = new Skin()
		{
			Name = STINKEYE_DEFAULT_ALT,
			CodeName = "RPlayerSkinStinkeye003",
			HexSpitfireGameUPK = new byte[] { 0x26, 0xE0, 0x00, 0x00 },
		};
		public static Skin EnfantTerrible = new Skin()
		{
			Name = ENFANT_TERRIBLE,
			CodeName = "RPlayerSkinStinkeye008",
			HexSpitfireGameUPK = new byte[] { 0x2A, 0xE0, 0x00, 0x00 },
		};
		public static Skin FloatyFun = new Skin()
		{
			Name = FLOATY_FUN,
			CodeName = "RPlayerSkinStinkeye010",
			HexSpitfireGameUPK = new byte[] { 0x2C, 0xE0, 0x00, 0x00 },
		};
		public static Skin TemperDefault = new Skin()
		{
			Name = TEMPER_DEFAULT,
			CodeName = "RPlayerSkinTemper000",
			HexSpitfireGameUPK = new byte[] { 0x2E, 0xE0, 0x00, 0x00 },
		};
		public static Skin TemperForgedFury = new Skin()
		{
			Name = TEMPER_FORGED_FURY,
			CodeName = "RPlayerSkinTemper001",
			HexSpitfireGameUPK = new byte[] { 0x30, 0xE0, 0x00, 0x00 },
		};
		public static Skin PrizedCow = new Skin()
		{
			Name = PRIZED_COW,
			CodeName = "RPlayerSkinTemper003",
			HexSpitfireGameUPK = new byte[] { 0x32, 0xE0, 0x00, 0x00 },
		};
		public static Skin CygnusDefault = new Skin()
		{
			Name = CYGNUS_DEFAULT,
			CodeName = "RPlayerSkinTheMaster000",
			HexSpitfireGameUPK = new byte[] { 0x34, 0xE0, 0x00, 0x00 },
		};
		public static Skin Adventurer = new Skin()
		{
			Name = ADVENTURER,
			CodeName = "RPlayerSkinTheMaster001",
			HexSpitfireGameUPK = new byte[] { 0x36, 0xE0, 0x00, 0x00 },
		};
		public static Skin CygnusDefaultRed = new Skin()
		{
			Name = CYGNUS_DEFAULT_RED,
			CodeName = "RPlayerSkinTheMaster003",
			HexSpitfireGameUPK = new byte[] { 0x38, 0xE0, 0x00, 0x00 },
		};
		public static Skin OldCodger = new Skin()
		{
			Name = OLD_CODGER,
			CodeName = "RPlayerSkinTheMaster007",
			HexSpitfireGameUPK = new byte[] { 0x3C, 0xE0, 0x00, 0x00 },
		};
		public static Skin RoadMaster = new Skin()
		{
			Name = ROAD_MASTER,
			CodeName = "RPlayerSkinTheMaster010",
			HexSpitfireGameUPK = new byte[] { 0x3E, 0xE0, 0x00, 0x00 },
		};
		public static Skin TundraDefault = new Skin()
		{
			Name = TUNDRA_DEFAULT,
			CodeName = "RPlayerSkinTundra000",
			HexSpitfireGameUPK = new byte[] { 0x40, 0xE0, 0x00, 0x00 },
		};
		public static Skin WarChief = new Skin()
		{
			Name = WAR_CHIEF,
			CodeName = "RPlayerSkinTundra001",
			HexSpitfireGameUPK = new byte[] { 0x42, 0xE0, 0x00, 0x00 },
		};
		public static Skin BigLebearski = new Skin()
		{
			Name = BIG_LEBEARSKI,
			CodeName = "RPlayerSkinTundra004",
			HexSpitfireGameUPK = new byte[] { 0x44, 0xE0, 0x00, 0x00 },
		};
		public static Skin KingOfArctos = new Skin()
		{
			Name = KING_OF_ARCTOS,
			CodeName = "RPlayerSkinTundra006",
			HexSpitfireGameUPK = new byte[] { 0x46, 0xE0, 0x00, 0x00 },
		};
		public static Skin ImperialGoldenMage = new Skin()
		{
			Name = IMPERIAL_GOLDEN_MAGE,
			CodeName = "RPlayerSkinTundra008",
			HexSpitfireGameUPK = new byte[] { 0x48, 0xE0, 0x00, 0x00 },
		};
		public static Skin LuckyTunic = new Skin()
		{
			Name = LUCKY_TUNIC,
			CodeName = "RPlayerSkinWarmage000",
			HexSpitfireGameUPK = new byte[] { 0x4A, 0xE0, 0x00, 0x00 },
		};
		public static Skin MaximillianEnchantedArmor = new Skin()
		{
			Name = MAXIMILLIAN_ENCHANTED_ARMOR,
			CodeName = "RPlayerSkinWarmage003",
			HexSpitfireGameUPK = new byte[] { 0x4C, 0xE0, 0x00, 0x00 },
		};
		public static Skin KnightsWatch = new Skin()
		{
			Name = KNIGHTS_WATCH,
			CodeName = "RPlayerSkinWarmage004",
			HexSpitfireGameUPK = new byte[] { 0x4E, 0xE0, 0x00, 0x00 },
		};
		public static Skin MaximillianDefault = new Skin()
		{
			Name = MAXIMILLIAN_DEFAULT,
			CodeName = "RPlayerSkinWarmage005",
			HexSpitfireGameUPK = new byte[] { 0x50, 0xE0, 0x00, 0x00 },
		};
		public static Skin OrcSlayer = new Skin()
		{
			Name = ORC_SLAYER,
			CodeName = "RPlayerSkinWarmage006",
			HexSpitfireGameUPK = new byte[] { 0x52, 0xE0, 0x00, 0x00 },
		};
		public static Skin CardboardSamurai = new Skin()
		{
			Name = CARDBOARD_SAMURAI,
			CodeName = "RPlayerSkinWarmage007",
			HexSpitfireGameUPK = new byte[] { 0x54, 0xE0, 0x00, 0x00 },
		};
		public static Skin ScaredCrow = new Skin()
		{
			Name = SCARED_CROW,
			CodeName = "RPlayerSkinWarmage012",
			HexSpitfireGameUPK = new byte[] { 0x56, 0xE0, 0x00, 0x00 },
		};
		public static Skin LionHeart = new Skin()
		{
			Name = LION_HEART,
			CodeName = "RPlayerSkinWarmage014",
			HexSpitfireGameUPK = new byte[] { 0x58, 0xE0, 0x00, 0x00 },
		};
		public static Skin RobinHood = new Skin()
		{
			Name = ROBIN_HOOD,
			CodeName = "RPlayerSkinWarmage016",
			HexSpitfireGameUPK = new byte[] { 0x5A, 0xE0, 0x00, 0x00 },
		};
		public static Skin Paximillian = new Skin()
		{
			Name = PAXIMILLIAN,
			CodeName = "RPlayerSkinWarmage018",
			HexSpitfireGameUPK = new byte[] { 0x5C, 0xE0, 0x00, 0x00 },
		};
		public static Skin MaximillianLegendaryDefault = new Skin()
		{
			Name = MAXIMILLIAN_LEGENDARY_DEFAULT,
			CodeName = "RPlayerSkinWarmage020",
			HexSpitfireGameUPK = new byte[] { 0x5E, 0xE0, 0x00, 0x00 },
		};
		public static Skin ChampionOfTheOrder = new Skin()
		{
			Name = CHAMPION_OF_THE_ORDER,
			CodeName = "RPlayerSkinWarmage022",
			HexSpitfireGameUPK = new byte[] { 0x60, 0xE0, 0x00, 0x00 },
		};
		public static Skin JamezRipher = new Skin()
		{
			Name = JAMEZ_RIPHER,
			CodeName = "RPlayerSkinWarmage025",
			HexSpitfireGameUPK = new byte[] { 0x62, 0xE0, 0x00, 0x00 },
		};
		public static Skin WinterWarrior = new Skin()
		{
			Name = WINTER_WARRIOR,
			CodeName = "RPlayerSkinWarmage027",
			HexSpitfireGameUPK = new byte[] { 0x64, 0xE0, 0x00, 0x00 },
		};
		public static Skin Boomstick = new Skin()
		{
			Name = BOOMSTICK,
			CodeName = "RPlayerSkinWarmage029",
			HexSpitfireGameUPK = new byte[] { 0x66, 0xE0, 0x00, 0x00 },
		};
		public static Skin Backdraft = new Skin()
		{
			Name = BACKDRAFT,
			CodeName = "RPlayerSkinWarmage030",
			HexSpitfireGameUPK = new byte[] { 0x68, 0xE0, 0x00, 0x00 },
		};
		public static Skin DragonSlayer = new Skin()
		{
			Name = DRAGON_SLAYER,
			CodeName = "RPlayerSkinWarmage032",
			HexSpitfireGameUPK = new byte[] { 0x6A, 0xE0, 0x00, 0x00 },
		};
		public static Skin SummerOfStunning = new Skin()
		{
			Name = SUMMER_OF_STUNNING,
			CodeName = "RPlayerSkinWarmage034",
			HexSpitfireGameUPK = new byte[] { 0x6C, 0xE0, 0x00, 0x00 },
		};
		public static Skin RedScarf = new Skin()
		{
			Name = RED_SCARF,
			CodeName = "RPlayerSkinWarmage036",
			HexSpitfireGameUPK = new byte[] { 0x6E, 0xE0, 0x00, 0x00 },
		};
		public static Skin YellowScarf = new Skin()
		{
			Name = YELLOW_SCARF,
			CodeName = "RPlayerSkinWarmage038",
			HexSpitfireGameUPK = new byte[] { 0x70, 0xE0, 0x00, 0x00 },
		};
		public static Skin BlueScarf = new Skin()
		{
			Name = BLUE_SCARF,
			CodeName = "RPlayerSkinWarmage040",
			HexSpitfireGameUPK = new byte[] { 0x72, 0xE0, 0x00, 0x00 },
		};
		public static Skin YiLinDefault = new Skin()
		{
			Name = YI_LIN_DEFAULT,
			CodeName = "RPlayerSkinYiLin000",
			HexSpitfireGameUPK = new byte[] { 0x78, 0xE0, 0x00, 0x00 },
		};
		public static Skin SentinelOfTheOrder = new Skin()
		{
			Name = SENTINEL_OF_THE_ORDER,
			CodeName = "RPlayerSkinYiLin001",
			HexSpitfireGameUPK = new byte[] { 0x7A, 0xE0, 0x00, 0x00 },
		};
		public static Skin SlayingInTheRain = new Skin()
		{
			Name = SLAYING_IN_THE_RAIN,
			CodeName = "RPlayerSkinYiLin004",
			HexSpitfireGameUPK = new byte[] { 0x7C, 0xE0, 0x00, 0x00 },
		};
		public static Skin YuleLin = new Skin()
		{
			Name = YULE_LIN,
			CodeName = "RPlayerSkinYiLin006",
			HexSpitfireGameUPK = new byte[] { 0x7E, 0xE0, 0x00, 0x00 },
		};


		// SIR WINSTON
		public static Skin DarkPaladin = new Skin()
		{
			Name = DARK_PALADIN,
			CodeName = "RPlayerSkinSirWinston000",
			HexSpitfireGameUPK = new byte[] { 0xEE, 0xDF, 0x00, 0x00 },
		};
		public static Skin WinstonDefault = new Skin()
		{
			Name = WINSTON_DEFAULT,
			CodeName = "RPlayerSkinSirWinston002",
			HexSpitfireGameUPK = new byte[] { 0xF0, 0xDF, 0x00, 0x00 },
		};


		// CHANG'E
		public static Skin ChangEDefault = new Skin()
		{
			Name = CHANG_E_DEFAULT,
			CodeName = "RPlayerSkinChangE000",
			HexSpitfireGameUPK = new byte[] { 0x80, 0xDF, 0x00, 0x00 },
		};


		// CHICKEN
		public static Skin Chicken = new Skin()
		{
			Name = CHICKEN,
			CodeName = "RPlayerSkinPolymorph000",
			HexSpitfireGameUPK = new byte[] { 0xC8, 0xDF, 0x00, 0x00 },
		};
		public static Skin ChickenWithTrainers = new Skin()
		{
			Name = CHICKEN_WITH_TRAINERS,
			CodeName = "RPlayerSkinPolymorph001",
			HexSpitfireGameUPK = new byte[] { 0xCA, 0xDF, 0x00, 0x00 },
		};


		// MERCENARIES
		public static Skin PrideAssassin = new Skin()
		{
			Name = PRIDE_ASSASSIN,
			CodeName = "RPlayerSkinPrideAssassin000",
			HexSpitfireGameUPK = new byte[] { 0xCC, 0xDF, 0x00, 0x00 },
		};
		public static Skin BouncerBear = new Skin()
		{
			Name = BOUNCER_BEAR,
			CodeName = "RPlayerSkinBouncerBear000",
			HexSpitfireGameUPK = new byte[] { 0x78, 0xDF, 0x00, 0x00 },
		};
		public static Skin ImageHuman = new Skin()
		{
			Name = IMAGE_HUMAN,
			CodeName = "RPlayerSkiniMage000",
			HexSpitfireGameUPK = new byte[] { 0xA6, 0xDF, 0x00, 0x00 },
		};
		public static Skin ImageArcane = new Skin()
		{
			Name = IMAGE_ARCANE,
			CodeName = "RPlayerSkiniMage001",
			HexSpitfireGameUPK = new byte[] { 0xA8, 0xDF, 0x00, 0x00 },
		};
		public static Skin ImageLightning = new Skin()
		{
			Name = IMAGE_LIGHTNING,
			CodeName = "RPlayerSkiniMage002",
			HexSpitfireGameUPK = new byte[] { 0xAA, 0xDF, 0x00, 0x00 },
		};
		public static Skin ImageIce = new Skin()
		{
			Name = IMAGE_ICE,
			CodeName = "RPlayerSkiniMage003",
			HexSpitfireGameUPK = new byte[] { 0xAC, 0xDF, 0x00, 0x00 },
		};
		public static Skin ImageFire = new Skin()
		{
			Name = IMAGE_FIRE,
			CodeName = "RPlayerSkiniMage004",
			HexSpitfireGameUPK = new byte[] { 0xAE, 0xDF, 0x00, 0x00 },
		};
		public static Skin ChaoticKobold = new Skin()
		{
			Name = CHAOTIC_KOBOLD,
			CodeName = "RPlayerSkinChaoticKobold000",
			HexSpitfireGameUPK = new byte[] { 0x82, 0xDF, 0x00, 0x00 },
		};
		public static Skin DwarfPriest = new Skin()
		{
			Name = DWARF_PRIEST,
			CodeName = "RPlayerSkinDwarfPriest000",
			HexSpitfireGameUPK = new byte[] { 0x88, 0xDF, 0x00, 0x00 },
		};
		public static Skin GnollBreeder = new Skin()
		{
			Name = GNOLL_BREEDER,
			CodeName = "RPlayerSkinGnollBreeder000",
			HexSpitfireGameUPK = new byte[] { 0x8A, 0xDF, 0x00, 0x00 },
		};

		public static Skin[] OzielSkins = new Skin[] { OzielDefault, BloodRune, StringTheory, KnightWalker };
		public static Skin[] ZoeySkins = new Skin[] { ZoeyDefault, SchoolDaze, PrettyLittleStitches, JurassicJourney };
		public static Skin[] BionkaSkins = new Skin[] { BionkaDefault, LizardQueen, Fluffalump, BionkaBunny };
		public static Skin[] BlackpawSkins = new Skin[] { BlackpawDefault, BlackpawEnchantedArmor, PawOfTheDead, TutuDloo, PrideOfThePack, Runeclaw, Blackscale, DragonThrall };
		public static Skin[] BloodspikeSkins = new Skin[] { BloodpsikeDefault, GrizzlyKill, BreakerOfMolds, BloodAppetit, GreenGuillotine, LaughingToDeath };
		public static Skin[] BrassSkins = new Skin[] { BrassDefault, GunsGearsNLace, BombshellBattalion };
		public static Skin[] HogarthSkins = new Skin[] { HogarthDefault, HogarthEnchantedArmor, GodOfPlunder, LumberingJack, HogarthDefaultGold, IceArmor, ImperialGoldenWarrior, BeachedBod, BlackThane, TheSchling, DragonWard };
		public static Skin[] DeadeyeSkins = new Skin[] { DeadeyeDefault, PrettyPunk, TheGoodTheBadAndTheDeadeye, HiddenTiger, };
		public static Skin[] MidnightSkins = new Skin[] { MidnightDefault, MidnightDefaultGold, CatBurglar, ShiverMeWhiskers, WuXingAzureAssassin, };
		public static Skin[] DobbinSkins = new Skin[] { DobbinDefault, GoldRush, DobbinDefaultGold, ElCavador, SantasLittleHelper, ScurvyRumrudder, DobbinEnchantedArmor, };
		public static Skin[] IvySkins = new Skin[] { IvyDefault, Valkyrie, FlowerFriend, IvyDefaultGold, ImperialRubyArcher, WickedWarden, Grovewatch, DragonTamer, };
		public static Skin[] SmolderSkins = new Skin[] { SmolderDefault, HelterSwelter, SmolderDefaultWhiteHair, Elite, KillAuea, FireAlarmFemme, Firestarter, WuXingDragonMage, };
		public static Skin[] GabriellaSkins = new Skin[] { GabriellaDefault, ViolentVintage, GabriellaEnchantedArmor, BloodQueen, FrightfullyDelightful, GabriellaDefaultRed, LifeInPlastic, ArchmageOfTheOrder, MistressOfIllusion, PromisingProdigy, IDreamOfGabby, MiracleWorker, WinterWitch, SkullNinja, EvilWays, DragonCharmer, };
		public static Skin[] StinkeyeSkins = new Skin[] { StinkeyeDefault, FirstEyeBlind, StinkeyeDefaultAlt, EnfantTerrible, FloatyFun, };
		public static Skin[] TemperSkins = new Skin[] { TemperDefault, TemperForgedFury, PrizedCow };
		public static Skin[] CygnusSkins = new Skin[] { CygnusDefault, Adventurer, CygnusDefaultRed, OldCodger, RoadMaster, };
		public static Skin[] TundraSkins = new Skin[] { TundraDefault, WarChief, BigLebearski, KingOfArctos, ImperialGoldenMage, };
		public static Skin[] MaximilianSkins = new Skin[] { MaximillianDefault, LuckyTunic, MaximillianEnchantedArmor, KnightsWatch, OrcSlayer, CardboardSamurai, ScaredCrow, LionHeart, RobinHood, Paximillian, MaximillianLegendaryDefault, ChampionOfTheOrder, JamezRipher, WinterWarrior, Boomstick, Backdraft, DragonSlayer, SummerOfStunning, RedScarf, YellowScarf, BlueScarf, };
		public static Skin[] YiLinSkins = new Skin[] { YiLinDefault, SentinelOfTheOrder, SlayingInTheRain, YuleLin, };
		public static Skin[] OtherSkins = new Skin[] { DarkPaladin, WinstonDefault, ChangEDefault, Chicken, ChickenWithTrainers, };
		public static Skin[] MercenarySkins = new Skin[] { PrideAssassin, BouncerBear, ImageHuman, ImageArcane, ImageLightning, ImageIce, ImageFire, ChaoticKobold, DwarfPriest, GnollBreeder };

		public static Dictionary<string, Skin[]> HeroSkinMap = new Dictionary<string, Skin[]>
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
			{ DOBBIN_ENCHANTED_ARMOR, DobbinEnchantedArmor },
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
			{ TEMPER_FORGED_FURY, TemperForgedFury },
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
	}
}
