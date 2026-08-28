
#nullable enable

namespace Weave
{
    /// <summary>
    /// Span sequences + feedback markers, one entry per requested conversation.
    /// </summary>
    public sealed partial class AgentConversationSpansRes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.AgentConversationSpans> Conversations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationSpansRes" /> class.
        /// </summary>
        /// <param name="conversations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConversationSpansRes(
            global::System.Collections.Generic.IList<global::Weave.AgentConversationSpans> conversations)
        {
            this.Conversations = conversations ?? throw new global::System.ArgumentNullException(nameof(conversations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationSpansRes" /> class.
        /// </summary>
        public AgentConversationSpansRes()
        {
        }

    }
}