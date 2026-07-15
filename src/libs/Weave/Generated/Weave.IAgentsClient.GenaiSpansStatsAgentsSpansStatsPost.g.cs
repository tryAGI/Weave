#nullable enable

namespace Weave
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Genai Spans Stats<br/>
        /// Query chart-ready aggregations over agent spans.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AgentSpanStatsRes> GenaiSpansStatsAgentsSpansStatsPostAsync(

            global::Weave.AgentSpanStatsReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Genai Spans Stats<br/>
        /// Query chart-ready aggregations over agent spans.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.AgentSpanStatsRes>> GenaiSpansStatsAgentsSpansStatsPostAsResponseAsync(

            global::Weave.AgentSpanStatsReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Genai Spans Stats<br/>
        /// Query chart-ready aggregations over agent spans.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="query"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="granularity"></param>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="metrics"></param>
        /// <param name="groupLimit">
        /// Default Value: 50
        /// </param>
        /// <param name="bucketBy"></param>
        /// <param name="groupFilters"></param>
        /// <param name="signalFilters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AgentSpanStatsRes> GenaiSpansStatsAgentsSpansStatsPostAsync(
            string projectId,
            global::System.DateTime start,
            global::Weave.Query? query = default,
            global::System.DateTime? end = default,
            int? granularity = default,
            string? timezone = default,
            global::System.Collections.Generic.IList<global::Weave.AgentGroupByRef>? groupBy = default,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanStatsMetricSpec>? metrics = default,
            int? groupLimit = default,
            global::Weave.BucketByVariant1? bucketBy = default,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupFilter>? groupFilters = default,
            global::Weave.AgentSignalFilter? signalFilters = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}