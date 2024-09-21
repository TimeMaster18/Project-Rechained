using System.Collections.Generic;
using static SingleplayerLauncher.Names.SiegeRole;

namespace SingleplayerLauncher.Model
{
    public class SiegeRole : Trait
    {
        // private constructor
        SiegeRole() { }
        public string Effect { get; private set; }

        // static members
        public static SiegeRole Defender = new()
        {
            Id = 1,
            Name = DEFENDER,
            Effect = "+10% XP from minion kills. Starts match with coin.",
            SiegeDescription = "Defends the rift by building traps and killing minions.",
            CodeName = "SpitfireGame.RWeaverRoleDefense"
        };
        public static SiegeRole Attacker = new()
        {
            Id = 2,
            Name = ATTACKER,
            Effect = "+8% leadership aura and XP when escorting minions.",
            SiegeDescription = "Leads minions through enemy defenses to attack enemy rifts.",
            CodeName = "SpitfireGame.RWeaverRoleOffense"
        };
        public static SiegeRole Pillager = new()
        {
            Id = 3,
            Name = PILLAGER,
            Effect = "+18% XP from cache drops.",
            SiegeDescription = "Finds and loots caches. Assists defenders and attackers.",
            CodeName = "SpitfireGame.RWeaverRolePillaging"
        };

        public static Dictionary<string, SiegeRole> Roles = new()
        {
            { DEFENDER, Defender },
            { ATTACKER, Attacker },
            { PILLAGER, Pillager }
        };

        public static Dictionary<int, SiegeRole> RolesById = new()
        {
            { Defender.Id, Defender },
            { Attacker.Id, Attacker },
            { Pillager.Id, Pillager }
        };

        public static SiegeRole GetById(int id)
        {
            if (RolesById.TryGetValue(id, out var trait))
            {
                return trait;
            }
            return new SiegeRole { Id = 0, Name = "Unknown" };
        }
    }
}