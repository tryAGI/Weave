
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentCustomAttrSchemaItemSource
    {
        /// <summary>
        /// 
        /// </summary>
        CustomAttrsBool,
        /// <summary>
        /// 
        /// </summary>
        CustomAttrsFloat,
        /// <summary>
        /// 
        /// </summary>
        CustomAttrsInt,
        /// <summary>
        /// 
        /// </summary>
        CustomAttrsString,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCustomAttrSchemaItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCustomAttrSchemaItemSource value)
        {
            return value switch
            {
                AgentCustomAttrSchemaItemSource.CustomAttrsBool => "custom_attrs_bool",
                AgentCustomAttrSchemaItemSource.CustomAttrsFloat => "custom_attrs_float",
                AgentCustomAttrSchemaItemSource.CustomAttrsInt => "custom_attrs_int",
                AgentCustomAttrSchemaItemSource.CustomAttrsString => "custom_attrs_string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCustomAttrSchemaItemSource? ToEnum(string value)
        {
            return value switch
            {
                "custom_attrs_bool" => AgentCustomAttrSchemaItemSource.CustomAttrsBool,
                "custom_attrs_float" => AgentCustomAttrSchemaItemSource.CustomAttrsFloat,
                "custom_attrs_int" => AgentCustomAttrSchemaItemSource.CustomAttrsInt,
                "custom_attrs_string" => AgentCustomAttrSchemaItemSource.CustomAttrsString,
                _ => null,
            };
        }
    }
}