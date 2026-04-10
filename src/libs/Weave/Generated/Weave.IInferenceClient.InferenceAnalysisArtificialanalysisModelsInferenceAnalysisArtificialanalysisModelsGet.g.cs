#nullable enable

namespace Weave
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Inference Analysis Artificialanalysis Models<br/>
        /// Returns a list of available models for Artificial Analysis.<br/>
        /// This API is available without authentication.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.RouterOpenRouterModelsRes> InferenceAnalysisArtificialanalysisModelsInferenceAnalysisArtificialanalysisModelsGetAsync(
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}