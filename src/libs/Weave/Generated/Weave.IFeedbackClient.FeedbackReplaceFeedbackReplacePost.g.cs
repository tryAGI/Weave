#nullable enable

namespace Weave
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Feedback Replace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.FeedbackReplaceRes> FeedbackReplaceFeedbackReplacePostAsync(

            global::Weave.FeedbackReplaceReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback Replace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.FeedbackReplaceRes>> FeedbackReplaceFeedbackReplacePostAsResponseAsync(

            global::Weave.FeedbackReplaceReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback Replace
        /// </summary>
        /// <param name="id">
        /// If provided by the client, this ID will be used for the feedback row instead of a server-generated one.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="weaveRef"></param>
        /// <param name="creator"></param>
        /// <param name="feedbackType"></param>
        /// <param name="payload"></param>
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
        /// <param name="spanConversationId">
        /// Conversation the feedback belongs to (from spans.conversation_id)
        /// </param>
        /// <param name="spanTraceId">
        /// Turn the feedback belongs to (from spans.trace_id)
        /// </param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="feedbackId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.FeedbackReplaceRes> FeedbackReplaceFeedbackReplacePostAsync(
            string projectId,
            string weaveRef,
            string feedbackType,
            object payload,
            string feedbackId,
            string? id = default,
            string? creator = default,
            string? annotationRef = default,
            string? runnableRef = default,
            string? callRef = default,
            string? triggerRef = default,
            string? queueId = default,
            global::System.Collections.Generic.IList<string>? scorerTags = default,
            global::System.Collections.Generic.Dictionary<string, string>? scorerTagReasons = default,
            global::System.Collections.Generic.Dictionary<string, double>? scorerTagConfidences = default,
            global::System.Collections.Generic.Dictionary<string, double>? scorerRatings = default,
            global::System.Collections.Generic.Dictionary<string, string>? scorerRatingReasons = default,
            global::System.Collections.Generic.Dictionary<string, double>? scorerRatingConfidences = default,
            string? spanAgentName = default,
            string? spanAgentVersion = default,
            string? spanStatusCode = default,
            string? spanConversationId = default,
            string? spanTraceId = default,
            string? wbUserId = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}