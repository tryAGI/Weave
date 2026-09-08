
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectIngestSamplingSettingsReadRes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SampleRate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dry_run")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DryRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectIngestSamplingSettingsReadRes" /> class.
        /// </summary>
        /// <param name="sampleRate"></param>
        /// <param name="dryRun"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectIngestSamplingSettingsReadRes(
            double sampleRate,
            bool dryRun)
        {
            this.SampleRate = sampleRate;
            this.DryRun = dryRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectIngestSamplingSettingsReadRes" /> class.
        /// </summary>
        public ProjectIngestSamplingSettingsReadRes()
        {
        }

    }
}