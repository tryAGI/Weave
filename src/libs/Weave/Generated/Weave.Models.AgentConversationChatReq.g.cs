
#nullable enable

namespace Weave
{
    /// <summary>
    /// Request to get the multi-turn chat view for a conversation.
    /// </summary>
    public sealed partial class AgentConversationChatReq
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// Maximum number of conversation turns to return.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Number of most-recent turns to skip. Results are returned in chronological order within the selected page.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_feedback")]
        public bool? IncludeFeedback { get; set; }

        /// <summary>
        /// Include tool calls requested in model outputs, even when no execution span was recorded, and place each execution span after the model span that requested it. Requests without execution evidence have no status, duration, or result. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_model_tool_calls")]
        public bool? IncludeModelToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationChatReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="conversationId"></param>
        /// <param name="limit">
        /// Maximum number of conversation turns to return.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Number of most-recent turns to skip. Results are returned in chronological order within the selected page.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="includeFeedback">
        /// Default Value: false
        /// </param>
        /// <param name="includeModelToolCalls">
        /// Include tool calls requested in model outputs, even when no execution span was recorded, and place each execution span after the model span that requested it. Requests without execution evidence have no status, duration, or result. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConversationChatReq(
            string projectId,
            string conversationId,
            int? limit,
            int? offset,
            bool? includeFeedback,
            bool? includeModelToolCalls)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.Limit = limit;
            this.Offset = offset;
            this.IncludeFeedback = includeFeedback;
            this.IncludeModelToolCalls = includeModelToolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationChatReq" /> class.
        /// </summary>
        public AgentConversationChatReq()
        {
        }

    }
}