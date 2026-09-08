#nullable enable

namespace Weave
{
    public partial interface IDatasetSourcesClient
    {
        /// <summary>
        /// Source Datasets Query<br/>
        /// Reverse provenance lookup: sources -&gt; datasets they appear in.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.SourceDatasetsQueryRes> SourceDatasetsQueryDatasetSourcesSourceDatasetsQueryPostAsync(

            global::Weave.SourceDatasetsQueryReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Source Datasets Query<br/>
        /// Reverse provenance lookup: sources -&gt; datasets they appear in.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.SourceDatasetsQueryRes>> SourceDatasetsQueryDatasetSourcesSourceDatasetsQueryPostAsResponseAsync(

            global::Weave.SourceDatasetsQueryReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Source Datasets Query<br/>
        /// Reverse provenance lookup: sources -&gt; datasets they appear in.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="sources"></param>
        /// <param name="includeDeleted">
        /// Default Value: false
        /// </param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.SourceDatasetsQueryRes> SourceDatasetsQueryDatasetSourcesSourceDatasetsQueryPostAsync(
            string projectId,
            global::System.Collections.Generic.IList<global::Weave.SourceRef> sources,
            bool? includeDeleted = default,
            string? wbUserId = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}