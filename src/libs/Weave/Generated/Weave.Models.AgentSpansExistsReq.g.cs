
#nullable enable

namespace Weave
{
    /// <summary>
    /// Check whether any span matches project-scoped, attributed filters.
    /// </summary>
    public sealed partial class AgentSpansExistsReq
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
        public global::Weave.Query? Query { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentSpansExistsReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="query"></param>
        /// <param name="startedAfter"></param>
        /// <param name="startedBefore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpansExistsReq(
            string projectId,
            global::Weave.Query? query,
            global::System.DateTime? startedAfter,
            global::System.DateTime? startedBefore)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Query = query;
            this.StartedAfter = startedAfter;
            this.StartedBefore = startedBefore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpansExistsReq" /> class.
        /// </summary>
        public AgentSpansExistsReq()
        {
        }

    }
}