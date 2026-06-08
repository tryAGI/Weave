#nullable enable

namespace Weave
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Genai Traces Chat
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AgentTraceChatRes> GenaiTracesChatAgentsTracesChatPostAsync(

            global::Weave.AgentTraceChatReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Genai Traces Chat
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.AgentTraceChatRes>> GenaiTracesChatAgentsTracesChatPostAsResponseAsync(

            global::Weave.AgentTraceChatReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Genai Traces Chat
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traceId"></param>
        /// <param name="includeFeedback">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AgentTraceChatRes> GenaiTracesChatAgentsTracesChatPostAsync(
            string projectId,
            string traceId,
            bool? includeFeedback = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}