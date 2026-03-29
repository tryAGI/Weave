#nullable enable

namespace Weave
{
    public partial interface ICostsClient
    {
        /// <summary>
        /// Cost Create
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CostCreateRes> CostCreateCostCreatePostAsync(

            global::Weave.CostCreateReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cost Create
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="costs"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CostCreateRes> CostCreateCostCreatePostAsync(
            string projectId,
            global::System.Collections.Generic.Dictionary<string, global::Weave.CostCreateInput> costs,
            string? wbUserId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}