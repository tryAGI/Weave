
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectTTLSettingsUpdateReq
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// None disables TTL; must be None or &gt;= 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_days")]
        public int? RetentionDays { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTTLSettingsUpdateReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="retentionDays">
        /// None disables TTL; must be None or &gt;= 1
        /// </param>
        /// <param name="wbUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectTTLSettingsUpdateReq(
            string projectId,
            int? retentionDays,
            string? wbUserId)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.RetentionDays = retentionDays;
            this.WbUserId = wbUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTTLSettingsUpdateReq" /> class.
        /// </summary>
        public ProjectTTLSettingsUpdateReq()
        {
        }

    }
}