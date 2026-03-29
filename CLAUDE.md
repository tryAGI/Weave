# CLAUDE.md — Weave SDK

## Overview

Auto-generated C# SDK for [W&B Weave](https://wandb.ai/site/weave) — LLM observability platform with tracing, evaluations, datasets, and feedback.
OpenAPI spec from `https://trace.wandb.ai/openapi.json` (FastAPI auto-generated, fixed with jq).

## Build & Test

```bash
dotnet build Weave.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

HTTP Bearer token (W&B API key):

```csharp
var client = new WeaveClient(apiKey);
```

## Key Files

- `src/libs/Weave/openapi.json` — Fixed OpenAPI spec (from trace.wandb.ai)
- `src/libs/Weave/generate.sh` — Downloads spec, fixes auth/servers/title with jq, runs autosdk
- `src/libs/Weave/Generated/` — **Never edit** — auto-generated code
- `src/libs/Weave/Extensions/WeaveClient.Tools.cs` — MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` — Example tests

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsListCallsTool()` — List traced calls/spans with filtering
- `AsGetCallTool()` — Get call details by ID
- `AsListObjectsTool()` — List tracked objects in a project
- `AsQueryTableTool()` — Query a Weave table
- `AsAddFeedbackTool()` — Add feedback/score to a traced call
- `AsGetCallStatsTool()` — Get call statistics for a project

## Spec Notes

- Base URL: `https://trace.wandb.ai`
- Spec fixes: Replace HTTPBasic with HTTPBearer, add top-level security/servers, fix title
- FastAPI auto-generated spec (OpenAPI 3.1.0)
