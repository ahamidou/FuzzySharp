using FuzzySharp.SimilarityRatio.Strategy;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class PartialTokenInitialismScorer : TokenInitialismScorerBase
    {
        public static readonly IRatioScorer Instance = new PartialTokenInitialismScorer();

        private PartialTokenInitialismScorer() : base(PartialRatioStrategy.Instance)
        {
        }
    }
}