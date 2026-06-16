
#nullable enable

namespace Weave
{
    /// <summary>
    /// Payload for an agent lifecycle boundary.
    /// </summary>
    public sealed partial class AgentChatAgentStart
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_instructions")]
        public string? SystemInstructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_definitions")]
        public string? ToolDefinitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Weave.AgentChatAgentStartStatus2? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChatAgentStart" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="systemInstructions"></param>
        /// <param name="toolDefinitions"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentChatAgentStart(
            string? model,
            string? systemInstructions,
            string? toolDefinitions,
            global::Weave.AgentChatAgentStartStatus2? status)
        {
            this.Model = model;
            this.SystemInstructions = systemInstructions;
            this.ToolDefinitions = toolDefinitions;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChatAgentStart" /> class.
        /// </summary>
        public AgentChatAgentStart()
        {
        }

    }
}