
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableCreateReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.TableSchemaForInsert Table { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableCreateReq" /> class.
        /// </summary>
        /// <param name="table"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableCreateReq(
            global::Weave.TableSchemaForInsert table)
        {
            this.Table = table ?? throw new global::System.ArgumentNullException(nameof(table));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableCreateReq" /> class.
        /// </summary>
        public TableCreateReq()
        {
        }
    }
}