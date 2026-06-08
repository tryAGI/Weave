
#nullable enable

namespace Weave
{
    /// <summary>
    /// Distribution data for one span-group/custom-attribute pair.
    /// </summary>
    public sealed partial class AgentSpanGroupDistributionItem
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
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentSpanGroupDistributionItemSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentSpanGroupDistributionItemSource Source { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentSpanGroupDistributionItemValueTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentSpanGroupDistributionItemValueType ValueType { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("present_count")]
        public int? PresentCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing_count")]
        public int? MissingCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other_count")]
        public int? OtherCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bins")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionBin>? Bins { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionValue>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanGroupDistributionItem" /> class.
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="source"></param>
        /// <param name="key"></param>
        /// <param name="valueType"></param>
        /// <param name="totalCount">
        /// Default Value: 0
        /// </param>
        /// <param name="presentCount">
        /// Default Value: 0
        /// </param>
        /// <param name="missingCount">
        /// Default Value: 0
        /// </param>
        /// <param name="otherCount">
        /// Default Value: 0
        /// </param>
        /// <param name="bins"></param>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanGroupDistributionItem(
            string alias,
            global::Weave.AgentSpanGroupDistributionItemSource source,
            string key,
            global::Weave.AgentSpanGroupDistributionItemValueType valueType,
            int? totalCount,
            int? presentCount,
            int? missingCount,
            int? otherCount,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionBin>? bins,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionValue>? values)
        {
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Source = source;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.ValueType = valueType;
            this.TotalCount = totalCount;
            this.PresentCount = presentCount;
            this.MissingCount = missingCount;
            this.OtherCount = otherCount;
            this.Bins = bins;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanGroupDistributionItem" /> class.
        /// </summary>
        public AgentSpanGroupDistributionItem()
        {
        }

    }
}