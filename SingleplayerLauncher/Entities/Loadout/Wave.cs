using System.Collections.Generic;
using static SingleplayerLauncher.Names.Wave;

namespace SingleplayerLauncher.Model
{
    public class Wave : LoadoutItem
    {
        public string CodeName { get; private set; }
        public int Cost { get; private set; }
        public int Level { get; private set; }
        public int TotalBounty { get; private set; }
        public string KeywordText { get; private set; }
        public string KeywordDescription { get; private set; }

        public static Wave KoboldWave = new()
        {
            Id = 1,
            CodeName = "SpitfireGame.RWaveMonoWaves000",
            Name = LVL1_9_KOBOLDS,
            Description = "Kobold runners rely on speed to get behind enemy lines because of their low HPs. Large groups are difficult to keep out of rifts.",
            Cost = 0,
            Level = 1,
            TotalBounty = 500,
            KeywordText = "Swarm",
            KeywordDescription = "Waves spawn in large numbers."
        };
        public static Wave LightSoldiersWave = new()
        {
            Id = 2,
            CodeName = "SpitfireGame.RWaveMonoWaves001",
            Name = LVL1_5_LIGHT_SOLDIERS,
            Description = "Light soldiers sport average armor, deal average damage, and have average HPs, but they gain some damage resistance at low health.",
            Cost = 0,
            Level = 1,
            TotalBounty = 500,
            KeywordText = "Steady",
            KeywordDescription = "Acquires moderate damage resistance while at low health."
        };
        public static Wave GnollHuntersWave = new()
        {
            Id = 3,
            CodeName = "SpitfireGame.RWaveMonoWaves002",
            Name = LVL2_3_GNOLL_HUNTERS,
            Description = "Gnoll hunters prioritize heroes and guardians. They deal a crushing amount of physical damage but are worth no RPs.",
            Cost = 250,
            Level = 2,
            TotalBounty = 500,
            KeywordText = "Leaping",
            KeywordDescription = "Jumps over barricade and wall traps."
        };
        public static Wave LightSoldiersWave8 = new()
        {
            Id = 4,
            CodeName = "SpitfireGame.RWaveMonoWaves003",
            Name = LVL2_8_LIGHT_SOLDIERS,
            Description = "Light soldiers sport average armor, deal average damage, and have average HPs, but they gain some damage resistance at low health.",
            Cost = 250,
            Level = 2,
            TotalBounty = 500,
            KeywordText = "Steady",
            KeywordDescription = "Acquires moderate damage resistance while at low health."
        };
        public static Wave OgresWave3 = new()
        {
            Id = 5,
            CodeName = "SpitfireGame.RWaveMonoWaves004",
            Name = LVL3_3_OGRES,
            Description = "Ogres hit hard, stunning their enemies with their blows. They are also too large to be affected by physics traps.",
            Cost = 300,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Stun",
            KeywordDescription = "Stuns enemies with attacks."
        };
        public static Wave CrossbowOrcsWave4 = new()
        {
            Id = 6,
            CodeName = "SpitfireGame.RWaveMonoWaves005",
            Name = LVL1_4_CROSSBOW_ORCS,
            Description = "Crossbow orcs deal light ranged physical damage and have low HPs. However, they are deadly in groups.",
            Cost = 0,
            Level = 1,
            TotalBounty = 500,
            KeywordText = "Ranged",
            KeywordDescription = "Attacks at range."
        };
        public static Wave OgresWave5 = new()
        {
            Id = 7,
            CodeName = "SpitfireGame.RWaveMonoWaves006",
            Name = LVL4_5_OGRES,
            Description = "Ogres hit hard, stunning their enemies with their blows. They are also too large to be affected by physics traps.",
            Cost = 350,
            Level = 4,
            TotalBounty = 500,
            KeywordText = "Stun",
            KeywordDescription = "Stuns enemies with attacks."
        };
        public static Wave GiantsWave3 = new()
        {
            Id = 8,
            CodeName = "SpitfireGame.RWaveMonoWaves007",
            Name = LVL4_3_GIANTS,
            Description = "Giants may be slow but they are heavy-hitting, dealing massive physical damage. At low HPs, they move and attack more quickly.",
            Cost = 350,
            Level = 4,
            TotalBounty = 500,
            KeywordText = "Enraging",
            KeywordDescription = "Doubles movement and attack speed when below 35% health."
        };
        public static Wave SatyrsWave9 = new()
        {
            Id = 9,
            CodeName = "SpitfireGame.RWaveMonoWaves008",
            Name = LVL3_9_SATYRS,
            Description = "Satyr runners are small and weak but fast. They ignore heroes and avoid damage. Large groups are difficult to keep out of rifts.",
            Cost = 300,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Phasing",
            KeywordDescription = "Gains a 2s damage shield when hit. Effect has 20s cooldown."
        };
        public static Wave SatyrsWave14 = new()
        {
            Id = 10,
            CodeName = "SpitfireGame.RWaveMonoWaves009",
            Name = LVL4_14_SATYRS,
            Description = "Satyr runners are small and weak but fast. They ignore heroes and avoid damage. Large groups are difficult to keep out of rifts.",
            Cost = 350,
            Level = 4,
            TotalBounty = 500,
            KeywordText = "Phasing",
            KeywordDescription = "Gains a 2s damage shield when hit. Effect has 20s cooldown."
        };
        public static Wave KoboldWave14 = new()
        {
            Id = 11,
            CodeName = "SpitfireGame.RWaveMonoWaves010",
            Name = LVL2_14_KOBOLDS,
            Description = "Kobold runners rely on speed to get behind enemy lines because of their low HPs. Large groups are difficult to keep out of rifts.",
            Cost = 250,
            Level = 2,
            TotalBounty = 500,
            KeywordText = "Swarm",
            KeywordDescription = "Waves spawn in large numbers."
        };
        public static Wave GnollHuntersWave2 = new()
        {
            Id = 12,
            CodeName = "SpitfireGame.RWaveMonoWaves011",
            Name = LVL1_2_GNOLL_HUNTERS,
            Description = "Gnoll hunters prioritize heroes and guardians. They deal a crushing amount of physical damage but are worth no RPs.",
            Cost = 0,
            Level = 1,
            TotalBounty = 500,
            KeywordText = "Leaping",
            KeywordDescription = "Jumps over barricade and wall traps."
        };
        public static Wave MediumSoldiersWave5 = new()
        {
            Id = 13,
            CodeName = "SpitfireGame.RWaveMonoWaves012",
            Name = LVL3_5_MEDIUM_SOLDIERS,
            Description = "Medium soldiers have moderate armor, HPs, and deal moderate damage. They gain some damage resistance at low health.",
            Cost = 300,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Steady",
            KeywordDescription = "Acquires moderate damage resistance while at low health."
        };
        public static Wave MediumSoldiersWave8 = new()
        {
            Id = 14,
            CodeName = "SpitfireGame.RWaveMonoWaves013",
            Name = LVL4_8_MEDIUM_SOLDIERS,
            Description = "Medium soldiers have moderate armor, HPs, and deal moderate damage. They gain some damage resistance at low health.",
            Cost = 350,
            Level = 4,
            TotalBounty = 500,
            KeywordText = "Steady",
            KeywordDescription = "Acquires moderate damage resistance while at low health."
        };
        public static Wave HumanCrossbowmenWave4 = new()
        {
            Id = 15,
            CodeName = "SpitfireGame.RWaveMonoWaves014",
            Name = LVL3_4_HUMAN_CROSSBOWMEN,
            Description = "Crossbowmen pepper their enemies with crossbow bolts, dealing high damage at range. They are deadly in groups.",
            Cost = 300,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Ranged",
            KeywordDescription = "Attacks at range."
        };
        public static Wave HumanCrossbowmenWave6 = new()
        {
            Id = 16,
            CodeName = "SpitfireGame.RWaveMonoWaves015",
            Name = LVL4_6_HUMAN_CROSSBOWMEN,
            Description = "Crossbowmen pepper their enemies with crossbow bolts, dealing high damage at range. They are deadly in groups.",
            Cost = 350,
            Level = 4,
            TotalBounty = 500,
            KeywordText = "Ranged",
            KeywordDescription = "Attacks at range."
        };
        public static Wave TrollsWave2 = new()
        {
            Id = 17,
            CodeName = "SpitfireGame.RWaveMonoWaves016",
            Name = LVL4_2_TROLLS,
            Description = "Large and thankfully solitary, trolls deal massive physical damage and regenerate their HPs. They are also large enough to ignore physics traps.",
            Cost = 350,
            Level = 4,
            TotalBounty = 500,
            KeywordText = "Regeneration",
            KeywordDescription = "Regenerates 2%/s health while not in combat."
        };
        public static Wave GiantsWave2 = new()
        {
            Id = 18,
            CodeName = "SpitfireGame.RWaveMonoWaves017",
            Name = LVL3_2_GIANTS,
            Description = "Giants may be slow but they are heavy-hitting, dealing massive physical damage. At low HPs, they move and attack more quickly.",
            Cost = 300,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Enraging",
            KeywordDescription = "Doubles movement and attack speed when below 35% health."
        };
        public static Wave CyclopsShamansWave2 = new()
        {
            Id = 19,
            CodeName = "SpitfireGame.RWaveMonoWaves018",
            Name = LVL2_2_CYCLOPS_SHAMANS,
            Description = "As followers of Stinkeye, these cyclops shamans wield the power of Oasis and are able to shoot high-damage arcane projectiles and resist most magic damage.",
            Cost = 250,
            Level = 2,
            TotalBounty = 500,
            KeywordText = "Growing",
            KeywordDescription = ""
        };
        public static Wave CyclopsShamansWave3 = new()
        {
            Id = 20,
            CodeName = "SpitfireGame.RWaveMonoWaves019",
            Name = LVL3_3_CYCLOPS_SHAMANS,
            Description = "As followers of Stinkeye, these cyclops shamans wield the power of Oasis and are able to shoot high-damage arcane projectiles and resist most magic damage.",
            Cost = 300,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Growing",
            KeywordDescription = ""
        };
        public static Wave GnomeTinkerersWave4 = new()
        {
            Id = 21,
            CodeName = "SpitfireGame.RWaveMonoWaves020",
            Name = LVL2_4_GNOME_TINKERERS,
            Description = "",
            Cost = 250,
            Level = 2,
            TotalBounty = 500,
            KeywordText = "Trap Disable",
            KeywordDescription = ""
        };
        public static Wave GnomeTinkerersWave9 = new()
        {
            Id = 22,
            CodeName = "SpitfireGame.RWaveMonoWaves021",
            Name = LVL4_9_GNOME_TINKERERS,
            Description = "Gnomes have trap-disabling down to a science. Gnome tinkerers are fast and run quickly towards traps, disabling them.",
            Cost = 350,
            Level = 4,
            TotalBounty = 500,
            KeywordText = "Trap Disable",
            KeywordDescription = ""
        };
        public static Wave GrizzlyBearsWave2 = new()
        {
            Id = 23,
            CodeName = "SpitfireGame.RWaveMonoWaves022",
            Name = LVL1_2_GRIZZLY_BEARS,
            Description = "Always ready and roaring for a fight, grizzly minions are intimidating in size and angered when their allies fall.",
            Cost = 0,
            Level = 1,
            TotalBounty = 500,
            KeywordText = "Vengeance",
            KeywordDescription = "Regains 25% of its HPs when a nearby ally dies."
        };
        public static Wave GrizzlyBearsWave3 = new()
        {
            Id = 24,
            CodeName = "SpitfireGame.RWaveMonoWaves023",
            Name = LVL2_3_GRIZZLY_BEARS,
            Description = "Always ready and roaring for a fight, grizzly minions are intimidating in size and angered when their allies fall.",
            Cost = 250,
            Level = 2,
            TotalBounty = 500,
            KeywordText = "Vengeance",
            KeywordDescription = "Regains 25% of its HPs when a nearby ally dies."
        };
        public static Wave HobgoblinShamansWave2 = new()
        {
            Id = 25,
            CodeName = "SpitfireGame.RWaveMonoWaves024",
            Name = LVL3_2_HOBGOBLIN_SHAMANS,
            Description = "Hobgoblin shamans have secret healing techniques known only by their cabal and loyally heal allied minions and heroes.",
            Cost = 300,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Healing",
            KeywordDescription = "Heals nearby minions."
        };
        public static Wave HobgoblinShamansWave3 = new()
        {
            Id = 26,
            CodeName = "SpitfireGame.RWaveMonoWaves025",
            Name = LVL4_3_HOBGOBLIN_SHAMANS,
            Description = "Hobgoblin shamans have secret healing techniques known only by their cabal and loyally heal allied minions and heroes.",
            Cost = 350,
            Level = 4,
            TotalBounty = 500,
            KeywordText = "Healing",
            KeywordDescription = "Heals nearby minions."
        };
        public static Wave DwarfShamansWave2 = new()
        {
            Id = 27,
            CodeName = "SpitfireGame.RWaveMonoWaves026",
            Name = LVL1_2_DWARF_SHAMANS,
            Description = "Dwarf shamans provide their allies with a magic shield that protects against all damage types but have low HPs themselves.",
            Cost = 0,
            Level = 1,
            TotalBounty = 500,
            KeywordText = "Shielding",
            KeywordDescription = "Casts a shield on nearby allied minions."
        };
        public static Wave DwarfShamansWave3 = new()
        {
            Id = 28,
            CodeName = "SpitfireGame.RWaveMonoWaves027",
            Name = LVL2_3_DWARF_SHAMANS,
            Description = "Dwarf shamans provide their allies with a magic shield that protects against all damage types but have low HPs themselves.",
            Cost = 250,
            Level = 2,
            TotalBounty = 500,
            KeywordText = "Shielding",
            KeywordDescription = "Casts a shield on nearby allied minions."
        };
        public static Wave LightOrcsWave9 = new()
        {
            Id = 29,
            CodeName = "SpitfireGame.RWaveMonoWaves028",
            Name = LVL1_9_LIGHT_ORCS,
            Description = "Light orcs have an average amount of health and armor and deal average physical damage, but in large groups they wreck enemy defenses.",
            Cost = 0,
            Level = 1,
            TotalBounty = 500,
            KeywordText = "Swarm",
            KeywordDescription = "Waves spawn in large numbers."
        };
        public static Wave FireMagesWave2 = new()
        {
            Id = 30,
            CodeName = "SpitfireGame.RWaveMonoWaves029",
            Name = LVL4_2_FIRE_MAGES,
            Description = "These mages are masters of fire magic, casting high-damage, ranged fire spells. They're also resistant to trap damage.",
            Cost = 350,
            Level = 4,
            TotalBounty = 500,
            KeywordText = "High Damage",
            KeywordDescription = "Deals high damage."
        };
        public static Wave CrossbowOrcsWave6 = new()
        {
            Id = 31,
            CodeName = "SpitfireGame.RWaveMonoWaves031",
            Name = LVL2_6_CROSSBOW_ORCS,
            Description = "Crossbow orcs deal light ranged physical damage and have low HPs. However, they are deadly in groups.",
            Cost = 250,
            Level = 2,
            TotalBounty = 500,
            KeywordText = "Ranged",
            KeywordDescription = "Attacks at range."
        };
        public static Wave PrideHuntersWave2 = new()
        {
            Id = 32,
            CodeName = "SpitfireGame.RWaveMonoWaves032",
            Name = LVL3_2_PRIDE_HUNTERS,
            Description = "Pride hunters pursue and take down heroes. They also regain HPs when nearby allies die but are worth no RPs.",
            Cost = 300,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Leaping",
            KeywordDescription = "Jumps over barricade and wall traps."
        };
        public static Wave PrideHuntersWave3 = new()
        {
            Id = 33,
            CodeName = "SpitfireGame.RWaveMonoWaves033",
            Name = LVL4_3_PRIDE_HUNTERS,
            Description = "Pride hunters pursue and take down heroes. They also regain HPs when nearby allies die but are worth no RPs.",
            Cost = 350,
            Level = 4,
            TotalBounty = 500,
            KeywordText = "Leaping",
            KeywordDescription = "Jumps over barricade and wall traps."
        };
        public static Wave GrizzlyShieldbearersWave2 = new()
        {
            Id = 34,
            CodeName = "SpitfireGame.RWaveMonoWaves034",
            Name = LVL1_2_GRIZZLY_SHIELDBEARERS,
            Description = "Grizzly shieldbearers destroy gates and guardians, ignore heroes and physics traps, and shield themselves from frontal assaults.",
            Cost = 0,
            Level = 1,
            TotalBounty = 500,
            KeywordText = "Block",
            KeywordDescription = "Blocks frontal assaults."
        };
        public static Wave GrizzlyShieldbearersWave3 = new()
        {
            Id = 35,
            CodeName = "SpitfireGame.RWaveMonoWaves035",
            Name = LVL2_3_GRIZZLY_SHIELDBEARERS,
            Description = "Grizzly shieldbearers destroy gates and guardians, ignore heroes and physics traps, and shield themselves from frontal assaults.",
            Cost = 250,
            Level = 2,
            TotalBounty = 500,
            KeywordText = "Block",
            KeywordDescription = "Blocks frontal assaults."
        };
        public static Wave TrollShieldbearersWave2 = new()
        {
            Id = 36,
            CodeName = "SpitfireGame.RWaveMonoWaves036",
            Name = LVL3_2_TROLL_SHIELDBEARERS,
            Description = "Troll shieldbearers deflect frontal attacks, deal physical damage, regenerate HPs, ignore heroes and physics traps, and focus on guardians and gates.",
            Cost = 300,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Block",
            KeywordDescription = "Blocks frontal assaults."
        };
        public static Wave TrollShieldbearersWave3 = new()
        {
            Id = 37,
            CodeName = "SpitfireGame.RWaveMonoWaves037",
            Name = LVL4_3_TROLL_SHIELDBEARERS,
            Description = "Troll shieldbearers deflect frontal attacks, deal physical damage, regenerate HPs, ignore heroes and physics traps, and focus on guardians and gates.",
            Cost = 350,
            Level = 4,
            TotalBounty = 500,
            KeywordText = "Block",
            KeywordDescription = "Blocks frontal assaults."
        };
        public static Wave LightOrcsWave14 = new()
        {
            Id = 38,
            CodeName = "SpitfireGame.RWaveMonoWaves038",
            Name = LVL2_14_LIGHT_ORCS,
            Description = "Light orcs are new, inexperienced fighters. They have an average amount of HPs and deal an average amount of physical damage. However, in large groups they can wreck enemy defenses.",
            Cost = 250,
            Level = 2,
            TotalBounty = 500,
            KeywordText = "Swarm",
            KeywordDescription = "Waves spawn in large numbers."
        };
        public static Wave MediumOrcsWave9 = new()
        {
            Id = 39,
            CodeName = "SpitfireGame.RWaveMonoWaves039",
            Name = LVL3_9_MEDIUM_ORCS,
            Description = "Medium orcs hit a little harder and take a little more abuse than light orcs. They deal moderate damage and have moderate HPs.",
            Cost = 300,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Swarm",
            KeywordDescription = "Waves spawn in large numbers."
        };
        public static Wave MediumOrcsWave14 = new()
        {
            Id = 40,
            CodeName = "SpitfireGame.RWaveMonoWaves040",
            Name = LVL4_14_MEDIUM_ORCS,
            Description = "Medium orcs hit a little harder and take a little more abuse than light orcs. They deal moderate damage and have moderate HPs.",
            Cost = 350,
            Level = 4,
            TotalBounty = 500,
            KeywordText = "Swarm",
            KeywordDescription = "Waves spawn in large numbers."
        };

        public static Wave OrfumMountainTroll = new()
        {
            Id = 41,
            CodeName = "SpitfireGame.RWaveMercWaves001",
            Name = BOSS_ORFUM_MOUNTAIN_TROLL,
            Description = "Orfum, a venerated troll warrior, attacks barricades and, like most trolls, regenerates health when he is not taking damage.",
            Cost = 4000,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Barricade Attack",
            KeywordDescription = "Destroys wall and barricade traps."
        };

        public static Wave OakentoesDwarfShaman = new()
        {
            Id = 42,
            CodeName = "SpitfireGame.RWaveMercWaves002",
            Name = BOSS_OAKENTOES_DWARF_SHAMAN,
            Description = "",
            Cost = 2000,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "",
            KeywordDescription = ""
        };

        public static Wave SawbonesHobgoblinShaman = new()
        {
            Id = 43,
            CodeName = "SpitfireGame.RWaveMercWaves003",
            Name = BOSS_SAWBONES_HOBGOBLIN_SHAMAN,
            Description = "",
            Cost = 2000,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "",
            KeywordDescription = ""
        };

        public static Wave BulgodArmoredOgre = new()
        {
            Id = 44,
            CodeName = "SpitfireGame.RWaveMercWaves004",
            Name = BOSS_BULGOD_ARMORED_OGRE,
            Description = "Bulgod, an armored ogre general, stomps around and disables traps in a wide AoE with his attack, giving his cohorts a better chance at surviving enemy killboxes.",
            Cost = 4000,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Shockwave",
            KeywordDescription = "Concussive waves disable nearby traps and throw enemy heroes."
        };

        public static Wave UrzaFireLord = new()
        {
            Id = 45,
            CodeName = "SpitfireGame.RWaveMercWaves005",
            Name = BOSS_URZA_FIRE_LORD,
            Description = "Urza, the Firelord, is very hard to kill. When Urza's main form is destroyed, he splits into smaller, explosive versions of himself. Urza also resists fire damage.",
            Cost = 4000,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Fireling Replication",
            KeywordDescription = "Divides into smaller units upon death."
        };

        public static Wave GaeadinEarthLord = new()
        {
            Id = 46,
            CodeName = "SpitfireGame.RWaveMercWaves006",
            Name = BOSS_GAEADIN_EARTH_LORD,
            Description = "Gaeadin, the Earth Lord, is immune to slowing and stunning effects and splits into smaller versions of herself when destroyed, making her very hard to kill.",
            Cost = 4000,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Replication",
            KeywordDescription = "Divides into smaller units upon death."
        };

        public static Wave Swiftyhooves = new()
        {
            Id = 47,
            CodeName = "SpitfireGame.RWaveMercWaves007",
            Name = BOSS_SWIFTYHOOVES,
            Description = "A very large and very fast satyr, Swiftyhooves dashes quickly towards enemy rifts, jumping any walls or barricades in his path.",
            Cost = 4000,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Fast",
            KeywordDescription = "Unusually quick and not easily distracted."
        };

        public static Wave TikLikHobgoblinShaman = new()
        {
            Id = 48,
            CodeName = "SpitfireGame.RWaveMercWaves008",
            Name = BOSS_TIKLIK_HOBGOBLIN_SHAMAN,
            Description = "TikLik is the leader of the hobgoblin shamans, and so wears the mysteriously powerful chieftain mask. TikLik uses his powers to heal other allied minions.",
            Cost = 4000,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Player Heal",
            KeywordDescription = "Heals nearby allied heroes."
        };

        public static Wave Vitality = new()
        {
            Id = 49,
            CodeName = "SpitfireGame.RWaveMercWaves009",
            Name = BOSS_VITALITY,
            Description = "Vitality, a cyclops, has learned the secrets of resurrection. On the battlefield, Vitality resurrects allied minions.",
            Cost = 4000,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Resurrection",
            KeywordDescription = "Periodically resurrects nearby fallen minions."
        };

        public static Wave Gatebreaker = new()
        {
            Id = 50,
            CodeName = "SpitfireGame.RWaveMercWaves010",
            Name = BOSS_GATEBREAKER,
            Description = "Like his name suggests, the Gatebreaker charges forward to eliminate gates with his personal battering ram.",
            Cost = 4000,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "",
            KeywordDescription = ""
        };

        public static Wave LyzanderCultResurrector = new()
        {
            Id = 51,
            CodeName = "SpitfireGame.RWaveMercWaves011",
            Name = BOSS_LYZANDER_CULT_RESURRECTOR,
            Description = "Lyzander, a disciple of the Cult of Death, practices one of the arts of necromancy: resurrection. On the battlefield, Lyzander resurrects allied minions.",
            Cost = 4000,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Resurrection",
            KeywordDescription = "Periodically resurrects nearby fallen minions."
        };

        public static Wave GrenwaldeNatureLord = new()
        {
            Id = 52,
            CodeName = "SpitfireGame.RWaveMercWaves012",
            Name = BOSS_GRENWALDE_NATURE_LORD,
            Description = "Grenwalde, the Nature Lord, blesses those who respect the sanctity of nature by using his powers to heal his allies and steal life from his foes.",
            Cost = 4000,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Player Heal",
            KeywordDescription = "Heals nearby allied heroes."
        };

        public static Wave Tubifore = new()
        {
            Id = 53,
            CodeName = "SpitfireGame.RWaveMercWaves013",
            Name = BOSS_TUBIFORE,
            Description = "Tubifore, the son Bionka never speaks of, attacks barricades and regenerates health when he is not taking damage.",
            Cost = 4000,
            Level = 3,
            TotalBounty = 500,
            KeywordText = "Barricade Attack",
            KeywordDescription = "Destroys wall and barricade traps."
        };


        public static Dictionary<string, Wave> Waves = new()
        {
            { KoboldWave.Name, KoboldWave },
            { LightSoldiersWave.Name, LightSoldiersWave },
            { GnollHuntersWave.Name, GnollHuntersWave },
            { LightSoldiersWave8.Name, LightSoldiersWave8 },
            { OgresWave3.Name, OgresWave3 },
            { CrossbowOrcsWave4.Name, CrossbowOrcsWave4 },
            { OgresWave5.Name, OgresWave5 },
            { GiantsWave3.Name, GiantsWave3 },
            { SatyrsWave9.Name, SatyrsWave9 },
            { SatyrsWave14.Name, SatyrsWave14 },
            { KoboldWave14.Name, KoboldWave14 },
            { GnollHuntersWave2.Name, GnollHuntersWave2 },
            { MediumSoldiersWave5.Name, MediumSoldiersWave5 },
            { MediumSoldiersWave8.Name, MediumSoldiersWave8 },
            { HumanCrossbowmenWave4.Name, HumanCrossbowmenWave4 },
            { HumanCrossbowmenWave6.Name, HumanCrossbowmenWave6 },
            { TrollsWave2.Name, TrollsWave2 },
            { GiantsWave2.Name, GiantsWave2 },
            { CyclopsShamansWave2.Name, CyclopsShamansWave2 },
            { CyclopsShamansWave3.Name, CyclopsShamansWave3 },
            { GnomeTinkerersWave4.Name, GnomeTinkerersWave4 },
            { GnomeTinkerersWave9.Name, GnomeTinkerersWave9 },
            { GrizzlyBearsWave2.Name, GrizzlyBearsWave2 },
            { GrizzlyBearsWave3.Name, GrizzlyBearsWave3 },
            { HobgoblinShamansWave2.Name, HobgoblinShamansWave2 },
            { HobgoblinShamansWave3.Name, HobgoblinShamansWave3 },
            { DwarfShamansWave2.Name, DwarfShamansWave2 },
            { DwarfShamansWave3.Name, DwarfShamansWave3 },
            { LightOrcsWave9.Name, LightOrcsWave9 },
            { FireMagesWave2.Name, FireMagesWave2 },
            { CrossbowOrcsWave6.Name, CrossbowOrcsWave6 },
            { PrideHuntersWave2.Name, PrideHuntersWave2 },
            { PrideHuntersWave3.Name, PrideHuntersWave3 },
            { GrizzlyShieldbearersWave2.Name, GrizzlyShieldbearersWave2 },
            { GrizzlyShieldbearersWave3.Name, GrizzlyShieldbearersWave3 },
            { TrollShieldbearersWave2.Name, TrollShieldbearersWave2 },
            { TrollShieldbearersWave3.Name, TrollShieldbearersWave3 },
            { LightOrcsWave14.Name, LightOrcsWave14 },
            { MediumOrcsWave9.Name, MediumOrcsWave9 },
            { MediumOrcsWave14.Name, MediumOrcsWave14 },
            { OrfumMountainTroll.Name, OrfumMountainTroll },
            { OakentoesDwarfShaman.Name, OakentoesDwarfShaman },
            { SawbonesHobgoblinShaman.Name, SawbonesHobgoblinShaman },
            { BulgodArmoredOgre.Name, BulgodArmoredOgre },
            { UrzaFireLord.Name, UrzaFireLord },
            { GaeadinEarthLord.Name, GaeadinEarthLord },
            { Swiftyhooves.Name, Swiftyhooves },
            { TikLikHobgoblinShaman.Name, TikLikHobgoblinShaman },
            { Vitality.Name, Vitality },
            { Gatebreaker.Name, Gatebreaker },
            { LyzanderCultResurrector.Name, LyzanderCultResurrector },
            { GrenwaldeNatureLord.Name, GrenwaldeNatureLord },
            { Tubifore.Name, Tubifore }
        };

        public static Dictionary<string, Wave> Lvl1Waves = new()
        {
            { KoboldWave.Name, KoboldWave },
            { LightSoldiersWave.Name, LightSoldiersWave },
            { CrossbowOrcsWave4.Name, CrossbowOrcsWave4 },
            { GnollHuntersWave2.Name, GnollHuntersWave2 },
            { GrizzlyShieldbearersWave2.Name, GrizzlyShieldbearersWave2 },
            { GrizzlyBearsWave2.Name, GrizzlyBearsWave2 },
            { DwarfShamansWave2.Name, DwarfShamansWave2 },
            { LightOrcsWave9.Name, LightOrcsWave9 }
        };

        public static Dictionary<string, Wave> Lvl2Waves = new()
        {
            { GnollHuntersWave.Name, GnollHuntersWave },
            { LightSoldiersWave8.Name, LightSoldiersWave8 },
            { KoboldWave14.Name, KoboldWave14 },
            { GnomeTinkerersWave4.Name, GnomeTinkerersWave4 },
            { GrizzlyBearsWave3.Name, GrizzlyBearsWave3 },
            { GrizzlyShieldbearersWave2.Name, GrizzlyShieldbearersWave2 },
            { DwarfShamansWave3.Name, DwarfShamansWave3 },
            { CrossbowOrcsWave6.Name, CrossbowOrcsWave6 },
            { LightOrcsWave14.Name, LightOrcsWave14 },
        };

        public static Dictionary<string, Wave> Lvl3Waves = new()
        {
            { OgresWave3.Name, OgresWave3 },
            { GiantsWave2.Name, GiantsWave2 },
            { SatyrsWave9.Name, SatyrsWave9 },
            { MediumSoldiersWave5.Name, MediumSoldiersWave5 },
            { HumanCrossbowmenWave4.Name, HumanCrossbowmenWave4 },
            { HobgoblinShamansWave2.Name, HobgoblinShamansWave2 },
            { PrideHuntersWave2.Name, PrideHuntersWave2 },
            { TrollShieldbearersWave2.Name, TrollShieldbearersWave2 },
            { MediumOrcsWave9.Name, MediumOrcsWave9 }
        };

        public static Dictionary<string, Wave> Lvl4Waves = new()
        {
            { OgresWave5.Name, OgresWave5 },
            { GiantsWave3.Name, GiantsWave3 },
            { SatyrsWave14.Name, SatyrsWave14 },
            { MediumSoldiersWave8.Name, MediumSoldiersWave8 },
            { HumanCrossbowmenWave6.Name, HumanCrossbowmenWave6 },
            { TrollsWave2.Name, TrollsWave2 },
            { FireMagesWave2.Name, FireMagesWave2 },
            { HobgoblinShamansWave3.Name, HobgoblinShamansWave3 },
            { PrideHuntersWave3.Name, PrideHuntersWave3 },
            { TrollShieldbearersWave3.Name, TrollShieldbearersWave3 },
            { MediumOrcsWave14.Name, MediumOrcsWave14 },
            { GnomeTinkerersWave9.Name, GnomeTinkerersWave9 }
        };

        public static Dictionary<string, Wave> BossWaves = new()
        {
            { OrfumMountainTroll.Name, OrfumMountainTroll },
            { OakentoesDwarfShaman.Name, OakentoesDwarfShaman },
            // { SawbonesHobgoblinShaman.Name, SawbonesHobgoblinShaman },
            { BulgodArmoredOgre.Name, BulgodArmoredOgre },
            { UrzaFireLord.Name, UrzaFireLord },
            { GaeadinEarthLord.Name, GaeadinEarthLord },
            { Swiftyhooves.Name, Swiftyhooves },
            { TikLikHobgoblinShaman.Name, TikLikHobgoblinShaman },
            { Vitality.Name, Vitality },
            { Gatebreaker.Name, Gatebreaker },
            { LyzanderCultResurrector.Name, LyzanderCultResurrector },
            { GrenwaldeNatureLord.Name, GrenwaldeNatureLord },
            { Tubifore.Name, Tubifore }
        };


        public static Dictionary<int, Wave> WavesById = new()
        {
            { KoboldWave.Id, KoboldWave },
            { LightSoldiersWave.Id, LightSoldiersWave },
            { GnollHuntersWave.Id, GnollHuntersWave },
            { LightSoldiersWave8.Id, LightSoldiersWave8 },
            { OgresWave3.Id, OgresWave3 },
            { CrossbowOrcsWave4.Id, CrossbowOrcsWave4 },
            { OgresWave5.Id, OgresWave5 },
            { GiantsWave3.Id, GiantsWave3 },
            { SatyrsWave9.Id, SatyrsWave9 },
            { SatyrsWave14.Id, SatyrsWave14 },
            { KoboldWave14.Id, KoboldWave14 },
            { GnollHuntersWave2.Id, GnollHuntersWave2 },
            { MediumSoldiersWave5.Id, MediumSoldiersWave5 },
            { MediumSoldiersWave8.Id, MediumSoldiersWave8 },
            { HumanCrossbowmenWave4.Id, HumanCrossbowmenWave4 },
            { HumanCrossbowmenWave6.Id, HumanCrossbowmenWave6 },
            { TrollsWave2.Id, TrollsWave2 },
            { GiantsWave2.Id, GiantsWave2 },
            { CyclopsShamansWave2.Id, CyclopsShamansWave2 },
            { CyclopsShamansWave3.Id, CyclopsShamansWave3 },
            { GnomeTinkerersWave4.Id, GnomeTinkerersWave4 },
            { GnomeTinkerersWave9.Id, GnomeTinkerersWave9 },
            { GrizzlyBearsWave2.Id, GrizzlyBearsWave2 },
            { GrizzlyBearsWave3.Id, GrizzlyBearsWave3 },
            { HobgoblinShamansWave2.Id, HobgoblinShamansWave2 },
            { HobgoblinShamansWave3.Id, HobgoblinShamansWave3 },
            { DwarfShamansWave2.Id, DwarfShamansWave2 },
            { DwarfShamansWave3.Id, DwarfShamansWave3 },
            { LightOrcsWave9.Id, LightOrcsWave9 },
            { FireMagesWave2.Id, FireMagesWave2 },
            { CrossbowOrcsWave6.Id, CrossbowOrcsWave6 },
            { PrideHuntersWave2.Id, PrideHuntersWave2 },
            { PrideHuntersWave3.Id, PrideHuntersWave3 },
            { GrizzlyShieldbearersWave2.Id, GrizzlyShieldbearersWave2 },
            { GrizzlyShieldbearersWave3.Id, GrizzlyShieldbearersWave3 },
            { TrollShieldbearersWave2.Id, TrollShieldbearersWave2 },
            { TrollShieldbearersWave3.Id, TrollShieldbearersWave3 },
            { LightOrcsWave14.Id, LightOrcsWave14 },
            { MediumOrcsWave9.Id, MediumOrcsWave9 },
            { MediumOrcsWave14.Id, MediumOrcsWave14 },
            { OrfumMountainTroll.Id, OrfumMountainTroll },
            { OakentoesDwarfShaman.Id, OakentoesDwarfShaman },
            { SawbonesHobgoblinShaman.Id, SawbonesHobgoblinShaman },
            { BulgodArmoredOgre.Id, BulgodArmoredOgre },
            { UrzaFireLord.Id, UrzaFireLord },
            { GaeadinEarthLord.Id, GaeadinEarthLord },
            { Swiftyhooves.Id, Swiftyhooves },
            { TikLikHobgoblinShaman.Id, TikLikHobgoblinShaman },
            { Vitality.Id, Vitality },
            { Gatebreaker.Id, Gatebreaker },
            { LyzanderCultResurrector.Id, LyzanderCultResurrector },
            { GrenwaldeNatureLord.Id, GrenwaldeNatureLord },
            { Tubifore.Id, Tubifore }
        };


        public static Wave GetById(int id)
        {
            if (WavesById.TryGetValue(id, out var wave))
            {
                return wave;
            }
            return new Wave { Id = 0, Name = "Unknown" };
        }
    }
}
