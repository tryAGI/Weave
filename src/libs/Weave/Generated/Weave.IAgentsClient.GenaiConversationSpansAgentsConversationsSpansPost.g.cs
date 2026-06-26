#nullable enable

namespace Weave
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Genai Conversation Spans
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AgentConversationSpansRes> GenaiConversationSpansAgentsConversationsSpansPostAsync(

            global::Weave.AgentConversationSpansReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Genai Conversation Spans
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.AgentConversationSpansRes>> GenaiConversationSpansAgentsConversationsSpansPostAsResponseAsync(

            global::Weave.AgentConversationSpansReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Genai Conversation Spans
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="conversationIds"></param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AgentConversationSpansRes> GenaiConversationSpansAgentsConversationsSpansPostAsync(
            string projectId,
            global::System.Collections.Generic.IList<string>? conversationIds = default,
            global::System.DateTime? startedAfter = default,
            global::System.DateTime? startedBefore = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}