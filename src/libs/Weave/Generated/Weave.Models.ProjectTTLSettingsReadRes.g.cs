
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectTTLSettingsReadRes
    {
        /// <summary>
        /// None = no TTL (infinite retention)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_days")]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTTLSettingsReadRes" /> class.
        /// </summary>
        /// <param name="retentionDays">
        /// None = no TTL (infinite retention)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectTTLSettingsReadRes(
            int? retentionDays)
        {
            this.RetentionDays = retentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTTLSettingsReadRes" /> class.
        /// </summary>
        public ProjectTTLSettingsReadRes()
        {
        }

    }
}