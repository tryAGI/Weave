
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentChatAssistantMessageStatus
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Ok,
        /// <summary>
        ///
        /// </summary>
        Unset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentChatAssistantMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentChatAssistantMessageStatus value)
        {
            return value switch
            {
                AgentChatAssistantMessageStatus.Error => "ERROR",
                AgentChatAssistantMessageStatus.Ok => "OK",
                AgentChatAssistantMessageStatus.Unset => "UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentChatAssistantMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => AgentChatAssistantMessageStatus.Error,
                "OK" => AgentChatAssistantMessageStatus.Ok,
                "UNSET" => AgentChatAssistantMessageStatus.Unset,
                _ => null,
            };
        }
    }
}