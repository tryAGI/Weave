
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSpanGroupDistributionItemSource
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
    public static class AgentSpanGroupDistributionItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSpanGroupDistributionItemSource value)
        {
            return value switch
            {
                AgentSpanGroupDistributionItemSource.CustomAttrsBool => "custom_attrs_bool",
                AgentSpanGroupDistributionItemSource.CustomAttrsFloat => "custom_attrs_float",
                AgentSpanGroupDistributionItemSource.CustomAttrsInt => "custom_attrs_int",
                AgentSpanGroupDistributionItemSource.CustomAttrsString => "custom_attrs_string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSpanGroupDistributionItemSource? ToEnum(string value)
        {
            return value switch
            {
                "custom_attrs_bool" => AgentSpanGroupDistributionItemSource.CustomAttrsBool,
                "custom_attrs_float" => AgentSpanGroupDistributionItemSource.CustomAttrsFloat,
                "custom_attrs_int" => AgentSpanGroupDistributionItemSource.CustomAttrsInt,
                "custom_attrs_string" => AgentSpanGroupDistributionItemSource.CustomAttrsString,
                _ => null,
            };
        }
    }
}