#nullable enable

namespace Weave
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Call Read
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallReadRes> CallReadCallReadPostAsync(

            global::Weave.CallReadReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call Read
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="includeCosts">
        /// Default Value: false
        /// </param>
        /// <param name="includeStorageSize">
        /// Default Value: false
        /// </param>
        /// <param name="includeTotalStorageSize">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallReadRes> CallReadCallReadPostAsync(
            string projectId,
            string id,
            bool? includeCosts = default,
            bool? includeStorageSize = default,
            bool? includeTotalStorageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}