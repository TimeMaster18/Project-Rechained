using IniParser;
using IniParser.Model;
using System.IO;

namespace SingleplayerLauncher
{
    internal class ConfigFile
    {
        private readonly FileIniDataParser parser;
        private readonly string path; // (filename too)
        public IniData data;
        //public Dictionary<string, Dictionary<string, string>> configDict;

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

        /*
        public void add(string section, string key, string value)
        {
            if (configDict.ContainsKey(section))
            {
                configDict[section][key] = value;
            }
        }
        /*
        private void add(string sectionName, string key, string value)
        {
            if (sections.Contains)
            {
                Section = sections[i]
                section.sectionDict[key] = value;
            }
            else
            {
                Section section = new Section(sectionName);
                section.sectionDict[key] = value;

            }
        }

        private void addSectionsToData()
        {            
            foreach (Section section in sections)
            {
                var sectionDict = section.sectionDict;
                var sectionName = section.sectionName;
                foreach (KeyValuePair<string, string> entry in sectionDict)
                {
                    data[sectionName][entry.Key] = entry.Value;
                }
            }
        }
        */

    }
}
