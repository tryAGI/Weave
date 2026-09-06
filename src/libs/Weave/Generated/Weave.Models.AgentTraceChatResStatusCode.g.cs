
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentTraceChatResStatusCode
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
    public static class AgentTraceChatResStatusCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTraceChatResStatusCode value)
        {
            return value switch
            {
                AgentTraceChatResStatusCode.Error => "ERROR",
                AgentTraceChatResStatusCode.Ok => "OK",
                AgentTraceChatResStatusCode.Unset => "UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTraceChatResStatusCode? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => AgentTraceChatResStatusCode.Error,
                "OK" => AgentTraceChatResStatusCode.Ok,
                "UNSET" => AgentTraceChatResStatusCode.Unset,
                _ => null,
            };
        }
    }
}