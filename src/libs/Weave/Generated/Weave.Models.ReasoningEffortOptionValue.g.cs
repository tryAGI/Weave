
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum ReasoningEffortOptionValue
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
    public static class ReasoningEffortOptionValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningEffortOptionValue value)
        {
            return value switch
            {
                ReasoningEffortOptionValue.Default => "default",
                ReasoningEffortOptionValue.High => "high",
                ReasoningEffortOptionValue.Low => "low",
                ReasoningEffortOptionValue.Max => "max",
                ReasoningEffortOptionValue.Medium => "medium",
                ReasoningEffortOptionValue.Minimal => "minimal",
                ReasoningEffortOptionValue.None => "none",
                ReasoningEffortOptionValue.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningEffortOptionValue? ToEnum(string value)
        {
            return value switch
            {
                "default" => ReasoningEffortOptionValue.Default,
                "high" => ReasoningEffortOptionValue.High,
                "low" => ReasoningEffortOptionValue.Low,
                "max" => ReasoningEffortOptionValue.Max,
                "medium" => ReasoningEffortOptionValue.Medium,
                "minimal" => ReasoningEffortOptionValue.Minimal,
                "none" => ReasoningEffortOptionValue.None,
                "xhigh" => ReasoningEffortOptionValue.Xhigh,
                _ => null,
            };
        }
    }
}