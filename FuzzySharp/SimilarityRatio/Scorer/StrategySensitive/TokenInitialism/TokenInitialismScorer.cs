using FuzzySharp.SimilarityRatio.Strategy;
using System;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class TokenInitialismScorer : TokenInitialismScorerBase
    {
        public static readonly IRatioScorer Instance = new TokenInitialismScorer();

        private TokenInitialismScorer()
        {
        }

        protected override Func<string, string, int> Scorer => DefaultRatioStrategy.Calculate;
    }
}