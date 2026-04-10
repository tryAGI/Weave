#nullable enable

namespace Weave
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Calls Usage<br/>
        /// Compute aggregated usage for multiple root calls, with descendant rollup.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallsUsageRes> CallsUsageCallsUsagePostAsync(

            global::Weave.CallsUsageReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calls Usage<br/>
        /// Compute aggregated usage for multiple root calls, with descendant rollup.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="callIds">
        /// Root call IDs to aggregate. Each result key corresponds to one input call ID.
        /// </param>
        /// <param name="includeCosts">
        /// If true, include cost calculations in the usage.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Maximum number of calls to process across all traces. Acts as a safety limit to prevent unbounded memory usage.<br/>
        /// Default Value: 10000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallsUsageRes> CallsUsageCallsUsagePostAsync(
            string projectId,
            global::System.Collections.Generic.IList<string> callIds,
            bool? includeCosts = default,
            int? limit = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}