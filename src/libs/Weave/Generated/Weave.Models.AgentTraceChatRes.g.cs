
#nullable enable

namespace Weave
{
    /// <summary>
    /// Structured chat view: a linear sequence of messages representing<br/>
    /// the agent trajectory for a single trace.
    /// </summary>
    public sealed partial class AgentTraceChatRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_span_name")]
        public string? RootSpanName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Wall-clock duration of the trace root span in milliseconds. This is not a sum of child span durations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_ms")]
        public int? TotalDurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Weave.AgentChatMessage>? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public global::System.Collections.Generic.IList<object>? Feedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTraceChatRes" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="rootSpanName"></param>
        /// <param name="provider"></param>
        /// <param name="totalDurationMs">
        /// Wall-clock duration of the trace root span in milliseconds. This is not a sum of child span durations.
        /// </param>
        /// <param name="messages"></param>
        /// <param name="feedback"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTraceChatRes(
            string traceId,
            string? rootSpanName,
            string? provider,
            int? totalDurationMs,
            global::System.Collections.Generic.IList<global::Weave.AgentChatMessage>? messages,
            global::System.Collections.Generic.IList<object>? feedback)
        {
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.RootSpanName = rootSpanName;
            this.Provider = provider;
            this.TotalDurationMs = totalDurationMs;
            this.Messages = messages;
            this.Feedback = feedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTraceChatRes" /> class.
        /// </summary>
        public AgentTraceChatRes()
        {
        }

    }
}