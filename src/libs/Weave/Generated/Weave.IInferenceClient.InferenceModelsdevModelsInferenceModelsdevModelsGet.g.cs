#nullable enable

namespace Weave
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Inference Modelsdev Models<br/>
        /// Returns the available models in the models.dev `api.json` schema.<br/>
        /// This API is available without authentication.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::Weave.ModelsDevProvider>> InferenceModelsdevModelsInferenceModelsdevModelsGetAsync(
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inference Modelsdev Models<br/>
        /// Returns the available models in the models.dev `api.json` schema.<br/>
        /// This API is available without authentication.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::System.Collections.Generic.Dictionary<string, global::Weave.ModelsDevProvider>>> InferenceModelsdevModelsInferenceModelsdevModelsGetAsResponseAsync(
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}