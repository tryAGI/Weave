
#nullable enable

namespace Weave
{
    /// <summary>
    /// A single row in a grouped spans query response.<br/>
    /// `group_keys` maps each group_by ref's alias to its value for this row.<br/>
    /// The remaining fields are a fixed aggregate bundle computed per group.
    /// </summary>
    public sealed partial class AgentSpanGroupRow
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object GroupKeys { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SpanCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocation_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InvocationCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConversationCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cache_creation_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCacheCreationInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cache_read_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCacheReadInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalOutputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_reasoning_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalReasoningTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalDurationMs { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ErrorCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost_usd")]
        public double? TotalCostUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_cost_usd")]
        public double? TotalInputCostUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_output_cost_usd")]
        public double? TotalOutputCostUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AgentNames { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AgentVersions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ProviderNames { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RequestModels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ConversationNames { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_seen")]
        public global::System.DateTime? FirstSeen { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen")]
        public global::System.DateTime? LastSeen { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public global::Weave.AgentConversationMessagePreview? FirstMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_message")]
        public global::Weave.AgentConversationMessagePreview? LastMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metrics { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distributions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Weave.AgentSpanGroupDistributionItem> Distributions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanGroupRow" /> class.
        /// </summary>
        /// <param name="groupKeys"></param>
        /// <param name="spanCount">
        /// Default Value: 0
        /// </param>
        /// <param name="invocationCount">
        /// Default Value: 0
        /// </param>
        /// <param name="conversationCount">
        /// Default Value: 0
        /// </param>
        /// <param name="totalInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalCacheCreationInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalCacheReadInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalOutputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalReasoningTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalDurationMs">
        /// Default Value: 0
        /// </param>
        /// <param name="errorCount">
        /// Default Value: 0
        /// </param>
        /// <param name="agentNames"></param>
        /// <param name="agentVersions"></param>
        /// <param name="providerNames"></param>
        /// <param name="requestModels"></param>
        /// <param name="conversationNames"></param>
        /// <param name="metrics"></param>
        /// <param name="distributions"></param>
        /// <param name="totalCostUsd"></param>
        /// <param name="totalInputCostUsd"></param>
        /// <param name="totalOutputCostUsd"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="firstMessage"></param>
        /// <param name="lastMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanGroupRow(
            object groupKeys,
            int spanCount,
            int invocationCount,
            int conversationCount,
            int totalInputTokens,
            int totalCacheCreationInputTokens,
            int totalCacheReadInputTokens,
            int totalOutputTokens,
            int totalReasoningTokens,
            int totalDurationMs,
            int errorCount,
            global::System.Collections.Generic.IList<string> agentNames,
            global::System.Collections.Generic.IList<string> agentVersions,
            global::System.Collections.Generic.IList<string> providerNames,
            global::System.Collections.Generic.IList<string> requestModels,
            global::System.Collections.Generic.IList<string> conversationNames,
            object metrics,
            global::System.Collections.Generic.Dictionary<string, global::Weave.AgentSpanGroupDistributionItem> distributions,
            double? totalCostUsd,
            double? totalInputCostUsd,
            double? totalOutputCostUsd,
            global::System.DateTime? firstSeen,
            global::System.DateTime? lastSeen,
            global::Weave.AgentConversationMessagePreview? firstMessage,
            global::Weave.AgentConversationMessagePreview? lastMessage)
        {
            this.GroupKeys = groupKeys ?? throw new global::System.ArgumentNullException(nameof(groupKeys));
            this.SpanCount = spanCount;
            this.InvocationCount = invocationCount;
            this.ConversationCount = conversationCount;
            this.TotalInputTokens = totalInputTokens;
            this.TotalCacheCreationInputTokens = totalCacheCreationInputTokens;
            this.TotalCacheReadInputTokens = totalCacheReadInputTokens;
            this.TotalOutputTokens = totalOutputTokens;
            this.TotalReasoningTokens = totalReasoningTokens;
            this.TotalDurationMs = totalDurationMs;
            this.ErrorCount = errorCount;
            this.TotalCostUsd = totalCostUsd;
            this.TotalInputCostUsd = totalInputCostUsd;
            this.TotalOutputCostUsd = totalOutputCostUsd;
            this.AgentNames = agentNames ?? throw new global::System.ArgumentNullException(nameof(agentNames));
            this.AgentVersions = agentVersions ?? throw new global::System.ArgumentNullException(nameof(agentVersions));
            this.ProviderNames = providerNames ?? throw new global::System.ArgumentNullException(nameof(providerNames));
            this.RequestModels = requestModels ?? throw new global::System.ArgumentNullException(nameof(requestModels));
            this.ConversationNames = conversationNames ?? throw new global::System.ArgumentNullException(nameof(conversationNames));
            this.FirstSeen = firstSeen;
            this.LastSeen = lastSeen;
            this.FirstMessage = firstMessage;
            this.LastMessage = lastMessage;
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.Distributions = distributions ?? throw new global::System.ArgumentNullException(nameof(distributions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanGroupRow" /> class.
        /// </summary>
        public AgentSpanGroupRow()
        {
        }

    }
}