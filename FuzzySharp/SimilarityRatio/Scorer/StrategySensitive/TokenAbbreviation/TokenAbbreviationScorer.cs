using FuzzySharp.SimilarityRatio.Strategy;
using System;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class TokenAbbreviationScorer : TokenAbbreviationScorerBase
    {
        public static readonly IRatioScorer Instance = new TokenAbbreviationScorer();

        private TokenAbbreviationScorer()
        {
        }

        protected override Func<string, string, int> Scorer => DefaultRatioStrategy.Calculate;
    }
}