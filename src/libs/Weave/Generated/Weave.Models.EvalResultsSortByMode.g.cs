
#nullable enable

namespace Weave
{
    /// <summary>
    /// When 'value', sort by the field value for the specified evaluation. When 'difference', sort by max-min spread of the field across all evaluations (evaluation_call_id is ignored).<br/>
    /// Default Value: value
    /// </summary>
    public enum EvalResultsSortByMode
    {
        /// <summary>
        /// 
        /// </summary>
        Difference,
        /// <summary>
        /// 
        /// </summary>
        Value,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalResultsSortByModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalResultsSortByMode value)
        {
            return value switch
            {
                EvalResultsSortByMode.Difference => "difference",
                EvalResultsSortByMode.Value => "value",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalResultsSortByMode? ToEnum(string value)
        {
            return value switch
            {
                "difference" => EvalResultsSortByMode.Difference,
                "value" => EvalResultsSortByMode.Value,
                _ => null,
            };
        }
    }
}