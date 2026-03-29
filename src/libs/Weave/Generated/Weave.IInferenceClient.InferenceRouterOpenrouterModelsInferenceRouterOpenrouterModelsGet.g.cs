#nullable enable

namespace Weave
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Inference Router Openrouter Models<br/>
        /// Returns a list of models that are available to be used with OpenRouter.<br/>
        /// This API is available without authentication.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.RouterOpenRouterModelsRes> InferenceRouterOpenrouterModelsInferenceRouterOpenrouterModelsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}