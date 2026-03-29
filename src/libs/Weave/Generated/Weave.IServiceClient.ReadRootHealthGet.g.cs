#nullable enable

namespace Weave
{
    public partial interface IServiceClient
    {
        /// <summary>
        /// Read Root
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ReadRootHealthGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}