
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Query
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$expr")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AnyOf<global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation> x_expr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Query" /> class.
        /// </summary>
        /// <param name="x_expr"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Query(
            global::Weave.AnyOf<global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation> x_expr)
        {
            this.x_expr = x_expr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query" /> class.
        /// </summary>
        public Query()
        {
        }
    }
}