
#nullable enable

namespace Weave
{
    /// <summary>
    /// Payload for assistant text emitted by an agent or LLM span.
    /// </summary>
    public sealed partial class AgentChatAssistantMessage
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
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_content")]
        public string? ReasoningContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        public int? ReasoningTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_usd")]
        public double? InputCostUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_usd")]
        public double? OutputCostUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost_usd")]
        public double? TotalCostUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Weave.AgentChatAssistantMessageStatus2? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentChatAssistantMessage" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="model"></param>
        /// <param name="reasoningContent"></param>
        /// <param name="reasoningTokens"></param>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="inputCostUsd"></param>
        /// <param name="outputCostUsd"></param>
        /// <param name="totalCostUsd"></param>
        /// <param name="durationMs"></param>
        /// <param name="status"></param>
        /// <param name="contentRefs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentChatAssistantMessage(
            string text,
            string? model,
            string? reasoningContent,
            int? reasoningTokens,
            int? inputTokens,
            int? outputTokens,
            double? inputCostUsd,
            double? outputCostUsd,
            double? totalCostUsd,
            int? durationMs,
            global::Weave.AgentChatAssistantMessageStatus2? status,
            global::System.Collections.Generic.IList<string>? contentRefs)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Model = model;
            this.ReasoningContent = reasoningContent;
            this.ReasoningTokens = reasoningTokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.InputCostUsd = inputCostUsd;
            this.OutputCostUsd = outputCostUsd;
            this.TotalCostUsd = totalCostUsd;
            this.DurationMs = durationMs;
            this.Status = status;
            this.ContentRefs = contentRefs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentChatAssistantMessage" /> class.
        /// </summary>
        public AgentChatAssistantMessage()
        {
        }

    }
}