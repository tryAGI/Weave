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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AgentConversationChatRes> GenaiConversationChatAgentsConversationsChatPostAsync(
            string projectId,
            string conversationId,
            int? limit = default,
            int? offset = default,
            bool? includeFeedback = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}