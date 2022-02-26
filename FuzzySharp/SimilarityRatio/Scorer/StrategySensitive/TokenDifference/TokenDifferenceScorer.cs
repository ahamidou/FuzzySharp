using FuzzySharp.SimilarityRatio.Strategy.Generic;
using System;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class TokenDifferenceScorer : TokenDifferenceScorerBase
    {
        public static readonly IRatioScorer Instance = new TokenDifferenceScorer();

        private TokenDifferenceScorer()
        {
        }

        protected override Func<string[], string[], int> Scorer => DefaultRatioStrategy<string>.Calculate;
    }
}