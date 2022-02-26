using FuzzySharp.SimilarityRatio.Strategy;
using System;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class PartialTokenSortScorer : TokenSortScorerBase
    {
        public static readonly IRatioScorer Instance = new PartialTokenSortScorer();

        private PartialTokenSortScorer()
        {
        }

        protected override Func<string, string, int> Scorer => PartialRatioStrategy.Calculate;
    }
}