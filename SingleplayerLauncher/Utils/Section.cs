
namespace SingleplayerLauncher.Utils
{
    using System.Collections.Generic;

    public class Section : IniElement
    {
        public string Name { get; private set; }
        public List<IniElement> Elements { get; private set; }
        private readonly Dictionary<string, List<Entry>> entries;

        public Section(string name, string rawText) : base(rawText)
        {
            Name = name;
            Elements = new List<IniElement>();
            entries = new Dictionary<string, List<Entry>>();
        }

        public void AddElement(IniElement element)
        {
            Elements.Add(element);
            if (element is Entry entry)
            {
                if (!entries.TryGetValue(entry.Key, out var entryList))
                {
                    entryList = new List<Entry>();
                    entries[entry.Key] = entryList;
                }
                entryList.Add(entry);
            }
        }

        public List<Entry> FindEntries(string key)
        {
            if (entries.TryGetValue(key, out var entryList))
            {
                return entryList;
            }
            return new List<Entry>();
        }
    }


}
