
#nullable enable

namespace Weave
{
    /// <summary>
    /// How to combine filters across evaluations: 'and' (Match All - row must match in ALL evals) or 'or' (Match Any - row must match in ANY eval). Defaults to 'or' (Match Any).<br/>
    /// Default Value: or
    /// </summary>
    public enum EvalResultsQueryBodyFilterLogicOperator
    {
        /// <summary>
        /// 'and' (Match All - row must match in ALL evals) or 'or' (Match Any - row must match in ANY eval). Defaults to 'or' (Match Any).
        /// </summary>
        And,
        /// <summary>
        /// 'and' (Match All - row must match in ALL evals) or 'or' (Match Any - row must match in ANY eval). Defaults to 'or' (Match Any).
        /// </summary>
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalResultsQueryBodyFilterLogicOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalResultsQueryBodyFilterLogicOperator value)
        {
            return value switch
            {
                EvalResultsQueryBodyFilterLogicOperator.And => "and",
                EvalResultsQueryBodyFilterLogicOperator.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalResultsQueryBodyFilterLogicOperator? ToEnum(string value)
        {
            return value switch
            {
                "and" => EvalResultsQueryBodyFilterLogicOperator.And,
                "or" => EvalResultsQueryBodyFilterLogicOperator.Or,
                _ => null,
            };
        }
    }
}