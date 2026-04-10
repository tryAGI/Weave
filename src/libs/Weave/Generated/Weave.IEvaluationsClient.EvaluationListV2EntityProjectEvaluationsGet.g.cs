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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> EvaluationListV2EntityProjectEvaluationsGetAsync(
            string entity,
            string project,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}