using System;
using System.Text.RegularExpressions;

namespace FuzzySharp.PreProcess
{
    public interface ILanguageSanitizer<T>
    {
        string Sanitize(T input);
    }

    internal class EnglishLanguageSanitizer : LanguageSanitizerBase
    {
        internal static readonly ILanguageSanitizer<string> Instance = new EnglishLanguageSanitizer();
        private static readonly Regex EnglishRegex = new("[^0-9a-zA-Z]", RegexOptions.Compiled);

        protected override string ReplaceUnknownCharactersWithSpace(string input)
        {
            return EnglishRegex.Replace(input, SpaceChar);
        }
    }

    internal class GermanLanguageSanitizer : LanguageSanitizerBase
    {
        internal static readonly ILanguageSanitizer<string> Instance = new GermanLanguageSanitizer();
        private static readonly Regex GermanRegex = new("[^0-9a-zA-ZäöüßÄÖÜẞ]", RegexOptions.Compiled);

        protected override string ReplaceUnknownCharactersWithSpace(string input)
        {
            return GermanRegex.Replace(input, SpaceChar);
        }
    }

    internal abstract class LanguageSanitizerBase : ILanguageSanitizer<string>
    {
        protected const string SpaceChar = " ";

        public string Sanitize(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            return ReplaceUnknownCharactersWithSpace(input)
                .Trim()
                .ToLowerInvariant();
        }

        protected abstract string ReplaceUnknownCharactersWithSpace(string input);
    }

    internal class LanguageSanitizerFactory
    {
        public static ILanguageSanitizer<string> Create(LanguageSanitizerType language)
        {
            return language switch
            {
                LanguageSanitizerType.NotSet => NotSetLanguageSanitizer.Instance,
                LanguageSanitizerType.English => EnglishLanguageSanitizer.Instance,
                LanguageSanitizerType.German => GermanLanguageSanitizer.Instance,
                LanguageSanitizerType.Russian => RussianLanguageSanitizer.Instance,
                _ => throw new ArgumentOutOfRangeException(nameof(language)),
            };
        }
    }

    internal class NotSetLanguageSanitizer : ILanguageSanitizer<string>
    {
        internal static readonly ILanguageSanitizer<string> Instance = new NotSetLanguageSanitizer();

        public string Sanitize(string input) => input;
    }

    internal class RussianLanguageSanitizer : LanguageSanitizerBase
    {
        internal static readonly ILanguageSanitizer<string> Instance = new RussianLanguageSanitizer();
        private static readonly Regex RussianRegex = new("[^0-9a-zA-Zа-зА-З]", RegexOptions.Compiled);

        protected override string ReplaceUnknownCharactersWithSpace(string input)
        {
            return RussianRegex.Replace(input, SpaceChar);
        }
    }
}