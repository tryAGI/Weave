
#nullable enable

namespace Weave
{
    /// <summary>
    /// Aggregated per-version stats from the agent_versions AMT.
    /// </summary>
    public sealed partial class AgentVersionSchema
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
        [global::System.Text.Json.Serialization.JsonPropertyName("invocation_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InvocationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SpanCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalOutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalDurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ErrorCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_seen")]
        public global::System.DateTime? FirstSeen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen")]
        public global::System.DateTime? LastSeen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost_usd")]
        public double? TotalCostUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVersionSchema" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="agentName"></param>
        /// <param name="invocationCount"></param>
        /// <param name="spanCount"></param>
        /// <param name="totalInputTokens"></param>
        /// <param name="totalOutputTokens"></param>
        /// <param name="totalDurationMs"></param>
        /// <param name="errorCount"></param>
        /// <param name="agentVersion"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="totalCostUsd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVersionSchema(
            string projectId,
            string agentName,
            int invocationCount,
            int spanCount,
            int totalInputTokens,
            int totalOutputTokens,
            int totalDurationMs,
            int errorCount,
            string agentVersion,
            global::System.DateTime? firstSeen,
            global::System.DateTime? lastSeen,
            double? totalCostUsd)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.InvocationCount = invocationCount;
            this.SpanCount = spanCount;
            this.TotalInputTokens = totalInputTokens;
            this.TotalOutputTokens = totalOutputTokens;
            this.TotalDurationMs = totalDurationMs;
            this.ErrorCount = errorCount;
            this.FirstSeen = firstSeen;
            this.LastSeen = lastSeen;
            this.TotalCostUsd = totalCostUsd;
            this.AgentVersion = agentVersion ?? throw new global::System.ArgumentNullException(nameof(agentVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVersionSchema" /> class.
        /// </summary>
        public AgentVersionSchema()
        {
        }

    }
}