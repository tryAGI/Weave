
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum ExportStatusResponseState
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportStatusResponseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportStatusResponseState value)
        {
            return value switch
            {
                ExportStatusResponseState.Failed => "failed",
                ExportStatusResponseState.InProgress => "in_progress",
                ExportStatusResponseState.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportStatusResponseState? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ExportStatusResponseState.Failed,
                "in_progress" => ExportStatusResponseState.InProgress,
                "succeeded" => ExportStatusResponseState.Succeeded,
                _ => null,
            };
        }
    }
}