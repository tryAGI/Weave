
#nullable enable

namespace Weave
{
    /// <summary>
    /// Filter conversations by live tag assignments.
    /// </summary>
    public sealed partial class AgentConversationTagFilter
    {
        /// <summary>
        /// Include conversations with a live assignment of any listed tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> TagIds { get; set; }

        /// <summary>
        /// Drop conversations with a live assignment of any listed tag.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public bool? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationTagFilter" /> class.
        /// </summary>
        /// <param name="tagIds">
        /// Include conversations with a live assignment of any listed tag.
        /// </param>
        /// <param name="exclude">
        /// Drop conversations with a live assignment of any listed tag.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConversationTagFilter(
            global::System.Collections.Generic.IList<global::System.Guid> tagIds,
            bool? exclude)
        {
            this.TagIds = tagIds ?? throw new global::System.ArgumentNullException(nameof(tagIds));
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationTagFilter" /> class.
        /// </summary>
        public AgentConversationTagFilter()
        {
        }

    }
}