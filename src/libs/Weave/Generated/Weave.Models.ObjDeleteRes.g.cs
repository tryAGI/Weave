
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjDeleteRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumDeleted { get; set; }

        /// <summary>
        /// Metadata for each deleted object version, with digest aliases resolved to content digests. None when the backing server does not report it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_versions")]
        public global::System.Collections.Generic.IList<global::Weave.DeletedObjVersion>? DeletedVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjDeleteRes" /> class.
        /// </summary>
        /// <param name="numDeleted"></param>
        /// <param name="deletedVersions">
        /// Metadata for each deleted object version, with digest aliases resolved to content digests. None when the backing server does not report it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjDeleteRes(
            int numDeleted,
            global::System.Collections.Generic.IList<global::Weave.DeletedObjVersion>? deletedVersions)
        {
            this.NumDeleted = numDeleted;
            this.DeletedVersions = deletedVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjDeleteRes" /> class.
        /// </summary>
        public ObjDeleteRes()
        {
        }

    }
}