using FuzzySharp.Extractor;
using FuzzySharp.PreProcess;
using FuzzySharp.SimilarityRatio.Scorer;
using FuzzySharp.SimilarityRatio.Scorer.Composite;
using System.Collections.Generic;

namespace FuzzySharp
{
    public static class Process
    {
        /// <summary>
        /// Creates a list of ExtractedResult which contain all the choices with
        /// their corresponding score where higher is more similar
        /// </summary>
        /// <param name="query"></param>
        /// <param name="choices"></param>
        /// <param name="processor"></param>
        /// <param name="scorer"></param>
        /// <param name="cutoff"></param>
        /// <returns></returns>
        public static IEnumerable<ExtractedResult<string>> ExtractAll(
            string query,
            IEnumerable<string> choices,
            ILanguageSanitizer<string> languageSanitizer = null,
            IRatioScorer scorer = null,
            int cutoff = 0)
        {
            return ResultExtractor.ExtractWithoutOrder(query, choices, languageSanitizer ?? EnglishLanguageSanitizer.Instance, scorer ?? WeightedRatioScorer.Instance, cutoff);
        }

        /// <summary>
        /// Creates a list of ExtractedResult which contain all the choices with
        /// their corresponding score where higher is more similar
        /// </summary>
        /// <param name="query"></param>
        /// <param name="choices"></param>
        /// <param name="processor"></param>
        /// <param name="scorer"></param>
        /// <param name="cutoff"></param>
        /// <returns></returns>
        public static IEnumerable<ExtractedResult<T>> ExtractAll<T>(
            T query,
            IEnumerable<T> choices,
            ILanguageSanitizer<T> languageSanitizer,
            IRatioScorer scorer = null,
            int cutoff = 0)
        {
            return ResultExtractor.ExtractWithoutOrder(query, choices, languageSanitizer, scorer ?? WeightedRatioScorer.Instance, cutoff);
        }

        /// <summary>
        /// Creates a sorted list of ExtractedResult  which contain the
        /// top limit most similar choices
        /// </summary>
        /// <param name="query"></param>
        /// <param name="choices"></param>
        /// <param name="processor"></param>
        /// <param name="scorer"></param>
        /// <param name="limit"></param>
        /// <param name="cutoff"></param>
        /// <returns></returns>
        public static IEnumerable<ExtractedResult<string>> ExtractTop(
            string query,
            IEnumerable<string> choices,
            ILanguageSanitizer<string> languageSanitizer = null,
            IRatioScorer scorer = null,
            int limit = 5,
            int cutoff = 0)
        {
            return ResultExtractor.ExtractTop(query, choices, languageSanitizer ?? EnglishLanguageSanitizer.Instance, scorer ?? WeightedRatioScorer.Instance, limit, cutoff);
        }

        /// <summary>
        /// Creates a sorted list of ExtractedResult  which contain the
        /// top limit most similar choices
        /// </summary>
        /// <param name="query"></param>
        /// <param name="choices"></param>
        /// <param name="processor"></param>
        /// <param name="scorer"></param>
        /// <param name="limit"></param>
        /// <param name="cutoff"></param>
        /// <returns></returns>
        public static IEnumerable<ExtractedResult<T>> ExtractTop<T>(
            T query,
            IEnumerable<T> choices,
            ILanguageSanitizer<T> languageSanitizer,
            IRatioScorer scorer = null,
            int limit = 5,
            int cutoff = 0)
        {
            return ResultExtractor.ExtractTop(query, choices, languageSanitizer, scorer ?? WeightedRatioScorer.Instance, limit, cutoff);
        }

        /// <summary>
        /// Creates a sorted list of ExtractedResult with the closest matches first
        /// </summary>
        /// <param name="query"></param>
        /// <param name="choices"></param>
        /// <param name="processor"></param>
        /// <param name="scorer"></param>
        /// <param name="cutoff"></param>
        /// <returns></returns>
        public static IEnumerable<ExtractedResult<string>> ExtractSorted(
            string query,
            IEnumerable<string> choices,
            ILanguageSanitizer<string> languageSanitizer = null,
            IRatioScorer scorer = null,
            int cutoff = 0)
        {
            return ResultExtractor.ExtractSorted(query, choices, languageSanitizer ?? EnglishLanguageSanitizer.Instance, scorer ?? WeightedRatioScorer.Instance, cutoff);
        }

        /// <summary>
        /// Creates a sorted list of ExtractedResult with the closest matches first
        /// </summary>
        /// <param name="query"></param>
        /// <param name="choices"></param>
        /// <param name="processor"></param>
        /// <param name="scorer"></param>
        /// <param name="cutoff"></param>
        /// <returns></returns>
        public static IEnumerable<ExtractedResult<T>> ExtractSorted<T>(
            T query,
            IEnumerable<T> choices,
            ILanguageSanitizer<T> languageSanitizer,
            IRatioScorer scorer = null,
            int cutoff = 0)
        {
            return ResultExtractor.ExtractSorted(query, choices, languageSanitizer, scorer ?? WeightedRatioScorer.Instance, cutoff);
        }

        /// <summary>
        /// Find the single best match above a score in a list of choices.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="choices"></param>
        /// <param name="processor"></param>
        /// <param name="scorer"></param>
        /// <param name="cutoff"></param>
        /// <returns></returns>
        public static ExtractedResult<string> ExtractOne(
            string query,
            IEnumerable<string> choices,
            ILanguageSanitizer<string> languageSanitizer = null,
            IRatioScorer scorer = null,
            int cutoff = 0)
        {
            return ResultExtractor.ExtractOne(query, choices, languageSanitizer ?? EnglishLanguageSanitizer.Instance, scorer ?? WeightedRatioScorer.Instance, cutoff);
        }

        /// <summary>
        /// Find the single best match above a score in a list of choices.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="choices"></param>
        /// <param name="processor"></param>
        /// <param name="scorer"></param>
        /// <param name="cutoff"></param>
        /// <returns></returns>
        public static ExtractedResult<T> ExtractOne<T>(
            T query,
            IEnumerable<T> choices,
            ILanguageSanitizer<T> languageSanitizer,
            IRatioScorer scorer = null,
            int cutoff = 0)
        {
            return ResultExtractor.ExtractOne(query, choices, languageSanitizer, scorer ?? WeightedRatioScorer.Instance, cutoff);
        }

        /// <summary>
        /// Find the single best match above a score in a list of choices.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="choices"></param>
        /// <returns></returns>
        public static ExtractedResult<string> ExtractOne(string query, params string[] choices)
        {
            return ResultExtractor.ExtractOne(query, choices, EnglishLanguageSanitizer.Instance, WeightedRatioScorer.Instance);
        }
    }
}