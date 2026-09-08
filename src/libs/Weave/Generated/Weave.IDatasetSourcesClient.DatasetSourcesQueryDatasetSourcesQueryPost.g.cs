#nullable enable

namespace Weave
{
    public partial interface IDatasetSourcesClient
    {
        /// <summary>
        /// Dataset Sources Query<br/>
        /// Forward provenance lookup: dataset (+ optional row digests) -&gt; sources.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.DatasetSourcesQueryRes> DatasetSourcesQueryDatasetSourcesQueryPostAsync(

            global::Weave.DatasetSourcesQueryReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dataset Sources Query<br/>
        /// Forward provenance lookup: dataset (+ optional row digests) -&gt; sources.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.DatasetSourcesQueryRes>> DatasetSourcesQueryDatasetSourcesQueryPostAsResponseAsync(

            global::Weave.DatasetSourcesQueryReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dataset Sources Query<br/>
        /// Forward provenance lookup: dataset (+ optional row digests) -&gt; sources.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="datasetObjectId"></param>
        /// <param name="rowDigests"></param>
        /// <param name="sourceKinds"></param>
        /// <param name="includeDeleted">
        /// Default Value: false
        /// </param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.DatasetSourcesQueryRes> DatasetSourcesQueryDatasetSourcesQueryPostAsync(
            string projectId,
            string datasetObjectId,
            global::System.Collections.Generic.IList<string>? rowDigests = default,
            global::System.Collections.Generic.IList<global::Weave.SourceKind>? sourceKinds = default,
            bool? includeDeleted = default,
            int? limit = default,
            int? offset = default,
            string? wbUserId = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}