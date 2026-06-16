#nullable enable

namespace Weave
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Rescore Evaluation<br/>
        /// Rescore an existing evaluation run with different scorer(s).<br/>
        /// Applies the provided scorer(s) to the predictions from source_evaluation_run_id<br/>
        /// and returns a new evaluation_run_id. Original prediction call IDs are preserved.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.RescoreRes> RescoreEvaluationEvaluationsRescorePostAsync(

            global::Weave.RescoreReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rescore Evaluation<br/>
        /// Rescore an existing evaluation run with different scorer(s).<br/>
        /// Applies the provided scorer(s) to the predictions from source_evaluation_run_id<br/>
        /// and returns a new evaluation_run_id. Original prediction call IDs are preserved.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.RescoreRes>> RescoreEvaluationEvaluationsRescorePostAsResponseAsync(

            global::Weave.RescoreReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rescore Evaluation<br/>
        /// Rescore an existing evaluation run with different scorer(s).<br/>
        /// Applies the provided scorer(s) to the predictions from source_evaluation_run_id<br/>
        /// and returns a new evaluation_run_id. Original prediction call IDs are preserved.
        /// </summary>
        /// <param name="sourceEvaluationRunId">
        /// The evaluation run whose predictions will be rescored
        /// </param>
        /// <param name="scorerRefs">
        /// Scorer references (weave:// URIs) to apply; must be non-empty
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.RescoreRes> RescoreEvaluationEvaluationsRescorePostAsync(
            string sourceEvaluationRunId,
            global::System.Collections.Generic.IList<string> scorerRefs,
            string projectId,
            string? wbUserId = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}