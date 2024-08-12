namespace SingleplayerLauncher.Model
{
    public class Trait : LoadoutItem
    {
        public const string PENTAGON_BONUS_SLOT = "Pentagon";
        public const string DIAMOND_BONUS_SLOT = "Diamond";
        public const string TRIANGLE_BONUS_SLOT = "Triangle";

        public string CodeName { get; set; }
        public string MatchingSlot { get; set; }
        public string UnlockedAt { get; set; }
        public string Rarity { get; set; }
        public Trait MatchingBonusTrait { get; set; }

        // Bonus Traits
        public static Trait BONUS_TRAIT_ARMOR = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitArmor",
            Description = "+8 armor.",
            SiegeDescription = "+8 armor."
        };
        public static Trait BONUS_TRAIT_CC_RESIST = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitCCResist",
            Description = "-10% control effect duration.",
            SiegeDescription = "-10% control effect duration."
        };
        public static Trait BONUS_TRAIT_COIN_TRICKLE = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitCoinTrickle",
            Description = "+1 coin per second.",
            SiegeDescription = "+1 coin per second."
        };
        public static Trait BONUS_TRAIT_COOLDOWN_REDUCTION = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitCooldownReduction",
            Description = "+10.0% cooldown speed.",
            SiegeDescription = "+10.0% cooldown speed."
        };
        public static Trait BONUS_TRAIT_HEALTH = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitHealth",
            Description = "+4.0% max health.",
            SiegeDescription = "+4.0% max health."
        };
        public static Trait BONUS_TRAIT_HEALTH_REGEN = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitHealthRegen",
            Description = "Regenerates 1% max health per second.",
            SiegeDescription = "+12.0% health regeneration."
        };
        public static Trait BONUS_TRAIT_MAGIC_ARMOR = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitMagicArmor",
            Description = "+8 magic armor.",
            SiegeDescription = "+8 magic armor."
        };
        public static Trait BONUS_TRAIT_MANA_MAX = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitManaMax",
            Description = "+8.0% max mana.",
            SiegeDescription = "+8.0% max mana."
        };
        public static Trait BONUS_TRAIT_MANA_REGEN = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitManaRegen",
            Description = "+12.0% mana regeneration.",
            SiegeDescription = "+12.0% mana regeneration."
        };
        public static Trait BONUS_TRAIT_PRIMARY_DAMAGE = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitPrimaryDamage",
            Description = "+5.0% primary attack damage.",
            SiegeDescription = "+5.0% primary attack damage."
        };
        public static Trait BONUS_TRAIT_SPEED = new Trait
        {
            CodeName = "SpitfireGame.RWeaverBonusTraitSpeed",
            Description = "+2.5% movement speed.",
            SiegeDescription = "+2.5% movement speed."
        };
    }
}