using System.Text.RegularExpressions;

namespace FuzzySharp.PreProcess
{

    internal class EnglishLanguageProcessor : LanguageProcessorBase
    {
        internal static readonly IProcessLanguage<string> Instance = new EnglishLanguageProcessor();
        private static readonly Regex EnglishRegex = new("[^0-9a-zA-Z]", RegexOptions.Compiled);

        protected override string ReplaceUnknownCharactersWithSpace(string input)
        {
            return EnglishRegex.Replace(input, SpaceChar);
        }
    }
}