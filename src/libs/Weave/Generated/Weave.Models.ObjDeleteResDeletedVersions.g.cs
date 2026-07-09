
#nullable enable

namespace Weave
{
    /// <summary>
    /// Metadata for each deleted object version, with digest aliases resolved to content digests. None when the backing server does not report it.
    /// </summary>
    public sealed partial class ObjDeleteResDeletedVersions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}