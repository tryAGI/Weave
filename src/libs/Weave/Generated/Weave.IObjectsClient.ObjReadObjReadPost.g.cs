#nullable enable

namespace Weave
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Obj Read
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ObjReadRes> ObjReadObjReadPostAsync(

            global::Weave.ObjReadReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Obj Read
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="objectId"></param>
        /// <param name="digest"></param>
        /// <param name="metadataOnly">
        /// If true, the `val` column is not read from the database and is empty.All other fields are returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTagsAndAliases">
        /// If true, tags and aliases are fetched and included in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ObjReadRes> ObjReadObjReadPostAsync(
            string projectId,
            string objectId,
            string digest,
            bool? metadataOnly = default,
            bool? includeTagsAndAliases = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}