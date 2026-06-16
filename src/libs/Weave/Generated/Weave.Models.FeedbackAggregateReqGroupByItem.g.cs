
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackAggregateReqGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        ScorerId,
        /// <summary>
        /// 
        /// </summary>
        SpanAgentName,
        /// <summary>
        /// 
        /// </summary>
        SpanAgentVersion,
        /// <summary>
        /// 
        /// </summary>
        SpanStatusCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackAggregateReqGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackAggregateReqGroupByItem value)
        {
            return value switch
            {
                FeedbackAggregateReqGroupByItem.ScorerId => "scorer_id",
                FeedbackAggregateReqGroupByItem.SpanAgentName => "span_agent_name",
                FeedbackAggregateReqGroupByItem.SpanAgentVersion => "span_agent_version",
                FeedbackAggregateReqGroupByItem.SpanStatusCode => "span_status_code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackAggregateReqGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "scorer_id" => FeedbackAggregateReqGroupByItem.ScorerId,
                "span_agent_name" => FeedbackAggregateReqGroupByItem.SpanAgentName,
                "span_agent_version" => FeedbackAggregateReqGroupByItem.SpanAgentVersion,
                "span_status_code" => FeedbackAggregateReqGroupByItem.SpanStatusCode,
                _ => null,
            };
        }
    }
}