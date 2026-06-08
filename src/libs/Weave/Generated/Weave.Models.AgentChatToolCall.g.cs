
#nullable enable

namespace Weave
{
    /// <summary>
    /// Payload for a tool call timeline event.
    /// </summary>
    public sealed partial class AgentChatToolCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        public string? ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_arguments")]
        public string? ToolArguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_result")]
        public string? ToolResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Weave.AgentChatToolCallStatus2? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_refs")]
        public global::System.Collections.Generic.IList<string>? ContentRefs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChatToolCall" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="toolArguments"></param>
        /// <param name="toolResult"></param>
        /// <param name="durationMs"></param>
        /// <param name="status"></param>
        /// <param name="contentRefs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentChatToolCall(
            string? toolName,
            string? toolArguments,
            string? toolResult,
            int? durationMs,
            global::Weave.AgentChatToolCallStatus2? status,
            global::System.Collections.Generic.IList<string>? contentRefs)
        {
            this.ToolName = toolName;
            this.ToolArguments = toolArguments;
            this.ToolResult = toolResult;
            this.DurationMs = durationMs;
            this.Status = status;
            this.ContentRefs = contentRefs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChatToolCall" /> class.
        /// </summary>
        public AgentChatToolCall()
        {
        }

    }
}