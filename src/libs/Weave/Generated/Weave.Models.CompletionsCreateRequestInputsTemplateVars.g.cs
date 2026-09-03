
#nullable enable

namespace Weave
{
    /// <summary>
    /// Dictionary of template variables to substitute in prompt messages. Variables in messages like '{variable_name}' will be replaced with the corresponding values. Applied to both prompt messages (if prompt is provided) and regular messages.
    /// </summary>
    public sealed partial class CompletionsCreateRequestInputsTemplateVars
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}