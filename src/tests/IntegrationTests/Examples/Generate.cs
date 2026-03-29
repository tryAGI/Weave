/* order: 10, title: Tracing, slug: tracing */

namespace Weave.IntegrationTests.Examples;

[TestClass]
public class Tracing
{
    //// W&B Weave provides LLM observability with tracing, evaluations, and feedback.
    //// Create a client and access the trace API.

    [TestMethod]
    public void CreateClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("WANDB_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("WANDB_API_KEY environment variable is not found.");

        using var client = new WeaveClient(apiKey);

        //// The client provides access to all Weave API endpoints.
        Assert.IsNotNull(client);
    }
}
