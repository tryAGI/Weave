
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentChatMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentHandoff,
        /// <summary>
        /// 
        /// </summary>
        AgentStart,
        /// <summary>
        /// 
        /// </summary>
        AssistantMessage,
        /// <summary>
        /// 
        /// </summary>
        ContextCompacted,
        /// <summary>
        /// 
        /// </summary>
        ToolCall,
        /// <summary>
        /// 
        /// </summary>
        UserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentChatMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentChatMessageType value)
        {
            return value switch
            {
                AgentChatMessageType.AgentHandoff => "agent_handoff",
                AgentChatMessageType.AgentStart => "agent_start",
                AgentChatMessageType.AssistantMessage => "assistant_message",
                AgentChatMessageType.ContextCompacted => "context_compacted",
                AgentChatMessageType.ToolCall => "tool_call",
                AgentChatMessageType.UserMessage => "user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentChatMessageType? ToEnum(string value)
        {
            return value switch
            {
                "agent_handoff" => AgentChatMessageType.AgentHandoff,
                "agent_start" => AgentChatMessageType.AgentStart,
                "assistant_message" => AgentChatMessageType.AssistantMessage,
                "context_compacted" => AgentChatMessageType.ContextCompacted,
                "tool_call" => AgentChatMessageType.ToolCall,
                "user_message" => AgentChatMessageType.UserMessage,
                _ => null,
            };
        }
    }
}