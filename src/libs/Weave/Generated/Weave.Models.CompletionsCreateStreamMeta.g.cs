
#nullable enable

namespace Weave
{
    /// <summary>
    /// Identifiers of the call the stream is recorded into.
    /// </summary>
    public sealed partial class CompletionsCreateStreamMeta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weave_call_id")]
        public string? WeaveCallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        public string? SpanId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsCreateStreamMeta" /> class.
        /// </summary>
        /// <param name="weaveCallId"></param>
        /// <param name="spanId"></param>
        /// <param name="traceId"></param>
        /// <param name="conversationId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionsCreateStreamMeta(
            string? weaveCallId,
            string? spanId,
            string? traceId,
            string? conversationId)
        {
            this.WeaveCallId = weaveCallId;
            this.SpanId = spanId;
            this.TraceId = traceId;
            this.ConversationId = conversationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsCreateStreamMeta" /> class.
        /// </summary>
        public CompletionsCreateStreamMeta()
        {
        }

    }
}