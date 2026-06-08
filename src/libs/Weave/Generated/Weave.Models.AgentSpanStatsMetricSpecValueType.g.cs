
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSpanStatsMetricSpecValueType
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
    public static class AgentSpanStatsMetricSpecValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanStatsMetricSpecValueType value)
        {
            return value switch
            {
                AgentSpanStatsMetricSpecValueType.Boolean => "boolean",
                AgentSpanStatsMetricSpecValueType.Datetime => "datetime",
                AgentSpanStatsMetricSpecValueType.Number => "number",
                AgentSpanStatsMetricSpecValueType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanStatsMetricSpecValueType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AgentSpanStatsMetricSpecValueType.Boolean,
                "datetime" => AgentSpanStatsMetricSpecValueType.Datetime,
                "number" => AgentSpanStatsMetricSpecValueType.Number,
                "string" => AgentSpanStatsMetricSpecValueType.String,
                _ => null,
            };
        }
    }
}