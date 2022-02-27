using FuzzySharp.SimilarityRatio.Strategy;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public abstract class StrategySensitiveScorerBase : ScorerBase
    {
        protected readonly IScoringStrategy ScoringStrategy;

        protected StrategySensitiveScorerBase(IScoringStrategy scoringStrategy)
        {
            ScoringStrategy = scoringStrategy;
        }
    }
}
