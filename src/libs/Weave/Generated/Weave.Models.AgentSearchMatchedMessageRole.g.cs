
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSearchMatchedMessageRole
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
    public static class AgentSearchMatchedMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSearchMatchedMessageRole value)
        {
            return value switch
            {
                AgentSearchMatchedMessageRole.Assistant => "assistant",
                AgentSearchMatchedMessageRole.System => "system",
                AgentSearchMatchedMessageRole.Tool => "tool",
                AgentSearchMatchedMessageRole.ToolCall => "tool_call",
                AgentSearchMatchedMessageRole.ToolResult => "tool_result",
                AgentSearchMatchedMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSearchMatchedMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentSearchMatchedMessageRole.Assistant,
                "system" => AgentSearchMatchedMessageRole.System,
                "tool" => AgentSearchMatchedMessageRole.Tool,
                "tool_call" => AgentSearchMatchedMessageRole.ToolCall,
                "tool_result" => AgentSearchMatchedMessageRole.ToolResult,
                "user" => AgentSearchMatchedMessageRole.User,
                _ => null,
            };
        }
    }
}