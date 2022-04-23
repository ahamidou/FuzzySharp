namespace FuzzySharp.PreProcess
{
    internal class LanguageNotSetProcessor : IProcessLanguage<string>
    {
        internal static readonly IProcessLanguage<string> Instance = new LanguageNotSetProcessor();

        public string Sanitize(string input) => input;
    }
}