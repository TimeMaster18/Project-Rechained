using SingleplayerLauncher.Utils;
using System.IO;

namespace SingleplayerLauncher.GameFiles
{
    internal class ConfigFile
    {
        private readonly string path; // filename included
        public IniFile data;

        public ConfigFile(string filePath, bool newFile = false)
        {
            path = filePath;
            data = new IniFile();

            if (!newFile && File.Exists(path))
            {
                data.Load(path);
            }
        }

        public void Write()
        {
            data.Save(path);
        }
    }
}
