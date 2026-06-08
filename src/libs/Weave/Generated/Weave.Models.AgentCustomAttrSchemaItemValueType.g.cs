
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentCustomAttrSchemaItemValueType
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
    public static class AgentCustomAttrSchemaItemValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCustomAttrSchemaItemValueType value)
        {
            return value switch
            {
                AgentCustomAttrSchemaItemValueType.Bool => "bool",
                AgentCustomAttrSchemaItemValueType.Float => "float",
                AgentCustomAttrSchemaItemValueType.Int => "int",
                AgentCustomAttrSchemaItemValueType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCustomAttrSchemaItemValueType? ToEnum(string value)
        {
            return value switch
            {
                "bool" => AgentCustomAttrSchemaItemValueType.Bool,
                "float" => AgentCustomAttrSchemaItemValueType.Float,
                "int" => AgentCustomAttrSchemaItemValueType.Int,
                "string" => AgentCustomAttrSchemaItemValueType.String,
                _ => null,
            };
        }
    }
}