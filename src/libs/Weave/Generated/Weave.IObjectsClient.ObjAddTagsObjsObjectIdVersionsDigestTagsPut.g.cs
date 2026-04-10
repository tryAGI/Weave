#nullable enable

namespace Weave
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Obj Add Tags<br/>
        /// Add tags to an object version.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="digest"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ObjAddTagsRes> ObjAddTagsObjsObjectIdVersionsDigestTagsPutAsync(
            string objectId,
            string digest,

            global::Weave.ObjTagsBody request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obj Add Tags<br/>
        /// Add tags to an object version.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="digest"></param>
        /// <param name="projectId"></param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ObjAddTagsRes> ObjAddTagsObjsObjectIdVersionsDigestTagsPutAsync(
            string objectId,
            string digest,
            string projectId,
            global::System.Collections.Generic.IList<string> tags,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}