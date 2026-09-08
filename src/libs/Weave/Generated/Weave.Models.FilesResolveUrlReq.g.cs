
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FilesResolveUrlReq
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uris")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Uris { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesResolveUrlReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="uris"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilesResolveUrlReq(
            string projectId,
            global::System.Collections.Generic.IList<string> uris)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Uris = uris ?? throw new global::System.ArgumentNullException(nameof(uris));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesResolveUrlReq" /> class.
        /// </summary>
        public FilesResolveUrlReq()
        {
        }

    }
}