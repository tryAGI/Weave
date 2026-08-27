
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum LLMModelDetailsReasoningEffort
    {
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
    public static class LLMModelDetailsReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMModelDetailsReasoningEffort value)
        {
            return value switch
            {
                LLMModelDetailsReasoningEffort.High => "high",
                LLMModelDetailsReasoningEffort.Low => "low",
                LLMModelDetailsReasoningEffort.Max => "max",
                LLMModelDetailsReasoningEffort.Medium => "medium",
                LLMModelDetailsReasoningEffort.Minimal => "minimal",
                LLMModelDetailsReasoningEffort.None => "none",
                LLMModelDetailsReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMModelDetailsReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => LLMModelDetailsReasoningEffort.High,
                "low" => LLMModelDetailsReasoningEffort.Low,
                "max" => LLMModelDetailsReasoningEffort.Max,
                "medium" => LLMModelDetailsReasoningEffort.Medium,
                "minimal" => LLMModelDetailsReasoningEffort.Minimal,
                "none" => LLMModelDetailsReasoningEffort.None,
                "xhigh" => LLMModelDetailsReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}