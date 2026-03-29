#nullable enable

namespace Weave
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Calls Query Stats
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallsQueryStatsRes> CallsQueryStatsCallsQueryStatsPostAsync(

            global::Weave.CallsQueryStatsReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calls Query Stats
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="filter"></param>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <param name="includeTotalStorageSize">
        /// Default Value: false
        /// </param>
        /// <param name="expandColumns">
        /// Columns with refs to objects or table rows that require expansion during filtering or ordering.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.CallsQueryStatsRes> CallsQueryStatsCallsQueryStatsPostAsync(
            string projectId,
            global::Weave.CallsFilter? filter = default,
            global::Weave.Query? query = default,
            int? limit = default,
            bool? includeTotalStorageSize = default,
            global::System.Collections.Generic.IList<string>? expandColumns = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}