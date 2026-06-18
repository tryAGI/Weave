#nullable enable

namespace Weave
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Genai Search
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AgentSearchRes> GenaiSearchAgentsSearchPostAsync(

            global::Weave.AgentSearchReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Genai Search
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.AgentSearchRes>> GenaiSearchAgentsSearchPostAsResponseAsync(

            global::Weave.AgentSearchReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Genai Search
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="query"></param>
        /// <param name="traceId"></param>
        /// <param name="roles"></param>
        /// <param name="conversationId"></param>
        /// <param name="agentName"></param>
        /// <param name="providerName"></param>
        /// <param name="requestModel"></param>
        /// <param name="truncateContent">
        /// Default Value: true
        /// </param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AgentSearchRes> GenaiSearchAgentsSearchPostAsync(
            string projectId,
            string? query = default,
            string? traceId = default,
            global::System.Collections.Generic.IList<global::Weave.AgentSearchReqRolesVariant1Item>? roles = default,
            string? conversationId = default,
            string? agentName = default,
            string? providerName = default,
            string? requestModel = default,
            bool? truncateContent = default,
            global::System.DateTime? startedAfter = default,
            global::System.DateTime? startedBefore = default,
            int? limit = default,
            int? offset = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}