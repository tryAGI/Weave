
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSpanMeasureSpecValueType2
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
    public static class AgentSpanMeasureSpecValueType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanMeasureSpecValueType2 value)
        {
            return value switch
            {
                AgentSpanMeasureSpecValueType2.Boolean => "boolean",
                AgentSpanMeasureSpecValueType2.Datetime => "datetime",
                AgentSpanMeasureSpecValueType2.Number => "number",
                AgentSpanMeasureSpecValueType2.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanMeasureSpecValueType2? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AgentSpanMeasureSpecValueType2.Boolean,
                "datetime" => AgentSpanMeasureSpecValueType2.Datetime,
                "number" => AgentSpanMeasureSpecValueType2.Number,
                "string" => AgentSpanMeasureSpecValueType2.String,
                _ => null,
            };
        }
    }
}