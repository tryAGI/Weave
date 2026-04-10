#nullable enable

namespace Weave
{
    public partial interface IScorersClient
    {
        /// <summary>
        /// Scorer Delete<br/>
        /// Delete a scorer object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="objectId"></param>
        /// <param name="digests">
        /// List of digests to delete. If not provided, all digests for the scorer will be deleted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ScorerDeleteRes> ScorerDeleteV2EntityProjectScorersObjectIdDeleteAsync(
            string entity,
            string project,
            string objectId,
            global::System.Collections.Generic.IList<string>? digests = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}