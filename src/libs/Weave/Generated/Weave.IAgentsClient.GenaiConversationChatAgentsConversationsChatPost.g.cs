#nullable enable

namespace Weave
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Genai Conversation Chat
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AgentConversationChatRes> GenaiConversationChatAgentsConversationsChatPostAsync(

            global::Weave.AgentConversationChatReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Genai Conversation Chat
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.AgentConversationChatRes>> GenaiConversationChatAgentsConversationsChatPostAsResponseAsync(

            global::Weave.AgentConversationChatReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Genai Conversation Chat
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="conversationId"></param>
        /// <param name="sortBy">
        /// Controls how turns are sorted and paginated. Only `started_at` is supported. When omitted, the endpoint selects the most recent `limit` turns and returns them in ascending `started_at` order.
        /// </param>
        /// <param name="limit">
        /// Maximum number of conversation turns to return.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Number of turns to skip in the requested sort order. When `sort_by` is omitted, results are returned in chronological order within the selected page.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="includeFeedback">
        /// Default Value: false
        /// </param>
        /// <param name="includeModelToolCalls">
        /// Include tool calls requested in model outputs, even when no execution span was recorded, and place each execution span after the model span that requested it. Requests without execution evidence have no status, duration, or result. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AgentConversationChatRes> GenaiConversationChatAgentsConversationsChatPostAsync(
            string projectId,
            string conversationId,
            global::System.Collections.Generic.IList<global::Weave.AgentSortBy>? sortBy = default,
            int? limit = default,
            int? offset = default,
            bool? includeFeedback = default,
            bool? includeModelToolCalls = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}