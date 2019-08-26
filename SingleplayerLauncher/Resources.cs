using System.Collections.Generic;

namespace SingleplayerLauncher
{

    internal static class Resources
    {
        //Initialize Dictionaries 

        //Traps (Name, Hex)
        public static Dictionary<string, byte[]> traps = new Dictionary<string, byte[]>
        {
            { "Acid Sprayer", new byte[] { 0x5A, 0xC4, 0x00, 0x00, } },
            { "Arcane Bowling Ball", new byte[] { 0x62, 0xC4, 0x00, 0x00 } },
            { "Arcane Phaser", new byte[] { 0x64, 0xC4, 0x00, 0x00 } },
            { "Arrow Wall", new byte[] { 0x66, 0xC4, 0x00, 0x00 } },
            { "BGH Arrow Wall", new byte[] { 0x68, 0xC4, 0x00, 0x00 } },
            { "Ceiling Ballista", new byte[] { 0x6A, 0xC4, 0x00, 0x00 } },
            { "Dragons Lance", new byte[] { 0x6C, 0xC4, 0x00, 0x00 } },
            { "BGH Ceiling Ballista", new byte[] { 0x6E, 0xC4, 0x00, 0x00 } },
            { "Barricade", new byte[] { 0x70, 0xC4, 0x00, 0x00 } },
            { "Great Wall Barricade", new byte[] { 0x72, 0xC4, 0x00, 0x00 } },
            { "Boom Barrel", new byte[] { 0x74, 0xC4, 0x00, 0x00 } },
            { "Boom Barrel Roller", new byte[] { 0x76, 0xC4, 0x00, 0x00 } },
            { "Boulder Chute", new byte[] { 0x78, 0xC4, 0x00, 0x00 } },
            { "Icicle Impaler", new byte[] { 0x7A, 0xC4, 0x00, 0x00 } },
            { "Brimstone", new byte[] { 0x7C, 0xC4, 0x00, 0x00 } },
            { "Coin Forge", new byte[] { 0x7E, 0xC4, 0x00, 0x00 } },
            { "Cursed Ground", new byte[] { 0x80, 0xC4, 0x00, 0x00 } },
            { "Decoy", new byte[] { 0x82, 0xC4, 0x00, 0x00 } },
            { "Spitfire Wall", new byte[] { 0x84, 0xC4, 0x00, 0x00 } },
            { "Fire Cracker", new byte[] { 0x86, 0xC4, 0x00, 0x00 } },
            { "Flip Trap", new byte[] { 0x88, 0xC4, 0x00, 0x00 } },
            { "Floor Scorcher", new byte[] { 0x8A, 0xC4, 0x00, 0x00 } },
            { "Temple Alarm Gong", new byte[] { 0x8C, 0xC4, 0x00, 0x00 } },
            { "Grinder", new byte[] { 0x8E, 0xC4, 0x00, 0x00 } },
            { "Quarter Pounder", new byte[] { 0x90, 0xC4, 0x00, 0x00 } },
            { "Haymaker", new byte[] { 0x92, 0xC4, 0x00, 0x00 } },
            { "Healing Well", new byte[] { 0x94, 0xC4, 0x00, 0x00 } },
            { "Ice Shard", new byte[] { 0x96, 0xC4, 0x00, 0x00 } },
            { "Ice Vent", new byte[] { 0x98, 0xC4, 0x00, 0x00 } },
            { "Lightning Rod", new byte[] { 0x9A, 0xC4, 0x00, 0x00 } },
            { "Mana Well", new byte[] { 0x9C, 0xC4, 0x00, 0x00 } },
            { "Summoner Trap", new byte[] { 0x9E, 0xC4, 0x00, 0x00 } },
            { "Naphtha Sprayer", new byte[] { 0xA0, 0xC4, 0x00, 0x00 } },
            { "Overload Trap", new byte[] { 0xA2, 0xC4, 0x00, 0x00 } },
            { "Powerup Damage", new byte[] { 0xA4, 0xC4, 0x00, 0x00 } },
            { "Pounder", new byte[] { 0xA6, 0xC4, 0x00, 0x00 } },
            { "Concussive Pounder", new byte[] { 0xA8, 0xC4, 0x00, 0x00 } },
            { "Power Generator", new byte[] { 0xAA, 0xC4, 0x00, 0x00 } },
            { "Projectile Shield", new byte[] { 0xAC, 0xC4, 0x00, 0x00 } },
            { "Push Trap", new byte[] { 0xAE, 0xC4, 0x00, 0x00 } },
            { "Saw Of Arctos", new byte[] { 0xB0, 0xC4, 0x00, 0x00 } },
            { "Shield Powerup", new byte[] { 0xB2, 0xC4, 0x00, 0x00 } },
            { "Speed Pad", new byte[] { 0xB4, 0xC4, 0x00, 0x00 } },
            { "Floor Spikes", new byte[] { 0xB6, 0xC4, 0x00, 0x00 } },
            { "Spike Wall", new byte[] { 0xB8, 0xC4, 0x00, 0x00 } },
            { "Steam Vent", new byte[] { 0xBA, 0xC4, 0x00, 0x00 } },
            { "Swinging Mace", new byte[] { 0xBC, 0xC4, 0x00, 0x00 } },
            { "Tar Trap", new byte[] { 0xBE, 0xC4, 0x00, 0x00 } },
            { "Viscous Tar", new byte[] { 0xC0, 0xC4, 0x00, 0x00 } },
            { "Shock Zapper", new byte[] { 0xC2, 0xC4, 0x00, 0x00 } },
            { "BGH Shock Zapper", new byte[] { 0xC4, 0xC4, 0x00, 0x00 } },
            { "Trip Wire", new byte[] { 0xC6, 0xC4, 0x00, 0x00 } },
            { "Wall Blades", new byte[] { 0xC8, 0xC4, 0x00, 0x00 } },
            { "Wall Charger", new byte[] { 0xCA, 0xC4, 0x00, 0x00 } },
            { "Web Spinner", new byte[] { 0xCC, 0xC4, 0x00, 0x00 } }
        };

        // Gear   (Name, Hex)
        public static Dictionary<string, byte[]> gear = new Dictionary<string, byte[]>
        {
            { "Freedom Trinket", new byte[] { 0xCE, 0xC4, 0x00, 0x00 } },
            { "Greater Freedom Trinket", new byte[] { 0xD0, 0xC4, 0x00, 0x00 } },
            { "Mending Root", new byte[] { 0xD2, 0xC4, 0x00, 0x00 } },
            { "Hobgoblin Charm", new byte[] { 0xD4, 0xC4, 0x00, 0x00 } },
            { "Ring of Last Stand", new byte[] { 0xD6, 0xC4, 0x00, 0x00 } },
            { "Mage's Picnic", new byte[] { 0xD8, 0xC4, 0x00, 0x00 } },
            { "Mage's Clover", new byte[] { 0xDA, 0xC4, 0x00, 0x00 } },
            { "Gnomish Repair Kit", new byte[] { 0xDC, 0xC4, 0x00, 0x00 } },
            { "Teleportation Ring", new byte[] { 0xDE, 0xC4, 0x00, 0x00 } },
            { "Arcane Bubble Blower", new byte[] { 0xE3, 0xC4, 0x00, 0x00 } },
            { "Fire Wall Bracers", new byte[] { 0xE5, 0xC4, 0x00, 0x00 } },
            { "Ice Amulet", new byte[] { 0xE7, 0xC4, 0x00, 0x00 } },
            { "Ring of Storms", new byte[] { 0xE9, 0xC4, 0x00, 0x00 } },
            { "Lightning Ring", new byte[] { 0xEB, 0xC4, 0x00, 0x00 } },
            { "AntiTrap Vambrace", new byte[] { 0x02, 0xC4, 0x00, 0x00 } }
        };


        // Initialize usable variables within CharactersData.ini

        // Heroes   (Name, pawnweapon)
        public static Dictionary<string, string> heroes = new Dictionary<string, string>
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
        public static Dictionary<string, string> maps = new Dictionary<string, string>
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
        public static Dictionary<string, string> gameModes = new Dictionary<string, string>
        {
            { "Survival", "1" },
            { "Endless", "5" }
            //{ "Weekly Challenge", "" }
            //{ "Chaos Trials", "" }
        };

        // Maps { Name, umap }
        public static Dictionary<string, HashSet<string>> mapSurvivalDifficulties = new Dictionary<string, HashSet<string>>
        {
            { "Academy Sewers", new HashSet<string> { "Rift Lord" } },
            { "Archmage Library", new HashSet<string> {"Apprentice" } },
            { "Avalanche", new HashSet<string> { "Master", "Rift Lord" } },
            { "Banquet Hall", new HashSet<string> { "Apprentice", "War Mage", "Rift Lord" } },
            { "Castle Gates", new HashSet<string> { "Master", "Rift Lord" } },
            { "Cliffside Clash", new HashSet<string> { "Apprentice", "Master" } },
            { "Confluence", new HashSet<string> { "Rift Lord" } },
            { "Crogon Keep", new HashSet<string> { "War Mage", "Master", "Rift Lord" } },
            { "Docks at Eventide", new HashSet<string> { "Master" } },
            { "Eventide Fortress", new HashSet<string> { "Rift Lord" } },
            { "Eventide Ramparts", new HashSet<string> {"Apprentice", "War Mage" } },
            { "Frostbite", new HashSet<string> { "Master", "Rift Lord" } },
            { "Gates of Thuricvod", new HashSet<string> { "War Mage", "Rift Lord" } },
            { "Highlands", new HashSet<string> { "Apprentice", "War Mage", "Rift Lord" } },
            { "Maximum Security", new HashSet<string> { "Rift Lord" } },
            { "Midnight Market", new HashSet<string> { "War Mage", "Rift Lord" } },
            { "Orcatraz", new HashSet<string> { "Master" } },
            { "Orcri-La", new HashSet<string> { "Master" } },
            { "Restricted Section", new HashSet<string> { "War Mage", "Rift Lord" } },
            { "Riftmaker's Temple", new HashSet<string> { "Apprentice" } },
            { "Shark Island", new HashSet<string> { "War Mage", "Master" } },
            { "Stables at Eventide", new HashSet<string> { "War Mage", "Master" } },
            { "Storm Drain", new HashSet<string> { "Master" } },
            { "Temple Graveyard", new HashSet<string> { "War Mage", "Rift Lord" } },
            { "The Baths", new HashSet<string> { "Apprentice", "Rift Lord" } },
            { "The Falling Folly", new HashSet<string> { "Master" } },
            { "The Wall", new HashSet<string> { "War Mage", "Master" } },
            { "Throne Room", new HashSet<string> { "Apprentice", "War Mage", "Rift Lord" } },
            { "Thuricvod Village", new HashSet<string> { "War Mage" } },
            { "Training Grounds", new HashSet<string> { "Apprentice", "War Mage", "Master" } },
            { "Unchained Fortress", new HashSet<string> { "Apprentice", "Master" } },
            { "Water Garden", new HashSet<string> { "Apprentice", "Master" } }
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
            { "Endless+", "20" },
            { "Endless++", "40" },
            { "Endless+3", "60" },
            { "Endless+4", "80" },
            { "Endless+5", "100" },
            { "Endless+6", "120" },
            { "Endless+7", "140" },
            { "Endless+8", "160" },
            { "Endless+9", "180" },
            { "Endless+10", "200" }
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
                    { "Master+" , new int[] { 6, 26 } },
                    { "Master++" , new int[] { 1, 45 } }
                }
            },
            { "Rift Lord", new Dictionary<string, int[]>
                {
                    { "Rift Lord+" , new int[] { 26, 46 } },
                    { "Rift Lord++" , new int[] { 6, 46 } },
                    { "Rift Lord+3" , new int[] { 1, 61 } },
                    { "Rift Lord+4" , new int[] { 1, 75 } }
                }
            }
        };

        // Dyes (Name, IdxDye)
        public static Dictionary<string, string> dyes = new Dictionary<string, string>
        {
            { "Normal", "0" },
            { "Heroic", "1" },
            { "Legendary", "2" }
        };


        // Skins
        public static Dictionary<string, Dictionary<string, byte[]>> skins = new Dictionary<string, Dictionary<string, byte[]>>
        {
            { "Maximilian", new Dictionary<string, byte[]>
                {
                    { "Lucky Tunic" , new byte[] { 0x4A, 0xE0, 0x00, 0x00 } },
                    { "Enchanted Armor" , new byte[] { 0x4C, 0xE0, 0x00, 0x00 } },
                    { "Knight's Watch" , new byte[] { 0x4E, 0xE0, 0x00, 0x00 } },
                    { "Default" , new byte[] { 0x50, 0xE0, 0x00, 0x00 } },
                    { "Orc Slayer" , new byte[] { 0x52, 0xE0, 0x00, 0x00 } },
                    { "Cardboard Samurai" , new byte[] { 0x54, 0xE0, 0x00, 0x00 } },
                    { "Scared-Crow" , new byte[] { 0x56, 0xE0, 0x00, 0x00 } },
                    { "Lion Heart" , new byte[] { 0x58, 0xE0, 0x00, 0x00 } },
                    { "Robin Hood" , new byte[] { 0x5A, 0xE0, 0x00, 0x00 } },
                    { "Paximillian" , new byte[] { 0x5C, 0xE0, 0x00, 0x00 } },
                    { "Legendary (default)" , new byte[] { 0x5E, 0xE0, 0x00, 0x00 } },
                    { "Champion of the Order" , new byte[] { 0x60, 0xE0, 0x00, 0x00 } },
                    { "Jamez Ripher" , new byte[] { 0x62, 0xE0, 0x00, 0x00 } },
                    { "Winter Warrior" , new byte[] { 0x64, 0xE0, 0x00, 0x00 } },
                    { "Boomstick" , new byte[] { 0x66, 0xE0, 0x00, 0x00 } },
                    { "Backdraft" , new byte[] { 0x68, 0xE0, 0x00, 0x00 } },
                    { "Dragon Slayer" , new byte[] { 0x6A, 0xE0, 0x00, 0x00 } },
                    { "Summer of Stunning" , new byte[] { 0x6C, 0xE0, 0x00, 0x00 } },
                    { "Red Scarf (China Ad)" , new byte[] { 0x6E, 0xE0, 0x00, 0x00 } },
                    { "Yellow Scarf (China Ad)" , new byte[] { 0x70, 0xE0, 0x00, 0x00 } },
                    { "Blue Scarf (China Ad)" , new byte[] { 0x72, 0xE0, 0x00, 0x00 } }
                }
            },
            { "Bionka", new Dictionary<string, byte[]>
                {
                    { "Default", new byte[] { 0x54, 0xDF, 0x00, 0x00 } },
                    { "Lizard Queen", new byte[] { 0x56, 0xDF, 0x00, 0x00 } },
                    { "Fluffalump", new byte[] { 0x58, 0xDF, 0x00, 0x00 } },
                    { "Bionka Bunny", new byte[] { 0x5A, 0xDF, 0x00, 0x00 } }
                }
            },
            { "Brass", new Dictionary<string, byte[]>
                {
                    { "Default", new byte[] { 0x7A, 0xDF, 0x00, 0x00 } },
                    { "Guns, Gears, 'n Lace", new byte[] { 0x7C, 0xDF, 0x00, 0x00 } },
                    { "Bombshell Battalion", new byte[] { 0x7E, 0xDF, 0x00, 0x00 } }
                }
            },
            { "Hogarth", new Dictionary<string, byte[]>
                {
                    { "Enchanted Armor", new byte[] { 0x8C, 0xDF, 0x00, 0x00 } },
                    { "God of Plunder", new byte[] { 0x8E, 0xDF, 0x00, 0x00 } },
                    { "Default", new byte[] { 0x90, 0xDF, 0x00, 0x00 } },
                    { "Lumbering Jack", new byte[] { 0x92, 0xDF, 0x00, 0x00 } },
                    { "Default (with some gold)", new byte[] { 0x94, 0xDF, 0x00, 0x00 } },
                    { "Ice Armor", new byte[] { 0x96, 0xDF, 0x00, 0x00 } },
                    { "Imperial Golden Warrior", new byte[] { 0x98, 0xDF, 0x00, 0x00 } },
                    { "Beached Bod", new byte[] { 0x9A, 0xDF, 0x00, 0x00 } },
                    { "*crashed*", new byte[] { 0x9C, 0xDF, 0x00, 0x00 } },
                    { "Black Thane", new byte[] { 0x9E, 0xDF, 0x00, 0x00 } },
                    { "The Schling", new byte[] { 0xA0, 0xDF, 0x00, 0x00 } },
                    { "Dragon Ward", new byte[] { 0xA2, 0xDF, 0x00, 0x00 } }
                }
            },
            { "Ivy", new Dictionary<string, byte[]>
                {
                    { "Enchanted Armor", new byte[] { 0xDA, 0xDF, 0x00, 0x00 } },
                    { "Valkyrie", new byte[] { 0xDC, 0xDF, 0x00, 0x00 } },
                    { "Default", new byte[] { 0xDE, 0xDF, 0x00, 0x00 } },
                    { "Flower Friend", new byte[] { 0xE0, 0xDF, 0x00, 0x00 } },
                    { "Default (with some gold)", new byte[] { 0xE2, 0xDF, 0x00, 0x00 } },
                    { "Imperial Ruby Archer", new byte[] { 0xE4, 0xDF, 0x00, 0x00 } },
                    { "*crashed*", new byte[] { 0xE6, 0xDF, 0x00, 0x00 } },
                    { "Wicked Warden", new byte[] { 0xE8, 0xDF, 0x00, 0x00 } },
                    { "Grovewatch", new byte[] { 0xEA, 0xDF, 0x00, 0x00 } },
                    { "Dragon Tamer", new byte[] { 0xEC, 0xDF, 0x00, 0x00 } }
                }
            },
            { "Smolder", new Dictionary<string, byte[]>
                {
                    { "Default", new byte[] { 0xF2, 0xDF, 0x00, 0x00 } },
                    { "Helter Swelter", new byte[] { 0xF4, 0xDF, 0x00, 0x00 } },
                    { "Default (White hair)", new byte[] { 0xF6, 0xDF, 0x00, 0x00 } },
                    { "Elite", new byte[] { 0xF8, 0xDF, 0x00, 0x00 } },
                    { "Kill-auea", new byte[] { 0xFA, 0xDF, 0x00, 0x00 } },
                    { "Fire-Alarm Femme", new byte[] { 0xFC, 0xDF, 0x00, 0x00 } },
                    { "Firestarter", new byte[] { 0xFE, 0xDF, 0x00, 0x00 } },
                    { "Wu Xing Dragon Mage", new byte[] { 0x00, 0xE0, 0x00, 0x00 } }
                }
            },
            { "Gabriella", new Dictionary<string, byte[]>
                {
                    { "Violent Vintage", new byte[] { 0x02, 0xE0, 0x00, 0x00 } },
                    { "Enchanted Armor", new byte[] { 0x04, 0xE0, 0x00, 0x00 } },
                    { "Blood Queen", new byte[] { 0x06, 0xE0, 0x00, 0x00 } },
                    { "Default", new byte[] { 0x08, 0xE0, 0x00, 0x00 } },
                    { "Frightfully Delightful", new byte[] { 0x0A, 0xE0, 0x00, 0x00 } },
                    { "Default (Red)", new byte[] { 0x0C, 0xE0, 0x00, 0x00 } },
                    { "Life In Plastic", new byte[] { 0x0E, 0xE0, 0x00, 0x00 } },
                    { "Archmage of the Order", new byte[] { 0x10, 0xE0, 0x00, 0x00 } },
                    { "Mistress of Illusion", new byte[] { 0x12, 0xE0, 0x00, 0x00 } },
                    { "Promising Prodigy", new byte[] { 0x14, 0xE0, 0x00, 0x00 } },
                    { "I Dream of Gabby", new byte[] { 0x16, 0xE0, 0x00, 0x00 } },
                    { "Miracle Worker", new byte[] { 0x18, 0xE0, 0x00, 0x00 } },
                    { "Winter Witch", new byte[] { 0x1A, 0xE0, 0x00, 0x00 } },
                    { "Skull Ninja", new byte[] { 0x1C, 0xE0, 0x00, 0x00 } },
                    { "Evil Ways", new byte[] { 0x1E, 0xE0, 0x00, 0x00 } },
                    { "Dragon Charmer", new byte[] { 0x20, 0xE0, 0x00, 0x00 } }
                }
            }
        };

        public static HashSet<string> startingCoin9000Maps = new HashSet<string> {
            "Academy Sewers",
            "Archmage Library",
            "Avalanche",
            "Banquet Hall",
            "Cliffside Clash",
            "Confluence",
            "Crogon Keep",
            "Docks at Eventide",
            "Eventide Fortress",
            "Eventide Ramparts",
            "Frostbite",
            "Gates of Thuricvod",
            "Highlands",
            "Maximum Security",
            "Orcatraz",
            "Orcri-La",
            "Restricted Section",
            "Shark Island",
            "Stables at Eventide",
            "Storm Drain",
            "Temple Graveyard",
            "The Falling Folly",
            "The Wall",
            "Throne Room",
            "Thuricvod Village",
            "Training Grounds",
            "Unchained Fortress",
        };

        public static HashSet<string> startingCoin6000Maps = new HashSet<string> {            
            "Castle Gates",
            "Midnight Market",
            "Riftmaker's Temple",
            "The Baths",
            "Water Garden"
        };
    }
}
