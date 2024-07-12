/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net.Http;
using System;
using System.Net;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using FoxentrySdk.Models;
using FoxentrySdk.Core;

namespace FoxentrySdk.Services;


public class EmailService
{
    public IHttpRequest HttpRequest { get; }

    public EmailService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Validate email
     * This endpoint will let you check if the e-mail address sent in query is valid.<br><br> Please pay attention to the <b>validationType</b> option since it has direct impact on the returned data. <b>Extended validation</b> (default) is the more advanced type that checks the real existence of the e-mail address and its deliverability. It also informs you about various flags such as <b>freemail and disposable mail</b> detection. <br><br> Foxentry validator is able not only to evaluate the validity of the inputed information but it also can fix various typos, errors and missing data. Foxentry can also suggest more suitable alternatives to the data sent in query. Please pay attention to the <b>result</b>, <b>resultCorrected</b> and <b>suggestions</b> in the response.<br><br> Always check <b>result.proposal</b> in the response for a proposed solution by Foxentry how you should process the response in your form or application.
     * @param requestBody
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @returns Task<ValidateEmailResp?> Successful response
     * @throws ApiError
     */
    public async Task<ValidateEmailResponse> ValidateEmail(
      ValidateEmailRequestBody? requestBody,
      bool? foxentryIncludeRequestDetails = false
    )
    {
        var headers = new Dictionary<string, string>();
        if (foxentryIncludeRequestDetails != null)
        {
            headers.Add("foxentry-include-request-details", foxentryIncludeRequestDetails.Value.ToString());
        }
        var result = await this.HttpRequest.Request<ValidateEmailResp?>(
          new ApiRequestOptions
          {
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/email/validate"
          }
        );

        return new ValidateEmailResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new ValidateEmailResponse.ValidateEmailHeaders
            {
                FoxentryApiVersion = result.RawHeaders?["foxentry-api-version"],
                FoxentryDailyCreditsLeft = Utils.ParseDouble(result.RawHeaders?["foxentry-daily-credits-left"]),
                FoxentryDailyCreditsLimit = Utils.ParseDouble(result.RawHeaders?["foxentry-daily-credits-limit"]),
                FoxentryRateLimit = int.TryParse(result.RawHeaders?["foxentry-rate-limit"], out int foxentryRateLimit) ? foxentryRateLimit : default,
                FoxentryRateLimitPeriod = int.TryParse(result.RawHeaders?["foxentry-rate-limit-period"], out int foxentryRateLimitPeriod) ? foxentryRateLimitPeriod : default,
                FoxentryRateLimitRemaining = int.TryParse(result.RawHeaders?["foxentry-rate-limit-remaining"], out int foxentryRateLimitRemaining) ? foxentryRateLimitRemaining : default,
            }
        };
    }

    public class ValidateEmailResponse
    {
        public ValidateEmailResp? Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required ValidateEmailHeaders Headers { get; init; }

        public class ValidateEmailHeaders
        {
            public string? FoxentryApiVersion { get; set; }
            public double? FoxentryDailyCreditsLeft { get; set; }
            public double? FoxentryDailyCreditsLimit { get; set; }
            public int? FoxentryRateLimit { get; set; }
            public int? FoxentryRateLimitPeriod { get; set; }
            public int? FoxentryRateLimitRemaining { get; set; }
        }
    }
    /**
   * Successful response
   */
    public class ValidateEmailResp
    {
        [JsonPropertyName("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required ValidateEmailRespRequest Request { get; init; }
        [JsonPropertyName("response")]
        [Newtonsoft.Json.JsonProperty("response")]
        public required ValidateEmailResponse Response { get; init; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public required IEnumerable<ValidateEmailRespErrors?> Errors { get; init; }
        public class ValidateEmailRespRequest : GlobalRequest
        {
            [JsonPropertyName("query")]
            [Newtonsoft.Json.JsonProperty("query")]
            public ValidateEmailRespRequestQuery? Query { get; set; }

            [JsonPropertyName("options")]
            [Newtonsoft.Json.JsonProperty("options")]
            public ValidateEmailRespRequestOptions? Options { get; set; }

            [JsonPropertyName("client")]
            [Newtonsoft.Json.JsonProperty("client")]
            public ClientRequest? Client { get; set; }

            [JsonPropertyName("endpoint")]
            [Newtonsoft.Json.JsonProperty("endpoint")]
            public required override string Endpoint { get; init; }

            public class ValidateEmailRespRequestQuery
            {
                [JsonPropertyName("email")]
                [Newtonsoft.Json.JsonProperty("email")]
                public required string Email { get; init; }
            }
            /**
             * Query options.
             */
            public class ValidateEmailRespRequestOptions
            {
                [JsonPropertyName("validationType")]
                [Newtonsoft.Json.JsonProperty("validationType")]
                public ValidateEmailRespRequestOptionsValidationType? ValidationType { get; set; }
                [JsonPropertyName("acceptDisposableEmails")]
                [Newtonsoft.Json.JsonProperty("acceptDisposableEmails")]
                public bool? AcceptDisposableEmails { get; set; }
                [JsonPropertyName("acceptFreemails")]
                [Newtonsoft.Json.JsonProperty("acceptFreemails")]
                public bool? AcceptFreemails { get; set; }
                /**
                 * Type of validation. <b>Basic</b> = only the format of e-mail is checked and only standard corrections are included. <b>Extended</b> = in depth check of deliverability. Additional information is returned such as temporary mail check or freemail check. More complicated corrections are included.
                 */
                [JsonConverter(typeof(StringValueEnumConverter<ValidateEmailRespRequestOptionsValidationType>))]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
                public enum ValidateEmailRespRequestOptionsValidationType
                {
                    [StringValue("basic")]
                    BASIC,
                    [StringValue("extended")]
                    EXTENDED
                }
            }
        }
        public class ValidateEmailRespErrors { }
    }
    public class ValidateEmailRequestBody
    {
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required ValidateEmailRequest Request { get; init; }
    }
    /**
     * Search email
     * Foxentry will automatically offer you suggestions to complete the e-mail address you are writing down. This mainly serves as <b>autocomplete</b>.<br><br> Pay attention to the <b>client</b> section in the request body. You can specify the user's location in order to receive more relevant suggestions.
     * @param requestBody
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @returns Task<EmailSearchResp?> Successful response
     * @throws ApiError
     */
    public async Task<EmailSearchResponse> EmailSearch(
      EmailSearchRequestBody? requestBody,
      bool? foxentryIncludeRequestDetails = false
    )
    {
        var headers = new Dictionary<string, string>();
        if (foxentryIncludeRequestDetails != null)
        {
            headers.Add("foxentry-include-request-details", foxentryIncludeRequestDetails.Value.ToString());
        }
        var result = await this.HttpRequest.Request<EmailSearchResp?>(
          new ApiRequestOptions
          {
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/email/search"
          }
        );

        return new EmailSearchResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new EmailSearchResponse.EmailSearchHeaders
            {
                FoxentryApiVersion = result.RawHeaders?["foxentry-api-version"],
                FoxentryDailyCreditsLeft = Utils.ParseDouble(result.RawHeaders?["foxentry-daily-credits-left"]),
                FoxentryDailyCreditsLimit = Utils.ParseDouble(result.RawHeaders?["foxentry-daily-credits-limit"]),
                FoxentryRateLimit = int.TryParse(result.RawHeaders?["foxentry-rate-limit"], out int foxentryRateLimit) ? foxentryRateLimit : default,
                FoxentryRateLimitPeriod = int.TryParse(result.RawHeaders?["foxentry-rate-limit-period"], out int foxentryRateLimitPeriod) ? foxentryRateLimitPeriod : default,
                FoxentryRateLimitRemaining = int.TryParse(result.RawHeaders?["foxentry-rate-limit-remaining"], out int foxentryRateLimitRemaining) ? foxentryRateLimitRemaining : default,
            }
        };
    }

    public class EmailSearchResponse
    {
        public EmailSearchResp? Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required EmailSearchHeaders Headers { get; init; }

        public class EmailSearchHeaders
        {
            public string? FoxentryApiVersion { get; set; }
            public double? FoxentryDailyCreditsLeft { get; set; }
            public double? FoxentryDailyCreditsLimit { get; set; }
            public int? FoxentryRateLimit { get; set; }
            public int? FoxentryRateLimitPeriod { get; set; }
            public int? FoxentryRateLimitRemaining { get; set; }
        }
    }
    /**
   * Successful response
   */
    public class EmailSearchResp
    {
        [JsonPropertyName("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required EmailSearchRespRequest Request { get; init; }
        [JsonPropertyName("response")]
        [Newtonsoft.Json.JsonProperty("response")]
        public EmailSearchResponse? Response { get; set; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<EmailSearchRespErrors?>? Errors { get; set; }
        public class EmailSearchRespRequest : GlobalRequest
        {
            [JsonPropertyName("query")]
            [Newtonsoft.Json.JsonProperty("query")]
            public EmailSearchRespRequestQuery? Query { get; set; }

            [JsonPropertyName("options")]
            [Newtonsoft.Json.JsonProperty("options")]
            public EmailSearchRespRequestOptions? Options { get; set; }

            [JsonPropertyName("client")]
            [Newtonsoft.Json.JsonProperty("client")]
            public ClientRequest? Client { get; set; }

            [JsonPropertyName("endpoint")]
            [Newtonsoft.Json.JsonProperty("endpoint")]
            public required override string Endpoint { get; init; }

            public class EmailSearchRespRequestQuery
            {
                [JsonPropertyName("value")]
                [Newtonsoft.Json.JsonProperty("value")]
                public string? Value { get; set; }
            }
            /**
             * Query options.
             */
            public class EmailSearchRespRequestOptions
            {
                [JsonPropertyName("resultsLimit")]
                [Newtonsoft.Json.JsonProperty("resultsLimit")]
                public double? ResultsLimit { get; set; }
            }
        }
        public class EmailSearchRespErrors { }
    }
    public class EmailSearchRequestBody
    {
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required EmailSearchRequest Request { get; init; }
    }
}
