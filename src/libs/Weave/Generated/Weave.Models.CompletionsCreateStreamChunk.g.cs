
#nullable enable

namespace Weave
{
    /// <summary>
    /// One NDJSON line of the completions stream.<br/>
    /// A tracked call opens with the identifiers, a failure produces `error`, and<br/>
    /// every other line is a provider chunk passed through as it arrived, which is<br/>
    /// why anything else is allowed.
    /// </summary>
    public sealed partial class CompletionsCreateStreamChunk
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_meta")]
        public global::Weave.CompletionsCreateStreamMeta? Meta { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsCreateStreamChunk" /> class.
        /// </summary>
        /// <param name="meta"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionsCreateStreamChunk(
            global::Weave.CompletionsCreateStreamMeta? meta,
            string? error)
        {
            this.Meta = meta;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsCreateStreamChunk" /> class.
        /// </summary>
        public CompletionsCreateStreamChunk()
        {
        }

    }
}