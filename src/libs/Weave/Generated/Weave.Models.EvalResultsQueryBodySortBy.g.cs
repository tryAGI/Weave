
#nullable enable

namespace Weave
{
    /// <summary>
    /// Sort specification for result rows. Supported field prefixes: scores.&lt;name&gt;, inputs.&lt;path&gt;, outputs.&lt;path&gt;. When null, rows are sorted by row_digest ASC.
    /// </summary>
    public sealed partial class EvalResultsQueryBodySortBy
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}