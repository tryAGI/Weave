#nullable enable

namespace Weave
{
    public partial interface IEvaluationRunsClient
    {
        /// <summary>
        /// Evaluation Run Delete<br/>
        /// Delete evaluation runs.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="evaluationRunIds">
        /// List of evaluation run IDs to delete
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.EvaluationRunDeleteRes> EvaluationRunDeleteV2EntityProjectEvaluationRunsDeleteAsync(
            string entity,
            string project,
            global::System.Collections.Generic.IList<string> evaluationRunIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}