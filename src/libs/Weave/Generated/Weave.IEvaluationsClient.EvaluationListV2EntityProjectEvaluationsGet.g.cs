#nullable enable

namespace Weave
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Evaluation List<br/>
        /// List evaluation objects.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="limit">
        /// Maximum number of evaluations to return
        /// </param>
        /// <param name="offset">
        /// Number of evaluations to skip
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Weave.EvaluationReadRes> EvaluationListV2EntityProjectEvaluationsGetAsync(
            string entity,
            string project,
            int? limit = default,
            int? offset = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}