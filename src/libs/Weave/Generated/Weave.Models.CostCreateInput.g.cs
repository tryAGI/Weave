
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CostCreateInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_token_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTokenCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_token_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTokenCost { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost")]
        public double? CacheReadInputTokenCost { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_token_cost")]
        public double? CacheCreationInputTokenCost { get; set; }

        /// <summary>
        /// The unit of the cost for the prompt tokens<br/>
        /// Default Value: USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_token_cost_unit")]
        public string? PromptTokenCostUnit { get; set; }

        /// <summary>
        /// The unit of the cost for the completion tokens<br/>
        /// Default Value: USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_token_cost_unit")]
        public string? CompletionTokenCostUnit { get; set; }

        /// <summary>
        /// The date after which the cost is effective for, will default to the current date if not provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_date")]
        public global::System.DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// The provider of the LLM, e.g. 'openai' or 'mistral'. If not provided, the provider_id will be set to 'default'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostCreateInput" /> class.
        /// </summary>
        /// <param name="promptTokenCost"></param>
        /// <param name="completionTokenCost"></param>
        /// <param name="cacheReadInputTokenCost">
        /// Default Value: 0
        /// </param>
        /// <param name="cacheCreationInputTokenCost">
        /// Default Value: 0
        /// </param>
        /// <param name="promptTokenCostUnit">
        /// The unit of the cost for the prompt tokens<br/>
        /// Default Value: USD
        /// </param>
        /// <param name="completionTokenCostUnit">
        /// The unit of the cost for the completion tokens<br/>
        /// Default Value: USD
        /// </param>
        /// <param name="effectiveDate">
        /// The date after which the cost is effective for, will default to the current date if not provided
        /// </param>
        /// <param name="providerId">
        /// The provider of the LLM, e.g. 'openai' or 'mistral'. If not provided, the provider_id will be set to 'default'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostCreateInput(
            double promptTokenCost,
            double completionTokenCost,
            double? cacheReadInputTokenCost,
            double? cacheCreationInputTokenCost,
            string? promptTokenCostUnit,
            string? completionTokenCostUnit,
            global::System.DateTime? effectiveDate,
            string? providerId)
        {
            this.PromptTokenCost = promptTokenCost;
            this.CompletionTokenCost = completionTokenCost;
            this.CacheReadInputTokenCost = cacheReadInputTokenCost;
            this.CacheCreationInputTokenCost = cacheCreationInputTokenCost;
            this.PromptTokenCostUnit = promptTokenCostUnit;
            this.CompletionTokenCostUnit = completionTokenCostUnit;
            this.EffectiveDate = effectiveDate;
            this.ProviderId = providerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostCreateInput" /> class.
        /// </summary>
        public CostCreateInput()
        {
        }
    }
}