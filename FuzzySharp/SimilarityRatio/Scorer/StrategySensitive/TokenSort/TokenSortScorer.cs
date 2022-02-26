using FuzzySharp.SimilarityRatio.Strategy;
using System;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class TokenSortScorer : TokenSortScorerBase
    {
        public static readonly IRatioScorer Instance = new TokenSortScorer();

        private TokenSortScorer()
        {
        }

        protected override Func<string, string, int> Scorer => DefaultRatioStrategy.Calculate;
    }
}