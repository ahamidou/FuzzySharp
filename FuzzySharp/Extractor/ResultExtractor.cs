using System;
using System.Collections.Generic;
using System.Linq;
using FuzzySharp.Extensions;
using FuzzySharp.PreProcess;
using FuzzySharp.SimilarityRatio.Scorer;

namespace FuzzySharp.Extractor
{
    public static class ResultExtractor
    {
        public static IEnumerable<ExtractedResult<T>> ExtractWithoutOrder<T>(T query, IEnumerable<T> choices, ILanguageSanitizer<T> languageSanitizer, IRatioScorer scorer, int cutoff = 0)
        {
            int index = 0;
            var sanitizedQuery = languageSanitizer.Sanitize(query);
            foreach (var choice in choices)
            {
                int score = scorer.Score(sanitizedQuery, languageSanitizer.Sanitize(choice));
                if (score >= cutoff)
                {
                    yield return new ExtractedResult<T>(choice, score, index);
                }
                index++;
            }
        }

        public static ExtractedResult<T> ExtractOne<T>(T query, IEnumerable<T> choices, ILanguageSanitizer<T> languageSanitizer, IRatioScorer calculator, int cutoff = 0)
        {
            return ExtractWithoutOrder(query, choices, languageSanitizer, calculator, cutoff).Max();
        }

        public static IEnumerable<ExtractedResult<T>> ExtractSorted<T>(T query, IEnumerable<T> choices, ILanguageSanitizer<T> languageSanitizer, IRatioScorer calculator, int cutoff = 0)
        {
            return ExtractWithoutOrder(query, choices, languageSanitizer, calculator, cutoff).OrderByDescending(r => r.Score);
        }

        public static IEnumerable<ExtractedResult<T>> ExtractTop<T>(T query, IEnumerable<T> choices, ILanguageSanitizer<T> languageSanitizer, IRatioScorer calculator, int limit, int cutoff = 0)
        {
            return ExtractWithoutOrder(query, choices, languageSanitizer, calculator, cutoff).MaxN(limit).Reverse();
        }
    }
}