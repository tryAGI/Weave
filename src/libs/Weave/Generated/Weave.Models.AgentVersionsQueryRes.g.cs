
#nullable enable

namespace Weave
{
    /// <summary>
    /// Response containing agent version stats.
    /// </summary>
    public sealed partial class AgentVersionsQueryRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.AgentVersionSchema> Versions { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentVersionsQueryRes" /> class.
        /// </summary>
        /// <param name="versions"></param>
        /// <param name="totalCount">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentVersionsQueryRes(
            global::System.Collections.Generic.IList<global::Weave.AgentVersionSchema> versions,
            int? totalCount)
        {
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentVersionsQueryRes" /> class.
        /// </summary>
        public AgentVersionsQueryRes()
        {
        }

    }
}