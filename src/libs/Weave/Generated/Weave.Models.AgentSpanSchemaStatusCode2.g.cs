
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSpanSchemaStatusCode2
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
    public static class AgentSpanSchemaStatusCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanSchemaStatusCode2 value)
        {
            return value switch
            {
                AgentSpanSchemaStatusCode2.Error => "ERROR",
                AgentSpanSchemaStatusCode2.Ok => "OK",
                AgentSpanSchemaStatusCode2.Unset => "UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanSchemaStatusCode2? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => AgentSpanSchemaStatusCode2.Error,
                "OK" => AgentSpanSchemaStatusCode2.Ok,
                "UNSET" => AgentSpanSchemaStatusCode2.Unset,
                _ => null,
            };
        }
    }
}