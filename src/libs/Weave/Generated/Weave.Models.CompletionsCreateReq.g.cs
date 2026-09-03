
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CompletionsCreateReq
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
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.CompletionsCreateRequestInputs Inputs { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Whether to track this LLM call in the trace server<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_llm_call")]
        public bool? TrackLlmCall { get; set; }

        /// <summary>
        /// Trace ID to use for the LLM call (for nesting under a parent)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// Parent call ID to nest this LLM call under
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Conversation ID to group related completions into a multi-turn conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Human-readable conversation name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_name")]
        public string? ConversationName { get; set; }

        /// <summary>
        /// Source of the completion request (e.g. 'playground', 'signals')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsCreateReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="inputs"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="trackLlmCall">
        /// Whether to track this LLM call in the trace server<br/>
        /// Default Value: true
        /// </param>
        /// <param name="traceId">
        /// Trace ID to use for the LLM call (for nesting under a parent)
        /// </param>
        /// <param name="parentId">
        /// Parent call ID to nest this LLM call under
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID to group related completions into a multi-turn conversation
        /// </param>
        /// <param name="conversationName">
        /// Human-readable conversation name
        /// </param>
        /// <param name="source">
        /// Source of the completion request (e.g. 'playground', 'signals')
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionsCreateReq(
            string projectId,
            global::Weave.CompletionsCreateRequestInputs inputs,
            string? wbUserId,
            bool? trackLlmCall,
            string? traceId,
            string? parentId,
            string? conversationId,
            string? conversationName,
            string? source)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.WbUserId = wbUserId;
            this.TrackLlmCall = trackLlmCall;
            this.TraceId = traceId;
            this.ParentId = parentId;
            this.ConversationId = conversationId;
            this.ConversationName = conversationName;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsCreateReq" /> class.
        /// </summary>
        public CompletionsCreateReq()
        {
        }

    }
}