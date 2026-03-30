
#nullable enable

namespace Weave
{
    /// <summary>
    /// All pricing values are in USD per 1 token.<br/>
    /// Pricing fields are in string format to avoid floating point precision issues.
    /// </summary>
    public sealed partial class Pricing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Completion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_read")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputCacheRead { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pricing" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="completion"></param>
        /// <param name="image"></param>
        /// <param name="request"></param>
        /// <param name="inputCacheRead"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Pricing(
            string prompt,
            string completion,
            string image,
            string request,
            string inputCacheRead)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Completion = completion ?? throw new global::System.ArgumentNullException(nameof(completion));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.InputCacheRead = inputCacheRead ?? throw new global::System.ArgumentNullException(nameof(inputCacheRead));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pricing" /> class.
        /// </summary>
        public Pricing()
        {
        }
    }
}