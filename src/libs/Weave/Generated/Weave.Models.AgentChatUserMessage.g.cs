
#nullable enable

namespace Weave
{
    /// <summary>
    /// Payload for a user prompt in the chat timeline.
    /// </summary>
    public sealed partial class AgentChatUserMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_refs")]
        public global::System.Collections.Generic.IList<string>? ContentRefs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChatUserMessage" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="contentRefs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentChatUserMessage(
            string text,
            global::System.Collections.Generic.IList<string>? contentRefs)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.ContentRefs = contentRefs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChatUserMessage" /> class.
        /// </summary>
        public AgentChatUserMessage()
        {
        }

    }
}