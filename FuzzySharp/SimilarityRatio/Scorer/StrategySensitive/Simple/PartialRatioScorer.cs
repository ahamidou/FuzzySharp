using FuzzySharp.SimilarityRatio.Strategy;
using System;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class PartialRatioScorer : SimpleRatioScorerBase
    {
        public static readonly IRatioScorer Instance = new PartialRatioScorer();

        private PartialRatioScorer()
        {
        }

        protected override Func<string, string, int> Scorer => PartialRatioStrategy.Calculate;
    }
}