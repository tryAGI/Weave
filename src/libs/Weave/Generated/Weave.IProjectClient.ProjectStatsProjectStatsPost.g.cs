#nullable enable

namespace Weave
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Project Stats
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ProjectStatsRes> ProjectStatsProjectStatsPostAsync(

            global::Weave.ProjectStatsReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Project Stats
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.ProjectStatsRes>> ProjectStatsProjectStatsPostAsResponseAsync(

            global::Weave.ProjectStatsReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Project Stats
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="includeTraceStorageSize">
        /// Default Value: true
        /// </param>
        /// <param name="includeObjectStorageSize">
        /// Default Value: true
        /// </param>
        /// <param name="includeTableStorageSize">
        /// Default Value: true
        /// </param>
        /// <param name="includeFileStorageSize">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ProjectStatsRes> ProjectStatsProjectStatsPostAsync(
            string projectId,
            bool? includeTraceStorageSize = default,
            bool? includeObjectStorageSize = default,
            bool? includeTableStorageSize = default,
            bool? includeFileStorageSize = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}