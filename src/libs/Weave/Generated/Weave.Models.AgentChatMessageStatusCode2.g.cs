
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentChatMessageStatusCode2
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
    public static class AgentChatMessageStatusCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentChatMessageStatusCode2 value)
        {
            return value switch
            {
                AgentChatMessageStatusCode2.Error => "ERROR",
                AgentChatMessageStatusCode2.Ok => "OK",
                AgentChatMessageStatusCode2.Unset => "UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentChatMessageStatusCode2? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => AgentChatMessageStatusCode2.Error,
                "OK" => AgentChatMessageStatusCode2.Ok,
                "UNSET" => AgentChatMessageStatusCode2.Unset,
                _ => null,
            };
        }
    }
}