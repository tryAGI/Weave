
#nullable enable

namespace Weave
{
    /// <summary>
    /// Sum of per-trial predict-only token usage for this evaluation (the model's predict() tokens only, excluding LLM-as-a-judge scorer usage); None when no trial reports usage.
    /// </summary>
    public sealed partial class EvalResultsEvaluationSummaryPredictTotalTokens
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}