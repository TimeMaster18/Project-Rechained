using Newtonsoft.Json;
using SingleplayerLauncher.Configuration;
using SingleplayerLauncher.GameFiles;
using System.Collections.Generic;
using System.IO;

namespace SingleplayerLauncher
{
    public abstract class BaseLoadouts : IConfiguration
    {
        public abstract string FileName { get; }

        public List<LoadoutDTO> LoadoutList { get; set; } = new List<LoadoutDTO>();

        protected BaseLoadouts() { }

        public void AddLoadout(string name, string code)
        {
            if (!LoadoutList.Exists(loadout => loadout.Name == name))
            {
                LoadoutList.Add(new LoadoutDTO { Name = name, Code = code });
            }
        }

        public void RemoveLoadout(string name)
        {
            LoadoutList.RemoveAll(loadout => loadout.Name == name);
        }

        public LoadoutDTO GetLoadoutByName(string name)
        {
            return LoadoutList.Find(l => l.Name == name);
        }

        public List<string> GetLoadoutNames()
        {
            return LoadoutList.ConvertAll(l => l.Name);
        }

        public bool Exists(string name)
        {
            return LoadoutList.Exists(l => l.Name == name);
        }

        public bool UpdateLoadout(string name, string newCode)
        {
            var loadout = LoadoutList.Find(l => l.Name == name);
            if (loadout != null)
            {
                loadout.Code = newCode;
                return true;
            }
            return false;
        }

        public void Load()
        {
            string loadoutsFile = Path.Combine(Settings.Instance.LauncherInstallationPath, FileUtils.CONFIG_FOLDER_NAME, FileName);
            if (File.Exists(loadoutsFile))
            {
                var root = JsonConvert.DeserializeObject<LoadoutRootDTO>(File.ReadAllText(loadoutsFile));
                LoadoutList = root.Loadouts;
            }
            else
            {
                Save();
            }
        }

        public void Save()
        {
            string loadoutsFile = Path.Combine(Settings.Instance.LauncherInstallationPath, FileUtils.CONFIG_FOLDER_NAME, FileName);
            var root = new LoadoutRootDTO { Loadouts = LoadoutList };
            File.WriteAllText(loadoutsFile, JsonConvert.SerializeObject(root, Formatting.Indented));
        }
    }

    public class LoadoutDTO
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class LoadoutRootDTO
    {
        public List<LoadoutDTO> Loadouts { get; set; } = new List<LoadoutDTO>();
    }
}
