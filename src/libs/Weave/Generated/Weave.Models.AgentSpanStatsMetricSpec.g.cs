
#nullable enable

namespace Weave
{
    /// <summary>
    /// Metric to extract from each matching span and aggregate into chart rows.
    /// </summary>
    public sealed partial class AgentSpanStatsMetricSpec
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
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentSpanStatsMetricSpecValueTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentSpanStatsMetricSpecValueType ValueType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregations")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsMetricSpecAggregation>? Aggregations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentiles")]
        public global::System.Collections.Generic.IList<double>? Percentiles { get; set; }

        /// <summary>
        /// Reference to a span field or typed custom attribute map value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentSpanValueRef Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanStatsMetricSpec" /> class.
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="valueType"></param>
        /// <param name="value">
        /// Reference to a span field or typed custom attribute map value.
        /// </param>
        /// <param name="aggregations"></param>
        /// <param name="percentiles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanStatsMetricSpec(
            string alias,
            global::Weave.AgentSpanStatsMetricSpecValueType valueType,
            global::Weave.AgentSpanValueRef value,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsMetricSpecAggregation>? aggregations,
            global::System.Collections.Generic.IList<double>? percentiles)
        {
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.ValueType = valueType;
            this.Aggregations = aggregations;
            this.Percentiles = percentiles;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanStatsMetricSpec" /> class.
        /// </summary>
        public AgentSpanStatsMetricSpec()
        {
        }

    }
}