
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAndLinkWeaveAssetRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_index")]
        public int? VersionIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAndLinkWeaveAssetRes" /> class.
        /// </summary>
        /// <param name="versionIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAndLinkWeaveAssetRes(
            int? versionIndex)
        {
            this.VersionIndex = versionIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAndLinkWeaveAssetRes" /> class.
        /// </summary>
        public CreateAndLinkWeaveAssetRes()
        {
        }
    }
}