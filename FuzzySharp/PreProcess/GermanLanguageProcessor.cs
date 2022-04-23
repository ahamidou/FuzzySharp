using System.Text.RegularExpressions;

namespace FuzzySharp.PreProcess
{
    internal class GermanLanguageProcessor : LanguageProcessorBase
    {
        internal static readonly IProcessLanguage<string> Instance = new GermanLanguageProcessor();
        private static readonly Regex GermanRegex = new("[^0-9a-zA-ZäöüßÄÖÜẞ]", RegexOptions.Compiled);

        protected override string ReplaceUnknownCharactersWithSpace(string input)
        {
            return GermanRegex.Replace(input, SpaceChar);
        }
    }
}