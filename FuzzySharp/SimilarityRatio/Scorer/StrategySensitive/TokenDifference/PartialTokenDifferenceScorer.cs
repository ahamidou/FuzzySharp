using FuzzySharp.SimilarityRatio.Strategy.Generic;
using System;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class PartialTokenDifferenceScorer : TokenDifferenceScorerBase
    {
        public static readonly IRatioScorer Instance = new PartialTokenDifferenceScorer();

        private PartialTokenDifferenceScorer()
        {
        }

        protected override Func<string[], string[], int> Scorer => PartialRatioStrategy<string>.Calculate;
    }
}