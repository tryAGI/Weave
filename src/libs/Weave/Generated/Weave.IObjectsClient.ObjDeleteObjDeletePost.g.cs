#nullable enable

namespace Weave
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Obj Delete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ObjDeleteRes> ObjDeleteObjDeletePostAsync(

            global::Weave.ObjDeleteReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obj Delete
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="objectId"></param>
        /// <param name="digests">
        /// List of digests to delete. If not provided, all digests for the object will be deleted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ObjDeleteRes> ObjDeleteObjDeletePostAsync(
            string projectId,
            string objectId,
            global::System.Collections.Generic.IList<string>? digests = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}