using FuzzySharp.SimilarityRatio.Strategy;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public abstract class TokenSortScorerBase : ScorerBase
    {
        private readonly IScoringStrategy _scoringStrategy;

        protected TokenSortScorerBase(IScoringStrategy scoringStrategy)
        {
            _scoringStrategy = scoringStrategy;
        }

        public override int Score(string input1, string input2)
        {
            var sorted1 = String.Join(" ", Regex.Split(input1, @"\s+").Where(s => s.Any()).OrderBy(s => s)).Trim();
            var sorted2 = String.Join(" ", Regex.Split(input2, @"\s+").Where(s => s.Any()).OrderBy(s => s)).Trim();

            return _scoringStrategy.Calculate(sorted1, sorted2);
        }
    }
}
