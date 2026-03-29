#nullable enable

namespace Weave
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Call End
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallEndRes> CallEndCallEndPostAsync(

            global::Weave.CallEndReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call End
        /// </summary>
        /// <param name="end"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallEndRes> CallEndCallEndPostAsync(
            global::Weave.EndedCallSchemaForInsert end,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}