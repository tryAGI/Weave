
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeletedObjVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_object_class")]
        public string? BaseObjectClass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaf_object_class")]
        public string? LeafObjectClass { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedObjVersion" /> class.
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="baseObjectClass"></param>
        /// <param name="leafObjectClass"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedObjVersion(
            string digest,
            string? baseObjectClass,
            string? leafObjectClass)
        {
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.BaseObjectClass = baseObjectClass;
            this.LeafObjectClass = leafObjectClass;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedObjVersion" /> class.
        /// </summary>
        public DeletedObjVersion()
        {
        }

    }
}