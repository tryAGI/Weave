
#nullable enable

namespace Weave
{
    /// <summary>
    /// One conversation's span sequence and its feedback markers.
    /// </summary>
    public sealed partial class AgentConversationSpans
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
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        public global::System.Collections.Generic.IList<global::Weave.AgentConversationSpan>? Spans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans_feedback")]
        public global::System.Collections.Generic.IList<global::Weave.AgentConversationSpanFeedback>? SpansFeedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationSpans" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="spans"></param>
        /// <param name="spansFeedback"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConversationSpans(
            string conversationId,
            global::System.Collections.Generic.IList<global::Weave.AgentConversationSpan>? spans,
            global::System.Collections.Generic.IList<global::Weave.AgentConversationSpanFeedback>? spansFeedback)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.Spans = spans;
            this.SpansFeedback = spansFeedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationSpans" /> class.
        /// </summary>
        public AgentConversationSpans()
        {
        }

    }
}