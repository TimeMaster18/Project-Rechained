
namespace SingleplayerLauncher.Utils
{
    public abstract class IniElement
    {
        public string RawText { get; set; }

        protected IniElement(string rawText)
        {
            RawText = rawText;
        }

        public override string ToString()
        {
            return RawText;
        }
    }


}
