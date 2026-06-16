
#nullable enable

namespace Weave
{
    /// <summary>
    /// One (time bucket, group) row of aggregated scorer feedback.
    /// </summary>
    public sealed partial class FeedbackAggregateBucket
    {
        /// <summary>
        /// Time bucket start, unix epoch ms (UTC). None when unbucketed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_bucket_start_ms")]
        public int? TimeBucketStartMs { get; set; }

        /// <summary>
        /// Group-by dimension values for this row (e.g. {'scorer_id': '...'}).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public global::System.Collections.Generic.Dictionary<string, string>? Group { get; set; }

        /// <summary>
        /// Number of feedback rows in this bucket/group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Rows that emitted a score (at least one tag or rating). Excludes agent-monitor rows that scored nothing — use this for score volume.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scored_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScoredCount { get; set; }

        /// <summary>
        /// Count of each scorer tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_counts")]
        public global::System.Collections.Generic.Dictionary<string, int>? TagCounts { get; set; }

        /// <summary>
        /// Number of rows carrying each rating key (e.g. '_rating_').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating_counts")]
        public global::System.Collections.Generic.Dictionary<string, int>? RatingCounts { get; set; }

        /// <summary>
        /// Sum of each rating key's values; client derives avg = sum/count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating_sums")]
        public global::System.Collections.Generic.Dictionary<string, double>? RatingSums { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackAggregateBucket" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// Number of feedback rows in this bucket/group.
        /// </param>
        /// <param name="scoredCount">
        /// Rows that emitted a score (at least one tag or rating). Excludes agent-monitor rows that scored nothing — use this for score volume.
        /// </param>
        /// <param name="timeBucketStartMs">
        /// Time bucket start, unix epoch ms (UTC). None when unbucketed.
        /// </param>
        /// <param name="group">
        /// Group-by dimension values for this row (e.g. {'scorer_id': '...'}).
        /// </param>
        /// <param name="tagCounts">
        /// Count of each scorer tag.
        /// </param>
        /// <param name="ratingCounts">
        /// Number of rows carrying each rating key (e.g. '_rating_').
        /// </param>
        /// <param name="ratingSums">
        /// Sum of each rating key's values; client derives avg = sum/count.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackAggregateBucket(
            int totalCount,
            int scoredCount,
            int? timeBucketStartMs,
            global::System.Collections.Generic.Dictionary<string, string>? group,
            global::System.Collections.Generic.Dictionary<string, int>? tagCounts,
            global::System.Collections.Generic.Dictionary<string, int>? ratingCounts,
            global::System.Collections.Generic.Dictionary<string, double>? ratingSums)
        {
            this.TimeBucketStartMs = timeBucketStartMs;
            this.Group = group;
            this.TotalCount = totalCount;
            this.ScoredCount = scoredCount;
            this.TagCounts = tagCounts;
            this.RatingCounts = ratingCounts;
            this.RatingSums = ratingSums;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackAggregateBucket" /> class.
        /// </summary>
        public FeedbackAggregateBucket()
        {
        }

    }
}