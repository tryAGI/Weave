
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomRuntimeIDRes
    {
        /// <summary>
        /// Value sent in the OpenAI-compatible request model field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Maximum tokens supported by this runtime ID<br/>
        /// Default Value: 4096
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playground_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaygroundId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRuntimeIDRes" /> class.
        /// </summary>
        /// <param name="id">
        /// Value sent in the OpenAI-compatible request model field
        /// </param>
        /// <param name="playgroundId"></param>
        /// <param name="maxTokens">
        /// Maximum tokens supported by this runtime ID<br/>
        /// Default Value: 4096
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomRuntimeIDRes(
            string id,
            string playgroundId,
            int? maxTokens)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MaxTokens = maxTokens;
            this.PlaygroundId = playgroundId ?? throw new global::System.ArgumentNullException(nameof(playgroundId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRuntimeIDRes" /> class.
        /// </summary>
        public CustomRuntimeIDRes()
        {
        }

    }
}