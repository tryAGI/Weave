
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentChatAgentStartStatus2
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
    public static class AgentChatAgentStartStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentChatAgentStartStatus2 value)
        {
            return value switch
            {
                AgentChatAgentStartStatus2.Error => "ERROR",
                AgentChatAgentStartStatus2.Ok => "OK",
                AgentChatAgentStartStatus2.Unset => "UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentChatAgentStartStatus2? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => AgentChatAgentStartStatus2.Error,
                "OK" => AgentChatAgentStartStatus2.Ok,
                "UNSET" => AgentChatAgentStartStatus2.Unset,
                _ => null,
            };
        }
    }
}