using System.Collections.Generic;
using static SingleplayerLauncher.Names.Hero;

namespace SingleplayerLauncher.Model
{
    public class Hero
    {
        public string Name { get; private set; }
        public Skin[] Skins { get; private set; }
        public int BaseHealth { get; private set; }
        public string PawnWeaponString { get; private set; }

        public string UPKFileName { get; private set; }

        public int UPKFileHeroObjectOffset { get; private set; }
        public int UPKFileHeroObjectSize { get; private set; }
        public UPKFile.Section[] ToRemoveSections { get; private set; }

        public UPKFile.Section Health { get; private set; }
        public UPKFile.Section MaxHealth { get; private set; }
        public UPKFile.Section CurrentSkinClass { get; private set; }
        public UPKFile.Section DefaultGuardianArchetypes { get; private set; }
        public UPKFile.Section DefaultInventoryClasses { get; private set; }
        public UPKFile.Section DefaultInventoryArchetypes { get; private set; }

        // private constructor
        Hero() { }

        // static members
        public static Hero Bionka = new Hero()
        {
            Name = BIONKA,
            BaseHealth = 625,
            Skins = Skin.BionkaSkins,
            PawnWeaponString = "PawnWeapon_Bionka.Pawn_Bionka",
            UPKFileName = "SpitfireGame.upk",
            UPKFileHeroObjectOffset = 0x28a992b,
            UPKFileHeroObjectSize = 1388,
            ToRemoveSections = new UPKFile.Section[] {  new UPKFile.Section("ObjectStrategicRole", 40, new byte[] {  0x74, 0xA3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectDefaultRoleClass", 28, new byte[] {   0xE4, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectBeginStealthClientSegment", 28, new byte[] {  0x5F, 0x0D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectEndStealthClientSegment", 28, new byte[] {    0xA6, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectTeamStealthSegment", 28, new byte[] { 0x09, 0xA7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectNetRelComponent", 28, new byte[] {    0xF9, 0x63, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectActionManager", 28, new byte[] {  0x8D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectmAIResponsiveBehaviors", 52, new byte[] { 0x82, 0x54, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),   },
            DefaultInventoryArchetypes = new UPKFile.Section("DefaultInventoryArchetypes", 32, new byte[] { 0xC5, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultInventoryClasses = new UPKFile.Section("DefaultInventoryClasses", null, new byte[] { 0xC6, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultGuardianArchetypes = new UPKFile.Section("DefaultGuardianArchetypes", null, new byte[] { 0xBA, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            CurrentSkinClass = new UPKFile.Section("CurrentSkinClass", null, new byte[] { 0x52, 0x1E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x8D, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            MaxHealth = new UPKFile.Section("HealthMax", null, new byte[] { 0x9E, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
        };
        public static Hero Blackpaw = new Hero()
        {
            Name = BLACKPAW,
            BaseHealth = 341,
            Skins = Skin.BlackpawSkins,
            PawnWeaponString = "PawnWeapon_Blackpaw.Pawn_Blackpaw",
        };
        public static Hero Bloodspike = new Hero()
        {
            Name = BLOODSPIKE,
            BaseHealth = 600,
            Skins = Skin.BloodspikeSkins,
            PawnWeaponString = "PawnWeapon_Bloodspike.Pawn_Bloodspike",
        };
        public static Hero Brass = new Hero()
        {
            Name = BRASS,
            BaseHealth = 350,
            Skins = Skin.BrassSkins,
            PawnWeaponString = "PawnWeapon_Brass.Pawn_Brass",
        };
        public static Hero Cygnus = new Hero()
        {
            Name = CYGNUS,
            BaseHealth = 215,
            Skins = Skin.CygnusSkins,
            PawnWeaponString = "PawnWeapon_Cygnus.Pawn_Cygnus",
        };
        public static Hero Deadeye = new Hero()
        {
            Name = DEADEYE,
            BaseHealth = 219,
            Skins = Skin.DeadeyeSkins,
            PawnWeaponString = "PawnWeapon_Deadeye.Pawn_Deadeye",
        };
        public static Hero Dobbin = new Hero()
        {
            Name = DOBBIN,
            BaseHealth = 500,
            Skins = Skin.DobbinSkins,
            PawnWeaponString = "PawnWeapon_Dobbin.Pawn_Dobbin",
        };
        public static Hero Gabriella = new Hero()
        {
            Name = GABRIELLA,
            BaseHealth = 200,
            Skins = Skin.GabriellaSkins,
            PawnWeaponString = "PawnWeapon_Sorceress.Pawn_Sorceress",
            UPKFileName = "SpitfireGame.upk",
            UPKFileHeroObjectOffset = 0x28aaf49,
            UPKFileHeroObjectSize = 1356,
            ToRemoveSections = new UPKFile.Section[] {  new UPKFile.Section("ObjectStrategicRole", 40, new byte[] {  0x74, 0xA3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectDefaultRoleClass", 28, new byte[] {   0xE4, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectBeginStealthClientSegment", 28, new byte[] {  0x5F, 0x0D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectEndStealthClientSegment", 28, new byte[] {    0xA6, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectTeamStealthSegment", 28, new byte[] { 0x09, 0xA7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectNetRelComponent", 28, new byte[] {    0xF9, 0x63, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectActionManager", 28, new byte[] {  0x8D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectmAIResponsiveBehaviors", 52, new byte[] { 0x82, 0x54, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),   },
            DefaultInventoryArchetypes = new UPKFile.Section("DefaultInventoryArchetypes", 32, new byte[] { 0xC5, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultInventoryClasses = new UPKFile.Section("DefaultInventoryClasses", null, new byte[] { 0xC6, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultGuardianArchetypes = new UPKFile.Section("DefaultGuardianArchetypes", null, new byte[] { 0xBA, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            CurrentSkinClass = new UPKFile.Section("CurrentSkinClass", null, new byte[] { 0x52, 0x1E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x8D, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            MaxHealth = new UPKFile.Section("HealthMax", null, new byte[] { 0x9E, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
        };
        public static Hero Hogarth = new Hero()
        {
            Name = HOGARTH,
            BaseHealth = 950,
            Skins = Skin.HogarthSkins,
            PawnWeaponString = "PawnWeapon_Hogarth.Pawn_Hogarth",
            UPKFileName = "SpitfireGame.upk",
            UPKFileHeroObjectOffset = 0x28a9e97,
            UPKFileHeroObjectSize = 1505,
            ToRemoveSections = new UPKFile.Section[] {  new UPKFile.Section("ObjectStrategicRole", 40, new byte[] {  0x74, 0xA3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectDefaultRoleClass", 28, new byte[] {   0xE4, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectBeginStealthClientSegment", 28, new byte[] {  0x5F, 0x0D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectEndStealthClientSegment", 28, new byte[] {    0xA6, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectTeamStealthSegment", 28, new byte[] { 0x09, 0xA7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectNetRelComponent", 28, new byte[] {    0xF9, 0x63, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectActionManager", 28, new byte[] {  0x8D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectmAIResponsiveBehaviors", 52, new byte[] { 0x82, 0x54, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),   },
            DefaultInventoryArchetypes = new UPKFile.Section("DefaultInventoryArchetypes", 32, new byte[] { 0xC5, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultInventoryClasses = new UPKFile.Section("DefaultInventoryClasses", null, new byte[] { 0xC6, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultGuardianArchetypes = new UPKFile.Section("DefaultGuardianArchetypes", null, new byte[] { 0xBA, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            CurrentSkinClass = new UPKFile.Section("CurrentSkinClass", null, new byte[] { 0x52, 0x1E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x8D, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            MaxHealth = new UPKFile.Section("HealthMax", null, new byte[] { 0x9E, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
        };
        public static Hero Ivy = new Hero()
        {
            Name = IVY,
            BaseHealth = 162,
            Skins = Skin.IvySkins,
            PawnWeaponString = "PawnWeapon_Ivy.Pawn_Ivy",
            UPKFileName = "SpitfireGame.upk",
            UPKFileHeroObjectOffset = 0x28aa478,
            UPKFileHeroObjectSize = 1372,
            ToRemoveSections = new UPKFile.Section[] {  new UPKFile.Section("ObjectStrategicRole", 40, new byte[] {  0x74, 0xA3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectDefaultRoleClass", 28, new byte[] {   0xE4, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectBeginStealthClientSegment", 28, new byte[] {  0x5F, 0x0D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectEndStealthClientSegment", 28, new byte[] {    0xA6, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectTeamStealthSegment", 28, new byte[] { 0x09, 0xA7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectNetRelComponent", 28, new byte[] {    0xF9, 0x63, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectActionManager", 28, new byte[] {  0x8D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectmAIResponsiveBehaviors", 52, new byte[] { 0x82, 0x54, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),   },
            DefaultInventoryArchetypes = new UPKFile.Section("DefaultInventoryArchetypes", 32, new byte[] { 0xC5, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultInventoryClasses = new UPKFile.Section("DefaultInventoryClasses", null, new byte[] { 0xC6, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultGuardianArchetypes = new UPKFile.Section("DefaultGuardianArchetypes", null, new byte[] { 0xBA, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            CurrentSkinClass = new UPKFile.Section("CurrentSkinClass", null, new byte[] { 0x52, 0x1E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x8D, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            MaxHealth = new UPKFile.Section("HealthMax", null, new byte[] { 0x9E, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
        };
        public static Hero Maximilian = new Hero()
        {
            Name = MAXIMILIAN,
            BaseHealth = 206,
            Skins = Skin.MaximilianSkins,
            PawnWeaponString = "PawnWeapon_Warmage.Pawn_Warmage",
            UPKFileName = "SpitfireGame.upk",
            UPKFileHeroObjectOffset = 0x28AB495,
            UPKFileHeroObjectSize = 1542,
            ToRemoveSections = new UPKFile.Section[] {  new UPKFile.Section("ObjectStrategicRole", 40, new byte[] {  0x74, 0xA3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectDefaultRoleClass", 28, new byte[] {   0xE4, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectNetRelComponent", 28, new byte[] {    0xF9, 0x63, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectActionManager", 28, new byte[] {  0x8D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectmAIResponsiveBehaviors", 52, new byte[] { 0x82, 0x54, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),   },
            DefaultInventoryArchetypes = new UPKFile.Section("DefaultInventoryArchetypes", 32, new byte[] { 0xC5, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultInventoryClasses = new UPKFile.Section("DefaultInventoryClasses", null, new byte[] { 0xC6, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultGuardianArchetypes = new UPKFile.Section("DefaultGuardianArchetypes", null, new byte[] { 0xBA, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            CurrentSkinClass = new UPKFile.Section("CurrentSkinClass", null, new byte[] { 0x52, 0x1E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x8D, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            MaxHealth = new UPKFile.Section("HealthMax", null, new byte[] { 0x9E, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
        };
        public static Hero Midnight = new Hero()
        {
            Name = MIDNIGHT,
            BaseHealth = 220,
            Skins = Skin.MidnightSkins,
            PawnWeaponString = "PawnWeapon_Midnight.Pawn_Midnight",
        };
        public static Hero Oziel = new Hero()
        {
            Name = OZIEL,
            BaseHealth = 200,
            Skins = Skin.OzielSkins,
            PawnWeaponString = "PawnWeapon_Oziel.Pawn_Oziel",
        };
        public static Hero Smolder = new Hero()
        {
            Name = SMOLDER,
            BaseHealth = 313,
            Skins = Skin.SmolderSkins,
            PawnWeaponString = "PawnWeapon_Smolder.Pawn_Smolder",
            UPKFileName = "SpitfireGame.upk",
            UPKFileHeroObjectOffset = 0x28aa9d4,
            UPKFileHeroObjectSize = 1397,
            ToRemoveSections = new UPKFile.Section[] {  new UPKFile.Section("ObjectStrategicRole", 40, new byte[] {  0x74, 0xA3, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectDefaultRoleClass", 28, new byte[] {   0xE4, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectBeginStealthClientSegment", 28, new byte[] {  0x5F, 0x0D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectEndStealthClientSegment", 28, new byte[] {    0xA6, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectTeamStealthSegment", 28, new byte[] { 0x09, 0xA7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectNetRelComponent", 28, new byte[] {    0xF9, 0x63, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectActionManager", 28, new byte[] {  0x8D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),
                                                        new UPKFile.Section("ObjectmAIResponsiveBehaviors", 52, new byte[] { 0x82, 0x54, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 } ),   },
            DefaultInventoryArchetypes = new UPKFile.Section("DefaultInventoryArchetypes", 32, new byte[] { 0xC5, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultInventoryClasses = new UPKFile.Section("DefaultInventoryClasses", null, new byte[] { 0xC6, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultGuardianArchetypes = new UPKFile.Section("DefaultGuardianArchetypes", null, new byte[] { 0xBA, 0x2C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            CurrentSkinClass = new UPKFile.Section("CurrentSkinClass", null, new byte[] { 0x52, 0x1E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x8D, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            MaxHealth = new UPKFile.Section("HealthMax", null, new byte[] { 0x9E, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
        };
        public static Hero Stinkeye = new Hero()
        {
            Name = STINKEYE,
            BaseHealth = 356,
            Skins = Skin.StinkeyeSkins,
            PawnWeaponString = "PawnWeapon_Stinkeye.Pawn_Stinkeye",
        };
        public static Hero Temper = new Hero()
        {
            Name = TEMPER,
            BaseHealth = 500,
            Skins = Skin.TemperSkins,
            PawnWeaponString = "PawnWeapon_Temper.Pawn_Temper",
        };
        public static Hero Tundra = new Hero()
        {
            Name = TUNDRA,
            BaseHealth = 625,
            Skins = Skin.TundraSkins,
            PawnWeaponString = "PawnWeapon_Tundra.Pawn_Tundra",
        };
        public static Hero YiLin = new Hero()
        {
            Name = YI_LIN,
            BaseHealth = 250,
            Skins = Skin.YiLinSkins,
            PawnWeaponString = "PawnWeapon_hooksword.Pawn_hooksword",
        };
        public static Hero Zoey = new Hero()
        {
            Name = ZOEY,
            BaseHealth = 275,
            Skins = Skin.ZoeySkins,
            PawnWeaponString = "PawnWeapon_Zoey.Pawn_Zoey",
        };

        public static Dictionary<string, Hero> Heroes = new Dictionary<string, Hero>
        {
            { BIONKA, Bionka },
            { BLACKPAW, Blackpaw },
            { BLOODSPIKE, Bloodspike },
            { BRASS, Brass },
            { CYGNUS, Cygnus },
            { DEADEYE, Deadeye },
            { DOBBIN, Dobbin },
            { GABRIELLA, Gabriella },
            { HOGARTH, Hogarth },
            { IVY, Ivy },
            { MAXIMILIAN, Maximilian },
            { MIDNIGHT, Midnight },
            { OZIEL, Oziel },
            { SMOLDER, Smolder },
            { STINKEYE, Stinkeye },
            { TEMPER, Temper },
            { TUNDRA, Tundra },
            { YI_LIN, YiLin },
            { ZOEY, Zoey },
        };

    }
}
