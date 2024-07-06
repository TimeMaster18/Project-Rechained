using System.Collections.Generic;
using static SingleplayerLauncher.Names.Guardian;

namespace SingleplayerLauncher.Model
{
    public class Guardian : LoadoutItem
    {
        public string ItemTemplateName { get; private set; }

        public static Guardian BartenderGuardian = new Guardian()
        {
            Id = 1,
            Name = BARTENDER_GUARDIAN,
            ItemTemplateName = "pawn_guardianbarmaid.Placeable_GuardianBarmaid",
        };
        public static Guardian BlacksmithGuardian = new Guardian()
        {
            Id = 2,
            Name = BLACKSMITH_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianBear.Placeable_Bear",
        };
        public static Guardian CookGuardian = new Guardian()
        {
            Id = 3,
            Name = COOK_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianCook.Placeable_Cook",
        };
        public static Guardian DeckhandGuardian = new Guardian()
        {
            Id = 4,
            Name = DECKHAND_GUARDIAN,
            ItemTemplateName = "pawn_guardiandeckhand.Placeable_GuardianDeckhand",
        };
        public static Guardian DragonGuardian = new Guardian()
        {
            Id = 5,
            Name = DRAGON_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianDragon.Placeable_Dragon",
        };
        public static Guardian FriarGuardian = new Guardian()
        {
            Id = 6,
            Name = FRIAR_GUARDIAN,
            ItemTemplateName = "pawn_guardianorcpriest.Placeable_GuardianOrcPriest",
        };
        public static Guardian HeadhunterGuardian = new Guardian()
        {
            Id = 7,
            Name = HEADHUNTER_GUARDIAN,
            ItemTemplateName = "pawn_guardiantrollcommander.Placeable_GuardianTrollCommander",
        };
        public static Guardian JadeEmpireGuardian = new Guardian()
        {
            Id = 8,
            Name = JADE_EMPIRE_GUARDIAN,
            ItemTemplateName = "pawn_guardianchinesejailer.Placeable_GuardianChineseJailer",
        };
        public static Guardian JailerGuardian = new Guardian()
        {
            Id = 9,
            Name = JAILER_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianJailer.Placeable_GuardianJailer",
        };
        public static Guardian LionGuardian = new Guardian()
        {
            Id = 10,
            Name = LION_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianLion.Placeable_Lion",
        };
        public static Guardian MoonGuardian = new Guardian()
        {
            Id = 11,
            Name = MOON_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianMoon.Placeable_Moon",
        };
        public static Guardian PriestGuardian = new Guardian()
        {
            Id = 12,
            Name = PRIEST_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianPriest.Placeable_GuardianPriest",
        };
        public static Guardian QuartermasterGuardian = new Guardian()
        {
            Id = 13,
            Name = QUARTERMASTER_GUARDIAN,
            ItemTemplateName = "pawn_guardiancaptain.Placeable_GuardianCaptain",
        };
        public static Guardian RanchHandGuardian = new Guardian()
        {
            Id = 14,
            Name = RANCH_HAND_GUARDIAN,
            ItemTemplateName = "pawn_guardianstablehand.Placeable_GuardianStablehand",
        };
        public static Guardian RumrudderGuardian = new Guardian()
        {
            Id = 15,
            Name = RUMRUDDER_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianScurvy.Placeable_GuardianScurvy",
        };
        public static Guardian SerpentGuardian = new Guardian()
        {
            Id = 16,
            Name = SERPENT_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianRazer.Placeable_Razer",
        };
        public static Guardian StablehandGuardian = new Guardian()
        {
            Id = 17,
            Name = STABLEHAND_GUARDIAN,
            ItemTemplateName = "pawn_guardianstablehand.Placeable_GuardianStablehand",
        };
        public static Guardian SunGuardian = new Guardian()
        {
            Id = 18,
            Name = SUN_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianSun.Placeable_Sun",
        };
        public static Guardian WeaponWrightGuardian = new Guardian()
        {
            Id = 19,
            Name = WEAPONWRIGHT_GUARDIAN,
            ItemTemplateName = "pawn_guardianweaponwright.Placeable_GuardianWeaponwright",
        };

        public static Dictionary<string, Guardian> Guardians = new Dictionary<string, Guardian>
        {
            { BARTENDER_GUARDIAN, BartenderGuardian },
            { BLACKSMITH_GUARDIAN, BlacksmithGuardian },
            { COOK_GUARDIAN, CookGuardian },
            { DECKHAND_GUARDIAN, DeckhandGuardian },
            { DRAGON_GUARDIAN, DragonGuardian },
            { FRIAR_GUARDIAN, FriarGuardian },
            { HEADHUNTER_GUARDIAN, HeadhunterGuardian },
            { JADE_EMPIRE_GUARDIAN, JadeEmpireGuardian },
            { JAILER_GUARDIAN, JailerGuardian },
            { LION_GUARDIAN, LionGuardian },
            { MOON_GUARDIAN, MoonGuardian },
            { PRIEST_GUARDIAN, PriestGuardian },
            { QUARTERMASTER_GUARDIAN, QuartermasterGuardian },
            { RANCH_HAND_GUARDIAN, RanchHandGuardian },
            { RUMRUDDER_GUARDIAN, RumrudderGuardian },
            { SERPENT_GUARDIAN, SerpentGuardian },
            { STABLEHAND_GUARDIAN, StablehandGuardian },
            { SUN_GUARDIAN, SunGuardian },
            { WEAPONWRIGHT_GUARDIAN, WeaponWrightGuardian },
        };

        public static Dictionary<int, Guardian> GuardiansById = new Dictionary<int, Guardian>
        {
            { BartenderGuardian.Id, BartenderGuardian },
            { BlacksmithGuardian.Id, BlacksmithGuardian },
            { CookGuardian.Id, CookGuardian },
            { DeckhandGuardian.Id, DeckhandGuardian },
            { DragonGuardian.Id, DragonGuardian },
            { FriarGuardian.Id, FriarGuardian },
            { HeadhunterGuardian.Id, HeadhunterGuardian },
            { JadeEmpireGuardian.Id, JadeEmpireGuardian },
            { JailerGuardian.Id, JailerGuardian },
            { LionGuardian.Id, LionGuardian },
            { MoonGuardian.Id, MoonGuardian },
            { PriestGuardian.Id, PriestGuardian },
            { QuartermasterGuardian.Id, QuartermasterGuardian },
            { RanchHandGuardian.Id, RanchHandGuardian },
            { RumrudderGuardian.Id, RumrudderGuardian },
            { SerpentGuardian.Id, SerpentGuardian },
            { StablehandGuardian.Id, StablehandGuardian },
            { SunGuardian.Id, SunGuardian },
            { WeaponWrightGuardian.Id, WeaponWrightGuardian },
        };

        public static Guardian GetById(int id)
        {
            if (GuardiansById.TryGetValue(id, out var guardian))
            {
                return guardian;
            }
            return new Guardian { Id = 0, Name = "Unknown" };
        }
    }
}
