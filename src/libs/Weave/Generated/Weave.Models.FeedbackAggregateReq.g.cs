
#nullable enable

namespace Weave
{
    /// <summary>
    /// Query for aggregate scores by time bucket and dimension.
    /// </summary>
    public sealed partial class FeedbackAggregateReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Inclusive lower bound on created_at (milliseconds since epoch).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long AfterMs { get; set; }

        /// <summary>
        /// Exclusive upper bound on created_at (milliseconds since epoch).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BeforeMs { get; set; }

        /// <summary>
        /// Time bucket size in seconds, e.g. 3600 for 1h buckets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_bucket_seconds")]
        public int? TimeBucketSeconds { get; set; }

        /// <summary>
        /// Filter on feedback_type by prefix
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_types")]
        public global::System.Collections.Generic.IList<string>? FeedbackTypes { get; set; }

        /// <summary>
        /// Filter to feedback that includes any of the given tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Include only rows with a rating &gt;= this value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating_min")]
        public double? RatingMin { get; set; }

        /// <summary>
        /// Include only rows with a rating &lt;= this value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating_max")]
        public double? RatingMax { get; set; }

        /// <summary>
        /// Filter to these monitor ids (exact match; suffix with '*' for prefix match).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitor_ids")]
        public global::System.Collections.Generic.IList<string>? MonitorIds { get; set; }

        /// <summary>
        /// Filter to these scorer ids (exact match; suffix with '*' for prefix match).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_ids")]
        public global::System.Collections.Generic.IList<string>? ScorerIds { get; set; }

        /// <summary>
        /// Filter to feedback whose span_agent_name matches any of these (exact).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_agent_names")]
        public global::System.Collections.Generic.IList<string>? SpanAgentNames { get; set; }

        /// <summary>
        /// Filter by span type (turn vs conversation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_types")]
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateReqSpanType>? SpanTypes { get; set; }

        /// <summary>
        /// Allowed: ['scorer_id', 'span_agent_name', 'span_agent_version', 'span_status_code'].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateReqGroupByItem>? GroupBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackAggregateReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="afterMs">
        /// Inclusive lower bound on created_at (milliseconds since epoch).
        /// </param>
        /// <param name="beforeMs">
        /// Exclusive upper bound on created_at (milliseconds since epoch).
        /// </param>
        /// <param name="timeBucketSeconds">
        /// Time bucket size in seconds, e.g. 3600 for 1h buckets
        /// </param>
        /// <param name="feedbackTypes">
        /// Filter on feedback_type by prefix
        /// </param>
        /// <param name="tags">
        /// Filter to feedback that includes any of the given tags
        /// </param>
        /// <param name="ratingMin">
        /// Include only rows with a rating &gt;= this value
        /// </param>
        /// <param name="ratingMax">
        /// Include only rows with a rating &lt;= this value
        /// </param>
        /// <param name="monitorIds">
        /// Filter to these monitor ids (exact match; suffix with '*' for prefix match).
        /// </param>
        /// <param name="scorerIds">
        /// Filter to these scorer ids (exact match; suffix with '*' for prefix match).
        /// </param>
        /// <param name="spanAgentNames">
        /// Filter to feedback whose span_agent_name matches any of these (exact).
        /// </param>
        /// <param name="spanTypes">
        /// Filter by span type (turn vs conversation).
        /// </param>
        /// <param name="groupBy">
        /// Allowed: ['scorer_id', 'span_agent_name', 'span_agent_version', 'span_status_code'].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackAggregateReq(
            string projectId,
            long afterMs,
            long beforeMs,
            int? timeBucketSeconds,
            global::System.Collections.Generic.IList<string>? feedbackTypes,
            global::System.Collections.Generic.IList<string>? tags,
            double? ratingMin,
            double? ratingMax,
            global::System.Collections.Generic.IList<string>? monitorIds,
            global::System.Collections.Generic.IList<string>? scorerIds,
            global::System.Collections.Generic.IList<string>? spanAgentNames,
            global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateReqSpanType>? spanTypes,
            global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateReqGroupByItem>? groupBy)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.AfterMs = afterMs;
            this.BeforeMs = beforeMs;
            this.TimeBucketSeconds = timeBucketSeconds;
            this.FeedbackTypes = feedbackTypes;
            this.Tags = tags;
            this.RatingMin = ratingMin;
            this.RatingMax = ratingMax;
            this.MonitorIds = monitorIds;
            this.ScorerIds = scorerIds;
            this.SpanAgentNames = spanAgentNames;
            this.SpanTypes = spanTypes;
            this.GroupBy = groupBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackAggregateReq" /> class.
        /// </summary>
        public FeedbackAggregateReq()
        {
        }

    }
}