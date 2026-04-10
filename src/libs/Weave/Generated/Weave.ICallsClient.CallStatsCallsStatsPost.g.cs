#nullable enable

namespace Weave
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Call Stats
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallStatsRes> CallStatsCallsStatsPostAsync(

            global::Weave.CallStatsReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call Stats
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="start">
        /// Inclusive start time (UTC, ISO 8601).
        /// </param>
        /// <param name="end">
        /// Exclusive end time (UTC, ISO 8601). Defaults to now if omitted.
        /// </param>
        /// <param name="granularity">
        /// Bucket size in seconds (e.g., 3600 for 1 hour). If omitted, auto-selected based on time range. Will be adjusted if it would produce more than 10,000 buckets.
        /// </param>
        /// <param name="usageMetrics">
        /// Usage metrics (tokens, cost) to compute. Grouped by timestamp and model.
        /// </param>
        /// <param name="callMetrics">
        /// Call-level metrics (latency, counts) to compute. Grouped by timestamp only.
        /// </param>
        /// <param name="filter"></param>
        /// <param name="timezone">
        /// IANA timezone for bucket alignment (e.g., 'America/New_York')<br/>
        /// Default Value: UTC
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallStatsRes> CallStatsCallsStatsPostAsync(
            string projectId,
            global::System.DateTime start,
            global::System.DateTime? end = default,
            int? granularity = default,
            global::System.Collections.Generic.IList<global::Weave.UsageMetricSpec>? usageMetrics = default,
            global::System.Collections.Generic.IList<global::Weave.CallMetricSpec>? callMetrics = default,
            global::Weave.CallsFilter? filter = default,
            string? timezone = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}