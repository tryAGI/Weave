
#nullable enable

namespace Weave
{
    /// <summary>
    /// Expiration timestamp for this call. None = no TTL configured for the project (the row will not be expired).
    /// </summary>
    public sealed partial class CallSchemaExpireAt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}