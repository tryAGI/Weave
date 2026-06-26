
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentConversationSpanStatus
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
    public static class AgentConversationSpanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConversationSpanStatus value)
        {
            return value switch
            {
                AgentConversationSpanStatus.Error => "ERROR",
                AgentConversationSpanStatus.Ok => "OK",
                AgentConversationSpanStatus.Unset => "UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConversationSpanStatus? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => AgentConversationSpanStatus.Error,
                "OK" => AgentConversationSpanStatus.Ok,
                "UNSET" => AgentConversationSpanStatus.Unset,
                _ => null,
            };
        }
    }
}