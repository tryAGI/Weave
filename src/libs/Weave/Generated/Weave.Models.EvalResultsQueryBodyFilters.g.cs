
#nullable enable

namespace Weave
{
    /// <summary>
    /// Filters applied to grouped rows. Multiple filters are AND'd together.
    /// </summary>
    public sealed partial class EvalResultsQueryBodyFilters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}