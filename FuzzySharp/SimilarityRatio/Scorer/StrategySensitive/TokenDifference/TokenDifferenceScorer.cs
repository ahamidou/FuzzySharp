using FuzzySharp.SimilarityRatio.Strategy.Generic;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class TokenDifferenceScorer : TokenDifferenceScorerBase
    {
        public static readonly IRatioScorer Instance = new TokenDifferenceScorer();

        private TokenDifferenceScorer()
        {
        }

        protected override int CreateSensitiveScorerScore(string[] input1, string[] input2) => DefaultRatioStrategy<string>.Calculate(input1, input2);
    }
}