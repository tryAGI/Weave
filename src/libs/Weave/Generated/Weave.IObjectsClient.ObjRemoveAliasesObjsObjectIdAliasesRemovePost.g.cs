#nullable enable

namespace Weave
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Obj Remove Aliases<br/>
        /// Remove aliases from an object.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ObjRemoveAliasesRes> ObjRemoveAliasesObjsObjectIdAliasesRemovePostAsync(
            string objectId,

            global::Weave.ObjRemoveAliasesBody request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obj Remove Aliases<br/>
        /// Remove aliases from an object.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="projectId"></param>
        /// <param name="aliases"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ObjRemoveAliasesRes> ObjRemoveAliasesObjsObjectIdAliasesRemovePostAsync(
            string objectId,
            string projectId,
            global::System.Collections.Generic.IList<string> aliases,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}