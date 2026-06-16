
#nullable enable

namespace Weave
{
    /// <summary>
    /// Default Value: field
    /// </summary>
    public enum AgentSpanValueRefSource
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
        /// <summary>
        /// 
        /// </summary>
        Derived,
        /// <summary>
        /// 
        /// </summary>
        Field,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSpanValueRefSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanValueRefSource value)
        {
            return value switch
            {
                AgentSpanValueRefSource.CustomAttrsBool => "custom_attrs_bool",
                AgentSpanValueRefSource.CustomAttrsFloat => "custom_attrs_float",
                AgentSpanValueRefSource.CustomAttrsInt => "custom_attrs_int",
                AgentSpanValueRefSource.CustomAttrsString => "custom_attrs_string",
                AgentSpanValueRefSource.Derived => "derived",
                AgentSpanValueRefSource.Field => "field",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanValueRefSource? ToEnum(string value)
        {
            return value switch
            {
                "custom_attrs_bool" => AgentSpanValueRefSource.CustomAttrsBool,
                "custom_attrs_float" => AgentSpanValueRefSource.CustomAttrsFloat,
                "custom_attrs_int" => AgentSpanValueRefSource.CustomAttrsInt,
                "custom_attrs_string" => AgentSpanValueRefSource.CustomAttrsString,
                "derived" => AgentSpanValueRefSource.Derived,
                "field" => AgentSpanValueRefSource.Field,
                _ => null,
            };
        }
    }
}