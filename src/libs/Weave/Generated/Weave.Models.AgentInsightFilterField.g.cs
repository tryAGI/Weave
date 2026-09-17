
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentInsightFilterField
    {
        /// <summary>
        ///
        /// </summary>
        FailureCategory,
        /// <summary>
        ///
        /// </summary>
        FailureSeverity,
        /// <summary>
        ///
        /// </summary>
        FailureTopicId,
        /// <summary>
        ///
        /// </summary>
        IntentCategory,
        /// <summary>
        ///
        /// </summary>
        IntentSentiment,
        /// <summary>
        ///
        /// </summary>
        IntentTopicId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentInsightFilterFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentInsightFilterField value)
        {
            return value switch
            {
                AgentInsightFilterField.FailureCategory => "failure_category",
                AgentInsightFilterField.FailureSeverity => "failure_severity",
                AgentInsightFilterField.FailureTopicId => "failure_topic_id",
                AgentInsightFilterField.IntentCategory => "intent_category",
                AgentInsightFilterField.IntentSentiment => "intent_sentiment",
                AgentInsightFilterField.IntentTopicId => "intent_topic_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentInsightFilterField? ToEnum(string value)
        {
            return value switch
            {
                "failure_category" => AgentInsightFilterField.FailureCategory,
                "failure_severity" => AgentInsightFilterField.FailureSeverity,
                "failure_topic_id" => AgentInsightFilterField.FailureTopicId,
                "intent_category" => AgentInsightFilterField.IntentCategory,
                "intent_sentiment" => AgentInsightFilterField.IntentSentiment,
                "intent_topic_id" => AgentInsightFilterField.IntentTopicId,
                _ => null,
            };
        }
    }
}