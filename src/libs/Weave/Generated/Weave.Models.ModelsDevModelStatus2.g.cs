
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelsDevModelStatus2
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
    public static class ModelsDevModelStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsDevModelStatus2 value)
        {
            return value switch
            {
                ModelsDevModelStatus2.Alpha => "alpha",
                ModelsDevModelStatus2.Beta => "beta",
                ModelsDevModelStatus2.Deprecated => "deprecated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsDevModelStatus2? ToEnum(string value)
        {
            return value switch
            {
                "alpha" => ModelsDevModelStatus2.Alpha,
                "beta" => ModelsDevModelStatus2.Beta,
                "deprecated" => ModelsDevModelStatus2.Deprecated,
                _ => null,
            };
        }
    }
}