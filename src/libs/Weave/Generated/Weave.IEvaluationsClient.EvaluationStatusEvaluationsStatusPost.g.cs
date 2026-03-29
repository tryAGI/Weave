#nullable enable

namespace Weave
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Evaluation Status
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.EvaluationStatusRes> EvaluationStatusEvaluationsStatusPostAsync(

            global::Weave.EvaluationStatusReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluation Status
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="callId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.EvaluationStatusRes> EvaluationStatusEvaluationsStatusPostAsync(
            string projectId,
            string callId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}