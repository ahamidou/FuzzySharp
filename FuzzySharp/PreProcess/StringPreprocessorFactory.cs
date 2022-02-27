using System;
using System.Text.RegularExpressions;

namespace FuzzySharp.PreProcess
{
    internal class StringPreprocessorFactory
    {
        private static readonly Regex EnglishRegex = new Regex("[^0-9a-zA-Z]", RegexOptions.Compiled);
        private static readonly Regex GermanRegex = new Regex("[^0-9a-zA-ZäöüßÄÖÜẞ]", RegexOptions.Compiled);
        private static readonly Regex RussianRegex = new Regex("[^0-9a-zA-Zа-зА-З]", RegexOptions.Compiled);

        public static Func<string, string> GetPreprocessor(LanguageProcessorType language)
        {
            return language switch
            {
                LanguageProcessorType.NotSet => x => x,
                LanguageProcessorType.English => ProcessEnglishString,
                LanguageProcessorType.German => ProcessGermanString,
                LanguageProcessorType.Russian => ProcessRussianString,
                _ => throw new ArgumentOutOfRangeException(nameof(language)),
            };
        }

        private static string ProcessEnglishString(string input) => ProcessString(input, EnglishRegex);

        private static string ProcessGermanString(string input) => ProcessString(input, GermanRegex);

        private static string ProcessRussianString(string input) => ProcessString(input, RussianRegex);

        private static string ProcessString(string input, Regex regex)
        {
            input = EnglishRegex.Replace(input, " ");
            return input.ToLowerInvariant().Trim();
        }
    }
}