#nullable enable

namespace Weave
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Call Start Batch
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallCreateBatchRes> CallStartBatchCallUpsertBatchPostAsync(

            global::Weave.CallCreateBatchReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call Start Batch
        /// </summary>
        /// <param name="batch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallCreateBatchRes> CallStartBatchCallUpsertBatchPostAsync(
            global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.CallBatchStartMode, global::Weave.CallBatchEndMode>> batch,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}