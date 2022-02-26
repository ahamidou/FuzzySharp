using FuzzySharp.SimilarityRatio.Strategy;
using System;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class PartialTokenSetScorer : TokenSetScorerBase
    {
        public static readonly IRatioScorer Instance = new PartialTokenSetScorer();

        private PartialTokenSetScorer()
        {
        }

        protected override Func<string, string, int> Scorer => PartialRatioStrategy.Calculate;
    }
}