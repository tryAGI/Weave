
#nullable enable

namespace Weave
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum AgentSortByDirection
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
    public static class AgentSortByDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSortByDirection value)
        {
            return value switch
            {
                AgentSortByDirection.Asc => "asc",
                AgentSortByDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSortByDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AgentSortByDirection.Asc,
                "desc" => AgentSortByDirection.Desc,
                _ => null,
            };
        }
    }
}