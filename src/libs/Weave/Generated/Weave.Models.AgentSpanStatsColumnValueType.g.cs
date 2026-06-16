
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSpanStatsColumnValueType
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
    public static class AgentSpanStatsColumnValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanStatsColumnValueType value)
        {
            return value switch
            {
                AgentSpanStatsColumnValueType.Boolean => "boolean",
                AgentSpanStatsColumnValueType.Datetime => "datetime",
                AgentSpanStatsColumnValueType.Number => "number",
                AgentSpanStatsColumnValueType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanStatsColumnValueType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AgentSpanStatsColumnValueType.Boolean,
                "datetime" => AgentSpanStatsColumnValueType.Datetime,
                "number" => AgentSpanStatsColumnValueType.Number,
                "string" => AgentSpanStatsColumnValueType.String,
                _ => null,
            };
        }
    }
}