
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvalResultsScorerStatsValueType2
    {
        /// <summary>
        /// 
        /// </summary>
        Binary,
        /// <summary>
        /// 
        /// </summary>
        Continuous,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalResultsScorerStatsValueType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalResultsScorerStatsValueType2 value)
        {
            return value switch
            {
                EvalResultsScorerStatsValueType2.Binary => "binary",
                EvalResultsScorerStatsValueType2.Continuous => "continuous",
                EvalResultsScorerStatsValueType2.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalResultsScorerStatsValueType2? ToEnum(string value)
        {
            return value switch
            {
                "binary" => EvalResultsScorerStatsValueType2.Binary,
                "continuous" => EvalResultsScorerStatsValueType2.Continuous,
                "text" => EvalResultsScorerStatsValueType2.Text,
                _ => null,
            };
        }
    }
}