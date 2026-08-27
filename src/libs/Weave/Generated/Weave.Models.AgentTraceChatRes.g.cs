
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
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_version")]
        public string? AgentVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public global::Weave.AgentTraceChatResStatusCode2? StatusCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Wall-clock duration of the trace root span in milliseconds. This is not a sum of child span durations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_ms")]
        public int? TotalDurationMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost_usd")]
        public double? TotalCostUsd { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_tokens")]
        public int? TotalInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_output_tokens")]
        public int? TotalOutputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_reasoning_tokens")]
        public int? TotalReasoningTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cache_creation_input_tokens")]
        public int? TotalCacheCreationInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cache_read_input_tokens")]
        public int? TotalCacheReadInputTokens { get; set; }

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
        /// <param name="agentName"></param>
        /// <param name="agentVersion"></param>
        /// <param name="statusCode"></param>
        /// <param name="provider"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="wbUserId"></param>
        /// <param name="totalDurationMs">
        /// Wall-clock duration of the trace root span in milliseconds. This is not a sum of child span durations.
        /// </param>
        /// <param name="totalCostUsd"></param>
        /// <param name="totalInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalOutputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalReasoningTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalCacheCreationInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalCacheReadInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="messages"></param>
        /// <param name="feedback"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTraceChatRes(
            string traceId,
            string? rootSpanName,
            string? agentName,
            string? agentVersion,
            global::Weave.AgentTraceChatResStatusCode2? statusCode,
            string? provider,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            string? wbUserId,
            int? totalDurationMs,
            double? totalCostUsd,
            int? totalInputTokens,
            int? totalOutputTokens,
            int? totalReasoningTokens,
            int? totalCacheCreationInputTokens,
            int? totalCacheReadInputTokens,
            global::System.Collections.Generic.IList<global::Weave.AgentChatMessage>? messages,
            global::System.Collections.Generic.IList<object>? feedback)
        {
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.RootSpanName = rootSpanName;
            this.AgentName = agentName;
            this.AgentVersion = agentVersion;
            this.StatusCode = statusCode;
            this.Provider = provider;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.WbUserId = wbUserId;
            this.TotalDurationMs = totalDurationMs;
            this.TotalCostUsd = totalCostUsd;
            this.TotalInputTokens = totalInputTokens;
            this.TotalOutputTokens = totalOutputTokens;
            this.TotalReasoningTokens = totalReasoningTokens;
            this.TotalCacheCreationInputTokens = totalCacheCreationInputTokens;
            this.TotalCacheReadInputTokens = totalCacheReadInputTokens;
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