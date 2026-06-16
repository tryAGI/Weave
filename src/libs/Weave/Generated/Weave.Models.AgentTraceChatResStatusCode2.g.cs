
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentTraceChatResStatusCode2
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
    public static class AgentTraceChatResStatusCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTraceChatResStatusCode2 value)
        {
            return value switch
            {
                AgentTraceChatResStatusCode2.Error => "ERROR",
                AgentTraceChatResStatusCode2.Ok => "OK",
                AgentTraceChatResStatusCode2.Unset => "UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTraceChatResStatusCode2? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => AgentTraceChatResStatusCode2.Error,
                "OK" => AgentTraceChatResStatusCode2.Ok,
                "UNSET" => AgentTraceChatResStatusCode2.Unset,
                _ => null,
            };
        }
    }
}