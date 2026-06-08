
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentChatAssistantMessageStatus2
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
    public static class AgentChatAssistantMessageStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentChatAssistantMessageStatus2 value)
        {
            return value switch
            {
                AgentChatAssistantMessageStatus2.Error => "ERROR",
                AgentChatAssistantMessageStatus2.Ok => "OK",
                AgentChatAssistantMessageStatus2.Unset => "UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentChatAssistantMessageStatus2? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => AgentChatAssistantMessageStatus2.Error,
                "OK" => AgentChatAssistantMessageStatus2.Ok,
                "UNSET" => AgentChatAssistantMessageStatus2.Unset,
                _ => null,
            };
        }
    }
}