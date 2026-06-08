
#nullable enable

namespace Weave
{
    /// <summary>
    /// Default Value: time
    /// </summary>
    public enum AgentSpanStatsResBucketType
    {
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Time,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSpanStatsResBucketTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanStatsResBucketType value)
        {
            return value switch
            {
                AgentSpanStatsResBucketType.Number => "number",
                AgentSpanStatsResBucketType.Time => "time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanStatsResBucketType? ToEnum(string value)
        {
            return value switch
            {
                "number" => AgentSpanStatsResBucketType.Number,
                "time" => AgentSpanStatsResBucketType.Time,
                _ => null,
            };
        }
    }
}