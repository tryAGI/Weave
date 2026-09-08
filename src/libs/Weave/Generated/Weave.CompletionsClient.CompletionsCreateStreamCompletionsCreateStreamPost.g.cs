
#nullable enable

namespace Weave
{
    public partial class CompletionsClient
    {


        private static readonly global::Weave.EndPointSecurityRequirement s_CompletionsCreateStreamCompletionsCreateStreamPostSecurityRequirement0 =
            new global::Weave.EndPointSecurityRequirement
            {
                Authorizations = new global::Weave.EndPointAuthorizationRequirement[]
                {                    new global::Weave.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HTTPBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Weave.EndPointSecurityRequirement[] s_CompletionsCreateStreamCompletionsCreateStreamPostSecurityRequirements =
            new global::Weave.EndPointSecurityRequirement[]
            {                s_CompletionsCreateStreamCompletionsCreateStreamPostSecurityRequirement0,
            };
        partial void PrepareCompletionsCreateStreamCompletionsCreateStreamPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Weave.CompletionsCreateReq request);
        partial void PrepareCompletionsCreateStreamCompletionsCreateStreamPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Weave.CompletionsCreateReq request);
        partial void ProcessCompletionsCreateStreamCompletionsCreateStreamPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Completions Create Stream
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Weave.CompletionsCreateStreamChunk> CompletionsCreateStreamCompletionsCreateStreamPostAsync(

            global::Weave.CompletionsCreateReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCompletionsCreateStreamCompletionsCreateStreamPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Weave.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CompletionsCreateStreamCompletionsCreateStreamPostSecurityRequirements,
                operationName: "CompletionsCreateStreamCompletionsCreateStreamPostAsync");

            using var __timeoutCancellationTokenSource = global::Weave.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Weave.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Weave.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Weave.PathBuilder(
                                path: "/completions/create_stream",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Weave.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Weave.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCompletionsCreateStreamCompletionsCreateStreamPostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Weave.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Weave.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CompletionsCreateStreamCompletionsCreateStreamPost",
                                methodName: "CompletionsCreateStreamCompletionsCreateStreamPostAsync",
                                pathTemplate: "\"/completions/create_stream\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Weave.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Weave.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Weave.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CompletionsCreateStreamCompletionsCreateStreamPost",
                                methodName: "CompletionsCreateStreamCompletionsCreateStreamPostAsync",
                                pathTemplate: "\"/completions/create_stream\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Weave.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Weave.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Weave.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Weave.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Weave.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CompletionsCreateStreamCompletionsCreateStreamPost",
                                methodName: "CompletionsCreateStreamCompletionsCreateStreamPostAsync",
                                pathTemplate: "\"/completions/create_stream\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Weave.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCompletionsCreateStreamCompletionsCreateStreamPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Weave.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Weave.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CompletionsCreateStreamCompletionsCreateStreamPost",
                                methodName: "CompletionsCreateStreamCompletionsCreateStreamPostAsync",
                                pathTemplate: "\"/completions/create_stream\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Weave.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Weave.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CompletionsCreateStreamCompletionsCreateStreamPost",
                                methodName: "CompletionsCreateStreamCompletionsCreateStreamPostAsync",
                                pathTemplate: "\"/completions/create_stream\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
                            {
                                string? __content = null;
                                try
                                {
                                    __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);
                                }
                                catch (global::System.Exception)
                                {
                                }

                                throw global::Weave.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __ex,
                                    responseBody: __content,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            using var __reader = new global::System.IO.StreamReader(__stream);

                            while (!__reader.EndOfStream && !__effectiveCancellationToken.IsCancellationRequested)
                            {
                                var __content = await __reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                                if (global::System.String.IsNullOrWhiteSpace(__content))
                                {
                                    continue;
                                }

                                var __streamedResponse = global::Weave.CompletionsCreateStreamChunk.FromJson(__content, JsonSerializerContext) ??
                                                       throw global::Weave.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Completions Create Stream
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="inputs"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="trackLlmCall">
        /// Whether to track this LLM call in the trace server<br/>
        /// Default Value: true
        /// </param>
        /// <param name="traceId">
        /// Trace ID to use for the LLM call (for nesting under a parent)
        /// </param>
        /// <param name="parentId">
        /// Parent call ID to nest this LLM call under
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID to group related completions into a multi-turn conversation
        /// </param>
        /// <param name="conversationName">
        /// Human-readable conversation name
        /// </param>
        /// <param name="source">
        /// Source of the completion request (e.g. 'playground', 'signals')
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Weave.CompletionsCreateStreamChunk> CompletionsCreateStreamCompletionsCreateStreamPostAsync(
            string projectId,
            global::Weave.CompletionsCreateRequestInputs inputs,
            string? wbUserId = default,
            bool? trackLlmCall = default,
            string? traceId = default,
            string? parentId = default,
            string? conversationId = default,
            string? conversationName = default,
            string? source = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Weave.CompletionsCreateReq
            {
                ProjectId = projectId,
                Inputs = inputs,
                WbUserId = wbUserId,
                TrackLlmCall = trackLlmCall,
                TraceId = traceId,
                ParentId = parentId,
                ConversationId = conversationId,
                ConversationName = conversationName,
                Source = source,
            };

            var __enumerable = CompletionsCreateStreamCompletionsCreateStreamPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}