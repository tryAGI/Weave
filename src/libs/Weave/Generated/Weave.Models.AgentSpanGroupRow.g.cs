
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
        public object? GroupKeys { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_count")]
        public int? SpanCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocation_count")]
        public int? InvocationCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_count")]
        public int? ConversationCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_tokens")]
        public int? TotalInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cache_creation_input_tokens")]
        public int? TotalCacheCreationInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cache_read_input_tokens")]
        public int? TotalCacheReadInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_output_tokens")]
        public int? TotalOutputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_reasoning_tokens")]
        public int? TotalReasoningTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_ms")]
        public int? TotalDurationMs { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_count")]
        public int? ErrorCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_names")]
        public global::System.Collections.Generic.IList<string>? AgentNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_versions")]
        public global::System.Collections.Generic.IList<string>? AgentVersions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_names")]
        public global::System.Collections.Generic.IList<string>? ProviderNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_models")]
        public global::System.Collections.Generic.IList<string>? RequestModels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_names")]
        public global::System.Collections.Generic.IList<string>? ConversationNames { get; set; }

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
        public object? Metrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distributions")]
        public global::System.Collections.Generic.Dictionary<string, global::Weave.AgentSpanGroupDistributionItem>? Distributions { get; set; }

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
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="firstMessage"></param>
        /// <param name="lastMessage"></param>
        /// <param name="metrics"></param>
        /// <param name="distributions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSpanGroupRow(
            object? groupKeys,
            int? spanCount,
            int? invocationCount,
            int? conversationCount,
            int? totalInputTokens,
            int? totalCacheCreationInputTokens,
            int? totalCacheReadInputTokens,
            int? totalOutputTokens,
            int? totalReasoningTokens,
            int? totalDurationMs,
            int? errorCount,
            global::System.Collections.Generic.IList<string>? agentNames,
            global::System.Collections.Generic.IList<string>? agentVersions,
            global::System.Collections.Generic.IList<string>? providerNames,
            global::System.Collections.Generic.IList<string>? requestModels,
            global::System.Collections.Generic.IList<string>? conversationNames,
            global::System.DateTime? firstSeen,
            global::System.DateTime? lastSeen,
            global::Weave.AgentConversationMessagePreview? firstMessage,
            global::Weave.AgentConversationMessagePreview? lastMessage,
            object? metrics,
            global::System.Collections.Generic.Dictionary<string, global::Weave.AgentSpanGroupDistributionItem>? distributions)
        {
            this.GroupKeys = groupKeys;
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
            this.AgentNames = agentNames;
            this.AgentVersions = agentVersions;
            this.ProviderNames = providerNames;
            this.RequestModels = requestModels;
            this.ConversationNames = conversationNames;
            this.FirstSeen = firstSeen;
            this.LastSeen = lastSeen;
            this.FirstMessage = firstMessage;
            this.LastMessage = lastMessage;
            this.Metrics = metrics;
            this.Distributions = distributions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSpanGroupRow" /> class.
        /// </summary>
        public AgentSpanGroupRow()
        {
        }

    }
}