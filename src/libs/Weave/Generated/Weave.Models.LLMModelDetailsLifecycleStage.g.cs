
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMModelDetailsLifecycleStage
    {
        /// <summary>
        /// 
        /// </summary>
        Deprecated,
        /// <summary>
        /// 
        /// </summary>
        Experimental,
        /// <summary>
        /// 
        /// </summary>
        GeneralAvailability,
        /// <summary>
        /// 
        /// </summary>
        Retired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMModelDetailsLifecycleStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMModelDetailsLifecycleStage value)
        {
            return value switch
            {
                LLMModelDetailsLifecycleStage.Deprecated => "deprecated",
                LLMModelDetailsLifecycleStage.Experimental => "experimental",
                LLMModelDetailsLifecycleStage.GeneralAvailability => "general-availability",
                LLMModelDetailsLifecycleStage.Retired => "retired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMModelDetailsLifecycleStage? ToEnum(string value)
        {
            return value switch
            {
                "deprecated" => LLMModelDetailsLifecycleStage.Deprecated,
                "experimental" => LLMModelDetailsLifecycleStage.Experimental,
                "general-availability" => LLMModelDetailsLifecycleStage.GeneralAvailability,
                "retired" => LLMModelDetailsLifecycleStage.Retired,
                _ => null,
            };
        }
    }
}