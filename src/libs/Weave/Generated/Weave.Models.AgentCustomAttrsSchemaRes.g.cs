
#nullable enable

namespace Weave
{
    /// <summary>
    /// Typed custom attribute keys available for spans query/group/stats APIs.
    /// </summary>
    public sealed partial class AgentCustomAttrsSchemaRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::Weave.AgentCustomAttrSchemaItem>? Attributes { get; set; }

        /// <summary>
        /// Default Value: 200
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCustomAttrsSchemaRes" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="limit">
        /// Default Value: 200
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="hasMore">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCustomAttrsSchemaRes(
            global::System.Collections.Generic.IList<global::Weave.AgentCustomAttrSchemaItem>? attributes,
            int? limit,
            int? offset,
            bool? hasMore)
        {
            this.Attributes = attributes;
            this.Limit = limit;
            this.Offset = offset;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCustomAttrsSchemaRes" /> class.
        /// </summary>
        public AgentCustomAttrsSchemaRes()
        {
        }

    }
}