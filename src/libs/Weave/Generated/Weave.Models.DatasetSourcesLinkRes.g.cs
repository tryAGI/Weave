
#nullable enable

namespace Weave
{
    /// <summary>
    /// Response from linking dataset rows to sources.<br/>
    /// One entry per flattened (row_digest, source) tuple, in input order.
    /// </summary>
    public sealed partial class DatasetSourcesLinkRes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.DatasetSourcesLinkResEntry> Entries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSourcesLinkRes" /> class.
        /// </summary>
        /// <param name="entries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetSourcesLinkRes(
            global::System.Collections.Generic.IList<global::Weave.DatasetSourcesLinkResEntry> entries)
        {
            this.Entries = entries ?? throw new global::System.ArgumentNullException(nameof(entries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSourcesLinkRes" /> class.
        /// </summary>
        public DatasetSourcesLinkRes()
        {
        }

    }
}