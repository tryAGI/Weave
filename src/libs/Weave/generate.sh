install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.json https://trace.wandb.ai/openapi.json

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
  --auth-env-var WEAVE_API_KEY \
  --auth-env-var WANDB_API_KEY \
  --generate-prompt-template-helpers \
  --generate-observability-lifecycle-helpers \
  --generate-evaluation-workflow-helpers \
  --exclude-deprecated-operations
