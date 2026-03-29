
#nullable enable

namespace Weave
{
    public sealed partial class WeaveClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Weave.EndPointAuthorization
            {
                Type = "Http",
                Location = "Header",
                Name = "Bearer",
                Value = apiKey,
            });
        }
    }
}