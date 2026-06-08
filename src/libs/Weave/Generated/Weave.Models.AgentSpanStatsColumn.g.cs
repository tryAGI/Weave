
#nullable enable

namespace Weave
{
    /// <summary>
    /// Metadata describing one column in an agent span stats result row.
    /// </summary>
    public sealed partial class AgentSpanStatsColumn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentSpanStatsColumnRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentSpanStatsColumnRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentSpanStatsColumnValueTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentSpanStatsColumnValueType ValueType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        public string? Metric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregation")]
        public string? Aggregation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanStatsColumn" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="role"></param>
        /// <param name="valueType"></param>
        /// <param name="metric"></param>
        /// <param name="aggregation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanStatsColumn(
            string name,
            global::Weave.AgentSpanStatsColumnRole role,
            global::Weave.AgentSpanStatsColumnValueType valueType,
            string? metric,
            string? aggregation)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role;
            this.ValueType = valueType;
            this.Metric = metric;
            this.Aggregation = aggregation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanStatsColumn" /> class.
        /// </summary>
        public AgentSpanStatsColumn()
        {
        }

    }
}