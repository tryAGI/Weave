
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentChatToolCallStatus2
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
    public static class AgentChatToolCallStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentChatToolCallStatus2 value)
        {
            return value switch
            {
                AgentChatToolCallStatus2.Error => "ERROR",
                AgentChatToolCallStatus2.Ok => "OK",
                AgentChatToolCallStatus2.Unset => "UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentChatToolCallStatus2? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => AgentChatToolCallStatus2.Error,
                "OK" => AgentChatToolCallStatus2.Ok,
                "UNSET" => AgentChatToolCallStatus2.Unset,
                _ => null,
            };
        }
    }
}