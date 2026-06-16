
#nullable enable

namespace Weave
{
    /// <summary>
    /// Request to list versions for an agent.
    /// </summary>
    public sealed partial class AgentVersionsQueryReq
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
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSortBy>? SortBy { get; set; }

        /// <summary>
        /// Default Value: 100
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
        /// Initializes a new instance of the <see cref="AgentVersionsQueryReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="agentName"></param>
        /// <param name="sortBy"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVersionsQueryReq(
            string projectId,
            string agentName,
            global::System.Collections.Generic.IList<global::Weave.AgentSortBy>? sortBy,
            int? limit,
            int? offset)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.SortBy = sortBy;
            this.Limit = limit;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVersionsQueryReq" /> class.
        /// </summary>
        public AgentVersionsQueryReq()
        {
        }

    }
}