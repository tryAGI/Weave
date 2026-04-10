#nullable enable

namespace Weave
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Annotation Queues Query Stream<br/>
        /// Query annotation queues for a project (streaming NDJSON response).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AnnotationQueuesQueryStreamAnnotationQueuesQueryPostAsync(

            global::Weave.AnnotationQueuesQueryReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Annotation Queues Query Stream<br/>
        /// Query annotation queues for a project (streaming NDJSON response).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// Filter by queue name (case-insensitive partial match)
        /// </param>
        /// <param name="sortBy">
        /// Sort by multiple fields (e.g., created_at, updated_at, name)
        /// </param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AnnotationQueuesQueryStreamAnnotationQueuesQueryPostAsync(
            string projectId,
            string? name = default,
            global::System.Collections.Generic.IList<global::Weave.SortBy>? sortBy = default,
            int? limit = default,
            int? offset = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}