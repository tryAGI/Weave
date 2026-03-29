#nullable enable

namespace Weave
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Annotation Queue Add Calls<br/>
        /// Add calls to an annotation queue.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AnnotationQueueAddCallsRes> AnnotationQueueAddCallsAnnotationQueuesQueueIdItemsPostAsync(
            string queueId,

            global::Weave.AnnotationQueueAddCallsBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Annotation Queue Add Calls<br/>
        /// Add calls to an annotation queue.
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="projectId"></param>
        /// <param name="callIds"></param>
        /// <param name="displayFields">
        /// JSON paths to display to annotators
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AnnotationQueueAddCallsRes> AnnotationQueueAddCallsAnnotationQueuesQueueIdItemsPostAsync(
            string queueId,
            string projectId,
            global::System.Collections.Generic.IList<string> callIds,
            global::System.Collections.Generic.IList<string> displayFields,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}