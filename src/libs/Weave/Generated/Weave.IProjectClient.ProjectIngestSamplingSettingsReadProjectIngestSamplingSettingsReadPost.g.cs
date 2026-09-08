#nullable enable

namespace Weave
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Project Ingest Sampling Settings Read
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ProjectIngestSamplingSettingsReadRes> ProjectIngestSamplingSettingsReadProjectIngestSamplingSettingsReadPostAsync(

            global::Weave.ProjectIngestSamplingSettingsReadReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Project Ingest Sampling Settings Read
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.ProjectIngestSamplingSettingsReadRes>> ProjectIngestSamplingSettingsReadProjectIngestSamplingSettingsReadPostAsResponseAsync(

            global::Weave.ProjectIngestSamplingSettingsReadReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Project Ingest Sampling Settings Read
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ProjectIngestSamplingSettingsReadRes> ProjectIngestSamplingSettingsReadProjectIngestSamplingSettingsReadPostAsync(
            string projectId,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}