#nullable enable

namespace Weave
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Genai Spans Query<br/>
        /// Query agent spans, either as raw rows or grouped aggregates.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AgentSpansQueryRes> GenaiSpansQueryAgentsSpansQueryPostAsync(

            global::Weave.AgentSpansQueryReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Genai Spans Query<br/>
        /// Query agent spans, either as raw rows or grouped aggregates.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.AgentSpansQueryRes>> GenaiSpansQueryAgentsSpansQueryPostAsResponseAsync(

            global::Weave.AgentSpansQueryReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Genai Spans Query<br/>
        /// Query agent spans, either as raw rows or grouped aggregates.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="query"></param>
        /// <param name="groupBy"></param>
        /// <param name="measures"></param>
        /// <param name="groupFilters"></param>
        /// <param name="groupDistributions"></param>
        /// <param name="customAttrColumns"></param>
        /// <param name="includeDetails">
        /// Default Value: false
        /// </param>
        /// <param name="sortBy"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AgentSpansQueryRes> GenaiSpansQueryAgentsSpansQueryPostAsync(
            string projectId,
            global::Weave.Query? query = default,
            global::System.Collections.Generic.IList<global::Weave.AgentGroupByRef>? groupBy = default,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanMeasureSpec>? measures = default,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupFilter>? groupFilters = default,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupDistributionSpec>? groupDistributions = default,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanValueRef>? customAttrColumns = default,
            bool? includeDetails = default,
            global::System.Collections.Generic.IList<global::Weave.AgentSortBy>? sortBy = default,
            int? limit = default,
            int? offset = default,
            global::System.DateTime? startedAfter = default,
            global::System.DateTime? startedBefore = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}