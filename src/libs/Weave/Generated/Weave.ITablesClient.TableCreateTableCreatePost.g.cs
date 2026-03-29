#nullable enable

namespace Weave
{
    public partial interface ITablesClient
    {
        /// <summary>
        /// Table Create
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.TableCreateRes> TableCreateTableCreatePostAsync(

            global::Weave.TableCreateReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Table Create
        /// </summary>
        /// <param name="table"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.TableCreateRes> TableCreateTableCreatePostAsync(
            global::Weave.TableSchemaForInsert table,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}