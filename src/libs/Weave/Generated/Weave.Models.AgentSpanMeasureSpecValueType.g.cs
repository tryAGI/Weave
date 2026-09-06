
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSpanMeasureSpecValueType
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
        /// <summary>
        ///
        /// </summary>
        Datetime,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSpanMeasureSpecValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanMeasureSpecValueType value)
        {
            return value switch
            {
                AgentSpanMeasureSpecValueType.Boolean => "boolean",
                AgentSpanMeasureSpecValueType.Datetime => "datetime",
                AgentSpanMeasureSpecValueType.Number => "number",
                AgentSpanMeasureSpecValueType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanMeasureSpecValueType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AgentSpanMeasureSpecValueType.Boolean,
                "datetime" => AgentSpanMeasureSpecValueType.Datetime,
                "number" => AgentSpanMeasureSpecValueType.Number,
                "string" => AgentSpanMeasureSpecValueType.String,
                _ => null,
            };
        }
    }
}