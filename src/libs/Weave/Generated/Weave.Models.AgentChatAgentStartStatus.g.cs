
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentChatAgentStartStatus
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
    public static class AgentChatAgentStartStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentChatAgentStartStatus value)
        {
            return value switch
            {
                AgentChatAgentStartStatus.Error => "ERROR",
                AgentChatAgentStartStatus.Ok => "OK",
                AgentChatAgentStartStatus.Unset => "UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentChatAgentStartStatus? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => AgentChatAgentStartStatus.Error,
                "OK" => AgentChatAgentStartStatus.Ok,
                "UNSET" => AgentChatAgentStartStatus.Unset,
                _ => null,
            };
        }
    }
}