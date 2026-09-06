
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentChatMessageStatusCode
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
    public static class AgentChatMessageStatusCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentChatMessageStatusCode value)
        {
            return value switch
            {
                AgentChatMessageStatusCode.Error => "ERROR",
                AgentChatMessageStatusCode.Ok => "OK",
                AgentChatMessageStatusCode.Unset => "UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentChatMessageStatusCode? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => AgentChatMessageStatusCode.Error,
                "OK" => AgentChatMessageStatusCode.Ok,
                "UNSET" => AgentChatMessageStatusCode.Unset,
                _ => null,
            };
        }
    }
}