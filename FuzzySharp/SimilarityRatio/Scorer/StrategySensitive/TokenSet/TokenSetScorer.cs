using FuzzySharp.SimilarityRatio.Strategy;
using System;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class TokenSetScorer : TokenSetScorerBase
    {
        public static readonly IRatioScorer Instance = new TokenSetScorer();

        private TokenSetScorer()
        {
        }

        protected override Func<string, string, int> Scorer => DefaultRatioStrategy.Calculate;
    }
}