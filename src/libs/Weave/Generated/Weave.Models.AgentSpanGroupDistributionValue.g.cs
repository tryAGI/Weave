
#nullable enable

namespace Weave
{
    /// <summary>
    /// One categorical custom attribute value count in a span group.
    /// </summary>
    public sealed partial class AgentSpanGroupDistributionValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanGroupDistributionValue" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanGroupDistributionValue(
            string value,
            int count)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanGroupDistributionValue" /> class.
        /// </summary>
        public AgentSpanGroupDistributionValue()
        {
        }

    }
}