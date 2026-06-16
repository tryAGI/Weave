
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackCreateReq
    {
        /// <summary>
        /// If provided by the client, this ID will be used for the feedback row instead of a server-generated one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weave_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WeaveRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FeedbackType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Payload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_ref")]
        public string? AnnotationRef { get; set; }

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
        /// The annotation queue ID this feedback was created from. References annotation_queues.id. NULL when feedback is created outside of queues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_id")]
        public string? QueueId { get; set; }

        /// <summary>
        /// Tags applied to the ref by a scorer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_tags")]
        public global::System.Collections.Generic.IList<string>? ScorerTags { get; set; }

        /// <summary>
        /// reason text per tag, keyed by tag name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_tag_reasons")]
        public global::System.Collections.Generic.Dictionary<string, string>? ScorerTagReasons { get; set; }

        /// <summary>
        /// confidence (0-1) per tag, keyed by tag name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_tag_confidences")]
        public global::System.Collections.Generic.Dictionary<string, double>? ScorerTagConfidences { get; set; }

        /// <summary>
        /// numeric ratings (0-1) keyed by rating name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_ratings")]
        public global::System.Collections.Generic.Dictionary<string, double>? ScorerRatings { get; set; }

        /// <summary>
        /// reason text per rating, keyed by rating name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_rating_reasons")]
        public global::System.Collections.Generic.Dictionary<string, string>? ScorerRatingReasons { get; set; }

        /// <summary>
        /// confidence (0-1) per rating, keyed by rating name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_rating_confidences")]
        public global::System.Collections.Generic.Dictionary<string, double>? ScorerRatingConfidences { get; set; }

        /// <summary>
        /// Display name of the scored agent (from spans.agent_name)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_agent_name")]
        public string? SpanAgentName { get; set; }

        /// <summary>
        /// Version of the scored agent (from spans.agent_version)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_agent_version")]
        public string? SpanAgentVersion { get; set; }

        /// <summary>
        /// Status of the scored turn (from spans.status_code)<br/>
        /// Default Value: UNSET
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_status_code")]
        public string? SpanStatusCode { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="weaveRef"></param>
        /// <param name="feedbackType"></param>
        /// <param name="payload"></param>
        /// <param name="id">
        /// If provided by the client, this ID will be used for the feedback row instead of a server-generated one.
        /// </param>
        /// <param name="creator"></param>
        /// <param name="annotationRef"></param>
        /// <param name="runnableRef"></param>
        /// <param name="callRef"></param>
        /// <param name="triggerRef"></param>
        /// <param name="queueId">
        /// The annotation queue ID this feedback was created from. References annotation_queues.id. NULL when feedback is created outside of queues.
        /// </param>
        /// <param name="scorerTags">
        /// Tags applied to the ref by a scorer
        /// </param>
        /// <param name="scorerTagReasons">
        /// reason text per tag, keyed by tag name
        /// </param>
        /// <param name="scorerTagConfidences">
        /// confidence (0-1) per tag, keyed by tag name
        /// </param>
        /// <param name="scorerRatings">
        /// numeric ratings (0-1) keyed by rating name
        /// </param>
        /// <param name="scorerRatingReasons">
        /// reason text per rating, keyed by rating name
        /// </param>
        /// <param name="scorerRatingConfidences">
        /// confidence (0-1) per rating, keyed by rating name
        /// </param>
        /// <param name="spanAgentName">
        /// Display name of the scored agent (from spans.agent_name)
        /// </param>
        /// <param name="spanAgentVersion">
        /// Version of the scored agent (from spans.agent_version)
        /// </param>
        /// <param name="spanStatusCode">
        /// Status of the scored turn (from spans.status_code)<br/>
        /// Default Value: UNSET
        /// </param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackCreateReq(
            string projectId,
            string weaveRef,
            string feedbackType,
            object payload,
            string? id,
            string? creator,
            string? annotationRef,
            string? runnableRef,
            string? callRef,
            string? triggerRef,
            string? queueId,
            global::System.Collections.Generic.IList<string>? scorerTags,
            global::System.Collections.Generic.Dictionary<string, string>? scorerTagReasons,
            global::System.Collections.Generic.Dictionary<string, double>? scorerTagConfidences,
            global::System.Collections.Generic.Dictionary<string, double>? scorerRatings,
            global::System.Collections.Generic.Dictionary<string, string>? scorerRatingReasons,
            global::System.Collections.Generic.Dictionary<string, double>? scorerRatingConfidences,
            string? spanAgentName,
            string? spanAgentVersion,
            string? spanStatusCode,
            string? wbUserId)
        {
            this.Id = id;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.WeaveRef = weaveRef ?? throw new global::System.ArgumentNullException(nameof(weaveRef));
            this.Creator = creator;
            this.FeedbackType = feedbackType ?? throw new global::System.ArgumentNullException(nameof(feedbackType));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.AnnotationRef = annotationRef;
            this.RunnableRef = runnableRef;
            this.CallRef = callRef;
            this.TriggerRef = triggerRef;
            this.QueueId = queueId;
            this.ScorerTags = scorerTags;
            this.ScorerTagReasons = scorerTagReasons;
            this.ScorerTagConfidences = scorerTagConfidences;
            this.ScorerRatings = scorerRatings;
            this.ScorerRatingReasons = scorerRatingReasons;
            this.ScorerRatingConfidences = scorerRatingConfidences;
            this.SpanAgentName = spanAgentName;
            this.SpanAgentVersion = spanAgentVersion;
            this.SpanStatusCode = spanStatusCode;
            this.WbUserId = wbUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateReq" /> class.
        /// </summary>
        public FeedbackCreateReq()
        {
        }

    }
}