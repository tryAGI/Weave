#nullable enable

namespace Weave
{
    public partial interface IRefsClient
    {
        /// <summary>
        /// Refs Read Batch
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.RefsReadBatchRes> RefsReadBatchRefsReadBatchPostAsync(

            global::Weave.RefsReadBatchReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Refs Read Batch
        /// </summary>
        /// <param name="refs"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.RefsReadBatchRes> RefsReadBatchRefsReadBatchPostAsync(
            global::System.Collections.Generic.IList<string> refs,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}