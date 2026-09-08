
#nullable enable

namespace Weave
{
    /// <summary>
    /// Response from the forward dataset -&gt; sources query.
    /// </summary>
    public sealed partial class DatasetSourcesQueryRes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.DatasetSourceLinkSchema> Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSourcesQueryRes" /> class.
        /// </summary>
        /// <param name="links"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetSourcesQueryRes(
            global::System.Collections.Generic.IList<global::Weave.DatasetSourceLinkSchema> links)
        {
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetSourcesQueryRes" /> class.
        /// </summary>
        public DatasetSourcesQueryRes()
        {
        }

    }
}