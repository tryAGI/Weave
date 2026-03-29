dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.json https://trace.wandb.ai/openapi.json

# Fix the spec:
# 1. Replace per-operation HTTPBasic security with HTTPBearer
# 2. Add top-level security array
# 3. Add servers array with base URL
# 4. Fix title from generic "FastAPI" to "Weave"
jq '
  # Fix title
  .info.title = "Weave" |
  .info.description = "W&B Weave API for LLM observability, tracing, evaluations, and datasets" |

  # Replace security schemes: remove HTTPBasic, keep/add HTTPBearer
  .components.securitySchemes = {
    "HTTPBearer": {
      "type": "http",
      "scheme": "bearer"
    }
  } |

  # Add top-level security
  .security = [{"HTTPBearer": []}] |

  # Add servers
  .servers = [{"url": "https://trace.wandb.ai"}] |

  # Remove per-operation security (top-level will apply)
  (.paths[][] | objects) |= del(.security)
' openapi.json > openapi.fixed.json

mv openapi.fixed.json openapi.json

autosdk generate openapi.json \
  --namespace Weave \
  --clientClassName WeaveClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
