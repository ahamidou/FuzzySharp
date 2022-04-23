using System;

namespace FuzzySharp.PreProcess
{
    internal class LanguageProcessorFactory
    {
        public static IProcessLanguage<string> Create(LanguageProcessorType language)
        {
            return language switch
            {
                LanguageProcessorType.NotSet => LanguageNotSetProcessor.Instance,
                LanguageProcessorType.English => EnglishLanguageProcessor.Instance,
                LanguageProcessorType.German => GermanLanguageProcessor.Instance,
                LanguageProcessorType.Russian => RussianLanguageProcessor.Instance,
                _ => throw new ArgumentOutOfRangeException(nameof(language)),
            };
        }
    }
}