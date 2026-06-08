
#nullable enable

namespace Weave
{
    /// <summary>
    /// One aggregate measure computed over spans in a group or bucket.
    /// </summary>
    public sealed partial class AgentSpanMeasureSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentSpanMeasureSpecAggregationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentSpanMeasureSpecAggregation Aggregation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::Weave.AgentSpanValueRef? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        public global::Weave.AgentSpanMeasureSpecValueType2? ValueType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::Weave.Query? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanMeasureSpec" /> class.
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="aggregation"></param>
        /// <param name="value"></param>
        /// <param name="valueType"></param>
        /// <param name="filter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanMeasureSpec(
            string alias,
            global::Weave.AgentSpanMeasureSpecAggregation aggregation,
            global::Weave.AgentSpanValueRef? value,
            global::Weave.AgentSpanMeasureSpecValueType2? valueType,
            global::Weave.Query? filter)
        {
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Aggregation = aggregation;
            this.Value = value;
            this.ValueType = valueType;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanMeasureSpec" /> class.
        /// </summary>
        public AgentSpanMeasureSpec()
        {
        }

    }
}