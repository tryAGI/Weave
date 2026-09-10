
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum SensitiveDataPolicy
    {
        /// <summary>
        ///
        /// </summary>
        Off,
        /// <summary>
        ///
        /// </summary>
        PiiV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SensitiveDataPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SensitiveDataPolicy value)
        {
            return value switch
            {
                SensitiveDataPolicy.Off => "off",
                SensitiveDataPolicy.PiiV1 => "pii-v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SensitiveDataPolicy? ToEnum(string value)
        {
            return value switch
            {
                "off" => SensitiveDataPolicy.Off,
                "pii-v1" => SensitiveDataPolicy.PiiV1,
                _ => null,
            };
        }
    }
}