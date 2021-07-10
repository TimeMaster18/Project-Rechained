using System.Collections.Generic;

namespace SingleplayerLauncher.Resources
{
    internal class IniConfig
    {
        // Usable variables within CharactersData.ini
        // Heroes   (Name, pawnweapon)
        public static Dictionary<string, string> Heroes = new Dictionary<string, string>
        {
            { "Bionka", "PawnWeapon_Bionka.Pawn_Bionka" },
            { "Blackpaw", "PawnWeapon_Blackpaw.Pawn_Blackpaw" },
            { "Bloodspike", "PawnWeapon_Bloodspike.Pawn_Bloodspike" },
            { "Brass", "PawnWeapon_Brass.Pawn_Brass" },
            { "Cygnus", "PawnWeapon_Cygnus.Pawn_Cygnus" },
            { "Deadeye", "PawnWeapon_Deadeye.Pawn_Deadeye" },
            { "Dobbin", "PawnWeapon_Dobbin.Pawn_Dobbin" },
            { "Gabriella", "PawnWeapon_Sorceress.Pawn_Sorceress" },
            { "Hogarth", "PawnWeapon_Hogarth.Pawn_Hogarth" },
            { "Ivy", "PawnWeapon_Ivy.Pawn_Ivy" },
            { "Maximilian", "PawnWeapon_Warmage.Pawn_Warmage" },
            { "Midnight", "PawnWeapon_Midnight.Pawn_Midnight" },
            { "Oziel", "PawnWeapon_Oziel.Pawn_Oziel" },
            { "Smolder", "PawnWeapon_Smolder.Pawn_Smolder" },
            { "Stinkeye", "PawnWeapon_Stinkeye.Pawn_Stinkeye" },
            { "Temper", "PawnWeapon_Temper.Pawn_Temper" },
            { "Tundra", "PawnWeapon_Tundra.Pawn_Tundra" },
            { "Yi-Lin", "PawnWeapon_hooksword.Pawn_hooksword" },
            { "Zoey", "PawnWeapon_Zoey.Pawn_Zoey" }
        };


        // Maps { Name, umap }
        public static Dictionary<string, string> Maps = new Dictionary<string, string>
        {
            { "Academy Sewers", "PvE_Sewers.umap" },
            { "Archmage Library", "PvE_AcademyLibrary.umap" },
            { "Avalanche", "PvE_Avalanche.umap" },
            { "Banquet Hall", "PvE_BanquetHall.umap" },
            { "Castle Gates", "PvE_ASN_CastleGates.umap" },
            { "Cliffside Clash", "PvE_2Lane.umap" },
            { "Confluence", "PvE_AcademyCanals.umap" },
            { "Crogon Keep", "PvE_CrogonKeep.umap" },
            { "Docks at Eventide", "PvE_SUR_Pirates.umap" },
            { "Eventide Fortress", "PvE_Surrounded.umap" },
            { "Eventide Ramparts", "PvE_SUR_NorthernClans.umap" },
            { "Frostbite", "PvE_FrostBite.umap" },
            { "Gates of Thuricvod", "PvE_Corridors.umap" },
            { "Highlands", "PvE_Highlands.umap" },
            { "Maximum Security", "PvE_AcademyDungeon.umap" },
            { "Midnight Market", "PvE_ASN_NightMarket.umap" },
            { "Orcatraz", "PvE_Orcatraz.umap" },
            { "Orcri-La", "PvE_OrcVil_Temple.umap" },
            { "Restricted Section", "PvE_RestrictedSection.umap" },
            { "Riftmaker's Temple", "PvE_AcademyTemple.umap" },
            { "Shark Island", "PvE_SharkIsle.umap" },
            { "Stables at Eventide", "PvE_SUR_JungleTribe.umap" },
            { "Storm Drain", "PvE_Flushed.umap" },
            { "Temple Graveyard", "PvE_Mausoleum.umap" },
            { "The Baths", "PvE_Baths.umap" },
            { "The Falling Folly", "PvE_Towering.umap" },
            { "The Wall", "PvE_TheWall.umap" },
            { "Throne Room", "PvE_ThroneRoom.umap" },
            { "Thuricvod Village", "PvE_Gap.umap" },
            { "Training Grounds", "PvE_TrainingGrounds.umap" },
            { "Unchained Fortress", "PvE_OneWay.umap" },
            { "Water Garden", "PvE_ASN_WaterGarden.umap" },
            { "Prologue 1 (Grand Foyer)", "NPE_1.umap" },
            { "Prologue 2 (Archmage Library)", "NPE_2.umap" },
            { "Prologue 3 (Dungeon)", "NPE_3.umap" },
            { "Prologue 4 (Canals)", "NPE_4.umap" },
            { "Prologue 5 (Riftmaker's Temple)", "NPE_5.umap" },
            //{ "SpitfireFrontEndMap", "SpitfireFrontEndMap.umap" },
            { "Survival Tutorial", "TutorialSurvival.umap" },
            { "Basics Tutorial", "NewbieTutorial.umap" }
        };

        // GameModes { Name, DefaultOfflineDifficulty } (DefaultGame.ini)
        public static Dictionary<string, string> GameModes = new Dictionary<string, string>
        {
            { "Survival", "1" },
            { "Endless", "5" }
            //{ "Weekly Challenge", "" }
            //{ "Chaos Trials", "" }
        };


        // Difficulty { Name, DefaultOfflineDifficulty } (DefaultGame.ini)
        public static Dictionary<string, string> survivalDifficulties = new Dictionary<string, string>
        {
            { "Apprentice", "1" },
            { "War Mage", "11" },
            { "Master", "26" },
            { "Rift Lord", "46" }
        };

        // Endless Difficulty { Name, DefaultOfflineDifficulty } (DefaultGame.ini)
        public static Dictionary<string, string> endlessDifficulties = new Dictionary<string, string>
        {
            { "Endless+", "100" },
            { "Endless++", "125" },
            { "Endless+3", "150" },
            { "Endless+4", "175" },
            { "Endless+5", "200" },
            { "Endless+6", "225" },
            { "Endless+7", "250" },
            { "Endless+8", "275" },
            { "Endless+9", "300" },
            { "Endless+10", "400" }
        };

        // Survival Difficulty { Name, {DefaultOfflinePlayerLevel, DefaultOfflineDifficulty } (DefaultGame.ini)
        public static Dictionary<string, Dictionary<string, int[]>> survivalExtraDifficulties = new Dictionary<string, Dictionary<string, int[]>>
        {
            { "Apprentice", new Dictionary<string, int[]>
                {
                    { "Apprentice+" , new int[] { 1, 10 } }
                }
            },
            { "War Mage", new Dictionary<string, int[]>
                {
                    { "War Mage+" , new int[] { 1, 25 } }
                }
            },
            { "Master", new Dictionary<string, int[]>
                {
                    { "Master+" , new int[] { 15, 35 } },
                    { "Master++" , new int[] { 1, 45 } }
                }
            },
            { "Rift Lord", new Dictionary<string, int[]>
                {
                    { "Rift Lord+" , new int[] { 35, 55 } },
                    { "Rift Lord++" , new int[] { 25, 65 } },
                    { "Rift Lord+3" , new int[] { 15, 75 } },
                    { "Rift Lord+4" , new int[] { 5, 85 } },
                    { "Rift Lord+5" , new int[] { 1, 100 } }
                }
            }
        };

        // Dyes (Name, IdxDye)
        public static Dictionary<string, string> Dyes = new Dictionary<string, string>
        {
            { "Normal", "0" },
            { "Heroic", "1" },
            { "Legendary", "2" }
        };

    }
}
