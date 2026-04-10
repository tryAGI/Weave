#nullable enable

namespace Weave
{
    public partial interface IScoresClient
    {
        /// <summary>
        /// Score List<br/>
        /// List scores.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="evaluationRunId">
        /// Filter by evaluation run ID
        /// </param>
        /// <param name="limit">
        /// Maximum number of scores to return
        /// </param>
        /// <param name="offset">
        /// Number of scores to skip
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Weave.ScoreReadRes> ScoreListV2EntityProjectScoresGetAsync(
            string entity,
            string project,
            string? evaluationRunId = default,
            int? limit = default,
            int? offset = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}