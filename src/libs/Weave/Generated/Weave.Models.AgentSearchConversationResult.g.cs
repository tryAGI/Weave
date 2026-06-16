
#nullable enable

namespace Weave
{
    /// <summary>
    /// A conversation containing messages that matched the search query.
    /// </summary>
    public sealed partial class AgentSearchConversationResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matched_messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.AgentSearchMatchedMessage> MatchedMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_activity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastActivity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSearchConversationResult" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="conversationName"></param>
        /// <param name="agentName"></param>
        /// <param name="matchedMessages"></param>
        /// <param name="lastActivity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSearchConversationResult(
            string conversationId,
            string conversationName,
            string agentName,
            global::System.Collections.Generic.IList<global::Weave.AgentSearchMatchedMessage> matchedMessages,
            global::System.DateTime lastActivity)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.ConversationName = conversationName ?? throw new global::System.ArgumentNullException(nameof(conversationName));
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.MatchedMessages = matchedMessages ?? throw new global::System.ArgumentNullException(nameof(matchedMessages));
            this.LastActivity = lastActivity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSearchConversationResult" /> class.
        /// </summary>
        public AgentSearchConversationResult()
        {
        }

    }
}