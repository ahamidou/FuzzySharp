namespace FuzzySharp.PreProcess
{
    internal abstract class LanguageProcessorBase : IProcessLanguage<string>
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
}