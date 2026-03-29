#nullable enable

namespace Weave
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// Threads Query Stream
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ThreadsQueryStreamThreadsStreamQueryPostAsync(

            global::Weave.ThreadsQueryReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Threads Query Stream
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="filter">
        /// Filter criteria for the threads query
        /// </param>
        /// <param name="limit">
        /// Maximum number of threads to return
        /// </param>
        /// <param name="offset">
        /// Number of threads to skip
        /// </param>
        /// <param name="sortBy">
        /// Sorting criteria for the threads. Supported fields: 'thread_id', 'turn_count', 'start_time', 'last_updated', 'p50_turn_duration_ms', 'p99_turn_duration_ms'.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ThreadsQueryStreamThreadsStreamQueryPostAsync(
            string projectId,
            global::Weave.ThreadsQueryFilter? filter = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::Weave.SortBy>? sortBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}