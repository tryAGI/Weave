
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAndLinkPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weave.CreateAndLinkTarget Target { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAndLinkPayload" /> class.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="target"></param>
        /// <param name="aliases">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAndLinkPayload(
            string @ref,
            global::Weave.CreateAndLinkTarget target,
            global::System.Collections.Generic.IList<string>? aliases)
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Aliases = aliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAndLinkPayload" /> class.
        /// </summary>
        public CreateAndLinkPayload()
        {
        }
    }
}