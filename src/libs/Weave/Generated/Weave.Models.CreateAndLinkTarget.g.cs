
#nullable enable

namespace Weave
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAndLinkTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("portfolio_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PortfolioName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAndLinkTarget" /> class.
        /// </summary>
        /// <param name="portfolioName"></param>
        /// <param name="entityName"></param>
        /// <param name="projectName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAndLinkTarget(
            string portfolioName,
            string entityName,
            string projectName)
        {
            this.PortfolioName = portfolioName ?? throw new global::System.ArgumentNullException(nameof(portfolioName));
            this.EntityName = entityName ?? throw new global::System.ArgumentNullException(nameof(entityName));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAndLinkTarget" /> class.
        /// </summary>
        public CreateAndLinkTarget()
        {
        }
    }
}