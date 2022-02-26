using FuzzySharp.SimilarityRatio.Strategy;
using System;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class PartialTokenInitialismScorer : TokenInitialismScorerBase
    {
        public static readonly IRatioScorer Instance = new PartialTokenInitialismScorer();

        private PartialTokenInitialismScorer()
        {
        }

        protected override Func<string, string, int> Scorer => PartialRatioStrategy.Calculate;
    }
}