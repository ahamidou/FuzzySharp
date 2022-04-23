using System.Text.RegularExpressions;

namespace FuzzySharp.PreProcess
{
    internal class RussianLanguageProcessor : LanguageProcessorBase
    {
        internal static readonly IProcessLanguage<string> Instance = new RussianLanguageProcessor();
        private static readonly Regex RussianRegex = new("[^0-9a-zA-Zа-зА-З]", RegexOptions.Compiled);

        protected override string ReplaceUnknownCharactersWithSpace(string input)
        {
            return RussianRegex.Replace(input, SpaceChar);
        }
    }
}