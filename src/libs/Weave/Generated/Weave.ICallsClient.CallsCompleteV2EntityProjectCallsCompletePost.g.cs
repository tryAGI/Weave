#nullable enable

namespace Weave
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Calls Complete<br/>
        /// Upsert a batch of completed calls directly to the calls_complete table.<br/>
        /// Each call in the batch contains both start and end information.<br/>
        /// This endpoint is used when calls are buffered client-side and sent as complete records.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallsUpsertCompleteRes> CallsCompleteV2EntityProjectCallsCompletePostAsync(
            string entity,
            string project,

            global::Weave.CallsUpsertCompleteReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calls Complete<br/>
        /// Upsert a batch of completed calls directly to the calls_complete table.<br/>
        /// Each call in the batch contains both start and end information.<br/>
        /// This endpoint is used when calls are buffered client-side and sent as complete records.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.CallsUpsertCompleteRes>> CallsCompleteV2EntityProjectCallsCompletePostAsResponseAsync(
            string entity,
            string project,

            global::Weave.CallsUpsertCompleteReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calls Complete<br/>
        /// Upsert a batch of completed calls directly to the calls_complete table.<br/>
        /// Each call in the batch contains both start and end information.<br/>
        /// This endpoint is used when calls are buffered client-side and sent as complete records.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="batch"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallsUpsertCompleteRes> CallsCompleteV2EntityProjectCallsCompletePostAsync(
            string entity,
            string project,
            global::System.Collections.Generic.IList<global::Weave.CompletedCallSchemaForInsert> batch,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}