
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSpanMeasureSpecAggregation
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
    public static class AgentSpanMeasureSpecAggregationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanMeasureSpecAggregation value)
        {
            return value switch
            {
                AgentSpanMeasureSpecAggregation.Avg => "avg",
                AgentSpanMeasureSpecAggregation.Count => "count",
                AgentSpanMeasureSpecAggregation.CountDistinct => "count_distinct",
                AgentSpanMeasureSpecAggregation.CountFalse => "count_false",
                AgentSpanMeasureSpecAggregation.CountTrue => "count_true",
                AgentSpanMeasureSpecAggregation.Max => "max",
                AgentSpanMeasureSpecAggregation.Min => "min",
                AgentSpanMeasureSpecAggregation.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanMeasureSpecAggregation? ToEnum(string value)
        {
            return value switch
            {
                "avg" => AgentSpanMeasureSpecAggregation.Avg,
                "count" => AgentSpanMeasureSpecAggregation.Count,
                "count_distinct" => AgentSpanMeasureSpecAggregation.CountDistinct,
                "count_false" => AgentSpanMeasureSpecAggregation.CountFalse,
                "count_true" => AgentSpanMeasureSpecAggregation.CountTrue,
                "max" => AgentSpanMeasureSpecAggregation.Max,
                "min" => AgentSpanMeasureSpecAggregation.Min,
                "sum" => AgentSpanMeasureSpecAggregation.Sum,
                _ => null,
            };
        }
    }
}