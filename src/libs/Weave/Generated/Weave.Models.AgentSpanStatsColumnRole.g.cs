
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSpanStatsColumnRole
    {
        /// <summary>
        /// 
        /// </summary>
        Bucket,
        /// <summary>
        /// 
        /// </summary>
        Group,
        /// <summary>
        /// 
        /// </summary>
        Metric,
        /// <summary>
        /// 
        /// </summary>
        Time,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSpanStatsColumnRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanStatsColumnRole value)
        {
            return value switch
            {
                AgentSpanStatsColumnRole.Bucket => "bucket",
                AgentSpanStatsColumnRole.Group => "group",
                AgentSpanStatsColumnRole.Metric => "metric",
                AgentSpanStatsColumnRole.Time => "time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanStatsColumnRole? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => AgentSpanStatsColumnRole.Bucket,
                "group" => AgentSpanStatsColumnRole.Group,
                "metric" => AgentSpanStatsColumnRole.Metric,
                "time" => AgentSpanStatsColumnRole.Time,
                _ => null,
            };
        }
    }
}