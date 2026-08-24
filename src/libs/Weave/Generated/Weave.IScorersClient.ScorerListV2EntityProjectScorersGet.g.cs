#nullable enable

namespace Weave
{
    public partial interface IScorersClient
    {
        /// <summary>
        /// Scorer List<br/>
        /// List scorer objects.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="limit">
        /// Maximum number of scorers to return
        /// </param>
        /// <param name="offset">
        /// Number of scorers to skip
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Weave.ScorerReadRes> ScorerListV2EntityProjectScorersGetAsync(
            string entity,
            string project,
            int? limit = default,
            int? offset = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}