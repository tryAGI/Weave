
#nullable enable

namespace Weave
{
    /// <summary>
    /// Specifies conversion details for `$convert`.<br/>
    /// - `input`: The operand to convert.<br/>
    /// - `to`: The type to convert to.
    /// </summary>
    public sealed partial class ConvertSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation> Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.ConvertSpecToJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.ConvertSpecTo To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertSpec" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="to"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvertSpec(
            global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation> input,
            global::Weave.ConvertSpecTo to)
        {
            this.Input = input;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertSpec" /> class.
        /// </summary>
        public ConvertSpec()
        {
        }
    }
}