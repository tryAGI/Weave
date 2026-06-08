
#nullable enable

namespace Weave
{
    /// <summary>
    /// Response from a spans query.<br/>
    /// Exactly one of `spans` or `groups` will be populated, based on<br/>
    /// whether the request specified `group_by`.
    /// </summary>
    public sealed partial class AgentSpansQueryRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanSchema>? Spans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupRow>? Groups { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentSpansQueryRes" /> class.
        /// </summary>
        /// <param name="spans"></param>
        /// <param name="groups"></param>
        /// <param name="totalCount">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpansQueryRes(
            global::System.Collections.Generic.IList<global::Weave.AgentSpanSchema>? spans,
            global::System.Collections.Generic.IList<global::Weave.AgentSpanGroupRow>? groups,
            int? totalCount)
        {
            this.Spans = spans;
            this.Groups = groups;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpansQueryRes" /> class.
        /// </summary>
        public AgentSpansQueryRes()
        {
        }

    }
}