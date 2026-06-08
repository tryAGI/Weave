
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSpanStatsReqBucketByVariant1DiscriminatorType
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
    public static class AgentSpanStatsReqBucketByVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanStatsReqBucketByVariant1DiscriminatorType value)
        {
            return value switch
            {
                AgentSpanStatsReqBucketByVariant1DiscriminatorType.Number => "number",
                AgentSpanStatsReqBucketByVariant1DiscriminatorType.Time => "time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanStatsReqBucketByVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "number" => AgentSpanStatsReqBucketByVariant1DiscriminatorType.Number,
                "time" => AgentSpanStatsReqBucketByVariant1DiscriminatorType.Time,
                _ => null,
            };
        }
    }
}