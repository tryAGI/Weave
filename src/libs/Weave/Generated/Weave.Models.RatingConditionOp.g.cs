
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum RatingConditionOp
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RatingConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RatingConditionOp value)
        {
            return value switch
            {
                RatingConditionOp.Eq => "eq",
                RatingConditionOp.Gt => "gt",
                RatingConditionOp.Gte => "gte",
                RatingConditionOp.Lt => "lt",
                RatingConditionOp.Lte => "lte",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RatingConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => RatingConditionOp.Eq,
                "gt" => RatingConditionOp.Gt,
                "gte" => RatingConditionOp.Gte,
                "lt" => RatingConditionOp.Lt,
                "lte" => RatingConditionOp.Lte,
                _ => null,
            };
        }
    }
}