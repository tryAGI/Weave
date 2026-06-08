
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSpanStatsMetricSpecAggregation
    {
        /// <summary>
        /// 
        /// </summary>
        Avg,
        /// <summary>
        /// 
        /// </summary>
        Count,
        /// <summary>
        /// 
        /// </summary>
        CountDistinct,
        /// <summary>
        /// 
        /// </summary>
        CountFalse,
        /// <summary>
        /// 
        /// </summary>
        CountTrue,
        /// <summary>
        /// 
        /// </summary>
        Max,
        /// <summary>
        /// 
        /// </summary>
        Min,
        /// <summary>
        /// 
        /// </summary>
        Sum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSpanStatsMetricSpecAggregationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanStatsMetricSpecAggregation value)
        {
            return value switch
            {
                AgentSpanStatsMetricSpecAggregation.Avg => "avg",
                AgentSpanStatsMetricSpecAggregation.Count => "count",
                AgentSpanStatsMetricSpecAggregation.CountDistinct => "count_distinct",
                AgentSpanStatsMetricSpecAggregation.CountFalse => "count_false",
                AgentSpanStatsMetricSpecAggregation.CountTrue => "count_true",
                AgentSpanStatsMetricSpecAggregation.Max => "max",
                AgentSpanStatsMetricSpecAggregation.Min => "min",
                AgentSpanStatsMetricSpecAggregation.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanStatsMetricSpecAggregation? ToEnum(string value)
        {
            return value switch
            {
                "avg" => AgentSpanStatsMetricSpecAggregation.Avg,
                "count" => AgentSpanStatsMetricSpecAggregation.Count,
                "count_distinct" => AgentSpanStatsMetricSpecAggregation.CountDistinct,
                "count_false" => AgentSpanStatsMetricSpecAggregation.CountFalse,
                "count_true" => AgentSpanStatsMetricSpecAggregation.CountTrue,
                "max" => AgentSpanStatsMetricSpecAggregation.Max,
                "min" => AgentSpanStatsMetricSpecAggregation.Min,
                "sum" => AgentSpanStatsMetricSpecAggregation.Sum,
                _ => null,
            };
        }
    }
}