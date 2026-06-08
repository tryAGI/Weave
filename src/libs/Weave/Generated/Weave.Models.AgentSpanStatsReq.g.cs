
#nullable enable

namespace Weave
{
    /// <summary>
    /// Request chart-ready aggregations over GenAI agent spans.
    /// </summary>
    public sealed partial class AgentSpanStatsReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public global::Weave.Query? Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public global::System.DateTime? End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        public int? Granularity { get; set; }

        /// <summary>
        /// Default Value: UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<global::Weave.AgentGroupByRef>? GroupBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsMetricSpec>? Metrics { get; set; }

        /// <summary>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_limit")]
        public int? GroupLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_by")]
        public global::Weave.BucketByVariant1? BucketBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_filters")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupFilter>? GroupFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanStatsReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="start"></param>
        /// <param name="query"></param>
        /// <param name="end"></param>
        /// <param name="granularity"></param>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="metrics"></param>
        /// <param name="groupLimit">
        /// Default Value: 50
        /// </param>
        /// <param name="bucketBy"></param>
        /// <param name="groupFilters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanStatsReq(
            string projectId,
            global::System.DateTime start,
            global::Weave.Query? query,
            global::System.DateTime? end,
            int? granularity,
            string? timezone,
            global::System.Collections.Generic.IList<global::Weave.AgentGroupByRef>? groupBy,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsMetricSpec>? metrics,
            int? groupLimit,
            global::Weave.BucketByVariant1? bucketBy,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupFilter>? groupFilters)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Query = query;
            this.Start = start;
            this.End = end;
            this.Granularity = granularity;
            this.Timezone = timezone;
            this.GroupBy = groupBy;
            this.Metrics = metrics;
            this.GroupLimit = groupLimit;
            this.BucketBy = bucketBy;
            this.GroupFilters = groupFilters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanStatsReq" /> class.
        /// </summary>
        public AgentSpanStatsReq()
        {
        }

    }
}