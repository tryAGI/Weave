
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CompletionsCreateRes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Response { get; set; }

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
        /// Initializes a new instance of the <see cref="CompletionsCreateRes" /> class.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="weaveCallId"></param>
        /// <param name="spanId"></param>
        /// <param name="traceId"></param>
        /// <param name="conversationId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionsCreateRes(
            object response,
            string? weaveCallId,
            string? spanId,
            string? traceId,
            string? conversationId)
        {
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.WeaveCallId = weaveCallId;
            this.SpanId = spanId;
            this.TraceId = traceId;
            this.ConversationId = conversationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsCreateRes" /> class.
        /// </summary>
        public CompletionsCreateRes()
        {
        }

    }
}