using FuzzySharp.SimilarityRatio.Strategy;
using System;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class PartialTokenAbbreviationScorer : TokenAbbreviationScorerBase
    {
        public static readonly IRatioScorer Instance = new PartialTokenAbbreviationScorer();

        private PartialTokenAbbreviationScorer()
        {
        }

        protected override Func<string, string, int> Scorer => PartialRatioStrategy.Calculate;
    }
}