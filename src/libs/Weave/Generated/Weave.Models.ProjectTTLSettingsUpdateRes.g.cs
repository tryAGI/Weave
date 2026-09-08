
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectTTLSettingsUpdateRes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_days")]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTTLSettingsUpdateRes" /> class.
        /// </summary>
        /// <param name="retentionDays"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectTTLSettingsUpdateRes(
            int? retentionDays)
        {
            this.RetentionDays = retentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTTLSettingsUpdateRes" /> class.
        /// </summary>
        public ProjectTTLSettingsUpdateRes()
        {
        }

    }
}