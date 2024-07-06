using System.Collections.Generic;
using static SingleplayerLauncher.Names.Consumable;

namespace SingleplayerLauncher.Model
{
    public class Consumable : LoadoutItem
    {
        public string ItemTemplateName { get; private set; }
        public int UsageLimit { get; private set; }
        public string FlavourText { get; private set; }

        public static Consumable BargainScroll = new Consumable
        {
            Id = 1,
            Name = BARGAIN_SCROLL,
            ItemTemplateName = "consumable_bargainscroll.consumable_bargainscroll",
            Description = "-50% to all Trap costs for 10s.",
            UsageLimit = 1,
            FlavourText = "Just in time for Riftmas! Get your favorite hero something shiny... and pointy!"
        };
        public static Consumable CooldownPotion = new Consumable
        {
            Id = 2,
            Name = COOLDOWN_POTION,
            ItemTemplateName = "consumable_cooldownpotion.consumable_cooldownpotion",
            Description = "Primary effect: instantly makes all abilities available for use. \nSecondary effect: -10% cooldown duration.",
            UsageLimit = 3,
            FlavourText = "For when your get up and go has gotten up and went."
        };
        public static Consumable EmptyRiftScroll = new Consumable
        {
            Id = 3,
            Name = EMPTY_RIFT_SCROLL,
            ItemTemplateName = "consumable_emptyriftscroll.consumable_emptyriftscroll",
            Description = "Enemies entering the Rift are worth 0 points for 10s",
            UsageLimit = 1,
            FlavourText = "\"Guys, guys, it's okay. I got this.\" - Maximilian, the War Mage"
        };
        public static Consumable GuardianPotion = new Consumable
        {
            Id = 4,
            Name = GUARDIAN_POTION,
            ItemTemplateName = "consumable_guardianpotion.consumable_guardianpotion",
            Description = "Primary effect: grants two extra Guardians from the Hero's loadout. \nSecondary effect: +0.6% max health and +1.5 mana per second. Secondary effects are permanently applied on use and are lost upon death.",
            UsageLimit = 1,
            FlavourText = "INSTRUCTIONS: Drink. Yes, YOU drink it. Don't try to force-feed it to a guardian. It won't like it."
        };
        public static Consumable HealthPotion = new Consumable
        {
            Id = 5,
            Name = HEALTH_POTION,
            ItemTemplateName = "consumable_healthpotion.consumable_healthpotion",
            Description = "Primary effect: restores full health. \nSecondary effect: +1% health per second.",
            UsageLimit = 10,
            FlavourText = "A bottle of good, clean living."
        };
        public static Consumable InvulnerabilityScroll = new Consumable
        {
            Id = 6,
            Name = INVULNERABILITY_SCROLL,
            ItemTemplateName = "consumable_invulnscroll.consumable_invulnerablescroll",
            Description = "Team takes no damage for 30s.",
            UsageLimit = 1,
            FlavourText = "\"All right now, team! Teamwork makes the dead orcs! Let's do it!\" - Maximilian, the War Mage"
        };
        public static Consumable LuckPotion = new Consumable
        {
            Id = 7,
            Name = LUCK_POTION,
            ItemTemplateName = "consumable_luckpotion.consumable_luckpotion",
            Description = "Primary effect: +100% coin income for 30s. \nSecondary effect: +10% coin from combos.",
            UsageLimit = 5,
            FlavourText = "\"If you see a coin, then pick it up / If you don't, drink potion of luck!\" - Old childhood rhyme."
        };
        public static Consumable ManaPotion = new Consumable
        {
            Id = 8,
            Name = MANA_POTION,
            ItemTemplateName = "consumable_manapotion.consumable_manapotion",
            Description = "Primary effect: restores full mana. \nSecondary effect: +2.5% max mana per second.",
            UsageLimit = 5,
            FlavourText = "Not legal in all territories."
        };
        public static Consumable RagePotion = new Consumable
        {
            Id = 9,
            Name = RAGE_POTION,
            ItemTemplateName = "consumable_ragepotion.consumable_ragepotion",
            Description = "Primary effect: +50% damage for 30s. \nSecondary effect: +15% primary attack damage.",
            UsageLimit = 5,
            FlavourText = "Ready to get your rage on?"
        };
        public static Consumable RepairScroll = new Consumable
        {
            Id = 10,
            Name = REPAIR_SCROLL,
            ItemTemplateName = "consumable_repairscroll.consumable_repairscroll",
            Description = "Primary effect: repairs damage to all Barricades. Has no effect on destroyed items. \nSecondary effect: Barricades are immune to damage for 30s.",
            UsageLimit = 1,
            FlavourText = "We can rebuild them; we have the technology."
        };
        public static Consumable ResurrectionScroll = new Consumable
        {
            Id = 11,
            Name = RESURRECTION_SCROLL,
            ItemTemplateName = "consumable_resscroll.consumable_resurrectionscroll",
            Description = "Primary Effect: Instantly resurrects all dead allied Heroes. \nSecondary effect: Heroes who are alive when the scroll is used will respawn after 3s on their next death.",
            UsageLimit = 1,
            FlavourText = "It isn't a towel, but better take one just to be safe."
        };
        public static Consumable SlowScroll = new Consumable
        {
            Id = 12,
            Name = SLOW_SCROLL,
            ItemTemplateName = "consumable_slowscroll.consumable_slowscroll",
            Description = "Slows nearby Minions by 50% for 30s.",
            UsageLimit = 1,
            FlavourText = "For when you want to slow down and enjoy the carnage."
        };
        public static Consumable SpeedPotion = new Consumable
        {
            Id = 13,
            Name = SPEED_POTION,
            ItemTemplateName = "consumable_speedpotion.consumable_speedpotion",
            Description = "Primary effect: +25% movement speed for 60s. \nSecondary effect: +20% movement speed.",
            UsageLimit = 5,
            FlavourText = "WARNING: Use as directed. Increases movement speed ONLY. Will not increase reading, studying, or thinking speed. Sorry, students. If you experience shortness of breath, dizziness, or chest pains, it's because you're running really fast. Take a break."
        };
        public static Consumable UnchainedScroll = new Consumable
        {
            Id = 14,
            Name = UNCHAINED_SCROLL,
            ItemTemplateName = "consumable_unchainedscroll.unchainedteam_unchainedscroll",
            Description = "Fills and activates the team's Unchained meters.",
            UsageLimit = 1,
            FlavourText = "This Unchained meter goes to ELEVEN!"
        };
        public static Consumable ExperiencePotion = new Consumable
        {
            Id = 15,
            Name = EXPERIENCE_POTION,
            ItemTemplateName = "consumable_xppotion.consumable_xppotion",
            Description = "Primary effect: +2 Battle Levels. \nSecondary effect: +10% XP.",
            UsageLimit = 1,
            FlavourText = "For those too cool for school."
        };

        public static Dictionary<string, Consumable> Consumables = new Dictionary<string, Consumable>
        {
            { BARGAIN_SCROLL, BargainScroll},
            { COOLDOWN_POTION, CooldownPotion},
            { EMPTY_RIFT_SCROLL, EmptyRiftScroll},
            { GUARDIAN_POTION, GuardianPotion},
            { HEALTH_POTION, HealthPotion},
            { INVULNERABILITY_SCROLL, InvulnerabilityScroll},
            { LUCK_POTION, LuckPotion},
            { MANA_POTION, ManaPotion},
            { RAGE_POTION, RagePotion},
            { REPAIR_SCROLL, RepairScroll},
            { RESURRECTION_SCROLL, ResurrectionScroll},
            { SLOW_SCROLL, SlowScroll},
            { SPEED_POTION, SpeedPotion},
            { UNCHAINED_SCROLL, UnchainedScroll},
            { EXPERIENCE_POTION, ExperiencePotion},
        };

        public static Dictionary<int, Consumable> ConsumablesById = new Dictionary<int, Consumable>
        {
            { BargainScroll.Id, BargainScroll},
            { CooldownPotion.Id, CooldownPotion},
            { EmptyRiftScroll.Id, EmptyRiftScroll},
            { GuardianPotion.Id, GuardianPotion},
            { HealthPotion.Id, HealthPotion},
            { InvulnerabilityScroll.Id, InvulnerabilityScroll},
            { LuckPotion.Id, LuckPotion},
            { ManaPotion.Id, ManaPotion},
            { RagePotion.Id, RagePotion},
            { RepairScroll.Id, RepairScroll},
            { ResurrectionScroll.Id, ResurrectionScroll},
            { SlowScroll.Id, SlowScroll},
            { SpeedPotion.Id, SpeedPotion},
            { UnchainedScroll.Id, UnchainedScroll},
            { ExperiencePotion.Id, ExperiencePotion},
        };

        public static Consumable GetById(int id)
        {
            if (ConsumablesById.TryGetValue(id, out var consumable))
            {
                return consumable;
            }
            return new Consumable { Id = 0, Name = "Unknown" };
        }
    }
}