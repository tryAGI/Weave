
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSpanGroupDistributionItemValueType
    {
        /// <summary>
        /// 
        /// </summary>
        Bool,
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Int,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSpanGroupDistributionItemValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanGroupDistributionItemValueType value)
        {
            return value switch
            {
                AgentSpanGroupDistributionItemValueType.Bool => "bool",
                AgentSpanGroupDistributionItemValueType.Float => "float",
                AgentSpanGroupDistributionItemValueType.Int => "int",
                AgentSpanGroupDistributionItemValueType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanGroupDistributionItemValueType? ToEnum(string value)
        {
            return value switch
            {
                "bool" => AgentSpanGroupDistributionItemValueType.Bool,
                "float" => AgentSpanGroupDistributionItemValueType.Float,
                "int" => AgentSpanGroupDistributionItemValueType.Int,
                "string" => AgentSpanGroupDistributionItemValueType.String,
                _ => null,
            };
        }
    }
}