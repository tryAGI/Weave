
#nullable enable

namespace Weave
{
    /// <summary>
    /// Reference to a span field or typed custom attribute map value.
    /// </summary>
    public sealed partial class AgentSpanValueRef
    {
        /// <summary>
        /// Default Value: field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentSpanValueRefSourceJsonConverter))]
        public global::Weave.AgentSpanValueRefSource? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanValueRef" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="source">
        /// Default Value: field
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanValueRef(
            string key,
            global::Weave.AgentSpanValueRefSource? source)
        {
            this.Source = source;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanValueRef" /> class.
        /// </summary>
        public AgentSpanValueRef()
        {
        }

    }
}