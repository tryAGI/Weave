
#nullable enable

namespace Weave
{
    /// <summary>
    /// Optional filters for querying agents.
    /// </summary>
    public sealed partial class AgentsQueryFilters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsQueryFilters" /> class.
        /// </summary>
        /// <param name="agentName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsQueryFilters(
            string? agentName)
        {
            this.AgentName = agentName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsQueryFilters" /> class.
        /// </summary>
        public AgentsQueryFilters()
        {
        }

    }
}