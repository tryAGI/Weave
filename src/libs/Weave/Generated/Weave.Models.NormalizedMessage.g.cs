
#nullable enable

namespace Weave
{
    /// <summary>
    /// A single message normalized from any provider format.<br/>
    /// Maps to ClickHouse ``Tuple(role String, content String, finish_reason String)``.<br/>
    /// - role: message role (user, assistant, tool, system)<br/>
    /// - content: plain text for simple messages, or JSON-serialized parts<br/>
    ///   array for multimodal/structured messages<br/>
    /// - finish_reason: per-message finish reason (output messages only)
    /// </summary>
    public sealed partial class NormalizedMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizedMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="finishReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NormalizedMessage(
            string content,
            string? role,
            string? finishReason)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizedMessage" /> class.
        /// </summary>
        public NormalizedMessage()
        {
        }

    }
}