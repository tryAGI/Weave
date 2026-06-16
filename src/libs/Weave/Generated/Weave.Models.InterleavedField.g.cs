
#nullable enable

namespace Weave
{
    /// <summary>
    /// Format identifier for interleaved reasoning.
    /// </summary>
    public enum InterleavedField
    {
        /// <summary>
        /// 
        /// </summary>
        ReasoningContent,
        /// <summary>
        /// 
        /// </summary>
        ReasoningDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InterleavedFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InterleavedField value)
        {
            return value switch
            {
                InterleavedField.ReasoningContent => "reasoning_content",
                InterleavedField.ReasoningDetails => "reasoning_details",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InterleavedField? ToEnum(string value)
        {
            return value switch
            {
                "reasoning_content" => InterleavedField.ReasoningContent,
                "reasoning_details" => InterleavedField.ReasoningDetails,
                _ => null,
            };
        }
    }
}