#nullable enable

namespace Weave
{
    public partial interface ICustomRuntimesClient
    {
        /// <summary>
        /// Custom Runtime Apply<br/>
        /// Create or replace a custom runtime configuration.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="runtimeName">
        /// Stable name of the custom runtime to create or replace
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CustomRuntimeApplyRes> CustomRuntimeApplyV2EntityProjectRuntimesRuntimeNamePutAsync(
            string entity,
            string project,
            string runtimeName,

            global::Weave.CustomRuntimeApplyBody request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Custom Runtime Apply<br/>
        /// Create or replace a custom runtime configuration.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="runtimeName">
        /// Stable name of the custom runtime to create or replace
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.CustomRuntimeApplyRes>> CustomRuntimeApplyV2EntityProjectRuntimesRuntimeNamePutAsResponseAsync(
            string entity,
            string project,
            string runtimeName,

            global::Weave.CustomRuntimeApplyBody request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Custom Runtime Apply<br/>
        /// Create or replace a custom runtime configuration.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="runtimeName">
        /// Stable name of the custom runtime to create or replace
        /// </param>
        /// <param name="baseUrl">
        /// Public OpenAI-compatible endpoint base URL
        /// </param>
        /// <param name="apiKeySecret">
        /// Team secret name used as the endpoint API key; never the secret value
        /// </param>
        /// <param name="headers">
        /// Literal headers forwarded to the endpoint
        /// </param>
        /// <param name="runtimeIds">
        /// Complete desired list of IDs exposed by the endpoint
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CustomRuntimeApplyRes> CustomRuntimeApplyV2EntityProjectRuntimesRuntimeNamePutAsync(
            string entity,
            string project,
            string runtimeName,
            string baseUrl,
            global::System.Collections.Generic.IList<global::Weave.CustomRuntimeID> runtimeIds,
            string? apiKeySecret = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}