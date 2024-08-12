using System.Collections.Generic;
using static SingleplayerLauncher.Names.Hero;

namespace SingleplayerLauncher.Model
{
    public class Hero : LoadoutItem
    {
        public Skin[] Skins { get; private set; }
        public string PawnWeaponTemplateName { get; private set; }
        public string PawnTemplateName { get; private set; }
        public string SiegePawnWeaponTemplateName { get; private set; }
        public string SiegeTemplateName { get; private set; }
        public SlotItem SiegeUniqueSlotItem { get; private set; }
        public Skin[] SiegeSkins { get; private set; }

        public string UPKFileName { get; private set; }


        // private constructor
        Hero() { }

        // static members
        public static Hero Bionka = new()
        {
            Id = 1,
            Name = BIONKA,
            Skins = Skin.BionkaSkins,
            PawnTemplateName = "PawnWeapon_Bionka.Pawn_Bionka",
            PawnWeaponTemplateName = "PawnWeapon_Bionka.Weapon_Bionka",
            SiegePawnWeaponTemplateName = "PawnWeapon_Bionka.Weapon_Bionka",
            SiegeTemplateName = "PawnWeapon_Bionka.Pawn_Bionka",
            SiegeUniqueSlotItem = Glyph.OrcishFieldPromotionGlyph,
            SiegeSkins = Skin.SiegeBionkaSkins
        };
        public static Hero Blackpaw = new()
        {
            Id = 2,
            Name = BLACKPAW,
            Skins = Skin.BlackpawSkins,
            PawnTemplateName = "PawnWeapon_Blackpaw.Pawn_Blackpaw",
            PawnWeaponTemplateName = "PawnWeapon_Blackpaw.Weapon_Blackpaw",
            SiegePawnWeaponTemplateName = "SpitfireGame.RItemWeaponBlackPaw",
            SiegeUniqueSlotItem = Glyph.GlyphOfBlood,
            SiegeTemplateName = "SpitfireGame.RPawnPlayerBlackPaw",
            SiegeSkins = Skin.SiegeBlackpawSkins
        };
        public static Hero Bloodspike = new()
        {
            Id = 3,
            Name = BLOODSPIKE,
            Skins = Skin.BloodspikeSkins,
            PawnTemplateName = "PawnWeapon_Bloodspike.Pawn_Bloodspike",
            PawnWeaponTemplateName = "PawnWeapon_Bloodspike.Weapon_Bloodspike",
            SiegePawnWeaponTemplateName = "SpitfireGame.RItemWeaponBloodspike",
            SiegeUniqueSlotItem = Glyph.GlyphOfPhysicalArmor,
            SiegeTemplateName = "SpitfireGame.RPawnPlayerBloodspike",
            SiegeSkins = Skin.SiegeBloodspikeSkins
        };
        public static Hero Brass = new()
        {
            Id = 4,
            Name = BRASS,
            Skins = Skin.BrassSkins,
            PawnTemplateName = "PawnWeapon_Brass.Pawn_Brass",
            PawnWeaponTemplateName = "PawnWeapon_Brass.Weapon_Brass",
        };
        public static Hero Cygnus = new()
        {
            Id = 5,
            Name = CYGNUS,
            Skins = Skin.CygnusSkins,
            PawnTemplateName = "PawnWeapon_Cygnus.Pawn_Cygnus",
            PawnWeaponTemplateName = "PawnWeapon_Cygnus.Weapon_Cygnus",
            SiegePawnWeaponTemplateName = "SpitfireGame.RItemWeaponMasterStaff",
            SiegeUniqueSlotItem = Trap.BuffPylon,
            SiegeTemplateName = "SpitfireGame.RPawnPlayerTheMaster",
            SiegeSkins = Skin.SiegeCygnusSkins
        };
        public static Hero Deadeye = new()
        {
            Id = 6,
            Name = DEADEYE,
            Skins = Skin.DeadeyeSkins,
            PawnTemplateName = "PawnWeapon_Deadeye.Pawn_Deadeye",
            PawnWeaponTemplateName = "PawnWeapon_Deadeye.Weapon_Deadeye",
        };
        public static Hero Dobbin = new()
        {
            Id = 7,
            Name = DOBBIN,
            Skins = Skin.DobbinSkins,
            PawnTemplateName = "PawnWeapon_Dobbin.Pawn_Dobbin",
            PawnWeaponTemplateName = "PawnWeapon_Dobbin.Weapon_Dobbin",
            SiegePawnWeaponTemplateName = "SpitfireGame.RItemWeaponProspectorShovel",
            SiegeUniqueSlotItem = Trap.CoinForge,
            SiegeTemplateName = "SpitfireGame.RPawnPlayerProspector",
            SiegeSkins = Skin.SiegeDobbinSkins
        };
        public static Hero Gabriella = new()
        {
            Id = 8,
            Name = GABRIELLA,
            Skins = Skin.GabriellaSkins,
            PawnTemplateName = "PawnWeapon_Sorceress.Pawn_Sorceress",
            PawnWeaponTemplateName = "PawnWeapon_Sorceress.Weapon_Sorceress",
            SiegePawnWeaponTemplateName = "SpitfireGame.RItemWeaponWand",
            SiegeUniqueSlotItem = Trap.SummonerTrap,
            SiegeTemplateName = "SpitfireGame.RPawnPlayerSorceress",
            SiegeSkins = Skin.SiegeGabriellaSkins
        };
        public static Hero Hogarth = new()
        {
            Id = 9,
            Name = HOGARTH,
            Skins = Skin.HogarthSkins,
            PawnTemplateName = "PawnWeapon_Hogarth.Pawn_Hogarth",
            PawnWeaponTemplateName = "PawnWeapon_Hogarth.Weapon_Hogarth",
            SiegePawnWeaponTemplateName = "SpitfireGame.RItemWeaponBattleAxe",
            SiegeUniqueSlotItem = Glyph.GlyphOfMagicArmor,
            SiegeTemplateName = "SpitfireGame.RPawnPlayerHogarth",
            SiegeSkins = Skin.SiegeHogarthSkins
        };
        public static Hero Ivy = new()
        {
            Id = 10,
            Name = IVY,
            Skins = Skin.IvySkins,
            PawnTemplateName = "PawnWeapon_Ivy.Pawn_Ivy",
            PawnWeaponTemplateName = "PawnWeapon_Ivy.Weapon_Ivy",
            SiegePawnWeaponTemplateName = "SpitfireGame.RItemWeaponElvenBow",
            SiegeUniqueSlotItem = Glyph.GlyphOfHealing,
            SiegeTemplateName = "SpitfireGame.RPawnPlayerSheElf",
            SiegeSkins = Skin.SiegeIvySkins
        };
        public static Hero Maximilian = new()
        {
            Id = 11,
            Name = MAXIMILIAN,
            Skins = Skin.MaximilianSkins,
            PawnTemplateName = "PawnWeapon_Warmage.Pawn_Warmage",
            PawnWeaponTemplateName = "PawnWeapon_Warmage.Weapon_Warmage",
            SiegePawnWeaponTemplateName = "SpitfireGame.RItemWeaponCrossbowHitscan",
            SiegeUniqueSlotItem = Trap.Decoy,
            SiegeTemplateName = "SpitfireGame.RPawnPlayerWarmage",
            SiegeSkins = Skin.SiegeMaximilianSkins
        };
        public static Hero Midnight = new()
        {
            Id = 12,
            Name = MIDNIGHT,
            Skins = Skin.MidnightSkins,
            PawnTemplateName = "PawnWeapon_Midnight.Pawn_Midnight",
            PawnWeaponTemplateName = "PawnWeapon_Midnight.Weapon_Midnight",
            SiegePawnWeaponTemplateName = "SpitfireGame.RItemWeaponPantherQueen",
            SiegeUniqueSlotItem = Glyph.GlyphOfSpeed,
            SiegeTemplateName = "SpitfireGame.RPawnPlayerPantherQueen",
            SiegeSkins = Skin.SiegeMidnightSkins
        };
        public static Hero Oziel = new()
        {
            Id = 13,
            Name = OZIEL,
            Skins = Skin.OzielSkins,
            PawnTemplateName = "PawnWeapon_Oziel.Pawn_Oziel",
            PawnWeaponTemplateName = "PawnWeapon_Oziel.Weapon_Oziel",
            SiegePawnWeaponTemplateName = "SpitfireGame.RItemWeaponAncestor",
            SiegeUniqueSlotItem = Glyph.GlyphOfMagicArmor,
            SiegeTemplateName = "SpitfireGame.RPawnPlayerAncestor",
            SiegeSkins = Skin.SiegeOzielSkins
        };
        public static Hero Smolder = new()
        {
            Id = 14,
            Name = SMOLDER,
            Skins = Skin.SmolderSkins,
            PawnTemplateName = "PawnWeapon_Smolder.Pawn_Smolder",
            PawnWeaponTemplateName = "PawnWeapon_Smolder.Weapon_Smolder",
            SiegePawnWeaponTemplateName = "SpitfireGame.RItemWeaponEvilMage",
            SiegeUniqueSlotItem = Trap.NaphthaSprayer,
            SiegeTemplateName = "SpitfireGame.RPawnPlayerEvilMage",
            SiegeSkins = Skin.SiegeSmolderSkins
        };
        public static Hero Stinkeye = new()
        {
            Id = 15,
            Name = STINKEYE,
            Skins = Skin.StinkeyeSkins,
            PawnTemplateName = "PawnWeapon_Stinkeye.Pawn_Stinkeye",
            PawnWeaponTemplateName = "PawnWeapon_Stinkeye.Weapon_Stinkeye",
            SiegePawnWeaponTemplateName = "SpitfireGame.RItemWeaponCyclopsMasterStaff",
            SiegeUniqueSlotItem = Trap.ArcaneBowlingBall,
            SiegeTemplateName = "SpitfireGame.RPawnPlayerCyclopsMaster",
            SiegeSkins = Skin.SiegeStinkeyeSkins
        };
        public static Hero Temper = new()
        {
            Id = 16,
            Name = TEMPER,
            Skins = Skin.TemperSkins,
            PawnTemplateName = "PawnWeapon_Temper.Pawn_Temper",
            PawnWeaponTemplateName = "PawnWeapon_Temper.Weapon_Temper",
        };
        public static Hero Tundra = new()
        {
            Id = 17,
            Name = TUNDRA,
            Skins = Skin.TundraSkins,
            PawnTemplateName = "PawnWeapon_Tundra.Pawn_Tundra",
            PawnWeaponTemplateName = "PawnWeapon_Tundra.Weapon_Tundra",
            SiegePawnWeaponTemplateName = "SpitfireGame.RItemWeaponBearStaff",
            SiegeUniqueSlotItem = Trap.SawOfArctos,
            SiegeTemplateName = "SpitfireGame.RPawnPlayerDaBear",
            SiegeSkins = Skin.SiegeTundraSkins
        };
        public static Hero YiLin = new()
        {
            Id = 18,
            Name = YI_LIN,
            Skins = Skin.YiLinSkins,
            PawnTemplateName = "PawnWeapon_hooksword.Pawn_hooksword",
            PawnWeaponTemplateName = "PawnWeapon_hooksword.Weapon_hooksword",
        };
        public static Hero Zoey = new()
        {
            Id = 19,
            Name = ZOEY,
            Skins = Skin.ZoeySkins,
            PawnTemplateName = "PawnWeapon_Zoey.Pawn_Zoey",
            PawnWeaponTemplateName = "PawnWeapon_Zoey.Weapon_Zoey",
            SiegePawnWeaponTemplateName = "SpitfireGame.RItemWeaponApprentice",
            SiegeUniqueSlotItem = Trap.OverloadTrap,
            SiegeTemplateName = "SpitfireGame.RPawnPlayerApprentice",
            SiegeSkins = Skin.SiegeZoeySkins
        };


        public static Dictionary<string, Hero> Heroes = new()
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


        public static Dictionary<string, Hero> SiegeHeroes = new()
        {
            { BIONKA, Bionka },
            { BLACKPAW, Blackpaw },
            { BLOODSPIKE, Bloodspike },
            { CYGNUS, Cygnus },
            { DOBBIN, Dobbin },
            { GABRIELLA, Gabriella },
            { HOGARTH, Hogarth },
            { IVY, Ivy },
            { MAXIMILIAN, Maximilian },
            { MIDNIGHT, Midnight },
            { OZIEL, Oziel },
            { SMOLDER, Smolder },
            { STINKEYE, Stinkeye },
            { TUNDRA, Tundra },
            { ZOEY, Zoey },
        };

        public static Dictionary<int, Hero> HeroesById = new()
        {
            { Bionka.Id, Bionka },
            { Blackpaw.Id, Blackpaw },
            { Bloodspike.Id, Bloodspike },
            { Brass.Id, Brass },
            { Cygnus.Id, Cygnus },
            { Deadeye.Id, Deadeye },
            { Dobbin.Id, Dobbin },
            { Gabriella.Id, Gabriella },
            { Hogarth.Id, Hogarth },
            { Ivy.Id, Ivy },
            { Maximilian.Id, Maximilian },
            { Midnight.Id, Midnight },
            { Oziel.Id, Oziel },
            { Smolder.Id, Smolder },
            { Stinkeye.Id, Stinkeye },
            { Temper.Id, Temper },
            { Tundra.Id, Tundra },
            { YiLin.Id, YiLin },
            { Zoey.Id, Zoey },
        };

        public static Hero GetById(int id)
        {
            if (HeroesById.TryGetValue(id, out var hero))
            {
                return hero;
            }
            return new Hero { Id = 0, Name = "Unknown" };
        }

    }
}
