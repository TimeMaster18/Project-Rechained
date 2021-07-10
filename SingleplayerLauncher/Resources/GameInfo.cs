using System.Collections.Generic;

namespace SingleplayerLauncher.Resources
{
    public class Tuple<T1, T2>
    {
        public T1 First { get; private set; }
        public T2 Second { get; private set; }
        internal Tuple(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }
    }

    public static class Tuple
    {
        public static Tuple<T1, T2> New<T1, T2>(T1 first, T2 second)
        {
            Tuple<T1, T2> tuple = new Tuple<T1, T2>(first, second);
            return tuple;
        }
    }





    internal static class GameInfo
    {

        public class Map
        {
            public string Name;
            public string[] SurvivalDifficulties;
            public Map(string name, string[] survivalDifficulties)
            {
                Name = name;
                SurvivalDifficulties = survivalDifficulties;
            }
        }

        public class Hero
        {
            public string Name;
            public Dictionary<string, Skin> Skins;
            public int BaseHealth;
            public Hero(string name, Dictionary<string, Skin> skins, int baseHealth)
            {
                Name = name;
                Skins = skins;
                BaseHealth = baseHealth;
            }

            public byte[] GetSkinHex(string skinName)
            {
                return Skins[skinName].HexSpitfireGameUPK;
            }
        }

        public class Skin
        {
            public string Name;
            public byte[] HexSpitfireGameUPK;
            public Skin(string name, byte[] hexSpitfireGameUPK)
            {
                Name = name;
                HexSpitfireGameUPK = hexSpitfireGameUPK;
            }
        }

        public static Dictionary<string, Hero> Heroes = new Dictionary<string, Hero>
        {
            { "Bionka", new Hero( "Bionka", new Dictionary<string, Skin> {
                                                        { "Default", new Skin("Default", new byte[] { 0x54, 0xDF, 0x00, 0x00 } ) },
                                                        { "Lizard Queen", new Skin("Lizard Queen", new byte[] { 0x56, 0xDF, 0x00, 0x00 } ) },
                                                        { "Fluffalump", new Skin("Fluffalump", new byte[] { 0x58, 0xDF, 0x00, 0x00 } ) },
                                                        { "Bionka Bunny", new Skin("Bionka Bunny", new byte[] { 0x5A, 0xDF, 0x00, 0x00 } ) }
                                                     },
                625)
            },
            { "Blackpaw", new Hero("Blackpaw", null, 341) },
            { "Bloodspike", new Hero("Bloodspike", null, 600) },
            { "Brass", new Hero("Brass", null, 350) },
            { "Cygnus", new Hero("Cygnus", null, 215) },
            { "Deadeye", new Hero("Deadeye", null, 219) },
            { "Dobbin", new Hero("Dobbin", null, 500) },
            { "Gabriella", new Hero( "Gabriella", new Dictionary<string, Skin> {
                                                        { "Violent Vintage", new Skin("Violent Vintage", new byte[] { 0x02, 0xE0, 0x00, 0x00 } ) },
                                                        { "Enchanted Armor", new Skin("Enchanted Armor", new byte[] { 0x04, 0xE0, 0x00, 0x00 } ) },
                                                        { "Blood Queen", new Skin("Blood Queen", new byte[] { 0x06, 0xE0, 0x00, 0x00 } ) },
                                                        { "Default", new Skin("Default", new byte[] { 0x08, 0xE0, 0x00, 0x00 } ) },
                                                        { "Frightfully Delightful", new Skin("Frightfully Delightful", new byte[] { 0x0A, 0xE0, 0x00, 0x00 } ) },
                                                        { "Default (Red)", new Skin("Default (Red)", new byte[] { 0x0C, 0xE0, 0x00, 0x00 } ) },
                                                        { "Life In Plastic", new Skin("Life In Plastic", new byte[] { 0x0E, 0xE0, 0x00, 0x00 } ) },
                                                        { "Archmage of the Order", new Skin("Archmage of the Order", new byte[] { 0x10, 0xE0, 0x00, 0x00 } ) },
                                                        { "Mistress of Illusion", new Skin("Mistress of Illusion", new byte[] { 0x12, 0xE0, 0x00, 0x00 } ) },
                                                        { "Promising Prodigy", new Skin("Promising Prodigy", new byte[] { 0x14, 0xE0, 0x00, 0x00 } ) },
                                                        { "I Dream of Gabby", new Skin("I Dream of Gabby", new byte[] { 0x16, 0xE0, 0x00, 0x00 } ) },
                                                        { "Miracle Worker", new Skin("Miracle Worker", new byte[] { 0x18, 0xE0, 0x00, 0x00 } ) },
                                                        { "Winter Witch", new Skin("Winter Witch", new byte[] { 0x1A, 0xE0, 0x00, 0x00 } ) },
                                                        { "Skull Ninja", new Skin("Skull Ninja", new byte[] { 0x1C, 0xE0, 0x00, 0x00 } ) },
                                                        { "Evil Ways", new Skin("Evil Ways", new byte[] { 0x1E, 0xE0, 0x00, 0x00 } ) },
                                                        { "Dragon Charmer", new Skin("Dragon Charmer", new byte[] { 0x20, 0xE0, 0x00, 0x00 } ) },
                                                        { "Chang'e", new Skin("Chang'e", new byte[] { 0x80, 0xDF, 0x00, 0x00 } ) }
                                                    },
                200)
            },
            { "Hogarth", new Hero( "Hogarth", new Dictionary<string, Skin> {
                                                        { "Enchanted Armor", new Skin("Enchanted Armor", new byte[] { 0x8C, 0xDF, 0x00, 0x00 } ) },
                                                        { "God of Plunder", new Skin("God of Plunder", new byte[] { 0x8E, 0xDF, 0x00, 0x00 } ) },
                                                        { "Default", new Skin("Default", new byte[] { 0x90, 0xDF, 0x00, 0x00 } ) },
                                                        { "Lumbering Jack", new Skin("Lumbering Jack", new byte[] { 0x92, 0xDF, 0x00, 0x00 } ) },
                                                        { "Default (with some gold)", new Skin("Default (with some gold)", new byte[] { 0x94, 0xDF, 0x00, 0x00 } ) },
                                                        { "Ice Armor", new Skin("Ice Armor", new byte[] { 0x96, 0xDF, 0x00, 0x00 } ) },
                                                        { "Imperial Golden Warrior", new Skin("Imperial Golden Warrior", new byte[] { 0x98, 0xDF, 0x00, 0x00 } ) },
                                                        { "Beached Bod", new Skin("Beached Bod", new byte[] { 0x9A, 0xDF, 0x00, 0x00 } ) },
                                                        //{ "*crashed*", new Skin("*crashed*", new byte[] { 0x9C, 0xDF, 0x00, 0x00 } ) },
                                                        { "Black Thane", new Skin("Black Thane", new byte[] { 0x9E, 0xDF, 0x00, 0x00 } ) },
                                                        { "The Schling", new Skin("The Schling", new byte[] { 0xA0, 0xDF, 0x00, 0x00 } ) },
                                                        { "Dragon Ward", new Skin("Dragon Ward", new byte[] { 0xA2, 0xDF, 0x00, 0x00 } ) }
                                                    },
                950)
            },
            { "Ivy", new Hero( "Ivy", new Dictionary<string, Skin> {
                                                        { "Enchanted Armor", new Skin("Enchanted Armor", new byte[] { 0xDA, 0xDF, 0x00, 0x00 } ) },
                                                        { "Valkyrie", new Skin("Valkyrie", new byte[] { 0xDC, 0xDF, 0x00, 0x00 } ) },
                                                        { "Default", new Skin("Default", new byte[] { 0xDE, 0xDF, 0x00, 0x00 } ) },
                                                        { "Flower Friend", new Skin("Flower Friend", new byte[] { 0xE0, 0xDF, 0x00, 0x00 } ) },
                                                        { "Default (with some gold)", new Skin("Default (with some gold)", new byte[] { 0xE2, 0xDF, 0x00, 0x00 } ) },
                                                        { "Imperial Ruby Archer", new Skin("Imperial Ruby Archer", new byte[] { 0xE4, 0xDF, 0x00, 0x00 } ) },
                                                        //{ "*crashed*", new Skin("*crashed*", new byte[] { 0xE6, 0xDF, 0x00, 0x00 } ) },
                                                        { "Wicked Warden", new Skin("Wicked Warden", new byte[] { 0xE8, 0xDF, 0x00, 0x00 } ) },
                                                        { "Grovewatch", new Skin("Grovewatch", new byte[] { 0xEA, 0xDF, 0x00, 0x00 } ) },
                                                        { "Dragon Tamer", new Skin("Dragon Tamer", new byte[] { 0xEC, 0xDF, 0x00, 0x00 } ) }
                                                    },
                162)
            },
            { "Maximilian", new Hero("Maximilian", new Dictionary<string, Skin> {
                                                        { "Lucky Tunic" , new Skin("Lucky Tunic" , new byte[] { 0x4A, 0xE0, 0x00, 0x00 } ) },
                                                        { "Enchanted Armor" , new Skin("Enchanted Armor" , new byte[] { 0x4C, 0xE0, 0x00, 0x00 } ) },
                                                        { "Knight's Watch" , new Skin("Knight's Watch" , new byte[] { 0x4E, 0xE0, 0x00, 0x00 } ) },
                                                        { "Default" , new Skin("Default" , new byte[] { 0x50, 0xE0, 0x00, 0x00 } ) },
                                                        { "Orc Slayer" , new Skin("Orc Slayer" , new byte[] { 0x52, 0xE0, 0x00, 0x00 } ) },
                                                        { "Cardboard Samurai" , new Skin("Cardboard Samurai" , new byte[] { 0x54, 0xE0, 0x00, 0x00 } ) },
                                                        { "Scared-Crow" , new Skin("Scared-Crow" , new byte[] { 0x56, 0xE0, 0x00, 0x00 } ) },
                                                        { "Lion Heart" , new Skin("Lion Heart" , new byte[] { 0x58, 0xE0, 0x00, 0x00 } ) },
                                                        { "Robin Hood" , new Skin("Robin Hood" , new byte[] { 0x5A, 0xE0, 0x00, 0x00 } ) },
                                                        { "Paximillian" , new Skin("Paximillian" , new byte[] { 0x5C, 0xE0, 0x00, 0x00 } ) },
                                                        { "Legendary (default)" , new Skin("Legendary (default)" , new byte[] { 0x5E, 0xE0, 0x00, 0x00 } ) },
                                                        { "Champion of the Order" , new Skin("Champion of the Order" , new byte[] { 0x60, 0xE0, 0x00, 0x00 } ) },
                                                        { "Jamez Ripher" , new Skin("Jamez Ripher" , new byte[] { 0x62, 0xE0, 0x00, 0x00 } ) },
                                                        { "Winter Warrior" , new Skin("Winter Warrior" , new byte[] { 0x64, 0xE0, 0x00, 0x00 } ) },
                                                        { "Boomstick" , new Skin("Boomstick" , new byte[] { 0x66, 0xE0, 0x00, 0x00 } ) },
                                                        { "Backdraft" , new Skin("Backdraft" , new byte[] { 0x68, 0xE0, 0x00, 0x00 } ) },
                                                        { "Dragon Slayer" , new Skin("Dragon Slayer" , new byte[] { 0x6A, 0xE0, 0x00, 0x00 } ) },
                                                        { "Summer of Stunning" , new Skin("Summer of Stunning" , new byte[] { 0x6C, 0xE0, 0x00, 0x00 } ) },
                                                        { "Red Scarf (China Ad)" , new Skin("Red Scarf (China Ad)" , new byte[] { 0x6E, 0xE0, 0x00, 0x00 } ) },
                                                        { "Yellow Scarf (China Ad)" , new Skin("Yellow Scarf (China Ad)" , new byte[] { 0x70, 0xE0, 0x00, 0x00 } ) },
                                                        { "Blue Scarf (China Ad)" , new Skin("Blue Scarf (China Ad)" , new byte[] { 0x72, 0xE0, 0x00, 0x00 } ) }
                                                     },
                206)
            },
            { "Midnight", new Hero("Midnight", null, 220) },
            { "Oziel", new Hero("Oziel", null, 200) },
            { "Smolder", new Hero( "Smolder", new Dictionary<string, Skin> {
                                                        { "Default", new Skin("Default", new byte[] { 0xF2, 0xDF, 0x00, 0x00 } ) },
                                                        { "Helter Swelter", new Skin("Helter Swelter", new byte[] { 0xF4, 0xDF, 0x00, 0x00 } ) },
                                                        { "Default (White hair)", new Skin("Default (White hair)", new byte[] { 0xF6, 0xDF, 0x00, 0x00 } ) },
                                                        { "Elite", new Skin("Elite", new byte[] { 0xF8, 0xDF, 0x00, 0x00 } ) },
                                                        { "Kill-auea", new Skin("Kill-auea", new byte[] { 0xFA, 0xDF, 0x00, 0x00 } ) },
                                                        { "Fire-Alarm Femme", new Skin("Fire-Alarm Femme", new byte[] { 0xFC, 0xDF, 0x00, 0x00 } ) },
                                                        { "Firestarter", new Skin("Firestarter", new byte[] { 0xFE, 0xDF, 0x00, 0x00 } ) },
                                                        { "Wu Xing Dragon Mage", new Skin("Wu Xing Dragon Mage", new byte[] { 0x00, 0xE0, 0x00, 0x00 } ) }
                                                    },
                313)
            },
            { "Stinkeye", new Hero("Stinkeye", null, 356) },
            { "Temper", new Hero("Temper", null, 500) },
            { "Tundra", new Hero("Tundra", null, 625) },
            { "Yi-Lin", new Hero("Yi-Lin", null, 250) },
            { "Zoey", new Hero("Zoey", null, 275) }
        };

        // Maps { Name, umap }
        public static Dictionary<string, Map> Maps = new Dictionary<string, Map>
        {
            { "Academy Sewers", new Map("Academy Sewers", new string[] { "Rift Lord" } ) },
            { "Archmage Library", new Map("Archmage Library", new string[] {"Apprentice" } ) },
            { "Avalanche",  new Map("Avalanche", new string[] { "Master", "Rift Lord" } ) },
            { "Banquet Hall", new Map("Banquet Hall", new string[] { "Apprentice", "War Mage", "Rift Lord" } ) },
            { "Castle Gates", new Map("Castle Gates", new string[] { "Master", "Rift Lord" } ) },
            { "Cliffside Clash", new Map("Cliffside Clash", new string[] { "Apprentice", "Master" } ) },
            { "Confluence",  new Map("Confluence", new string[] { "Rift Lord" } ) },
            { "Crogon Keep", new Map("Crogon Keep", new string[] { "War Mage", "Master", "Rift Lord" } ) },
            { "Docks at Eventide", new Map("Docks at Eventide", new string[] { "Master" } ) },
            { "Eventide Fortress", new Map("Eventide Fortress", new string[] { "Rift Lord" } ) },
            { "Eventide Ramparts", new Map("Eventide Ramparts", new string[] {"Apprentice", "War Mage" } ) },
            { "Frostbite",  new Map("Frostbite", new string[] { "Master", "Rift Lord" } ) },
            { "Gates of Thuricvod", new Map("Gates of Thuricvod", new string[] { "War Mage", "Rift Lord" } ) },
            { "Highlands",  new Map("Highlands", new string[] { "Apprentice", "War Mage", "Rift Lord" } ) },
            { "Maximum Security", new Map("Maximum Security", new string[] { "Rift Lord" } ) },
            { "Midnight Market", new Map("Midnight Market", new string[] { "War Mage", "Rift Lord" } ) },
            { "Orcatraz",  new Map("Orcatraz", new string[] { "Master" } ) },
            { "Orcri-La", new Map("Orcri-La", new string[] { "Master" } ) },
            { "Restricted Section", new Map("Restricted Section", new string[] { "War Mage", "Rift Lord" } ) },
            { "Riftmaker's Temple", new Map("Riftmaker's Temple", new string[] { "Apprentice" } ) },
            { "Shark Island", new Map("Shark Island", new string[] { "War Mage", "Master" } ) },
            { "Stables at Eventide", new Map("Stables at Eventide", new string[] { "War Mage", "Master" } ) },
            { "Storm Drain", new Map("Storm Drain", new string[] { "Master" } ) },
            { "Temple Graveyard", new Map("Temple Graveyard", new string[] { "War Mage", "Rift Lord" } ) },
            { "The Baths", new Map("The Baths", new string[] { "Apprentice", "Rift Lord" } ) },
            { "The Falling Folly", new Map("The Falling Folly", new string[] { "Master" } ) },
            { "The Wall", new Map("The Wall", new string[] { "War Mage", "Master" } ) },
            { "Throne Room", new Map("Throne Room", new string[] { "Apprentice", "War Mage", "Rift Lord" } ) },
            { "Thuricvod Village", new Map("Thuricvod Village", new string[] { "War Mage" } ) },
            { "Training Grounds", new Map("Training Grounds", new string[] { "Apprentice", "War Mage", "Master" } ) },
            { "Unchained Fortress", new Map("Unchained Fortress", new string[] { "Apprentice", "Master" } ) },
            { "Water Garden", new Map("Water Garden", new string[] { "Apprentice", "Master" }) }
        };

        public static HashSet<string> startingCoin9000Maps = new HashSet<string>
        {
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

        public static HashSet<string> startingCoin6000Maps = new HashSet<string>
        {
            "Castle Gates",
            "Midnight Market",
            "Riftmaker's Temple",
            "The Baths",
            "Water Garden"
        };

        public static Dictionary<string, int> DifficultyTrapTierMap = new Dictionary<string, int>
        {
            { "Apprentice", 1 },
            { "War Mage", 2 },
            { "Master", 4 },
            { "Rift Lord", 6 }
        };
    }
}
