
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum ExportBodyTarget
    {
        /// <summary>
        ///
        /// </summary>
        Calls,
        /// <summary>
        ///
        /// </summary>
        Feedback,
        /// <summary>
        ///
        /// </summary>
        Objects,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportBodyTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportBodyTarget value)
        {
            return value switch
            {
                ExportBodyTarget.Calls => "calls",
                ExportBodyTarget.Feedback => "feedback",
                ExportBodyTarget.Objects => "objects",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportBodyTarget? ToEnum(string value)
        {
            return value switch
            {
                "calls" => ExportBodyTarget.Calls,
                "feedback" => ExportBodyTarget.Feedback,
                "objects" => ExportBodyTarget.Objects,
                _ => null,
            };
        }
    }
}