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


public class NameService
{
    public IHttpRequest HttpRequest { get; }

    public NameService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Validate name data
     * Foxentry allows you to check the validity and real existence of names and their combinations. At least one parameter is required in the query. You can either write down the name separately or use <b>nameSurname</b> as connected parameter. <br><br>Pay attention to the query options. Especially <b>validationDepth</b>, which determines how strict the validation should be based on your use case. For example you''d want minimal validationDepth for web forms since you usually don''t want to disturb the user too much with error messages and suggestions.   <br><br> Foxentry validator is able not only to evaluate the validity of the inputed information but it also can fix various typos, errors and missing data. Foxentry can also suggest more suitable alternatives to the data sent in query. Please pay attention to the <b>result</b>, <b>resultCorrected</b> and <b>suggestions</b> in the response.<br><br> Always check <b>result.proposal</b> in the response for a proposed solution by Foxentry how you should process the response in your form or application.
     * @param requestBody
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @returns Task<NameValidationResp?> Successful response
     * @throws ApiError
     */
    public async Task<NameValidationResponse> NameValidation(
      NameValidationRequestBody? requestBody,
      bool? foxentryIncludeRequestDetails = false
    )
    {
        var headers = new Dictionary<string, string>();
        if (foxentryIncludeRequestDetails != null)
        {
            headers.Add("foxentry-include-request-details", foxentryIncludeRequestDetails.Value.ToString());
        }
        var result = await this.HttpRequest.Request<NameValidationResp?>(
          new ApiRequestOptions
          {
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/name/validate"
          }
        );

        return new NameValidationResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new NameValidationResponse.NameValidationHeaders
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

    public class NameValidationResponse
    {
        public NameValidationResp? Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required NameValidationHeaders Headers { get; init; }

        public class NameValidationHeaders
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
    public class NameValidationResp
    {
        [JsonPropertyName("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required NameValidationResponseRequest Request { get; init; }
        [JsonPropertyName("response")]
        [Newtonsoft.Json.JsonProperty("response")]
        public required NameValidationResults Response { get; init; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public required IEnumerable<NameValidationRespErrors?> Errors { get; init; }
        public class NameValidationRespErrors { }
    }
    public class NameValidationRequestBody
    {
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required NameValidationRequest Request { get; init; }
    }
}
