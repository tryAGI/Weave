/* order: 20, title: MEAI Tools, slug: meai-tools */

namespace Weave.IntegrationTests;

[TestClass]
public class MeaiTools
{
    //// Weave provides AIFunction tools for use with any IChatClient.
    //// These tools let AI agents inspect LLM traces, calls, and feedback.

    [TestMethod]
    public void CreateTools()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("WANDB_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("WANDB_API_KEY environment variable is not found.");

        using var client = new WeaveClient(apiKey);

        //// Create AIFunction tools for LLM observability.
        var listCallsTool = client.AsListCallsTool();
        Assert.IsNotNull(listCallsTool);

        var getCallTool = client.AsGetCallTool();
        Assert.IsNotNull(getCallTool);

        var listObjectsTool = client.AsListObjectsTool();
        Assert.IsNotNull(listObjectsTool);

        var queryTableTool = client.AsQueryTableTool();
        Assert.IsNotNull(queryTableTool);

        var addFeedbackTool = client.AsAddFeedbackTool();
        Assert.IsNotNull(addFeedbackTool);

        var getCallStatsTool = client.AsGetCallStatsTool();
        Assert.IsNotNull(getCallStatsTool);
    }
}
