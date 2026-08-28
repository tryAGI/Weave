
#nullable enable

namespace Weave
{
    /// <summary>
    /// Feedback row from the agent chat `include_feedback` projection.<br/>
    /// Field names match FEEDBACK_QUERY_FIELDS. This is not the feedback<br/>
    /// table row and not FeedbackCreateReq: project_id and span_* are not<br/>
    /// selected.
    /// </summary>
    public sealed partial class AgentChatFeedback
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FeedbackType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weave_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WeaveRef { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Payload { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runnable_ref")]
        public string? RunnableRef { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_ref")]
        public string? CallRef { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_ref")]
        public string? TriggerRef { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_ref")]
        public string? AnnotationRef { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ScorerTags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_tag_reasons")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> ScorerTagReasons { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_tag_confidences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> ScorerTagConfidences { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_ratings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> ScorerRatings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_rating_reasons")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> ScorerRatingReasons { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_rating_confidences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> ScorerRatingConfidences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChatFeedback" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="feedbackType"></param>
        /// <param name="weaveRef"></param>
        /// <param name="payload"></param>
        /// <param name="scorerTags"></param>
        /// <param name="scorerTagReasons"></param>
        /// <param name="scorerTagConfidences"></param>
        /// <param name="scorerRatings"></param>
        /// <param name="scorerRatingReasons"></param>
        /// <param name="scorerRatingConfidences"></param>
        /// <param name="creator"></param>
        /// <param name="createdAt"></param>
        /// <param name="wbUserId"></param>
        /// <param name="runnableRef"></param>
        /// <param name="callRef"></param>
        /// <param name="triggerRef"></param>
        /// <param name="annotationRef"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentChatFeedback(
            string id,
            string feedbackType,
            string weaveRef,
            object payload,
            global::System.Collections.Generic.IList<string> scorerTags,
            global::System.Collections.Generic.Dictionary<string, string> scorerTagReasons,
            global::System.Collections.Generic.Dictionary<string, double> scorerTagConfidences,
            global::System.Collections.Generic.Dictionary<string, double> scorerRatings,
            global::System.Collections.Generic.Dictionary<string, string> scorerRatingReasons,
            global::System.Collections.Generic.Dictionary<string, double> scorerRatingConfidences,
            string? creator,
            global::System.DateTime? createdAt,
            string? wbUserId,
            string? runnableRef,
            string? callRef,
            string? triggerRef,
            string? annotationRef)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FeedbackType = feedbackType ?? throw new global::System.ArgumentNullException(nameof(feedbackType));
            this.WeaveRef = weaveRef ?? throw new global::System.ArgumentNullException(nameof(weaveRef));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.Creator = creator;
            this.CreatedAt = createdAt;
            this.WbUserId = wbUserId;
            this.RunnableRef = runnableRef;
            this.CallRef = callRef;
            this.TriggerRef = triggerRef;
            this.AnnotationRef = annotationRef;
            this.ScorerTags = scorerTags ?? throw new global::System.ArgumentNullException(nameof(scorerTags));
            this.ScorerTagReasons = scorerTagReasons ?? throw new global::System.ArgumentNullException(nameof(scorerTagReasons));
            this.ScorerTagConfidences = scorerTagConfidences ?? throw new global::System.ArgumentNullException(nameof(scorerTagConfidences));
            this.ScorerRatings = scorerRatings ?? throw new global::System.ArgumentNullException(nameof(scorerRatings));
            this.ScorerRatingReasons = scorerRatingReasons ?? throw new global::System.ArgumentNullException(nameof(scorerRatingReasons));
            this.ScorerRatingConfidences = scorerRatingConfidences ?? throw new global::System.ArgumentNullException(nameof(scorerRatingConfidences));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChatFeedback" /> class.
        /// </summary>
        public AgentChatFeedback()
        {
        }

    }
}