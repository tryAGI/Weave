#nullable enable

namespace Weave
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Feedback Aggregate<br/>
        /// Aggregate typed scorer feedback (tags, ratings) over time buckets.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.FeedbackAggregateRes> FeedbackAggregateFeedbackAggregatePostAsync(

            global::Weave.FeedbackAggregateReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback Aggregate<br/>
        /// Aggregate typed scorer feedback (tags, ratings) over time buckets.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.FeedbackAggregateRes>> FeedbackAggregateFeedbackAggregatePostAsResponseAsync(

            global::Weave.FeedbackAggregateReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Feedback Aggregate<br/>
        /// Aggregate typed scorer feedback (tags, ratings) over time buckets.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="afterMs">
        /// Inclusive lower bound on created_at (milliseconds since epoch).
        /// </param>
        /// <param name="beforeMs">
        /// Exclusive upper bound on created_at (milliseconds since epoch).
        /// </param>
        /// <param name="timeBucketSeconds">
        /// Time bucket size in seconds, e.g. 3600 for 1h buckets
        /// </param>
        /// <param name="feedbackTypes">
        /// Filter on feedback_type by prefix
        /// </param>
        /// <param name="tags">
        /// Filter to feedback that includes any of the given tags
        /// </param>
        /// <param name="ratingMin">
        /// Include only rows with a rating &gt;= this value
        /// </param>
        /// <param name="ratingMax">
        /// Include only rows with a rating &lt;= this value
        /// </param>
        /// <param name="monitorIds">
        /// Filter to these monitor ids (exact match; suffix with '*' for prefix match).
        /// </param>
        /// <param name="scorerIds">
        /// Filter to these scorer ids (exact match; suffix with '*' for prefix match).
        /// </param>
        /// <param name="spanAgentNames">
        /// Filter to feedback whose span_agent_name matches any of these (exact).
        /// </param>
        /// <param name="spanTypes">
        /// Filter by span type (turn vs conversation).
        /// </param>
        /// <param name="groupBy">
        /// Allowed: ['scorer_id', 'span_agent_name', 'span_agent_version', 'span_status_code'].
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.FeedbackAggregateRes> FeedbackAggregateFeedbackAggregatePostAsync(
            string projectId,
            long afterMs,
            long beforeMs,
            int? timeBucketSeconds = default,
            global::System.Collections.Generic.IList<string>? feedbackTypes = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            double? ratingMin = default,
            double? ratingMax = default,
            global::System.Collections.Generic.IList<string>? monitorIds = default,
            global::System.Collections.Generic.IList<string>? scorerIds = default,
            global::System.Collections.Generic.IList<string>? spanAgentNames = default,
            global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateReqSpanType>? spanTypes = default,
            global::System.Collections.Generic.IList<global::Weave.FeedbackAggregateReqGroupByItem>? groupBy = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}