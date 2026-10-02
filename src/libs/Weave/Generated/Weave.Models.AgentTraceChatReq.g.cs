
#nullable enable

namespace Weave
{
    /// <summary>
    /// Request to get the structured chat / trajectory view for a trace.
    /// </summary>
    public sealed partial class AgentTraceChatReq
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_feedback")]
        public bool? IncludeFeedback { get; set; }

        /// <summary>
        /// Include tool calls requested in model outputs, even when no execution span was recorded. Requests without execution evidence have no status, duration, or result. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_model_tool_calls")]
        public bool? IncludeModelToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTraceChatReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="traceId"></param>
        /// <param name="includeFeedback">
        /// Default Value: false
        /// </param>
        /// <param name="includeModelToolCalls">
        /// Include tool calls requested in model outputs, even when no execution span was recorded. Requests without execution evidence have no status, duration, or result. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTraceChatReq(
            string projectId,
            string traceId,
            bool? includeFeedback,
            bool? includeModelToolCalls)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.IncludeFeedback = includeFeedback;
            this.IncludeModelToolCalls = includeModelToolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTraceChatReq" /> class.
        /// </summary>
        public AgentTraceChatReq()
        {
        }

    }
}