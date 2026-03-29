
#nullable enable

namespace Weave
{
    /// <summary>
    /// Logical AND. All conditions must evaluate to true.<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {<br/>
    ///         "$and": [<br/>
    ///             {"$eq": [{"$getField": "op_name"}, {"$literal": "predict"}]},<br/>
    ///             {"$gt": [{"$getField": "summary.usage.tokens"}, {"$literal": 1000}]}<br/>
    ///         ]<br/>
    ///     }<br/>
    ///     ```
    /// </summary>
    public sealed partial class AndOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$and")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>> x_and { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AndOperation" /> class.
        /// </summary>
        /// <param name="x_and"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AndOperation(
            global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>> x_and)
        {
            this.x_and = x_and ?? throw new global::System.ArgumentNullException(nameof(x_and));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AndOperation" /> class.
        /// </summary>
        public AndOperation()
        {
        }
    }
}