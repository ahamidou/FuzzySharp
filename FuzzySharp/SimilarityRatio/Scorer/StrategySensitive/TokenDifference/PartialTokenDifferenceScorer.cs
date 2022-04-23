using FuzzySharp.SimilarityRatio.Strategy.Generic;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class PartialTokenDifferenceScorer : TokenDifferenceScorerBase
    {
        public static readonly IRatioScorer Instance = new PartialTokenDifferenceScorer();

        private PartialTokenDifferenceScorer()
        {
        }

        protected override int CreateSensitiveScorerScore(string[] input1, string[] input2) => PartialRatioStrategy<string>.Calculate(input1, input2);
    }
}