
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMModelDetailsAvailableInItem
    {
        /// <summary>
        /// 
        /// </summary>
        CwProd,
        /// <summary>
        /// 
        /// </summary>
        CwQa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMModelDetailsAvailableInItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMModelDetailsAvailableInItem value)
        {
            return value switch
            {
                LLMModelDetailsAvailableInItem.CwProd => "cw-prod",
                LLMModelDetailsAvailableInItem.CwQa => "cw-qa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMModelDetailsAvailableInItem? ToEnum(string value)
        {
            return value switch
            {
                "cw-prod" => LLMModelDetailsAvailableInItem.CwProd,
                "cw-qa" => LLMModelDetailsAvailableInItem.CwQa,
                _ => null,
            };
        }
    }
}