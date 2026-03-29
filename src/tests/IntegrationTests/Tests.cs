namespace Weave.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static WeaveClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("WEAVE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("WEAVE_API_KEY environment variable is not found.");

        var client = new WeaveClient(apiKey);
        
        return client;
    }
}
