
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum LLMModelDetailsReasoningSupport
    {
        /// <summary>
        ///
        /// </summary>
        Adaptive,
        /// <summary>
        ///
        /// </summary>
        AlwaysOn,
        /// <summary>
        ///
        /// </summary>
        DefaultOff,
        /// <summary>
        ///
        /// </summary>
        DefaultOn,
        /// <summary>
        ///
        /// </summary>
        Unsupported,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMModelDetailsReasoningSupportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMModelDetailsReasoningSupport value)
        {
            return value switch
            {
                LLMModelDetailsReasoningSupport.Adaptive => "adaptive",
                LLMModelDetailsReasoningSupport.AlwaysOn => "always-on",
                LLMModelDetailsReasoningSupport.DefaultOff => "default-off",
                LLMModelDetailsReasoningSupport.DefaultOn => "default-on",
                LLMModelDetailsReasoningSupport.Unsupported => "unsupported",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMModelDetailsReasoningSupport? ToEnum(string value)
        {
            return value switch
            {
                "adaptive" => LLMModelDetailsReasoningSupport.Adaptive,
                "always-on" => LLMModelDetailsReasoningSupport.AlwaysOn,
                "default-off" => LLMModelDetailsReasoningSupport.DefaultOff,
                "default-on" => LLMModelDetailsReasoningSupport.DefaultOn,
                "unsupported" => LLMModelDetailsReasoningSupport.Unsupported,
                _ => null,
            };
        }
    }
}