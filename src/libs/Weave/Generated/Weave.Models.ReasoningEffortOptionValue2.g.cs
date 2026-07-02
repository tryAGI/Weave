
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReasoningEffortOptionValue2
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Max,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningEffortOptionValue2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningEffortOptionValue2 value)
        {
            return value switch
            {
                ReasoningEffortOptionValue2.Default => "default",
                ReasoningEffortOptionValue2.High => "high",
                ReasoningEffortOptionValue2.Low => "low",
                ReasoningEffortOptionValue2.Max => "max",
                ReasoningEffortOptionValue2.Medium => "medium",
                ReasoningEffortOptionValue2.Minimal => "minimal",
                ReasoningEffortOptionValue2.None => "none",
                ReasoningEffortOptionValue2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningEffortOptionValue2? ToEnum(string value)
        {
            return value switch
            {
                "default" => ReasoningEffortOptionValue2.Default,
                "high" => ReasoningEffortOptionValue2.High,
                "low" => ReasoningEffortOptionValue2.Low,
                "max" => ReasoningEffortOptionValue2.Max,
                "medium" => ReasoningEffortOptionValue2.Medium,
                "minimal" => ReasoningEffortOptionValue2.Minimal,
                "none" => ReasoningEffortOptionValue2.None,
                "xhigh" => ReasoningEffortOptionValue2.Xhigh,
                _ => null,
            };
        }
    }
}