using FuzzySharp.SimilarityRatio.Strategy;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public abstract class SimpleRatioScorerBase : StrategySensitiveScorerBase
    {
        protected SimpleRatioScorerBase(IScoringStrategy scoringStrategy) : base(scoringStrategy)
        {
        }
        public override int Score(string input1, string input2)
        {
            return ScoringStrategy.Calculate(input1, input2);
        }
    }
}
