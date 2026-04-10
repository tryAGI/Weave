#nullable enable

namespace Weave
{
    public partial interface IPredictionsClient
    {
        /// <summary>
        /// Prediction Read<br/>
        /// Read a prediction.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="predictionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.PredictionReadRes> PredictionReadV2EntityProjectPredictionsPredictionIdGetAsync(
            string entity,
            string project,
            string predictionId,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}