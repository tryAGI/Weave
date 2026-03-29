#nullable enable

namespace Weave
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Feedback Purge<br/>
        /// Permanently delete feedback.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.FeedbackPurgeRes> FeedbackPurgeFeedbackPurgePostAsync(

            global::Weave.FeedbackPurgeReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback Purge<br/>
        /// Permanently delete feedback.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.FeedbackPurgeRes> FeedbackPurgeFeedbackPurgePostAsync(
            string projectId,
            global::Weave.Query query,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}