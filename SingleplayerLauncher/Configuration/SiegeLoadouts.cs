
using System.Collections.Generic;

namespace SingleplayerLauncher
{
    public class SiegeLoadouts : BaseLoadouts
    {
        private static SiegeLoadouts _instance;
        private static readonly object _lock = new();

        public override string FileName { get; } = "siege_loadouts.json";

        private SiegeLoadouts() { }

        public static SiegeLoadouts Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SiegeLoadouts();
                        _instance.Load();

                        if (_instance.LoadoutList.Count == 0)
                        {
                            LoadDefaultLoadouts();
                        }
                    }
                }
                return _instance;
            }
        }

        private static void LoadDefaultLoadouts()
        {
            _instance.LoadoutList.AddRange(new List<LoadoutDTO>
            {
                new() { Name = "Defender 1", Code = "Defender1-B1p3-1-3P3N1j2M1r1e2R2B2O-N1BJK9AUli-LdA5" },
                new() { Name = "Defender 2", Code = "Defender2-E172-1-3P3N1j2M1w1t2Q2B1i-N1BJK9AUli-LdF5" },
                new() { Name = "Pillager 1", Code = "Pillager1-20G3-3-3J3N2G292F21251i2O-61BVK9AUli-VbE7" },
                new() { Name = "Attacker 1", Code = "Attacker1-90X2-2-3P3N2G292F21251i2O-NT4OdIH8qi-Wh8C" },
                new() { Name = "Attacker 2", Code = "Attacker2-A0v2-2-3J3N2G292F21251i2O-Y2O4DabEpf-MjC8" }
            });
            _instance.Save();
        }
    }
}
