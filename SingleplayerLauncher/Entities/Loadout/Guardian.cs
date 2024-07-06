using System.Collections.Generic;
using static SingleplayerLauncher.Names.Guardian;

namespace SingleplayerLauncher.Model
{
    public class Guardian : LoadoutItem
    {
        public string ItemTemplateName { get; private set; }
        public string AuraText { get; private set; }

        public static Guardian BartenderGuardian = new Guardian()
        {
            Id = 1,
            Name = BARTENDER_GUARDIAN,
            ItemTemplateName = "pawn_guardianbarmaid.Placeable_GuardianBarmaid",
            AuraText = "Liquid Courage: (In Combat) Reduces all cooldown durations by 20%. Buff granted to all heroes in Barmaid's aura.",
            Description = "Bartender guardian is at home in the kitchen where she puts up with no nonsense from unruly customers. Pay your tab!"
        };
        public static Guardian BlacksmithGuardian = new Guardian()
        {
            Id = 2,
            Name = BLACKSMITH_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianBear.Placeable_Bear",
            AuraText = "Forged Armor: (In Combat) Reduces damage taken by heroes 50%. Increases heroes' aggro max. Lasts only while in Blacksmith's aura.",
            Description = "At home in the forge, the Blacksmith guardian forges for the Royal Arctos Armory and will gladly armor allies who will help protect his home."
        };
        public static Guardian CookGuardian = new Guardian()
        {
            Id = 3,
            Name = COOK_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianCook.Placeable_Cook",
            AuraText = "Serving Up Grub: Quickly regenerates heroes' health and grants them the Full Stomach buff which increases their health for 45s when outside the aura. Heroes regain the buff upon re-entering the aura.",
            Description = "The ogre Cook guardian serves up some mean grub (and it may actually be grubs) in his home, the kitchen, giving free meals to his allies."
        };
        public static Guardian DeckhandGuardian = new Guardian()
        {
            Id = 4,
            Name = DECKHAND_GUARDIAN,
            ItemTemplateName = "pawn_guardiandeckhand.Placeable_GuardianDeckhand",
            AuraText = "Swashbuckling: (In Combat) Kills increase Unchained meter by +3.",
            Description = "As a pirate, the Deckhand guardian is at home on the docks. For some coin, he'll swab the deck with his allies' enemies and protect their rifts."
        };
        public static Guardian DragonGuardian = new Guardian()
        {
            Id = 5,
            Name = DRAGON_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianDragon.Placeable_Dragon",
            AuraText = "Guardian's Blessing: (Permanent) +50 armor and magic armor due to a nearby allied guardian. \n(Out of Combat) Regenerating health due to an allied guardian's aura.",
            Description = "Kin to the Sun, Moon, and Lion guardians, the Dragon guardian is at home in default locations and bravely defends his allies' rifts from invaders."
        };
        public static Guardian FriarGuardian = new Guardian()
        {
            Id = 6,
            Name = FRIAR_GUARDIAN,
            ItemTemplateName = "pawn_guardianorcpriest.Placeable_GuardianOrcPriest",
            AuraText = "Wiftmaker's Bwessing: (In Combat) Primary attacks dealing arcane damage.",
            Description = "As a devotee of the Riftmaker, the Friar's home is the temple. There, he blesses his followers and fights for the will of the Creator of Rifts."
        };
        public static Guardian HeadhunterGuardian = new Guardian()
        {
            Id = 7,
            Name = HEADHUNTER_GUARDIAN,
            ItemTemplateName = "pawn_guardiantrollcommander.Placeable_GuardianTrollCommander",
            AuraText = "Junior Headhunter: (In Combat) Reflecting 30% of incoming damage.",
            Description = "As a troll headhunter trying to make it in the modern day world, the Headhunter guardian makes his home in the barracks where he recruits only the finest warriors to protect his rifts."
        };
        public static Guardian JadeEmpireGuardian = new Guardian()
        {
            Id = 8,
            Name = JADE_EMPIRE_GUARDIAN,
            ItemTemplateName = "pawn_guardianchinesejailer.Placeable_GuardianChineseJailer",
            AuraText = "Blessing of Wealth: Generating 3 coin per second.",
            Description = "As the jailer of the Imperial Prison, the Jade Empire Guardian stands against those who would do the rifts harm. At home in the jail, he keeps allies' rifts secure."
        };
        public static Guardian JailerGuardian = new Guardian()
        {
            Id = 9,
            Name = JAILER_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianJailer.Placeable_GuardianJailer",
            AuraText = "Soul Shackle: (In Combat) Lifestealing with primary attacks.",
            Description = "At home in the jail, the Jailer keeps his prisoners locked up. Judge, jury, and executioner, the Jailer will \"deal with\" his allies' enemies."
        };
        public static Guardian LionGuardian = new Guardian()
        {
            Id = 10,
            Name = LION_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianLion.Placeable_Lion",
            AuraText = "Guardian's Blessing: (Permanent) +50 armor and magic armor due to a nearby allied guardian. \n(Out of Combat) Regenerating health due to an allied guardian's aura.",
            Description = "Kin to the Sun, Moon, and Dragon guardians, the Lion guardian is at home in default locations and bravely defends his allies' rifts from invaders."
        };
        public static Guardian MoonGuardian = new Guardian()
        {
            Id = 11,
            Name = MOON_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianMoon.Placeable_Moon",
            AuraText = "Guardian's Blessing: (Permanent) +50 armor and magic armor due to a nearby allied guardian. \n(Out of Combat) Regenerating health due to an allied guardian's aura.",
            Description = "Kin to the Sun, Dragon, and Lion guardians, the Moon guardian is at home in default locations and bravely defends his allies' rifts from invaders."
        };
        public static Guardian PriestGuardian = new Guardian()
        {
            Id = 12,
            Name = PRIEST_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianPriest.Placeable_GuardianPriest",
            AuraText = "Stirring Benediction: (Permanent) Mana regeneration increased.",
            Description = "The Priest guardian is a devote follower of Nature and its powers. At home in the temple, he uses the powers of nature to protect his congregation."
        };
        public static Guardian QuartermasterGuardian = new Guardian()
        {
            Id = 13,
            Name = QUARTERMASTER_GUARDIAN,
            ItemTemplateName = "pawn_guardiancaptain.Placeable_GuardianCaptain",
            AuraText = "Morale Boost: Damage increased by 25%.",
            Description = "To keep his soldiers safe in his home, the barracks, the Quartermaster demoralizes his enemies and boosts the morale of his allies."
        };
        public static Guardian RanchHandGuardian = new Guardian()
        {
            Id = 14,
            Name = RANCH_HAND_GUARDIAN,
            ItemTemplateName = "pawn_guardianstablehand.Placeable_GuardianStablehand",
            AuraText = "Slowpoke: (In Combat) Primary attacks slow enemies.",
            Description = "The Ranch Hand Guardian defends his allies' rift with a crazed intensity. Rustlers should steer clear of this \"cow boy\" and his stable."
        };
        public static Guardian RumrudderGuardian = new Guardian()
        {
            Id = 15,
            Name = RUMRUDDER_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianScurvy.Placeable_GuardianScurvy",
            AuraText = "Plunder: (Permanent) Kills yield health, mana, or Unchained pickups.",
            Description = "A part-time boss and guardian, but full-time pirate, Rumrudder is at home on the docks, defending his allies and rewarding them with booty."
        };
        public static Guardian SerpentGuardian = new Guardian()
        {
            Id = 16,
            Name = SERPENT_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianRazer.Placeable_Razer",
            AuraText = "Guardian's Blessing: (Permanent) +50 Physical Armor and Magic Armor due to a nearby allied guardian. \n(Out of Combat) Regenerating health due to an allied guardian's aura.",
            Description = "Constructed from the armor of fallen guardians, the corrupted Serpent guardian is at home in default locations and bravely defends his allies' rifts from invaders."
        };
        public static Guardian StablehandGuardian = new Guardian()
        {
            Id = 17,
            Name = STABLEHAND_GUARDIAN,
            ItemTemplateName = "pawn_guardianstablehand.Placeable_GuardianStablehand",
            AuraText = "Hoedown: (Permanent) Movement speed increased.",
            Description = "At home at the stables, the Stablehand knows that a chicken in the hand is worth a few deaths on the battlefield for his allies."
        };
        public static Guardian SunGuardian = new Guardian()
        {
            Id = 18,
            Name = SUN_GUARDIAN,
            ItemTemplateName = "Pawn_GuardianSun.Placeable_Sun",
            AuraText = "Guardian's Blessing: (Permanent) +50 armor and magic armor due to a nearby allied guardian. \n(Out of Combat) Regenerating health due to an allied guardian's aura.",
            Description = "Kin to the Moon, Dragon, and Lion guardians, the Sun guardian is at home in default locations and bravely defends his allies' rifts from invaders."
        };
        public static Guardian WeaponWrightGuardian = new Guardian()
        {
            Id = 19,
            Name = WEAPONWRIGHT_GUARDIAN,
            ItemTemplateName = "pawn_guardianweaponwright.Placeable_GuardianWeaponwright",
            AuraText = "Forged Weapons: (In Combat) Primary attacks dealing fire damage over time.",
            Description = "A follower of Oasis, the Weaponwright hones weapons for his cyclops brethren and helps those who will defend his forge from unbelievers."
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
