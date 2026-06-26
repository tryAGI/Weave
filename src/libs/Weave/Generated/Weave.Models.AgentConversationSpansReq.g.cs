
#nullable enable

namespace Weave
{
    /// <summary>
    /// Request the span sequences for an explicit set of conversations.<br/>
    /// Reads span scalar columns only (no message bodies) for the given<br/>
    /// `conversation_ids`. Powers the conversations-list spans minimap.
    /// </summary>
    public sealed partial class AgentConversationSpansReq
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
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_ids")]
        public global::System.Collections.Generic.IList<string>? ConversationIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_after")]
        public global::System.DateTime? StartedAfter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_before")]
        public global::System.DateTime? StartedBefore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationSpansReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="conversationIds"></param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConversationSpansReq(
            string projectId,
            global::System.Collections.Generic.IList<string>? conversationIds,
            global::System.DateTime? startedAfter,
            global::System.DateTime? startedBefore)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ConversationIds = conversationIds;
            this.StartedAfter = startedAfter;
            this.StartedBefore = startedBefore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationSpansReq" /> class.
        /// </summary>
        public AgentConversationSpansReq()
        {
        }

    }
}