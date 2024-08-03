using System.Collections.Generic;
using static SingleplayerLauncher.Names.Glyph;

namespace SingleplayerLauncher.Model
{
    public class Glyph : SlotItem
    {

        // private constructor
        Glyph() { }

        // static members
        public static Glyph GlyphOfAmplification = new Glyph()
        {
            Id = 300,
            Name = GLYPH_OF_AMPLIFICATION,
            ItemTemplateName = "SpitfireGame.RItemTrapGlyphAmplification",
            SiegeDescription = "Amplifies the abilities of minions with RP values that cross it. Glyphs may only be placed in dedicated glyph spaces."
        };
        public static Glyph GlyphOfBlood = new Glyph()
        {
            Id = 301,
            Name = GLYPH_OF_BLOOD,
            ItemTemplateName = "SpitfireGame.RItemTrapGlyphBlood",
            SiegeDescription = "Grants a damage boost to minions that cross it. Glyphs may only be placed in dedicated glyph spaces."
        };
        public static Glyph GlyphOfHealing = new Glyph()
        {
            Id = 302,
            Name = GLYPH_OF_HEALING,
            ItemTemplateName = "SpitfireGame.RItemTrapGlyphHealing",
            SiegeDescription = "Grants health to minions that cross it. Glyphs may only be placed in dedicated glyph spaces."
        };
        public static Glyph GlyphOfHealth = new Glyph()
        {
            Id = 303,
            Name = GLYPH_OF_HEALTH,
            ItemTemplateName = "SpitfireGame.RItemTrapGlyphHealth",
            SiegeDescription = "Grants minor health regeneration to minions that cross it. Glyphs may only be placed in dedicated glyph spaces."
        };
        public static Glyph GlyphOfMagicArmor = new Glyph()
        {
            Id = 304,
            Name = GLYPH_OF_MAGIC_ARMOR,
            ItemTemplateName = "SpitfireGame.RItemTrapGlyphArmorMagic",
            SiegeDescription = "Grants magic armor to minions that cross it. Magic armor protects against elemental damage. Glyphs may only be placed in dedicated glyph spaces."
        };
        public static Glyph GlyphOfPhysicalArmor = new Glyph()
        {
            Id = 305,
            Name = GLYPH_OF_PHYSICAL_ARMOR,
            ItemTemplateName = "SpitfireGame.RItemTrapGlyphPhysicalArmor",
            SiegeDescription = "Increases the physical armor of allied minions who cross it by 20. Glyphs may only be placed in dedicated glyph spaces."
        };
        public static Glyph GlyphOfSneaking = new Glyph()
        {
            Id = 306,
            Name = GLYPH_OF_SNEAKING,
            ItemTemplateName = "SpitfireGame.RItemTrapGlyphStealth",
            SiegeDescription = "Briefly grants stealth to minions that cross it. Glyphs may only be placed in dedicated glyph spaces."
        };
        public static Glyph GlyphOfSpeed = new Glyph()
        {
            Id = 307,
            Name = GLYPH_OF_SPEED,
            ItemTemplateName = "SpitfireGame.RItemTrapGlyphSpeed",
            SiegeDescription = "Increases the movement speed of minions that cross it. Glyphs may only be placed in dedicated glyph spaces."
        };
        public static Glyph MinorGlyphOfHealing = new Glyph()
        {
            Id = 308,
            Name = MINOR_GLYPH_OF_HEALING,
            ItemTemplateName = "SpitfireGame.RItemTrapGlyphHealingMinor",
            SiegeDescription = "Heals minions that cross it. Glyphs may only be placed in dedicated glyph spaces."
        };
        public static Glyph OrcishFieldPromotionGlyph = new Glyph()
        {
            Id = 309,
            Name = ORCISH_FIELD_PROMOTION_GLYPH,
            ItemTemplateName = "SpitfireGame.RItemTrapGlyphOrcishPromotion",
            SiegeDescription = "Promotes 5 orc minions that cross the glyph. Light orcs are promoted to medium orcs, medium to heavy. Glyph expires after 20 promotions."
        };

        public static Dictionary<string, SlotItem> Glyphs = new Dictionary<string, SlotItem>
        {
            { GLYPH_OF_AMPLIFICATION, GlyphOfAmplification },
            { GLYPH_OF_BLOOD, GlyphOfBlood },
            { GLYPH_OF_HEALING, GlyphOfHealing },
            { GLYPH_OF_HEALTH, GlyphOfHealth },
            { GLYPH_OF_MAGIC_ARMOR, GlyphOfMagicArmor },
            { GLYPH_OF_PHYSICAL_ARMOR, GlyphOfPhysicalArmor },
            { GLYPH_OF_SNEAKING, GlyphOfSneaking },
            { GLYPH_OF_SPEED, GlyphOfSpeed },
            { MINOR_GLYPH_OF_HEALING, MinorGlyphOfHealing },
            { ORCISH_FIELD_PROMOTION_GLYPH, OrcishFieldPromotionGlyph }
        };

        public static Dictionary<int, SlotItem> GlyphsById = new Dictionary<int, SlotItem>
        {
            { GlyphOfAmplification.Id, GlyphOfAmplification },
            { GlyphOfBlood.Id, GlyphOfBlood },
            { GlyphOfHealing.Id, GlyphOfHealing },
            { GlyphOfHealth.Id, GlyphOfHealth },
            { GlyphOfMagicArmor.Id, GlyphOfMagicArmor },
            { GlyphOfPhysicalArmor.Id, GlyphOfPhysicalArmor },
            { GlyphOfSneaking.Id, GlyphOfSneaking },
            { GlyphOfSpeed.Id, GlyphOfSpeed },
            { MinorGlyphOfHealing.Id, MinorGlyphOfHealing },
            { OrcishFieldPromotionGlyph.Id, OrcishFieldPromotionGlyph }
        };
    }
}
