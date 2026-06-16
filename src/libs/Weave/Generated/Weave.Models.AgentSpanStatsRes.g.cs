
#nullable enable

namespace Weave
{
    /// <summary>
    /// Response containing chart-ready agent span stats rows.
    /// </summary>
    public sealed partial class AgentSpanStatsRes
    {
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        public int? Granularity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// Default Value: time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentSpanStatsResBucketTypeJsonConverter))]
        public global::Weave.AgentSpanStatsResBucketType? BucketType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsColumn>? Columns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        public global::System.Collections.Generic.IList<object>? Rows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanStatsRes" /> class.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="timezone"></param>
        /// <param name="granularity"></param>
        /// <param name="bucketType">
        /// Default Value: time
        /// </param>
        /// <param name="columns"></param>
        /// <param name="rows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanStatsRes(
            global::System.DateTime start,
            global::System.DateTime end,
            string timezone,
            int? granularity,
            global::Weave.AgentSpanStatsResBucketType? bucketType,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsColumn>? columns,
            global::System.Collections.Generic.IList<object>? rows)
        {
            this.Start = start;
            this.End = end;
            this.Granularity = granularity;
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
            this.BucketType = bucketType;
            this.Columns = columns;
            this.Rows = rows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanStatsRes" /> class.
        /// </summary>
        public AgentSpanStatsRes()
        {
        }

    }
}