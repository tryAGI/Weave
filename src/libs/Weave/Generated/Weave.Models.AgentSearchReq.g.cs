
#nullable enable

namespace Weave
{
    /// <summary>
    /// Query the `messages` table by content and/or span-level filters.<br/>
    /// Scans the `messages` table (one row per message occurrence, populated by an<br/>
    /// MV from spans) and returns matching span-level hits. Full-text search sets<br/>
    /// `query`; structured retrieval (e.g. all messages in a trace) leaves `query`<br/>
    /// empty and uses the filters below. The caller groups by conversation for the<br/>
    /// response shape.
    /// </summary>
    public sealed partial class AgentSearchReq
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
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSearchReqRolesVariant1Item>? Roles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_model")]
        public string? RequestModel { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate_content")]
        public bool? TruncateContent { get; set; }

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
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSearchReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="query"></param>
        /// <param name="traceId"></param>
        /// <param name="roles"></param>
        /// <param name="conversationId"></param>
        /// <param name="agentName"></param>
        /// <param name="providerName"></param>
        /// <param name="requestModel"></param>
        /// <param name="truncateContent">
        /// Default Value: true
        /// </param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSearchReq(
            string projectId,
            string? query,
            string? traceId,
            global::System.Collections.Generic.IList<global::Weave.AgentSearchReqRolesVariant1Item>? roles,
            string? conversationId,
            string? agentName,
            string? providerName,
            string? requestModel,
            bool? truncateContent,
            global::System.DateTime? startedAfter,
            global::System.DateTime? startedBefore,
            int? limit,
            int? offset)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Query = query;
            this.TraceId = traceId;
            this.Roles = roles;
            this.ConversationId = conversationId;
            this.AgentName = agentName;
            this.ProviderName = providerName;
            this.RequestModel = requestModel;
            this.TruncateContent = truncateContent;
            this.StartedAfter = startedAfter;
            this.StartedBefore = startedBefore;
            this.Limit = limit;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSearchReq" /> class.
        /// </summary>
        public AgentSearchReq()
        {
        }

    }
}