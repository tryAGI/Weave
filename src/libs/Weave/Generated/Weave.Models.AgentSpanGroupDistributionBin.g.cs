
#nullable enable

namespace Weave
{
    /// <summary>
    /// One numeric histogram bin for a custom attribute in a span group.
    /// </summary>
    public sealed partial class AgentSpanGroupDistributionBin
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Min { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Max { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentSpanGroupDistributionBin" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanGroupDistributionBin(
            int index,
            double min,
            double max,
            int count)
        {
            this.Index = index;
            this.Min = min;
            this.Max = max;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanGroupDistributionBin" /> class.
        /// </summary>
        public AgentSpanGroupDistributionBin()
        {
        }

    }
}