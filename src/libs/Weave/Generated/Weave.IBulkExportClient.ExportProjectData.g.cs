#nullable enable

namespace Weave
{
    public partial interface IBulkExportClient
    {
        /// <summary>
        /// Start<br/>
        /// Start one project's export. Save the job ID to look up its status.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ExportStartedResponse> ExportProjectDataAsync(
            string entity,
            string project,

            global::Weave.ExportBody request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start<br/>
        /// Start one project's export. Save the job ID to look up its status.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.ExportStartedResponse>> ExportProjectDataAsResponseAsync(
            string entity,
            string project,

            global::Weave.ExportBody request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start<br/>
        /// Start one project's export. Save the job ID to look up its status.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="targets"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ExportStartedResponse> ExportProjectDataAsync(
            string entity,
            string project,
            global::System.Collections.Generic.IList<global::Weave.ExportBodyTarget> targets,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}