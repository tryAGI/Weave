
#nullable enable

namespace Weave
{
    /// <summary>
    /// Bucket stats rows by ranges of one numeric span or grouped value.
    /// </summary>
    public sealed partial class AgentSpanStatsNumericBucketSpec
    {
        /// <summary>
        /// Default Value: number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Default Value: 24
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bins")]
        public int? Bins { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::Weave.AgentSpanValueRef? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<global::Weave.AgentGroupByRef>? GroupBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measure")]
        public global::Weave.AgentSpanMeasureSpec? Measure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanStatsNumericBucketSpec" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: number
        /// </param>
        /// <param name="alias">
        /// Default Value: value
        /// </param>
        /// <param name="bins">
        /// Default Value: 24
        /// </param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="value"></param>
        /// <param name="groupBy"></param>
        /// <param name="measure"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanStatsNumericBucketSpec(
            string? type,
            string? alias,
            int? bins,
            double? min,
            double? max,
            global::Weave.AgentSpanValueRef? value,
            global::System.Collections.Generic.IList<global::Weave.AgentGroupByRef>? groupBy,
            global::Weave.AgentSpanMeasureSpec? measure)
        {
            this.Type = type;
            this.Alias = alias;
            this.Bins = bins;
            this.Min = min;
            this.Max = max;
            this.Value = value;
            this.GroupBy = groupBy;
            this.Measure = measure;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanStatsNumericBucketSpec" /> class.
        /// </summary>
        public AgentSpanStatsNumericBucketSpec()
        {
        }

    }
}