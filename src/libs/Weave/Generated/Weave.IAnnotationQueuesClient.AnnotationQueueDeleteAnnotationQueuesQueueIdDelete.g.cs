#nullable enable

namespace Weave
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Annotation Queue Delete<br/>
        /// Delete (soft-delete) an annotation queue.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AnnotationQueueDeleteRes> AnnotationQueueDeleteAnnotationQueuesQueueIdDeleteAsync(
            string queueId,
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}