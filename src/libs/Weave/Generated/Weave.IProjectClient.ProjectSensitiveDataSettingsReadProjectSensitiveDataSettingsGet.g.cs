#nullable enable

namespace Weave
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Project Sensitive Data Settings Read<br/>
        /// Read the owning organization's sensitive-data policy for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ProjectSensitiveDataSettingsReadRes> ProjectSensitiveDataSettingsReadProjectSensitiveDataSettingsGetAsync(
            string projectId,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Project Sensitive Data Settings Read<br/>
        /// Read the owning organization's sensitive-data policy for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.ProjectSensitiveDataSettingsReadRes>> ProjectSensitiveDataSettingsReadProjectSensitiveDataSettingsGetAsResponseAsync(
            string projectId,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}