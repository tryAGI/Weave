
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomRuntimeApplyRes
    {
        /// <summary>
        /// Stable custom runtime name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_secret")]
        public string? ApiKeySecret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Headers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.CustomRuntimeIDRes> RuntimeIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRuntimeApplyRes" /> class.
        /// </summary>
        /// <param name="name">
        /// Stable custom runtime name
        /// </param>
        /// <param name="baseUrl"></param>
        /// <param name="headers"></param>
        /// <param name="runtimeIds"></param>
        /// <param name="apiKeySecret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomRuntimeApplyRes(
            string name,
            string baseUrl,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            global::System.Collections.Generic.IList<global::Weave.CustomRuntimeIDRes> runtimeIds,
            string? apiKeySecret)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
            this.ApiKeySecret = apiKeySecret;
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.RuntimeIds = runtimeIds ?? throw new global::System.ArgumentNullException(nameof(runtimeIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRuntimeApplyRes" /> class.
        /// </summary>
        public CustomRuntimeApplyRes()
        {
        }

    }
}