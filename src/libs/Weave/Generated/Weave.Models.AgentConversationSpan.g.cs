
#nullable enable

namespace Weave
{
    /// <summary>
    /// One span in a conversation's trace.<br/>
    /// Returned by `agent_conversation_spans`, which reads span scalar columns<br/>
    /// only (no message bodies). Spans are ordered by `started_at`, which<br/>
    /// approximates — but does not exactly match — the detail chat view's<br/>
    /// parent/child tree-walk order. `operation_name` is the raw OTel value; the<br/>
    /// client maps it to a display category.
    /// </summary>
    public sealed partial class AgentConversationSpan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OperationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentConversationSpanStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentConversationSpanStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationSpan" /> class.
        /// </summary>
        /// <param name="operationName"></param>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="status"></param>
        /// <param name="durationMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConversationSpan(
            string operationName,
            string traceId,
            string spanId,
            global::Weave.AgentConversationSpanStatus status,
            int durationMs)
        {
            this.OperationName = operationName ?? throw new global::System.ArgumentNullException(nameof(operationName));
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.Status = status;
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationSpan" /> class.
        /// </summary>
        public AgentConversationSpan()
        {
        }

    }
}