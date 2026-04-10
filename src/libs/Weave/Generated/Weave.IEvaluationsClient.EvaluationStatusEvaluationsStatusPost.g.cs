#nullable enable

namespace Weave
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Evaluation Status
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.EvaluationStatusRes> EvaluationStatusEvaluationsStatusPostAsync(

            global::Weave.EvaluationStatusReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluation Status
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="callId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.EvaluationStatusRes> EvaluationStatusEvaluationsStatusPostAsync(
            string projectId,
            string callId,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}