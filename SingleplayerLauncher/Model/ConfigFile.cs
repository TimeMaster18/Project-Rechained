using IniParser;
using IniParser.Model;
using System.IO;

namespace SingleplayerLauncher.Model
{
    internal class ConfigFile
    {
        private readonly FileIniDataParser parser;
        private readonly string path; // filename included
        public IniData data;

        public ConfigFile(string filePath, bool newFile)
        {
            path = filePath;
            parser = new FileIniDataParser();
            parser.Parser.Configuration.AllowDuplicateKeys = true;
            parser.Parser.Configuration.AssigmentSpacer = "";
            parser.Parser.Configuration.CommentString = ";";
            parser.Parser.Configuration.AllowCreateSectionsOnFly = true;

            if (!newFile && File.Exists(path))
            {
                data = parser.ReadFile(path);
            }
            else
            {
                data = new IniData();
            }
        }

        public ConfigFile(string filePath)
        {
            path = filePath;
            parser = new FileIniDataParser();
            parser.Parser.Configuration.AllowDuplicateKeys = true;
            parser.Parser.Configuration.AssigmentSpacer = "";
            parser.Parser.Configuration.CommentString = ";";
            parser.Parser.Configuration.AllowCreateSectionsOnFly = true;

            if (File.Exists(path))
            {
                data = parser.ReadFile(path);
            }
            else
            {
                data = new IniData();
            }
        }

        public void Write(IniData data)
        {
            parser.WriteFile(path, data);
            // This is needed because the above saves it with BOM and the game can't read it.
            // might be better with this? https://github.com/rickyah/ini-parser/issues/189#issuecomment-510038349
            File.WriteAllText(path, File.ReadAllText(path));
        }
    }
}
