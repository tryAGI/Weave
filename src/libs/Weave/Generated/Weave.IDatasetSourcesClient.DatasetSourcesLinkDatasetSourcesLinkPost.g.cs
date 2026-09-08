#nullable enable

namespace Weave
{
    public partial interface IDatasetSourcesClient
    {
        /// <summary>
        /// Dataset Sources Link<br/>
        /// Link source calls/spans to dataset rows (batch, idempotent).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.DatasetSourcesLinkRes> DatasetSourcesLinkDatasetSourcesLinkPostAsync(

            global::Weave.DatasetSourcesLinkReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dataset Sources Link<br/>
        /// Link source calls/spans to dataset rows (batch, idempotent).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.DatasetSourcesLinkRes>> DatasetSourcesLinkDatasetSourcesLinkPostAsResponseAsync(

            global::Weave.DatasetSourcesLinkReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dataset Sources Link<br/>
        /// Link source calls/spans to dataset rows (batch, idempotent).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="datasetObjectId"></param>
        /// <param name="datasetDigest"></param>
        /// <param name="links"></param>
        /// <param name="includeCreatedStatus">
        /// Default Value: false
        /// </param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.DatasetSourcesLinkRes> DatasetSourcesLinkDatasetSourcesLinkPostAsync(
            string projectId,
            string datasetObjectId,
            string datasetDigest,
            global::System.Collections.Generic.IList<global::Weave.DatasetSourceLinkPayload> links,
            bool? includeCreatedStatus = default,
            string? wbUserId = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}