
#nullable enable

namespace Weave
{
    /// <summary>
    /// Logical OR. At least one condition must be true.<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {<br/>
    ///         "$or": [<br/>
    ///             {"$eq": [{"$getField": "op_name"}, {"$literal": "a"}]},<br/>
    ///             {"$eq": [{"$getField": "op_name"}, {"$literal": "b"}]}<br/>
    ///         ]<br/>
    ///     }<br/>
    ///     ```
    /// </summary>
    public sealed partial class OrOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$or")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>> x_or { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrOperation" /> class.
        /// </summary>
        /// <param name="x_or"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrOperation(
            global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>> x_or)
        {
            this.x_or = x_or ?? throw new global::System.ArgumentNullException(nameof(x_or));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrOperation" /> class.
        /// </summary>
        public OrOperation()
        {
        }
    }
}