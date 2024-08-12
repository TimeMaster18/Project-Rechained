
using System.Collections.Generic;

namespace SingleplayerLauncher
{
    public class SurvivalLoadouts : BaseLoadouts
    {
        private static SurvivalLoadouts _instance;
        private static readonly object _lock = new object();

        public override string FileName { get; } = "loadouts.json";

        private SurvivalLoadouts() { }

        public static SurvivalLoadouts Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SurvivalLoadouts();
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
                new LoadoutDTO { Name = "TimeMaster Recommendation", Code = "TimeMaster-B1s2-3G3R1j2M1v2R1x1w2B-5H-1E-UjAI-0000006DKIDJ2ScMSbISbRSW8Db" }
            });
            _instance.Save();
        }
    }
}
