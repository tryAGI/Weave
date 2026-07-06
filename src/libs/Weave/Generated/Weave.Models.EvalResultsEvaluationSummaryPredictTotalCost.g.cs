
#nullable enable

namespace Weave
{
    /// <summary>
    /// Sum of per-trial predict-only cost for this evaluation (the model's predict() cost only, excluding LLM-as-a-judge scorer cost); None when no trial reports cost.
    /// </summary>
    public sealed partial class EvalResultsEvaluationSummaryPredictTotalCost
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}