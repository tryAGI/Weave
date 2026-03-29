#nullable enable

namespace Weave
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Call Start
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallStartRes> CallStartCallStartPostAsync(

            global::Weave.CallStartReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call Start
        /// </summary>
        /// <param name="start"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallStartRes> CallStartCallStartPostAsync(
            global::Weave.StartedCallSchemaForInsert start,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}