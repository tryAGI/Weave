
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSpanSchemaStatusCode
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
    public static class AgentSpanSchemaStatusCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanSchemaStatusCode value)
        {
            return value switch
            {
                AgentSpanSchemaStatusCode.Error => "ERROR",
                AgentSpanSchemaStatusCode.Ok => "OK",
                AgentSpanSchemaStatusCode.Unset => "UNSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanSchemaStatusCode? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => AgentSpanSchemaStatusCode.Error,
                "OK" => AgentSpanSchemaStatusCode.Ok,
                "UNSET" => AgentSpanSchemaStatusCode.Unset,
                _ => null,
            };
        }
    }
}