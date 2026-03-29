#nullable enable

namespace Weave
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Image Create
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ImageGenerationCreateRes> ImageCreateImageCreatePostAsync(

            global::Weave.ImageGenerationCreateReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Create
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="inputs"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="trackLlmCall">
        /// Whether to track this image generation call in the trace server<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ImageGenerationCreateRes> ImageCreateImageCreatePostAsync(
            string projectId,
            global::Weave.ImageGenerationRequestInputs inputs,
            string? wbUserId = default,
            bool? trackLlmCall = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}