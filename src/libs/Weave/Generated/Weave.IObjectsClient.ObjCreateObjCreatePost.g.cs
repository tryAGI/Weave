#nullable enable

namespace Weave
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Obj Create
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ObjCreateRes> ObjCreateObjCreatePostAsync(

            global::Weave.ObjCreateReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obj Create
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ObjCreateRes> ObjCreateObjCreatePostAsync(
            global::Weave.ObjSchemaForInsert obj,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}