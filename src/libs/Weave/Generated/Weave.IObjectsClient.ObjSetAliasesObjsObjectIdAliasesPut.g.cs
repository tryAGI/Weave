#nullable enable

namespace Weave
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Obj Set Aliases<br/>
        /// Set aliases for an object version.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ObjSetAliasesRes> ObjSetAliasesObjsObjectIdAliasesPutAsync(
            string objectId,

            global::Weave.ObjSetAliasesBody request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obj Set Aliases<br/>
        /// Set aliases for an object version.
        /// </summary>
        /// <param name="objectId"></param>
        /// <param name="projectId"></param>
        /// <param name="digest"></param>
        /// <param name="aliases"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ObjSetAliasesRes> ObjSetAliasesObjsObjectIdAliasesPutAsync(
            string objectId,
            string projectId,
            string digest,
            global::System.Collections.Generic.IList<string> aliases,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}