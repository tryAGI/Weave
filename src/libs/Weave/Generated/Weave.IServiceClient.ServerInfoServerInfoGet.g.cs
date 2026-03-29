#nullable enable

namespace Weave
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Server Info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Weave.ServerInfoRes> ServerInfoServerInfoGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}