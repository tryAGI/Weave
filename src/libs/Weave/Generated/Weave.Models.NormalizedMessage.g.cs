
#nullable enable

namespace Weave
{
    /// <summary>
    /// A single message normalized from any provider format.<br/>
    /// Maps to ClickHouse ``Tuple(role String, content String, finish_reason String)``.<br/>
    /// - role: message role (user, assistant, tool, system)<br/>
    /// - content: plain text for simple messages, or JSON-serialized parts<br/>
    ///   array for multimodal/structured messages<br/>
    /// - finish_reason: per-message finish reason (output messages only)<br/>
    /// Serialization JSON Schema marks defaulted fields required. In the public<br/>
    /// OpenAPI document this class appears only as an AgentSpanSchema message<br/>
    /// element. Ingest validation is unchanged.
    /// </summary>
    public sealed partial class NormalizedMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizedMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="finishReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NormalizedMessage(
            string role,
            string content,
            string finishReason)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.FinishReason = finishReason ?? throw new global::System.ArgumentNullException(nameof(finishReason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizedMessage" /> class.
        /// </summary>
        public NormalizedMessage()
        {
        }

    }
}