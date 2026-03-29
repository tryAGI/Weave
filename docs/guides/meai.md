# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Weave SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to W&B Weave's LLM observability with call tracing, object listing, table querying, and feedback management.

## Installation

```bash
dotnet add package tryAGI.Weave
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListCallsTool()` | `ListCalls` | List traced LLM calls/spans |
| `AsGetCallTool()` | `GetCall` | Get a specific traced call |
| `AsListObjectsTool()` | `ListObjects` | List tracked objects (models, datasets) |
| `AsQueryTableTool()` | `QueryTable` | Query rows from a table |
| `AsAddFeedbackTool()` | `AddFeedback` | Add feedback/score to a traced call |
| `AsGetCallStatsTool()` | `GetCallStats` | Get call statistics for a project |

## Usage

```csharp
using Microsoft.Extensions.AI;
using Weave;

var client = new WeaveClient(
    apiKey: Environment.GetEnvironmentVariable("WANDB_API_KEY")!);

var options = new ChatOptions
{
    Tools = [client.AsListCallsTool()],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "List the recent traced LLM calls in my project"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
