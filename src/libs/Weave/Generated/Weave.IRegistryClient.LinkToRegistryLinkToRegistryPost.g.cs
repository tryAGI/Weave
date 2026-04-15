#nullable enable

namespace Weave
{
    public partial interface IRegistryClient
    {
        /// <summary>
        /// Link To Registry
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CreateAndLinkWeaveAssetRes> LinkToRegistryLinkToRegistryPostAsync(

            global::Weave.CreateAndLinkPayload request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Link To Registry
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="target"></param>
        /// <param name="aliases">
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CreateAndLinkWeaveAssetRes> LinkToRegistryLinkToRegistryPostAsync(
            string @ref,
            global::Weave.CreateAndLinkTarget target,
            global::System.Collections.Generic.IList<string>? aliases = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}