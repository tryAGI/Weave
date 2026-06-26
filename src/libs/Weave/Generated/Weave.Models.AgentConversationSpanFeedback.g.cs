
#nullable enable

namespace Weave
{
    /// <summary>
    /// Tags and ratings applied to a conversation's turn (or the conversation).<br/>
    /// Positioned client-side by matching `trace_id` (turn) against the spans;<br/>
    /// `trace_id` is None for conversation-level feedback.
    /// </summary>
    public sealed partial class AgentConversationSpanFeedback
    {
        /// <summary>
        /// The turn this feedback is anchored to; None for conversation-level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentConversationSpanFeedbackFeedbackTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentConversationSpanFeedbackFeedbackType FeedbackType { get; set; }

        /// <summary>
        /// Arbitrary descriptive tags applied to this feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Numeric scorer ratings applied to this feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratings")]
        public global::System.Collections.Generic.IList<global::Weave.AgentConversationSpanRating>? Ratings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationSpanFeedback" /> class.
        /// </summary>
        /// <param name="feedbackType"></param>
        /// <param name="traceId">
        /// The turn this feedback is anchored to; None for conversation-level.
        /// </param>
        /// <param name="tags">
        /// Arbitrary descriptive tags applied to this feedback.
        /// </param>
        /// <param name="ratings">
        /// Numeric scorer ratings applied to this feedback.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConversationSpanFeedback(
            global::Weave.AgentConversationSpanFeedbackFeedbackType feedbackType,
            string? traceId,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<global::Weave.AgentConversationSpanRating>? ratings)
        {
            this.TraceId = traceId;
            this.FeedbackType = feedbackType;
            this.Tags = tags;
            this.Ratings = ratings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationSpanFeedback" /> class.
        /// </summary>
        public AgentConversationSpanFeedback()
        {
        }

    }
}