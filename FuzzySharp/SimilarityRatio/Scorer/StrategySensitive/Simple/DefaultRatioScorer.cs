using FuzzySharp.SimilarityRatio.Strategy;
using System;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class DefaultRatioScorer : SimpleRatioScorerBase
    {
        public static readonly IRatioScorer Instance = new DefaultRatioScorer();

        private DefaultRatioScorer()
        {
        }

        protected override Func<string, string, int> Scorer => DefaultRatioStrategy.Calculate;
    }
}