using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SingleplayerLauncher
{

    internal static class Resources
    {
        //Initialize Dictionaries that maps name to hex values (hex offset within SpitfireGame.upk)

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
            { "Yi-Lin", "PawnWeapon_hooksword.hooksword" },
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
            { "Riftmaker's Temple (Snow Temple Graveyard Prologue)", "PvE_AcademyTemple.umap" },
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
            { "SpitfireFrontEndMap", "SpitfireFrontEndMap.umap" },
            { "Survival Tutorial", "TutorialSurvival.umap" },
            { "Basics Tutorial", "NewbieTutorial.umap" }
        };


        // Dyes (Name, IdxDye)
        public static Dictionary<string, string> dyes = new Dictionary<string, string>
        {
            { "Normal", "0" },
            { "Heroic", "1" },
            { "Legendary", "2" }
        };






    }
}
