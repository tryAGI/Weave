
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelsDevModelStatus
    {
        /// <summary>
        ///
        /// </summary>
        Alpha,
        /// <summary>
        ///
        /// </summary>
        Beta,
        /// <summary>
        ///
        /// </summary>
        Deprecated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsDevModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsDevModelStatus value)
        {
            return value switch
            {
                ModelsDevModelStatus.Alpha => "alpha",
                ModelsDevModelStatus.Beta => "beta",
                ModelsDevModelStatus.Deprecated => "deprecated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsDevModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "alpha" => ModelsDevModelStatus.Alpha,
                "beta" => ModelsDevModelStatus.Beta,
                "deprecated" => ModelsDevModelStatus.Deprecated,
                _ => null,
            };
        }
    }
}