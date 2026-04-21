
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvalResultsSortByDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalResultsSortByDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalResultsSortByDirection value)
        {
            return value switch
            {
                EvalResultsSortByDirection.Asc => "asc",
                EvalResultsSortByDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalResultsSortByDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => EvalResultsSortByDirection.Asc,
                "desc" => EvalResultsSortByDirection.Desc,
                _ => null,
            };
        }
    }
}