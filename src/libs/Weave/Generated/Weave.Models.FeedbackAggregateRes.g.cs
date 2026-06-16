
#nullable enable

namespace Weave
{
    /// <summary>
    /// Sparse time-series of aggregated scorer feedback (empty buckets omitted).
    /// </summary>
    public sealed partial class FeedbackAggregateRes
    {
        /// <summary>
        /// Time bucket size used (seconds). None when unbucketed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_bucket_seconds")]
        public int? TimeBucketSeconds { get; set; }

        /// <summary>
        /// Resolved inclusive lower bound, unix epoch ms (UTC).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AfterMs { get; set; }

        /// <summary>
        /// Resolved exclusive upper bound, unix epoch ms (UTC).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BeforeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buckets")]
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateBucket>? Buckets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackAggregateRes" /> class.
        /// </summary>
        /// <param name="afterMs">
        /// Resolved inclusive lower bound, unix epoch ms (UTC).
        /// </param>
        /// <param name="beforeMs">
        /// Resolved exclusive upper bound, unix epoch ms (UTC).
        /// </param>
        /// <param name="timeBucketSeconds">
        /// Time bucket size used (seconds). None when unbucketed.
        /// </param>
        /// <param name="buckets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackAggregateRes(
            int afterMs,
            int beforeMs,
            int? timeBucketSeconds,
            global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateBucket>? buckets)
        {
            this.TimeBucketSeconds = timeBucketSeconds;
            this.AfterMs = afterMs;
            this.BeforeMs = beforeMs;
            this.Buckets = buckets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackAggregateRes" /> class.
        /// </summary>
        public FeedbackAggregateRes()
        {
        }

    }
}