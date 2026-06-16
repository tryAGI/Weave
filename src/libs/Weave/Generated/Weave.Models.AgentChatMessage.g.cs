
#nullable enable

namespace Weave
{
    /// <summary>
    /// A single element in the structured agent trajectory / chat view.<br/>
    /// Common event fields live at the top level. Type-specific fields are<br/>
    /// grouped under the payload matching `type`, and exactly one payload must be<br/>
    /// set. This keeps subtype nullability explicit while preserving a single<br/>
    /// ordered timeline model for callers.
    /// </summary>
    public sealed partial class AgentChatMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentChatMessageTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentChatMessageType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        public string? SpanId { get; set; }

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
        public global::Weave.AgentChatMessageStatusCode2? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_message")]
        public global::Weave.AgentChatUserMessage? UserMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant_message")]
        public global::Weave.AgentChatAssistantMessage? AssistantMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call")]
        public global::Weave.AgentChatToolCall? ToolCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_start")]
        public global::Weave.AgentChatAgentStart? AgentStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_handoff")]
        public global::Weave.AgentChatAgentHandoff? AgentHandoff { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_compacted")]
        public global::Weave.AgentChatContextCompacted? ContextCompacted { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentChatMessage" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="spanId"></param>
        /// <param name="agentName"></param>
        /// <param name="agentVersion"></param>
        /// <param name="statusCode"></param>
        /// <param name="startedAt"></param>
        /// <param name="userMessage"></param>
        /// <param name="assistantMessage"></param>
        /// <param name="toolCall"></param>
        /// <param name="agentStart"></param>
        /// <param name="agentHandoff"></param>
        /// <param name="contextCompacted"></param>
        /// <param name="feedback"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentChatMessage(
            global::Weave.AgentChatMessageType type,
            string? spanId,
            string? agentName,
            string? agentVersion,
            global::Weave.AgentChatMessageStatusCode2? statusCode,
            global::System.DateTime? startedAt,
            global::Weave.AgentChatUserMessage? userMessage,
            global::Weave.AgentChatAssistantMessage? assistantMessage,
            global::Weave.AgentChatToolCall? toolCall,
            global::Weave.AgentChatAgentStart? agentStart,
            global::Weave.AgentChatAgentHandoff? agentHandoff,
            global::Weave.AgentChatContextCompacted? contextCompacted,
            global::System.Collections.Generic.IList<object>? feedback)
        {
            this.Type = type;
            this.SpanId = spanId;
            this.AgentName = agentName;
            this.AgentVersion = agentVersion;
            this.StatusCode = statusCode;
            this.StartedAt = startedAt;
            this.UserMessage = userMessage;
            this.AssistantMessage = assistantMessage;
            this.ToolCall = toolCall;
            this.AgentStart = agentStart;
            this.AgentHandoff = agentHandoff;
            this.ContextCompacted = contextCompacted;
            this.Feedback = feedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChatMessage" /> class.
        /// </summary>
        public AgentChatMessage()
        {
        }

    }
}