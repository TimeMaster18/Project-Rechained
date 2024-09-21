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

        public static Wave KoboldLvl1Wave = new()
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
        public static Wave LightSoldiersLvl1Wave = new()
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
        public static Wave GnollHuntersLvl2Wave = new()
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
        public static Wave LightSoldiersLvl2Wave = new()
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
        public static Wave OgresLvl3Wave = new()
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
        public static Wave CrossbowOrcsLvl1Wave = new()
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
        public static Wave OgresLvl4Wave = new()
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
        public static Wave GiantsLvl4Wave = new()
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
        public static Wave SatyrsLvl3Wave = new()
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
        public static Wave SatyrsLvl4Wave = new()
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
        public static Wave KoboldLvl2Wave = new()
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
        public static Wave GnollHuntersLvl1Wave = new()
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
        public static Wave MediumSoldiersLvl3Wave = new()
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
        public static Wave MediumSoldiersLvl4Wave = new()
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
        public static Wave HumanCrossbowmenLvl3Wave = new()
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
        public static Wave HumanCrossbowmenLvl4Wave = new()
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
        public static Wave TrollsLvl4Wave = new()
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
        public static Wave GiantsLvl3Wave = new()
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
        public static Wave GnomeTinkerersLvl2Wave = new()
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
        public static Wave GnomeTinkerersLvl4Wave = new()
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
        public static Wave GrizzlyBearsLvl1Wave = new()
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
        public static Wave GrizzlyBearsLvl2Wave = new()
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
        public static Wave HobgoblinShamansLvl3Wave = new()
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
        public static Wave HobgoblinShamansLvl4Wave = new()
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
        public static Wave DwarfShamansLvl1Wave = new()
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
        public static Wave DwarfShamansLvl2Wave = new()
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
        public static Wave LightOrcsLvl1Wave = new()
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
        public static Wave FireMagesLvl4Wave = new()
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
        public static Wave CrossbowOrcsLvl2Wave = new()
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
        public static Wave PrideHuntersLvl3Wave = new()
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
        public static Wave PrideHuntersLvl4Wave = new()
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
        public static Wave GrizzlyShieldbearersLvl1Wave = new()
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
        public static Wave GrizzlyShieldbearersLvl2Wave = new()
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
        public static Wave TrollShieldbearersLvl3Wave = new()
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
        public static Wave TrollShieldbearersLvl4Wave = new()
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
        public static Wave LightOrcsLvl2Wave = new()
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
        public static Wave MediumOrcsLvl3Wave = new()
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
        public static Wave MediumOrcsLvl4Wave = new()
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
            { KoboldLvl1Wave.Name, KoboldLvl1Wave },
            { LightSoldiersLvl1Wave.Name, LightSoldiersLvl1Wave },
            { GnollHuntersLvl2Wave.Name, GnollHuntersLvl2Wave },
            { LightSoldiersLvl2Wave.Name, LightSoldiersLvl2Wave },
            { OgresLvl3Wave.Name, OgresLvl3Wave },
            { CrossbowOrcsLvl1Wave.Name, CrossbowOrcsLvl1Wave },
            { OgresLvl4Wave.Name, OgresLvl4Wave },
            { GiantsLvl4Wave.Name, GiantsLvl4Wave },
            { SatyrsLvl3Wave.Name, SatyrsLvl3Wave },
            { SatyrsLvl4Wave.Name, SatyrsLvl4Wave },
            { KoboldLvl2Wave.Name, KoboldLvl2Wave },
            { GnollHuntersLvl1Wave.Name, GnollHuntersLvl1Wave },
            { MediumSoldiersLvl3Wave.Name, MediumSoldiersLvl3Wave },
            { MediumSoldiersLvl4Wave.Name, MediumSoldiersLvl4Wave },
            { HumanCrossbowmenLvl3Wave.Name, HumanCrossbowmenLvl3Wave },
            { HumanCrossbowmenLvl4Wave.Name, HumanCrossbowmenLvl4Wave },
            { TrollsLvl4Wave.Name, TrollsLvl4Wave },
            { GiantsLvl3Wave.Name, GiantsLvl3Wave },
            { CyclopsShamansWave2.Name, CyclopsShamansWave2 },
            { CyclopsShamansWave3.Name, CyclopsShamansWave3 },
            { GnomeTinkerersLvl2Wave.Name, GnomeTinkerersLvl2Wave },
            { GnomeTinkerersLvl4Wave.Name, GnomeTinkerersLvl4Wave },
            { GrizzlyBearsLvl1Wave.Name, GrizzlyBearsLvl1Wave },
            { GrizzlyBearsLvl2Wave.Name, GrizzlyBearsLvl2Wave },
            { HobgoblinShamansLvl3Wave.Name, HobgoblinShamansLvl3Wave },
            { HobgoblinShamansLvl4Wave.Name, HobgoblinShamansLvl4Wave },
            { DwarfShamansLvl1Wave.Name, DwarfShamansLvl1Wave },
            { DwarfShamansLvl2Wave.Name, DwarfShamansLvl2Wave },
            { LightOrcsLvl1Wave.Name, LightOrcsLvl1Wave },
            { FireMagesLvl4Wave.Name, FireMagesLvl4Wave },
            { CrossbowOrcsLvl2Wave.Name, CrossbowOrcsLvl2Wave },
            { PrideHuntersLvl3Wave.Name, PrideHuntersLvl3Wave },
            { PrideHuntersLvl4Wave.Name, PrideHuntersLvl4Wave },
            { GrizzlyShieldbearersLvl1Wave.Name, GrizzlyShieldbearersLvl1Wave },
            { GrizzlyShieldbearersLvl2Wave.Name, GrizzlyShieldbearersLvl2Wave },
            { TrollShieldbearersLvl3Wave.Name, TrollShieldbearersLvl3Wave },
            { TrollShieldbearersLvl4Wave.Name, TrollShieldbearersLvl4Wave },
            { LightOrcsLvl2Wave.Name, LightOrcsLvl2Wave },
            { MediumOrcsLvl3Wave.Name, MediumOrcsLvl3Wave },
            { MediumOrcsLvl4Wave.Name, MediumOrcsLvl4Wave },
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
            { KoboldLvl1Wave.Name, KoboldLvl1Wave },
            { LightSoldiersLvl1Wave.Name, LightSoldiersLvl1Wave },
            { CrossbowOrcsLvl1Wave.Name, CrossbowOrcsLvl1Wave },
            { GnollHuntersLvl1Wave.Name, GnollHuntersLvl1Wave },
            { GrizzlyShieldbearersLvl1Wave.Name, GrizzlyShieldbearersLvl1Wave },
            { GrizzlyBearsLvl1Wave.Name, GrizzlyBearsLvl1Wave },
            { DwarfShamansLvl1Wave.Name, DwarfShamansLvl1Wave },
            { LightOrcsLvl1Wave.Name, LightOrcsLvl1Wave }
        };

        public static Dictionary<string, Wave> Lvl2Waves = new()
        {
            { GnollHuntersLvl2Wave.Name, GnollHuntersLvl2Wave },
            { LightSoldiersLvl2Wave.Name, LightSoldiersLvl2Wave },
            { KoboldLvl2Wave.Name, KoboldLvl2Wave },
            { GnomeTinkerersLvl2Wave.Name, GnomeTinkerersLvl2Wave },
            { GrizzlyBearsLvl2Wave.Name, GrizzlyBearsLvl2Wave },
            { GrizzlyShieldbearersLvl2Wave.Name, GrizzlyShieldbearersLvl2Wave },
            { DwarfShamansLvl2Wave.Name, DwarfShamansLvl2Wave },
            { CrossbowOrcsLvl2Wave.Name, CrossbowOrcsLvl2Wave },
            { LightOrcsLvl2Wave.Name, LightOrcsLvl2Wave },
        };

        public static Dictionary<string, Wave> Lvl3Waves = new()
        {
            { OgresLvl3Wave.Name, OgresLvl3Wave },
            { GiantsLvl3Wave.Name, GiantsLvl3Wave },
            { SatyrsLvl3Wave.Name, SatyrsLvl3Wave },
            { MediumSoldiersLvl3Wave.Name, MediumSoldiersLvl3Wave },
            { HumanCrossbowmenLvl3Wave.Name, HumanCrossbowmenLvl3Wave },
            { HobgoblinShamansLvl3Wave.Name, HobgoblinShamansLvl3Wave },
            { PrideHuntersLvl3Wave.Name, PrideHuntersLvl3Wave },
            { TrollShieldbearersLvl3Wave.Name, TrollShieldbearersLvl3Wave },
            { MediumOrcsLvl3Wave.Name, MediumOrcsLvl3Wave }
        };

        public static Dictionary<string, Wave> Lvl4Waves = new()
        {
            { OgresLvl4Wave.Name, OgresLvl4Wave },
            { GiantsLvl4Wave.Name, GiantsLvl4Wave },
            { SatyrsLvl4Wave.Name, SatyrsLvl4Wave },
            { MediumSoldiersLvl4Wave.Name, MediumSoldiersLvl4Wave },
            { HumanCrossbowmenLvl4Wave.Name, HumanCrossbowmenLvl4Wave },
            { TrollsLvl4Wave.Name, TrollsLvl4Wave },
            { FireMagesLvl4Wave.Name, FireMagesLvl4Wave },
            { HobgoblinShamansLvl4Wave.Name, HobgoblinShamansLvl4Wave },
            { PrideHuntersLvl4Wave.Name, PrideHuntersLvl4Wave },
            { TrollShieldbearersLvl4Wave.Name, TrollShieldbearersLvl4Wave },
            { MediumOrcsLvl4Wave.Name, MediumOrcsLvl4Wave },
            { GnomeTinkerersLvl4Wave.Name, GnomeTinkerersLvl4Wave }
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
            { KoboldLvl1Wave.Id, KoboldLvl1Wave },
            { LightSoldiersLvl1Wave.Id, LightSoldiersLvl1Wave },
            { GnollHuntersLvl2Wave.Id, GnollHuntersLvl2Wave },
            { LightSoldiersLvl2Wave.Id, LightSoldiersLvl2Wave },
            { OgresLvl3Wave.Id, OgresLvl3Wave },
            { CrossbowOrcsLvl1Wave.Id, CrossbowOrcsLvl1Wave },
            { OgresLvl4Wave.Id, OgresLvl4Wave },
            { GiantsLvl4Wave.Id, GiantsLvl4Wave },
            { SatyrsLvl3Wave.Id, SatyrsLvl3Wave },
            { SatyrsLvl4Wave.Id, SatyrsLvl4Wave },
            { KoboldLvl2Wave.Id, KoboldLvl2Wave },
            { GnollHuntersLvl1Wave.Id, GnollHuntersLvl1Wave },
            { MediumSoldiersLvl3Wave.Id, MediumSoldiersLvl3Wave },
            { MediumSoldiersLvl4Wave.Id, MediumSoldiersLvl4Wave },
            { HumanCrossbowmenLvl3Wave.Id, HumanCrossbowmenLvl3Wave },
            { HumanCrossbowmenLvl4Wave.Id, HumanCrossbowmenLvl4Wave },
            { TrollsLvl4Wave.Id, TrollsLvl4Wave },
            { GiantsLvl3Wave.Id, GiantsLvl3Wave },
            { CyclopsShamansWave2.Id, CyclopsShamansWave2 },
            { CyclopsShamansWave3.Id, CyclopsShamansWave3 },
            { GnomeTinkerersLvl2Wave.Id, GnomeTinkerersLvl2Wave },
            { GnomeTinkerersLvl4Wave.Id, GnomeTinkerersLvl4Wave },
            { GrizzlyBearsLvl1Wave.Id, GrizzlyBearsLvl1Wave },
            { GrizzlyBearsLvl2Wave.Id, GrizzlyBearsLvl2Wave },
            { HobgoblinShamansLvl3Wave.Id, HobgoblinShamansLvl3Wave },
            { HobgoblinShamansLvl4Wave.Id, HobgoblinShamansLvl4Wave },
            { DwarfShamansLvl1Wave.Id, DwarfShamansLvl1Wave },
            { DwarfShamansLvl2Wave.Id, DwarfShamansLvl2Wave },
            { LightOrcsLvl1Wave.Id, LightOrcsLvl1Wave },
            { FireMagesLvl4Wave.Id, FireMagesLvl4Wave },
            { CrossbowOrcsLvl2Wave.Id, CrossbowOrcsLvl2Wave },
            { PrideHuntersLvl3Wave.Id, PrideHuntersLvl3Wave },
            { PrideHuntersLvl4Wave.Id, PrideHuntersLvl4Wave },
            { GrizzlyShieldbearersLvl1Wave.Id, GrizzlyShieldbearersLvl1Wave },
            { GrizzlyShieldbearersLvl2Wave.Id, GrizzlyShieldbearersLvl2Wave },
            { TrollShieldbearersLvl3Wave.Id, TrollShieldbearersLvl3Wave },
            { TrollShieldbearersLvl4Wave.Id, TrollShieldbearersLvl4Wave },
            { LightOrcsLvl2Wave.Id, LightOrcsLvl2Wave },
            { MediumOrcsLvl3Wave.Id, MediumOrcsLvl3Wave },
            { MediumOrcsLvl4Wave.Id, MediumOrcsLvl4Wave },
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
