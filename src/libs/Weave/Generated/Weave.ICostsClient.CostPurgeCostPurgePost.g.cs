#nullable enable

namespace Weave
{
    public partial interface ICostsClient
    {
        /// <summary>
        /// Cost Purge
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CostPurgeRes> CostPurgeCostPurgePostAsync(

            global::Weave.CostPurgeReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cost Purge
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CostPurgeRes> CostPurgeCostPurgePostAsync(
            string projectId,
            global::Weave.Query query,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}