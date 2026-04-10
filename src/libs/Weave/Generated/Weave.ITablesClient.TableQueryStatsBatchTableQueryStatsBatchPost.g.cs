#nullable enable

namespace Weave
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Table Query Stats Batch
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.TableQueryStatsBatchRes> TableQueryStatsBatchTableQueryStatsBatchPostAsync(

            global::Weave.TableQueryStatsBatchReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Table Query Stats Batch
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="digests">
        /// The digests of the tables to query<br/>
        /// Default Value: []
        /// </param>
        /// <param name="includeStorageSize">
        /// If true, the `storage_size_bytes` column is returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.TableQueryStatsBatchRes> TableQueryStatsBatchTableQueryStatsBatchPostAsync(
            string projectId,
            global::System.Collections.Generic.IList<string>? digests = default,
            bool? includeStorageSize = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}