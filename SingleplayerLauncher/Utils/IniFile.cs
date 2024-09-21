using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleplayerLauncher.Utils
{

    public class IniFile
    {
        public Dictionary<string, Section> Sections { get; private set; }

        public IniFile()
        {
            Sections = [];
        }

        public void Load(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            Section currentSection = null;

            foreach (var line in lines)
            {
                var trimmedLine = line.Trim();
                if (trimmedLine.Length == 0)
                {
                    continue;
                }

                if (trimmedLine.StartsWith(";"))
                {
                    // Comment line
                    var comment = new Comment(line);
                    if (currentSection != null)
                    {
                        currentSection.AddElement(comment);
                    }
                    else
                    {
                        // Add comment outside of any section
                        var sectionKey = Guid.NewGuid().ToString();
                        Sections[sectionKey] = new Section(null, line);
                        Sections[sectionKey].AddElement(comment);
                    }
                }
                else if (trimmedLine.StartsWith("[") && trimmedLine.EndsWith("]"))
                {
                    // New section
                    var sectionName = trimmedLine.Substring(1, trimmedLine.Length - 2);
                    currentSection = new Section(sectionName, line);
                    Sections[sectionName] = currentSection;
                }
                else
                {
                    // Entry in section
                    var entry = new Entry(line);
                    if (currentSection != null)
                    {
                        currentSection.AddElement(entry);
                    }
                    else
                    {
                        // Add entry outside of any section
                        var sectionKey = Guid.NewGuid().ToString();
                        Sections[sectionKey] = new Section(null, line);
                        Sections[sectionKey].AddElement(entry);
                    }
                }
            }
        }

        public void Save(string filePath)
        {
            var sb = new StringBuilder();

            foreach (var section in Sections.Values)
            {
                if (section.Name != null)
                {
                    sb.AppendLine($"[{section.Name}]");
                }

                foreach (var element in section.Elements)
                {
                    sb.AppendLine(element.ToString());
                }

                sb.AppendLine(); // Add an extra line between sections for readability
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        public List<Entry> FindEntries(string sectionName, string key)
        {
            if (Sections.TryGetValue(sectionName, out var section))
            {
                return section.FindEntries(key);
            }
            return null;
        }

        public void UpdateEntry(string sectionName, string key, string newValue, int index = 0)
        {
            if (!Sections.TryGetValue(sectionName, out var section))
            {
                section = new Section(sectionName, $"[{sectionName}]");
                Sections[sectionName] = section;
            }

            var entries = section.FindEntries(key);
            if (entries != null && index < entries.Count)
            {
                entries[index].UpdateValue(newValue);
            }
            else
            {
                var newEntry = new Entry($"{key}={newValue}");
                section.AddElement(newEntry);
            }
        }

        public void RemoveSection(string sectionName)
        {
            if (!Sections.TryGetValue(sectionName, out var section))
            {
                // Section not found; nothing to remove
                return;
            }

            Sections.Remove(sectionName);
        }
    }

}
