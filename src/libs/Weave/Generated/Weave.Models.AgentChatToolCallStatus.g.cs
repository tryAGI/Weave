
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentChatToolCallStatus
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
    public static class AgentChatToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentChatToolCallStatus value)
        {
            return value switch
            {
                AgentChatToolCallStatus.Error => "ERROR",
                AgentChatToolCallStatus.Ok => "OK",
                AgentChatToolCallStatus.Unset => "UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentChatToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => AgentChatToolCallStatus.Error,
                "OK" => AgentChatToolCallStatus.Ok,
                "UNSET" => AgentChatToolCallStatus.Unset,
                _ => null,
            };
        }
    }
}