
#nullable enable

namespace Weave
{
    public partial class FeedbackClient
    {


        private static readonly global::Weave.EndPointSecurityRequirement s_FeedbackReplaceFeedbackReplacePostSecurityRequirement0 =
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
        private static readonly global::Weave.EndPointSecurityRequirement[] s_FeedbackReplaceFeedbackReplacePostSecurityRequirements =
            new global::Weave.EndPointSecurityRequirement[]
            {                s_FeedbackReplaceFeedbackReplacePostSecurityRequirement0,
            };
        partial void PrepareFeedbackReplaceFeedbackReplacePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Weave.FeedbackReplaceReq request);
        partial void PrepareFeedbackReplaceFeedbackReplacePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Weave.FeedbackReplaceReq request);
        partial void ProcessFeedbackReplaceFeedbackReplacePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFeedbackReplaceFeedbackReplacePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Feedback Replace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Weave.FeedbackReplaceRes> FeedbackReplaceFeedbackReplacePostAsync(

            global::Weave.FeedbackReplaceReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await FeedbackReplaceFeedbackReplacePostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Feedback Replace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Weave.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Weave.AutoSDKHttpResponse<global::Weave.FeedbackReplaceRes>> FeedbackReplaceFeedbackReplacePostAsResponseAsync(

            global::Weave.FeedbackReplaceReq request,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareFeedbackReplaceFeedbackReplacePostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Weave.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_FeedbackReplaceFeedbackReplacePostSecurityRequirements,
                operationName: "FeedbackReplaceFeedbackReplacePostAsync");

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
                                path: "/feedback/replace",
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
                PrepareFeedbackReplaceFeedbackReplacePostRequest(
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
                                operationId: "FeedbackReplaceFeedbackReplacePost",
                                methodName: "FeedbackReplaceFeedbackReplacePostAsync",
                                pathTemplate: "\"/feedback/replace\"",
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
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
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
                                operationId: "FeedbackReplaceFeedbackReplacePost",
                                methodName: "FeedbackReplaceFeedbackReplacePostAsync",
                                pathTemplate: "\"/feedback/replace\"",
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
                                operationId: "FeedbackReplaceFeedbackReplacePost",
                                methodName: "FeedbackReplaceFeedbackReplacePostAsync",
                                pathTemplate: "\"/feedback/replace\"",
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
                ProcessFeedbackReplaceFeedbackReplacePostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Weave.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Weave.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "FeedbackReplaceFeedbackReplacePost",
                                methodName: "FeedbackReplaceFeedbackReplacePostAsync",
                                pathTemplate: "\"/feedback/replace\"",
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
                                operationId: "FeedbackReplaceFeedbackReplacePost",
                                methodName: "FeedbackReplaceFeedbackReplacePostAsync",
                                pathTemplate: "\"/feedback/replace\"",
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
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Weave.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Weave.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Weave.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Weave.ApiException<global::Weave.HTTPValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessFeedbackReplaceFeedbackReplacePostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Weave.FeedbackReplaceRes.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Weave.AutoSDKHttpResponse<global::Weave.FeedbackReplaceRes>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Weave.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
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
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Weave.FeedbackReplaceRes.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Weave.AutoSDKHttpResponse<global::Weave.FeedbackReplaceRes>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Weave.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
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
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Feedback Replace
        /// </summary>
        /// <param name="id">
        /// If provided by the client, this ID will be used for the feedback row instead of a server-generated one.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="weaveRef"></param>
        /// <param name="creator"></param>
        /// <param name="feedbackType"></param>
        /// <param name="payload"></param>
        /// <param name="annotationRef"></param>
        /// <param name="runnableRef"></param>
        /// <param name="callRef"></param>
        /// <param name="triggerRef"></param>
        /// <param name="queueId">
        /// The annotation queue ID this feedback was created from. References annotation_queues.id. NULL when feedback is created outside of queues.
        /// </param>
        /// <param name="scorerTags">
        /// Tags applied to the ref by a scorer
        /// </param>
        /// <param name="scorerTagReasons">
        /// reason text per tag, keyed by tag name
        /// </param>
        /// <param name="scorerTagConfidences">
        /// confidence (0-1) per tag, keyed by tag name
        /// </param>
        /// <param name="scorerRatings">
        /// numeric ratings (0-1) keyed by rating name
        /// </param>
        /// <param name="scorerRatingReasons">
        /// reason text per rating, keyed by rating name
        /// </param>
        /// <param name="scorerRatingConfidences">
        /// confidence (0-1) per rating, keyed by rating name
        /// </param>
        /// <param name="spanAgentName">
        /// Display name of the scored agent (from spans.agent_name)
        /// </param>
        /// <param name="spanAgentVersion">
        /// Version of the scored agent (from spans.agent_version)
        /// </param>
        /// <param name="spanStatusCode">
        /// Status of the scored turn (from spans.status_code)<br/>
        /// Default Value: UNSET
        /// </param>
        /// <param name="spanConversationId">
        /// Conversation the feedback belongs to (from spans.conversation_id)
        /// </param>
        /// <param name="spanTraceId">
        /// Turn the feedback belongs to (from spans.trace_id)
        /// </param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="feedbackId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Weave.FeedbackReplaceRes> FeedbackReplaceFeedbackReplacePostAsync(
            string projectId,
            string weaveRef,
            string feedbackType,
            object payload,
            string feedbackId,
            string? id = default,
            string? creator = default,
            string? annotationRef = default,
            string? runnableRef = default,
            string? callRef = default,
            string? triggerRef = default,
            string? queueId = default,
            global::System.Collections.Generic.IList<string>? scorerTags = default,
            global::System.Collections.Generic.Dictionary<string, string>? scorerTagReasons = default,
            global::System.Collections.Generic.Dictionary<string, double>? scorerTagConfidences = default,
            global::System.Collections.Generic.Dictionary<string, double>? scorerRatings = default,
            global::System.Collections.Generic.Dictionary<string, string>? scorerRatingReasons = default,
            global::System.Collections.Generic.Dictionary<string, double>? scorerRatingConfidences = default,
            string? spanAgentName = default,
            string? spanAgentVersion = default,
            string? spanStatusCode = default,
            string? spanConversationId = default,
            string? spanTraceId = default,
            string? wbUserId = default,
            global::Weave.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Weave.FeedbackReplaceReq
            {
                Id = id,
                ProjectId = projectId,
                WeaveRef = weaveRef,
                Creator = creator,
                FeedbackType = feedbackType,
                Payload = payload,
                AnnotationRef = annotationRef,
                RunnableRef = runnableRef,
                CallRef = callRef,
                TriggerRef = triggerRef,
                QueueId = queueId,
                ScorerTags = scorerTags,
                ScorerTagReasons = scorerTagReasons,
                ScorerTagConfidences = scorerTagConfidences,
                ScorerRatings = scorerRatings,
                ScorerRatingReasons = scorerRatingReasons,
                ScorerRatingConfidences = scorerRatingConfidences,
                SpanAgentName = spanAgentName,
                SpanAgentVersion = spanAgentVersion,
                SpanStatusCode = spanStatusCode,
                SpanConversationId = spanConversationId,
                SpanTraceId = spanTraceId,
                WbUserId = wbUserId,
                FeedbackId = feedbackId,
            };

            return await FeedbackReplaceFeedbackReplacePostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}