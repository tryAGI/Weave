
#nullable enable

namespace Weave
{
    /// <summary>
    /// Specification for the `$contains` operation.<br/>
    /// - `input`: The string to search.<br/>
    /// - `substr`: The substring to search for.<br/>
    /// - `case_insensitive`: If true, match is case-insensitive.
    /// </summary>
    public sealed partial class ContainsSpec
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
        [global::System.Text.Json.Serialization.JsonPropertyName("substr")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.AnyOfJsonConverter<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation> Substr { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("case_insensitive")]
        public bool? CaseInsensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsSpec" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="substr"></param>
        /// <param name="caseInsensitive">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainsSpec(
            global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation> input,
            global::Weave.AnyOf<global::Weave.LiteralOperation, global::Weave.GetFieldOperator, global::Weave.ConvertOperation, global::Weave.AndOperation, global::Weave.OrOperation, global::Weave.NotOperation, global::Weave.EqOperation, global::Weave.GtOperation, global::Weave.LtOperation, global::Weave.GteOperation, global::Weave.LteOperation, global::Weave.InOperation, global::Weave.ContainsOperation> substr,
            bool? caseInsensitive)
        {
            this.Input = input;
            this.Substr = substr;
            this.CaseInsensitive = caseInsensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsSpec" /> class.
        /// </summary>
        public ContainsSpec()
        {
        }
    }
}