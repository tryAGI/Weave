
#nullable enable

namespace Weave
{
    /// <summary>
    /// Multi-turn chat view: an ordered list of per-turn chat responses.<br/>
    /// Each entry in `turns` corresponds to one trace_id, which Weave treats as<br/>
    /// one conversation turn. This is not necessarily one `invoke_agent` span:<br/>
    /// a turn can contain zero, one, or many agent invocations. The frontend can<br/>
    /// render turn-number dividers between entries and still reuse<br/>
    /// `AgentTraceChatRes` rendering for each individual turn.
    /// </summary>
    public sealed partial class AgentConversationChatRes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("turns")]
        public global::System.Collections.Generic.IList<global::Weave.AgentTraceChatRes>? Turns { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_turns")]
        public int? TotalTurns { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentConversationChatRes" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="turns"></param>
        /// <param name="totalTurns">
        /// Default Value: 0
        /// </param>
        /// <param name="hasMore">
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="feedback"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConversationChatRes(
            string conversationId,
            global::System.Collections.Generic.IList<global::Weave.AgentTraceChatRes>? turns,
            int? totalTurns,
            bool? hasMore,
            int? limit,
            int? offset,
            global::System.Collections.Generic.IList<object>? feedback)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.Turns = turns;
            this.TotalTurns = totalTurns;
            this.HasMore = hasMore;
            this.Limit = limit;
            this.Offset = offset;
            this.Feedback = feedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationChatRes" /> class.
        /// </summary>
        public AgentConversationChatRes()
        {
        }

    }
}