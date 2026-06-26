
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentConversationSpanFeedbackFeedbackType
    {
        /// <summary>
        /// 
        /// </summary>
        WandbAgentMonitor,
        /// <summary>
        /// 
        /// </summary>
        WandbAgentUserFeedback,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentConversationSpanFeedbackFeedbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConversationSpanFeedbackFeedbackType value)
        {
            return value switch
            {
                AgentConversationSpanFeedbackFeedbackType.WandbAgentMonitor => "wandb.agent_monitor",
                AgentConversationSpanFeedbackFeedbackType.WandbAgentUserFeedback => "wandb.agent_user_feedback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConversationSpanFeedbackFeedbackType? ToEnum(string value)
        {
            return value switch
            {
                "wandb.agent_monitor" => AgentConversationSpanFeedbackFeedbackType.WandbAgentMonitor,
                "wandb.agent_user_feedback" => AgentConversationSpanFeedbackFeedbackType.WandbAgentUserFeedback,
                _ => null,
            };
        }
    }
}