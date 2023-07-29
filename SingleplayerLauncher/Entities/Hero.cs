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
        public UPKFile.Section HealthMax { get; private set; }
        public UPKFile.Section CurrentSkinClass { get; private set; }
        public UPKFile.Section DefaultGuardianArchetypes { get; private set; }
        public UPKFile.Section DefaultInventoryClasses { get; private set; }
        public UPKFile.Section DefaultInventoryArchetypes { get; private set; }
        public UPKFile.Section WeaverTreeDefault { get; private set; }
        public UPKFile.Section ArrayProperty { get; private set; }


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
            WeaverTreeDefault = new UPKFile.Section("WeaverTreeDefault", null, new byte[] { 0x00, 0xB4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            ArrayProperty = new UPKFile.Section("ArrayProperty", null, new byte[] { 0xC5, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x8D, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            HealthMax = new UPKFile.Section("HealthMax", null, new byte[] { 0x9E, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
        };
        public static Hero Blackpaw = new Hero()
        {
            Name = BLACKPAW,
            BaseHealth = 341,
            Skins = Skin.BlackpawSkins,
            PawnWeaponString = "PawnWeapon_Blackpaw.Pawn_Blackpaw",
            UPKFileName = "pawnweapon_blackpaw_SF.upk",
            UPKFileHeroObjectOffset = 0x003db9a,
            UPKFileHeroObjectSize = 1224,
            ToRemoveSections = new UPKFile.Section[] {
                new UPKFile.Section("TauntSegment", 28, new byte[] { 0x8B, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("DefeatedSegment", 28, new byte[] { 0x3D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDanceSegment", 28, new byte[] { 0x7B, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameLockMovementSegmentg", 28, new byte[] { 0x7F, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDefeatedSegment", 28, new byte[] { 0x7D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("ActionManager", 28, new byte[] { 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("NetRelComponent", 28, new byte[] { 0xC7, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("BeginStealthClientSegment", 28, new byte[] { 0x65, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndStealthClientSegment", 28, new byte[] { 0x80, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("TeamStealthSegment", 28, new byte[] { 0x8F, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
            },
            DefaultInventoryArchetypes = new UPKFile.Section("DefaultInventoryArchetypes", null, new byte[] { 0x3A, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultInventoryClasses = new UPKFile.Section("DefaultInventoryClasses", null, new byte[] { 0xFD, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultGuardianArchetypes = new UPKFile.Section("DefaultGuardianArchetypes", null, new byte[] { 0xFE, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            CurrentSkinClass = new UPKFile.Section("CurrentSkinClass", null, new byte[] { 0x16, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            WeaverTreeDefault = new UPKFile.Section("WeaverTreeDefault", null, new byte[] { 0xF7, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            ArrayProperty = new UPKFile.Section("ArrayProperty", null, new byte[] { 0x46, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0xF2, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            HealthMax = new UPKFile.Section("HealthMax", null, new byte[] { 0xF3, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
        };
        public static Hero Bloodspike = new Hero()
        {
            Name = BLOODSPIKE,
            BaseHealth = 600,
            Skins = Skin.BloodspikeSkins,
            PawnWeaponString = "PawnWeapon_Bloodspike.Pawn_Bloodspike",
            UPKFileName = "pawnweapon_bloodspike_SF.upk",
            UPKFileHeroObjectOffset = 0x0077eb6,
            UPKFileHeroObjectSize = 1296,
            ToRemoveSections = new UPKFile.Section[] {
                new UPKFile.Section("EndGameLockMovementSegmentg", 28, new byte[] { 0xA4, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDefeatedSegment", 28, new byte[] { 0xA2, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("DefaultRoleClass", 28, new byte[] { 0x56, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("StrategicRole", 40, new byte[] { 0xCB, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("ActionManager", 28, new byte[] { 0x1F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("NetRelComponent", 28, new byte[] { 0xFD, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("BeginStealthClientSegment", 28, new byte[] { 0x70, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndStealthClientSegment", 28, new byte[] { 0xA5, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("TeamStealthSegment", 28, new byte[] { 0xF2, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
            },
            DefaultInventoryArchetypes = new UPKFile.Section("DefaultInventoryArchetypes", 32, new byte[] { 0x54, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultInventoryClasses = new UPKFile.Section("DefaultInventoryClasses", null, new byte[] { 0xB1, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultGuardianArchetypes = new UPKFile.Section("DefaultGuardianArchetypes", null, new byte[] { 0xB2, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            CurrentSkinClass = new UPKFile.Section("CurrentSkinClass", null, new byte[] { 0x31, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            WeaverTreeDefault = new UPKFile.Section("WeaverTreeDefault", null, new byte[] { 0x62, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            ArrayProperty = new UPKFile.Section("ArrayProperty", null, new byte[] { 0x4B, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x20, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            HealthMax = new UPKFile.Section("HealthMax", null, new byte[] { 0x21, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
        };
        public static Hero Brass = new Hero()
        {
            Name = BRASS,
            BaseHealth = 350,
            Skins = Skin.BrassSkins,
            PawnWeaponString = "PawnWeapon_Brass.Pawn_Brass",
            UPKFileName = "pawnweapon_brass_SF.upk",
            UPKFileHeroObjectOffset = 0x00b6e43,
            UPKFileHeroObjectSize = 1449,
            ToRemoveSections = new UPKFile.Section[] {
                new UPKFile.Section("TauntSegment", 28, new byte[] { 0x77, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("DefeatedSegment", 28, new byte[] { 0x30, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDanceSegment", 28, new byte[] { 0x89, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameLockMovementSegmentg", 28, new byte[] { 0x8D, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDefeatedSegment", 28, new byte[] { 0x8B, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("ActionManager", 28, new byte[] { 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("NetRelComponent", 28, new byte[] { 0x73, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("BeginStealthClientSegment", 28, new byte[] { 0xB0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndStealthClientSegment", 28, new byte[] { 0x8E, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("TeamStealthSegment", 28, new byte[] { 0x7C, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("ManaRegenPerSecond", 28, new byte[] { 0xFE, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
            },
            DefaultInventoryArchetypes = new UPKFile.Section("DefaultInventoryArchetypes", null, new byte[] { 0x2C, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultInventoryClasses = new UPKFile.Section("DefaultInventoryClasses", null, new byte[] { 0x8D, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultGuardianArchetypes = new UPKFile.Section("DefaultGuardianArchetypes", null, new byte[] { 0x8E, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            CurrentSkinClass = new UPKFile.Section("CurrentSkinClass", null, new byte[] { 0xF6, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            WeaverTreeDefault = new UPKFile.Section("WeaverTreeDefault", null, new byte[] { 0x3B, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            ArrayProperty = new UPKFile.Section("ArrayProperty", null, new byte[] { 0x70, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x49, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xde, 0x02, 0x00, 0x00 }),
            HealthMax = new UPKFile.Section("HealthMax", null, new byte[] { 0x4C, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
        };
        public static Hero Cygnus = new Hero()
        {
            Name = CYGNUS,
            BaseHealth = 215,
            Skins = Skin.CygnusSkins,
            PawnWeaponString = "PawnWeapon_Cygnus.Pawn_Cygnus",
            ToRemoveSections = new UPKFile.Section[] {
                new UPKFile.Section("EndGameDefeatedSegment", 28, new byte[] { 0x14, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("StrategicRole", 40, new byte[] { 0x44, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("ActionManager", 28, new byte[] { 0x25, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("NetRelComponent", 28, new byte[] { 0xCB, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("BeginStealthClientSegment", 28, new byte[] { 0xA0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndStealthClientSegment", 28, new byte[] { 0x17, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("TeamStealthSegment", 28, new byte[] { 0x75, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("HeroDamageType", 40, new byte[] { 0xB8, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } )
            }
        };
        public static Hero Deadeye = new Hero()
        {
            Name = DEADEYE,
            BaseHealth = 219,
            Skins = Skin.DeadeyeSkins,
            PawnWeaponString = "PawnWeapon_Deadeye.Pawn_Deadeye",
            ToRemoveSections = new UPKFile.Section[] {
                new UPKFile.Section("DefaultRoleClass", 28, new byte[] { 0x39, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("StrategicRole", 40, new byte[] { 0x86, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("ActionManager", 28, new byte[] { 0x39, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("NetRelComponent", 28, new byte[] { 0xDB, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("BeginStealthClientSegment", 28, new byte[] { 0xD0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndStealthClientSegment", 28, new byte[] { 0xC5, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("TeamStealthSegment", 28, new byte[] { 0xC0, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("HeroDamageType", 40, new byte[] { 0xC4, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } )
            }
        };
        public static Hero Dobbin = new Hero()
        {
            Name = DOBBIN,
            BaseHealth = 500,
            Skins = Skin.DobbinSkins,
            PawnWeaponString = "PawnWeapon_Dobbin.Pawn_Dobbin",
            ToRemoveSections = new UPKFile.Section[] {
                new UPKFile.Section("EndGameDanceSegment", 28, new byte[] { 0xD2, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameLockMovementSegmentg", 28, new byte[] { 0xD6, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDefeatedSegment", 28, new byte[] { 0xD4, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("StrategicRole", 40, new byte[] { 0x4C, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("ActionManager", 28, new byte[] { 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("NetRelComponent", 28, new byte[] { 0x36, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("BeginStealthClientSegment", 28, new byte[] { 0x7D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndStealthClientSegment", 28, new byte[] { 0xD7, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("TeamStealthSegment", 28, new byte[] { 0x72, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
            }
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
            WeaverTreeDefault = new UPKFile.Section("WeaverTreeDefault", null, new byte[] { 0x00, 0xB4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            ArrayProperty = new UPKFile.Section("ArrayProperty", null, new byte[] { 0xC5, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x8D, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            HealthMax = new UPKFile.Section("HealthMax", null, new byte[] { 0x9E, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
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
            WeaverTreeDefault = new UPKFile.Section("WeaverTreeDefault", null, new byte[] { 0x00, 0xB4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            ArrayProperty = new UPKFile.Section("ArrayProperty", null, new byte[] { 0xC5, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x8D, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            HealthMax = new UPKFile.Section("HealthMax", null, new byte[] { 0x9E, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
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
            WeaverTreeDefault = new UPKFile.Section("WeaverTreeDefault", null, new byte[] { 0x00, 0xB4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            ArrayProperty = new UPKFile.Section("ArrayProperty", null, new byte[] { 0xC5, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x8D, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            HealthMax = new UPKFile.Section("HealthMax", null, new byte[] { 0x9E, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
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
            WeaverTreeDefault = new UPKFile.Section("WeaverTreeDefault", null, new byte[] { 0x00, 0xB4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            ArrayProperty = new UPKFile.Section("ArrayProperty", null, new byte[] { 0xC5, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x8D, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            HealthMax = new UPKFile.Section("HealthMax", null, new byte[] { 0x9E, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
        };
        public static Hero Midnight = new Hero()
        {
            Name = MIDNIGHT,
            BaseHealth = 220,
            Skins = Skin.MidnightSkins,
            PawnWeaponString = "PawnWeapon_Midnight.Pawn_Midnight",
            ToRemoveSections = new UPKFile.Section[] {
                new UPKFile.Section("TauntSegment", 28, new byte[] { 0xC1, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("DefeatedSegment", 28, new byte[] { 0x31, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDanceSegment", 28, new byte[] { 0x7B, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameLockMovementSegmentg", 28, new byte[] { 0x7F, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDefeatedSegment", 28, new byte[] { 0x7D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("ActionManager", 28, new byte[] { 0x18, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("NetRelComponent", 28, new byte[] { 0xC3, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("BeginStealthClientSegment", 28, new byte[] { 0x6B, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndStealthClientSegment", 28, new byte[] { 0x81, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("TeamStealthSegment", 28, new byte[] { 0x80, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
            }
        };
        public static Hero Oziel = new Hero()
        {
            Name = OZIEL,
            BaseHealth = 200,
            Skins = Skin.OzielSkins,
            PawnWeaponString = "PawnWeapon_Oziel.Pawn_Oziel",
            UPKFileName = "pawnweapon_oziel_SF.upk",
            UPKFileHeroObjectOffset = 0x000c406a,
            UPKFileHeroObjectSize = 1671,
            ToRemoveSections = new UPKFile.Section[] {
                new UPKFile.Section("TauntSegment", 28, new byte[] { 0xED, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("DefeatedSegment", 28, new byte[] { 0x82, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDanceSegment", 28, new byte[] { 0xC5, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameLockMovementSegmentg", 28, new byte[] { 0xC9, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDefeatedSegment", 28, new byte[] { 0xC7, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("ActionManager", 28, new byte[] { 0x18, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("NetRelComponent", 28, new byte[] { 0x66, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("BeginStealthClientSegment", 28, new byte[] { 0x82, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndStealthClientSegment", 28, new byte[] { 0xCC, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("TeamStealthSegment", 28, new byte[] { 0xF0, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("HeroDamageType", 40, new byte[] { 0x7E, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } )
            },
            DefaultInventoryArchetypes = new UPKFile.Section("DefaultInventoryArchetypes", 32, new byte[] { 0x7D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultInventoryClasses = new UPKFile.Section("DefaultInventoryClasses", null, new byte[] { 0x7E, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            DefaultGuardianArchetypes = new UPKFile.Section("DefaultGuardianArchetypes", null, new byte[] { 0xB5, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            CurrentSkinClass = new UPKFile.Section("CurrentSkinClass", null, new byte[] { 0x51, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            WeaverTreeDefault = new UPKFile.Section("WeaverTreeDefault", null, new byte[] { 0x6F, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            ArrayProperty = new UPKFile.Section("ArrayProperty", null, new byte[] { 0x58, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x6F, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            HealthMax = new UPKFile.Section("HealthMax", null, new byte[] { 0x71, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
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
            WeaverTreeDefault = new UPKFile.Section("WeaverTreeDefault", null, new byte[] { 0x00, 0xB4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            ArrayProperty = new UPKFile.Section("ArrayProperty", null, new byte[] { 0xC5, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            Health = new UPKFile.Section("Health", null, new byte[] { 0x8D, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
            HealthMax = new UPKFile.Section("HealthMax", null, new byte[] { 0x9E, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }),
        };
        public static Hero Stinkeye = new Hero()
        {
            Name = STINKEYE,
            BaseHealth = 356,
            Skins = Skin.StinkeyeSkins,
            PawnWeaponString = "PawnWeapon_Stinkeye.Pawn_Stinkeye",
            ToRemoveSections = new UPKFile.Section[] {
                new UPKFile.Section("TauntSegment", 28, new byte[] { 0x68, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("DefeatedSegment", 28, new byte[] { 0xB1, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDanceSegment", 28, new byte[] { 0x17, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameLockMovementSegmentg", 28, new byte[] { 0x1B, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDefeatedSegment", 28, new byte[] { 0x19, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("ActionManager", 28, new byte[] { 0x12, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("NetRelComponent", 28, new byte[] { 0xCA, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("BeginStealthClientSegment", 28, new byte[] { 0x95, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndStealthClientSegment", 28, new byte[] { 0x1C, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("TeamStealthSegment", 28, new byte[] { 0x6D, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
            }
        };
        public static Hero Temper = new Hero()
        {
            Name = TEMPER,
            BaseHealth = 500,
            Skins = Skin.TemperSkins,
            PawnWeaponString = "PawnWeapon_Temper.Pawn_Temper",
            ToRemoveSections = new UPKFile.Section[] {
                new UPKFile.Section("TauntSegment", 28, new byte[] { 0xB7, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("DefeatedSegment", 28, new byte[] { 0x9C, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDanceSegment", 28, new byte[] { 0xF0, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameLockMovementSegmentg", 28, new byte[] { 0xF4, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDefeatedSegment", 28, new byte[] { 0xF2, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("ActionManager", 28, new byte[] { 0x1A, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("NetRelComponent", 28, new byte[] { 0x04, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("BeginStealthClientSegment", 28, new byte[] { 0x8E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndStealthClientSegment", 28, new byte[] { 0xF5, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("TeamStealthSegment", 28, new byte[] { 0xBB, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
            }
        };
        public static Hero Tundra = new Hero()
        {
            Name = TUNDRA,
            BaseHealth = 625,
            Skins = Skin.TundraSkins,
            PawnWeaponString = "PawnWeapon_Tundra.Pawn_Tundra",
            ToRemoveSections = new UPKFile.Section[] {
                new UPKFile.Section("EndGameLockMovementSegmentg", 28, new byte[] { 0xC3, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndGameDefeatedSegment", 28, new byte[] { 0xC1, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("DefaultRoleClass", 28, new byte[] { 0x73, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("StrategicRole", 40, new byte[] { 0xA9, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("ActionManager", 28, new byte[] { 0x13, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("NetRelComponent", 28, new byte[] { 0x6B, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("BeginStealthClientSegment", 28, new byte[] { 0x85, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndStealthClientSegment", 28, new byte[] { 0xC6, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("TeamStealthSegment", 28, new byte[] { 0xC8, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
            }
        };
        public static Hero YiLin = new Hero()
        {
            Name = YI_LIN,
            BaseHealth = 250,
            Skins = Skin.YiLinSkins,
            PawnWeaponString = "PawnWeapon_hooksword.Pawn_hooksword",
            ToRemoveSections = new UPKFile.Section[] {
                new UPKFile.Section("DefaultRoleClass", 28, new byte[] { 0x5F, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("StrategicRole", 40, new byte[] { 0x3A, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("ActionManager", 28, new byte[] { 0x26, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("NetRelComponent", 28, new byte[] { 0x1E, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("BeginStealthClientSegment", 28, new byte[] { 0x7A, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("EndStealthClientSegment", 28, new byte[] { 0xA3, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("TeamStealthSegment", 28, new byte[] { 0x61, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } ),
                new UPKFile.Section("HeroDamageType", 40, new byte[] { 0x2C, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, } )
            }
        };
        public static Hero Zoey = new Hero()
        {
            Name = ZOEY,
            BaseHealth = 275,
            Skins = Skin.ZoeySkins,
            PawnWeaponString = "PawnWeapon_Zoey.Pawn_Zoey",
            ToRemoveSections = new UPKFile.Section[] {
                new UPKFile.Section("EndGameDanceSegment", 28, new byte[] { 0x26, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  } ),
                new UPKFile.Section("EndGameLockMovementSegmentg", 28, new byte[] { 0x2A, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  } ),
                new UPKFile.Section("EndGameDefeatedSegment", 28, new byte[] { 0x28, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  } ),
                new UPKFile.Section("StrategicRole", 40, new byte[] { 0x35, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  } ),
                new UPKFile.Section("ActionManager", 28, new byte[] { 0x28, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  } ),
                new UPKFile.Section("NetRelComponent", 28, new byte[] { 0xE0, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  } ),
                new UPKFile.Section("BeginStealthClientSegment", 28, new byte[] { 0xD0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  } ),
                new UPKFile.Section("EndStealthClientSegment", 28, new byte[] { 0x2D, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  } ),
                new UPKFile.Section("TeamStealthSegment", 28, new byte[] { 0x66, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  } ),
            }
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
