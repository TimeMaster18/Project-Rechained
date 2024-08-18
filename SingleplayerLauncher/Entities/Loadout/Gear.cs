using System.Collections.Generic;
using static SingleplayerLauncher.Names.Gear;

namespace SingleplayerLauncher.Model
{
    public class Gear : SlotItem
    {

        // private constructor
        Gear() { }

        // static members
        public static Gear AntitrapVambrace = new()
        {
            Id = 200,
            Name = ANTITRAP_VAMBRACE,
            ItemTemplateName = "SpitfireGame.RItemDisableTrapVambrace",
            Description = "Negates control effects for a short time after use.",
            SiegeDescription = "Zaps traps with a ranged attack that disables them."
        };
        public static Gear ArcaneBubbleBlower = new()
        {
            Id = 201,
            Name = ARCANE_BUBBLE_BLOWER,
            ItemTemplateName = "SpitfireGame.RItemWeaponArcaneBubbleBlower",
            Description = "Creates a bomb that explodes after a time, dealing Arcane damage in that area. It's targets are susceptible to Arcane damage.",
            SiegeDescription = "Blows a bomb that explodes after a time, dealing arcane AoE damage and casting an arcane-damage increasing debuff to its targets."
        };
        public static Gear FireWallBracers = new()
        {
            Id = 202,
            Name = FIRE_WALL_BRACERS,
            ItemTemplateName = "SpitfireGame.RItemWeaponFlameWallBracers",
            Description = "Creates a wall of Fire igniting enemies who walk through it. Fire damage from the same Hero or Trap-type does not stack.",
            SiegeDescription = "Creates a wall of fire that ignites enemies who walk through it. Fire damage from the same hero or trap-type does not stack."
        };
        public static Gear FreedomTrinket = new()
        {
            Id = 203,
            Name = FREEDOM_TRINKET,
            ItemTemplateName = "SpitfireGame.RItemTrinketFreedom",
            Description = "Negates control effects for a short time after use.",
            SiegeDescription = "Negates control effects for a short time after use."
        };
        public static Gear GnomishRepairKit = new()
        {
            Id = 204,
            Name = GNOMISH_REPAIR_KIT,
            ItemTemplateName = "SpitfireGame.RItemTrinketOrcToolkit",
            Description = "Activates a targeted Trap even if it is on cooldown.",
            SiegeDescription = "Activates a targeted trap--even if it is on cooldown or disabled."
        };
        public static Gear GreaterFreedomTrinket = new()
        {
            Id = 205,
            Name = GREATER_FREEDOM_TRINKET,
            ItemTemplateName = "SpitfireGame.RItemTrinketFreedomGreater",
            Description = "Negates control effects for you and nearby allies/minions for a short time after use.",
            SiegeDescription = "Negates control effects for a short time after use."
        };
        public static Gear HobgoblinCharm = new()
        {
            Id = 206,
            Name = HOBGOBLIN_CHARM,
            ItemTemplateName = "SpitfireGame.RItemTrinketHobgoblinCharm",
            Description = "Heals an allied minion. Siege gear but can work on summoned allied minions.",
            SiegeDescription = "Rapidly heals a targeted minion for a significant amount of health."
        };
        public static Gear IceAmulet = new()
        {
            Id = 207,
            Name = ICE_AMULET,
            ItemTemplateName = "SpitfireGame.RItemWeaponIceAmulet",
            Description = "Fires three projectiles at once. Frost damage applies chilled to enemies, which can cause them to become frozen.",
            SiegeDescription = "Fires three frost projectiles at once. Frost damage applies Chilled to enemies, which can cause them to become frozen."
        };
        public static Gear LightningRing = new()
        {
            Id = 208,
            Name = LIGHTNING_RING,
            ItemTemplateName = "SpitfireGame.RItemWeaponLightningRing",
            Description = "Fires a short burst of Lightning damage to enemies in range.",
            SiegeDescription = "Fires a chain of lightning. Lightning chains from target to target within a short range. Enemies killed by lightning damage explode for AoE damage."
        };
        public static Gear MagesClover = new()
        {
            Id = 209,
            Name = MAGES_CLOVER,
            ItemTemplateName = "SpitfireGame.RItemTrinketManaRegen",
            Description = "Grants a short period of increased mana regeneration. Effect is canceled upon taking damage.",
            SiegeDescription = "Grants a short period of increased mana regeneration. Effect is canceled upon taking damage."
        };
        public static Gear MagesPicnic = new()
        {
            Id = 210,
            Name = MAGES_PICNIC,
            ItemTemplateName = "SpitfireGame.RItemTrinketMagesPicnic",
            Description = "Creates a totem that increases mana regeneration for nearby allied players.",
            SiegeDescription = "Creates a totem that increases mana regeneration for nearby allied players."
        };
        public static Gear MendingRoot = new()
        {
            Id = 211,
            Name = MENDING_ROOT,
            ItemTemplateName = "SpitfireGame.RItemTrinketHealing",
            Description = "Grants a short duration of increased health regeneration. Being attacked cancels the regeneration.",
            SiegeDescription = "Grants a short period of increased health regeneration. Effect is canceled upon taking damage."
        };
        public static Gear RingOfLastStand = new()
        {
            Id = 212,
            Name = RING_OF_LAST_STAND,
            ItemTemplateName = "SpitfireGame.RItemTrinketLastStand",
            Description = "Grants the Hero damage immunity for a short duration.",
            SiegeDescription = "Makes hero briefly immune to damage. The hero suffers a debuff that reduces all armor types after use."
        };
        public static Gear RingOfStorms = new()
        {
            Id = 213,
            Name = RING_OF_STORMS,
            ItemTemplateName = "SpitfireGame.RItemWeaponLightningCloudRing",
            Description = "Creates a storm that deals Lightning damage to enemies in range. Enemies killed by Lightning explode, dealing damage in an area around them.",
            SiegeDescription = "Creates a storm cloud that deals lightning damage to enemies in range. Enemies killed by lightning damage explode for AoE damage."
        };
        public static Gear TeleportationRing = new()
        {
            Id = 214,
            Name = TELEPORTATION_RING,
            ItemTemplateName = "SpitfireGame.RItemTrinketTeleport",
            Description = "Teleports the Hero back to its allied rift. Ring takes 1s to cast. Taking damage interrupts cast.",
            SiegeDescription = "Teleports the hero back to its allied rift. Trinket takes 4s to cast. Taking damage interrupts casting."
        };
        public static Gear FlameBracers = new()
        {
            Id = 215,
            Name = FLAME_BRACERS,
            ItemTemplateName = "gear_firebracers.gear_firebracers",
            Description = "Launches a Fireball that deals significant damage over time to the first target hit. Fire damage from the same hero or trap-type does not stack.",
            SiegeDescription = "Launches a fireball that deals significant DoT to the first target hit. Fire damage from the same hero or trap-type does not stack."
        };


        public static Dictionary<string, SlotItem> Gears = new()
        {
            { ANTITRAP_VAMBRACE, AntitrapVambrace },
            { ARCANE_BUBBLE_BLOWER, ArcaneBubbleBlower },
            { FIRE_WALL_BRACERS, FireWallBracers },
            { FREEDOM_TRINKET, FreedomTrinket },
            { GNOMISH_REPAIR_KIT, GnomishRepairKit },
            // { GREATER_FREEDOM_TRINKET, GreaterFreedomTrinket },
            { HOBGOBLIN_CHARM, HobgoblinCharm },
            { ICE_AMULET, IceAmulet },
            { LIGHTNING_RING, LightningRing },
            { MAGES_CLOVER, MagesClover },
            { MAGES_PICNIC, MagesPicnic },
            { MENDING_ROOT, MendingRoot },
            { RING_OF_LAST_STAND, RingOfLastStand },
            { RING_OF_STORMS, RingOfStorms },
            { TELEPORTATION_RING, TeleportationRing },
            { FLAME_BRACERS, FlameBracers }
        };


        public static Dictionary<int, SlotItem> GearsById = new()
        {
            {  AntitrapVambrace.Id, AntitrapVambrace },
            {  ArcaneBubbleBlower.Id, ArcaneBubbleBlower },
            {  FireWallBracers.Id, FireWallBracers },
            {  FreedomTrinket.Id, FreedomTrinket },
            {  GnomishRepairKit.Id, GnomishRepairKit },
            {  GreaterFreedomTrinket.Id, GreaterFreedomTrinket },
            {  HobgoblinCharm.Id, HobgoblinCharm },
            {  IceAmulet.Id, IceAmulet },
            {  LightningRing.Id, LightningRing },
            {  MagesClover.Id, MagesClover },
            {  MagesPicnic.Id, MagesPicnic },
            {  MendingRoot.Id, MendingRoot },
            {  RingOfLastStand.Id, RingOfLastStand },
            {  RingOfStorms.Id, RingOfStorms },
            {  TeleportationRing.Id, TeleportationRing },
            {  FlameBracers.Id, FlameBracers }
        };
    }
}
