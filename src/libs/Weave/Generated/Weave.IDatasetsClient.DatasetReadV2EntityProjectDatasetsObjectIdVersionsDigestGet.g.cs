#nullable enable

namespace Weave
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Dataset Read<br/>
        /// Get a dataset object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="objectId"></param>
        /// <param name="digest"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.DatasetReadRes> DatasetReadV2EntityProjectDatasetsObjectIdVersionsDigestGetAsync(
            string entity,
            string project,
            string objectId,
            string digest,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}