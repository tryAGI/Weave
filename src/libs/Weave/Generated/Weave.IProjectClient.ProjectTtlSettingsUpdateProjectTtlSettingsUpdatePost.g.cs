#nullable enable

namespace Weave
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// Project Ttl Settings Update
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ProjectTTLSettingsUpdateRes> ProjectTtlSettingsUpdateProjectTtlSettingsUpdatePostAsync(

            global::Weave.ProjectTTLSettingsUpdateReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Project Ttl Settings Update
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.ProjectTTLSettingsUpdateRes>> ProjectTtlSettingsUpdateProjectTtlSettingsUpdatePostAsResponseAsync(

            global::Weave.ProjectTTLSettingsUpdateReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Project Ttl Settings Update
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="retentionDays">
        /// None disables TTL; must be None or &gt;= 1
        /// </param>
        /// <param name="wbUserId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ProjectTTLSettingsUpdateRes> ProjectTtlSettingsUpdateProjectTtlSettingsUpdatePostAsync(
            string projectId,
            int? retentionDays = default,
            string? wbUserId = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}