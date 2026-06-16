
#nullable enable

namespace Weave
{
    /// <summary>
    /// Default Value: field
    /// </summary>
    public enum AgentGroupByRefSource
    {
        /// <summary>
        /// 
        /// </summary>
        Column,
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
        /// <summary>
        /// 
        /// </summary>
        Field,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentGroupByRefSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentGroupByRefSource value)
        {
            return value switch
            {
                AgentGroupByRefSource.Column => "column",
                AgentGroupByRefSource.CustomAttrsBool => "custom_attrs_bool",
                AgentGroupByRefSource.CustomAttrsFloat => "custom_attrs_float",
                AgentGroupByRefSource.CustomAttrsInt => "custom_attrs_int",
                AgentGroupByRefSource.CustomAttrsString => "custom_attrs_string",
                AgentGroupByRefSource.Field => "field",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentGroupByRefSource? ToEnum(string value)
        {
            return value switch
            {
                "column" => AgentGroupByRefSource.Column,
                "custom_attrs_bool" => AgentGroupByRefSource.CustomAttrsBool,
                "custom_attrs_float" => AgentGroupByRefSource.CustomAttrsFloat,
                "custom_attrs_int" => AgentGroupByRefSource.CustomAttrsInt,
                "custom_attrs_string" => AgentGroupByRefSource.CustomAttrsString,
                "field" => AgentGroupByRefSource.Field,
                _ => null,
            };
        }
    }
}