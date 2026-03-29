#nullable enable

namespace Weave
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Table Update
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.TableUpdateRes> TableUpdateTableUpdatePostAsync(

            global::Weave.TableUpdateReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Table Update
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="baseDigest"></param>
        /// <param name="updates"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.TableUpdateRes> TableUpdateTableUpdatePostAsync(
            string projectId,
            string baseDigest,
            global::System.Collections.Generic.IList<global::Weave.AnyOf<global::Weave.TableAppendSpec, global::Weave.TablePopSpec, global::Weave.TableInsertSpec>> updates,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}