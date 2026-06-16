
#nullable enable

namespace Weave
{
    /// <summary>
    /// One custom attribute distribution to compute per returned span group.
    /// </summary>
    public sealed partial class AgentSpanGroupDistributionSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// Reference to a span field or typed custom attribute map value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentSpanValueRef Value { get; set; }

        /// <summary>
        /// Default Value: 12
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bins")]
        public int? Bins { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanGroupDistributionSpec" /> class.
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="value">
        /// Reference to a span field or typed custom attribute map value.
        /// </param>
        /// <param name="bins">
        /// Default Value: 12
        /// </param>
        /// <param name="topN">
        /// Default Value: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanGroupDistributionSpec(
            string alias,
            global::Weave.AgentSpanValueRef value,
            int? bins,
            int? topN)
        {
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Bins = bins;
            this.TopN = topN;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanGroupDistributionSpec" /> class.
        /// </summary>
        public AgentSpanGroupDistributionSpec()
        {
        }

    }
}