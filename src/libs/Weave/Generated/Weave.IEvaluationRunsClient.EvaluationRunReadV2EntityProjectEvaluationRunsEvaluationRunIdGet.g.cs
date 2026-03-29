#nullable enable

namespace Weave
{
    public partial interface IEvaluationRunsClient
    {
        /// <summary>
        /// Evaluation Run Read<br/>
        /// Read an evaluation run.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="evaluationRunId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.EvaluationRunReadRes> EvaluationRunReadV2EntityProjectEvaluationRunsEvaluationRunIdGetAsync(
            string entity,
            string project,
            string evaluationRunId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}