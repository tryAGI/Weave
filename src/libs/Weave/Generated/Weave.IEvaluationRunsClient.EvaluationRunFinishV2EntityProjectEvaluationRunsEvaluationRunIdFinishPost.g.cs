#nullable enable

namespace Weave
{
    public partial interface IEvaluationRunsClient
    {
        /// <summary>
        /// Evaluation Run Finish<br/>
        /// Finish an evaluation run.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="evaluationRunId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.EvaluationRunFinishRes> EvaluationRunFinishV2EntityProjectEvaluationRunsEvaluationRunIdFinishPostAsync(
            string entity,
            string project,
            string evaluationRunId,

            global::Weave.EvaluationRunFinishBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluation Run Finish<br/>
        /// Finish an evaluation run.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="evaluationRunId"></param>
        /// <param name="summary">
        /// Optional summary dictionary for the evaluation run
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.EvaluationRunFinishRes> EvaluationRunFinishV2EntityProjectEvaluationRunsEvaluationRunIdFinishPostAsync(
            string entity,
            string project,
            string evaluationRunId,
            object? summary = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}