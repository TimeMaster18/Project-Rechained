
namespace SingleplayerLauncher.Utils
{
    public class Entry : IniElement
    {
        public string Key { get; private set; }
        public string Value { get; private set; }

        public Entry(string line) : base(line)
        {
            var index = line.IndexOf('=');
            if (index >= 0)
            {
                Key = line.Substring(0, index).Trim();
                Value = line.Substring(index + 1).Trim();
            }
            else
            {
                Key = line.Trim();
                Value = string.Empty;
            }
        }

        public void UpdateValue(string newValue)
        {
            Value = newValue;
            RawText = $"{Key}={Value}";
        }
    }


}
