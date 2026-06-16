
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackAggregateReqSpanType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentConversation,
        /// <summary>
        /// 
        /// </summary>
        AgentTurn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackAggregateReqSpanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackAggregateReqSpanType value)
        {
            return value switch
            {
                FeedbackAggregateReqSpanType.AgentConversation => "agent_conversation",
                FeedbackAggregateReqSpanType.AgentTurn => "agent_turn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackAggregateReqSpanType? ToEnum(string value)
        {
            return value switch
            {
                "agent_conversation" => FeedbackAggregateReqSpanType.AgentConversation,
                "agent_turn" => FeedbackAggregateReqSpanType.AgentTurn,
                _ => null,
            };
        }
    }
}