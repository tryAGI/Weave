
#nullable enable

namespace Weave
{
    /// <summary>
    /// A truncated first/last message snippet for a grouped conversation row.<br/>
    /// `role` is the chat-timeline message type (e.g. "user_message",<br/>
    /// "assistant_message") so clients can style it consistently with the full<br/>
    /// chat view; `text` is the trimmed, length-capped preview content.
    /// </summary>
    public sealed partial class AgentConversationMessagePreview
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AgentConversationMessagePreviewRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AgentConversationMessagePreviewRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationMessagePreview" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConversationMessagePreview(
            global::Weave.AgentConversationMessagePreviewRole role,
            string? text)
        {
            this.Role = role;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationMessagePreview" /> class.
        /// </summary>
        public AgentConversationMessagePreview()
        {
        }

    }
}