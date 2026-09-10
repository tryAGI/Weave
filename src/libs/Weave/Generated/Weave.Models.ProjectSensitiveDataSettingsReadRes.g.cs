
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectSensitiveDataSettingsReadRes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weave.JsonConverters.SensitiveDataPolicyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.SensitiveDataPolicy Policy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSensitiveDataSettingsReadRes" /> class.
        /// </summary>
        /// <param name="policy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSensitiveDataSettingsReadRes(
            global::Weave.SensitiveDataPolicy policy)
        {
            this.Policy = policy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSensitiveDataSettingsReadRes" /> class.
        /// </summary>
        public ProjectSensitiveDataSettingsReadRes()
        {
        }

    }
}