#nullable enable

namespace Weave
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Annotation Queue Update<br/>
        /// Update an annotation queue's metadata (name, description, scorer_refs).
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AnnotationQueueUpdateRes> AnnotationQueueUpdateAnnotationQueuesQueueIdPutAsync(
            string queueId,

            global::Weave.AnnotationQueueUpdateBody request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Annotation Queue Update<br/>
        /// Update an annotation queue's metadata (name, description, scorer_refs).
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="scorerRefs"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AnnotationQueueUpdateRes> AnnotationQueueUpdateAnnotationQueuesQueueIdPutAsync(
            string queueId,
            string projectId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? scorerRefs = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}