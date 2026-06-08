
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSearchReqRolesVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        ToolCall,
        /// <summary>
        /// 
        /// </summary>
        ToolResult,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSearchReqRolesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSearchReqRolesVariant1Item value)
        {
            return value switch
            {
                AgentSearchReqRolesVariant1Item.Assistant => "assistant",
                AgentSearchReqRolesVariant1Item.System => "system",
                AgentSearchReqRolesVariant1Item.Tool => "tool",
                AgentSearchReqRolesVariant1Item.ToolCall => "tool_call",
                AgentSearchReqRolesVariant1Item.ToolResult => "tool_result",
                AgentSearchReqRolesVariant1Item.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSearchReqRolesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentSearchReqRolesVariant1Item.Assistant,
                "system" => AgentSearchReqRolesVariant1Item.System,
                "tool" => AgentSearchReqRolesVariant1Item.Tool,
                "tool_call" => AgentSearchReqRolesVariant1Item.ToolCall,
                "tool_result" => AgentSearchReqRolesVariant1Item.ToolResult,
                "user" => AgentSearchReqRolesVariant1Item.User,
                _ => null,
            };
        }
    }
}