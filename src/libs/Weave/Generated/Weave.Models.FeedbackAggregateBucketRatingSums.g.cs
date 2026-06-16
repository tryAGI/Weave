
#nullable enable

namespace Weave
{
    /// <summary>
    /// Sum of each rating key's values; client derives avg = sum/count.
    /// </summary>
    public sealed partial class FeedbackAggregateBucketRatingSums
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}