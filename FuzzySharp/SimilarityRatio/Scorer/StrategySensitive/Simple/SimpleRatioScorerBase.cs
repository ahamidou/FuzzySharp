using FuzzySharp.SimilarityRatio.Strategy;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public abstract class SimpleRatioScorerBase : ScorerBase
    {
        private readonly IScoringStrategy _scoringStrategy;

        protected SimpleRatioScorerBase(IScoringStrategy scoringStrategy)
        {
            _scoringStrategy = scoringStrategy;
        }
        public override int Score(string input1, string input2)
        {
            return _scoringStrategy.Calculate(input1, input2);
        }
    }
}
