
#nullable enable

namespace Weave
{
    /// <summary>
    /// A provider entry in the models.dev schema.
    /// </summary>
    public sealed partial class ModelsDevProvider
    {
        /// <summary>
        /// Provider identifier, derived from the folder name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name of the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// AI SDK package name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("npm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Npm { get; set; }

        /// <summary>
        /// Environment variable keys for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>
        /// Link to provider documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Doc { get; set; }

        /// <summary>
        /// OpenAI-compatible API endpoint. Required only when using @ai-sdk/openai-compatible.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api")]
        public string? Api { get; set; }

        /// <summary>
        /// Mapping of model id -&gt; model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.Dictionary<string, global::Weave.ModelsDevModel>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsDevProvider" /> class.
        /// </summary>
        /// <param name="id">
        /// Provider identifier, derived from the folder name.
        /// </param>
        /// <param name="name">
        /// Display name of the provider.
        /// </param>
        /// <param name="npm">
        /// AI SDK package name.
        /// </param>
        /// <param name="env">
        /// Environment variable keys for authentication.
        /// </param>
        /// <param name="doc">
        /// Link to provider documentation.
        /// </param>
        /// <param name="api">
        /// OpenAI-compatible API endpoint. Required only when using @ai-sdk/openai-compatible.
        /// </param>
        /// <param name="models">
        /// Mapping of model id -&gt; model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsDevProvider(
            string id,
            string name,
            string npm,
            global::System.Collections.Generic.IList<string> env,
            string doc,
            string? api,
            global::System.Collections.Generic.Dictionary<string, global::Weave.ModelsDevModel>? models)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Npm = npm ?? throw new global::System.ArgumentNullException(nameof(npm));
            this.Env = env ?? throw new global::System.ArgumentNullException(nameof(env));
            this.Doc = doc ?? throw new global::System.ArgumentNullException(nameof(doc));
            this.Api = api;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsDevProvider" /> class.
        /// </summary>
        public ModelsDevProvider()
        {
        }

    }
}