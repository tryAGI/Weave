
#nullable enable

namespace Weave
{
    /// <summary>
    /// Response containing aggregated agent stats.
    /// </summary>
    public sealed partial class AgentsQueryRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.AgentSchema> Agents { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsQueryRes" /> class.
        /// </summary>
        /// <param name="agents"></param>
        /// <param name="totalCount">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsQueryRes(
            global::System.Collections.Generic.IList<global::Weave.AgentSchema> agents,
            int? totalCount)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsQueryRes" /> class.
        /// </summary>
        public AgentsQueryRes()
        {
        }

    }
}