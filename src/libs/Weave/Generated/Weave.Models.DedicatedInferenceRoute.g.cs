
#nullable enable

namespace Weave
{
    /// <summary>
    /// Server-side routing information for a dedicated inference deployment.
    /// </summary>
    public sealed partial class DedicatedInferenceRoute
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"dedicated"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_type")]
        public string ConnectionType { get; set; } = "dedicated";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Connection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DedicatedInferenceRoute" /> class.
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="baseUrl"></param>
        /// <param name="connectionType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DedicatedInferenceRoute(
            string connection,
            string baseUrl,
            string connectionType = "dedicated")
        {
            this.ConnectionType = connectionType;
            this.Connection = connection ?? throw new global::System.ArgumentNullException(nameof(connection));
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DedicatedInferenceRoute" /> class.
        /// </summary>
        public DedicatedInferenceRoute()
        {
        }

    }
}