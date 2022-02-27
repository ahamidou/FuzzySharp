using FuzzySharp.SimilarityRatio.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FuzzySharp.SimilarityRatio.Scorer.StrategySensitive
{
    public abstract class TokenSetScorerBase : StrategySensitiveScorerBase
    {
        protected TokenSetScorerBase(IScoringStrategy scoringStrategy) : base(scoringStrategy)
        {
        }

        public override int Score(string input1, string input2)
        {
            var tokens1 = new HashSet<string>(Regex.Split(input1, @"\s+").Where(s => s.Any()));
            var tokens2 = new HashSet<string>(Regex.Split(input2, @"\s+").Where(s => s.Any()));

            var sortedIntersection = String.Join(" ", tokens1.Intersect(tokens2).OrderBy(s => s)).Trim();
            var sortedDiff1To2 = (sortedIntersection + " " + String.Join(" ", tokens1.Except(tokens2).OrderBy(s => s))).Trim();
            var sortedDiff2To1 = (sortedIntersection + " " + String.Join(" ", tokens2.Except(tokens1).OrderBy(s => s))).Trim();

            return new[]
            {
                ScoringStrategy.Calculate(sortedIntersection, sortedDiff1To2),
                ScoringStrategy.Calculate(sortedIntersection, sortedDiff2To1),
                ScoringStrategy.Calculate(sortedDiff1To2,     sortedDiff2To1)
            }.Max();
        }
    }
}
