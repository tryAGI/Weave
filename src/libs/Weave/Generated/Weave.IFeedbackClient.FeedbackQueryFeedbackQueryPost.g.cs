#nullable enable

namespace Weave
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Feedback Query<br/>
        /// Query for feedback.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.FeedbackQueryRes> FeedbackQueryFeedbackQueryPostAsync(

            global::Weave.FeedbackQueryReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback Query<br/>
        /// Query for feedback.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fields"></param>
        /// <param name="query"></param>
        /// <param name="sortBy"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.FeedbackQueryRes> FeedbackQueryFeedbackQueryPostAsync(
            string projectId,
            global::System.Collections.Generic.IList<string>? fields = default,
            global::Weave.Query? query = default,
            global::System.Collections.Generic.IList<global::Weave.SortBy>? sortBy = default,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}