
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentConversationMessagePreviewRole
    {
        /// <summary>
        /// 
        /// </summary>
        AssistantMessage,
        /// <summary>
        /// 
        /// </summary>
        UserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentConversationMessagePreviewRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConversationMessagePreviewRole value)
        {
            return value switch
            {
                AgentConversationMessagePreviewRole.AssistantMessage => "assistant_message",
                AgentConversationMessagePreviewRole.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConversationMessagePreviewRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant_message" => AgentConversationMessagePreviewRole.AssistantMessage,
                "user_message" => AgentConversationMessagePreviewRole.UserMessage,
                _ => null,
            };
        }
    }
}