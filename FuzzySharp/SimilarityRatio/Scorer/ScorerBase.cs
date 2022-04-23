using FuzzySharp.PreProcess;

namespace FuzzySharp.SimilarityRatio.Scorer
{
    public abstract class ScorerBase : IRatioScorer
    {
        public abstract int Score(string input1, string input2);

        public int Score(string input1, string input2, LanguageProcessorType languageSanitizerType)
        {
            var languageSanitizer = LanguageProcessorFactory.Create(languageSanitizerType);
            input1 = languageSanitizer.Sanitize(input1);
            input2 = languageSanitizer.Sanitize(input2);
            return Score(input1, input2);
        }
    }
}
