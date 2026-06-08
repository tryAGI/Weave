
#nullable enable

namespace Weave
{
    /// <summary>
    /// One custom attribute key/type observed in the matching spans.
    /// </summary>
    public sealed partial class AgentCustomAttrSchemaItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentCustomAttrSchemaItemSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentCustomAttrSchemaItemSource Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentCustomAttrSchemaItemValueTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentCustomAttrSchemaItemValueType ValueType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SpanCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCustomAttrSchemaItem" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="key"></param>
        /// <param name="valueType"></param>
        /// <param name="spanCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCustomAttrSchemaItem(
            global::Weave.AgentCustomAttrSchemaItemSource source,
            string key,
            global::Weave.AgentCustomAttrSchemaItemValueType valueType,
            int spanCount)
        {
            this.Source = source;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.ValueType = valueType;
            this.SpanCount = spanCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCustomAttrSchemaItem" /> class.
        /// </summary>
        public AgentCustomAttrSchemaItem()
        {
        }

    }
}