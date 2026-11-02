#nullable enable

namespace Weave
{
    public partial interface IBulkExportClient
    {
        /// <summary>
        /// Get Status<br/>
        /// Read a known export job. Partial output is never returned.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ExportStatusResponse> GetProjectExportAsync(
            string entity,
            string project,
            global::System.Guid jobId,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Status<br/>
        /// Read a known export job. Partial output is never returned.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.ExportStatusResponse>> GetProjectExportAsResponseAsync(
            string entity,
            string project,
            global::System.Guid jobId,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}