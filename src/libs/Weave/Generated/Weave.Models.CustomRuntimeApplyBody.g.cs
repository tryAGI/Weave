
#nullable enable

namespace Weave
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomRuntimeApplyBody
    {
        /// <summary>
        /// Public OpenAI-compatible endpoint base URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

        /// <summary>
        /// Team secret name used as the endpoint API key; never the secret value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_secret")]
        public string? ApiKeySecret { get; set; }

        /// <summary>
        /// Literal headers forwarded to the endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Complete desired list of IDs exposed by the endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weave.CustomRuntimeID> RuntimeIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRuntimeApplyBody" /> class.
        /// </summary>
        /// <param name="baseUrl">
        /// Public OpenAI-compatible endpoint base URL
        /// </param>
        /// <param name="runtimeIds">
        /// Complete desired list of IDs exposed by the endpoint
        /// </param>
        /// <param name="apiKeySecret">
        /// Team secret name used as the endpoint API key; never the secret value
        /// </param>
        /// <param name="headers">
        /// Literal headers forwarded to the endpoint
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomRuntimeApplyBody(
            string baseUrl,
            global::System.Collections.Generic.IList<global::Weave.CustomRuntimeID> runtimeIds,
            string? apiKeySecret,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
            this.ApiKeySecret = apiKeySecret;
            this.Headers = headers;
            this.RuntimeIds = runtimeIds ?? throw new global::System.ArgumentNullException(nameof(runtimeIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRuntimeApplyBody" /> class.
        /// </summary>
        public CustomRuntimeApplyBody()
        {
        }

    }
}