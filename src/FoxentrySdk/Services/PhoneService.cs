/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.cz
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


public class PhoneService
{
    public IHttpRequest HttpRequest { get; }

    public PhoneService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Validate phone number
     * Foxentry allows you to check validity and the existence of phone numbers. It can also give you additional information about the validated phone number based on the <b>validationType</b> option.<br><br>Please pay attention to the <b>formatNumber</b> option. This option defines the format of number that should be considered as valid. <br><br>Foxentry validator is able not only to evaluate the validity of the inputed information but it also can fix various typos, errors and missing data. Foxentry can also suggest more suitable alternatives to the data sent in query. Please pay attention to the <b>result</b>, <b>resultCorrected</b> and <b>suggestions</b> in the response.<br><br> Always check <b>result.proposal</b> in the response for a proposed solution by Foxentry how you should process the response in your form or application.
     * @param requestBody
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @returns Task<ValidatePhoneNumberResp?> Successful response
     * @throws ApiError
     */
    public async Task<ValidatePhoneNumberResponse> ValidatePhoneNumber(
      ValidatePhoneNumberRequestBody? requestBody,
      bool? foxentryIncludeRequestDetails = false
    )
    {
        var headers = new Dictionary<string, string>();
        if (foxentryIncludeRequestDetails != null)
        {
            headers.Add("foxentry-include-request-details", foxentryIncludeRequestDetails.Value.ToString());
        }
        var result = await this.HttpRequest.Request<ValidatePhoneNumberResp?>(
          new ApiRequestOptions
          {
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/phone/validate"
          }
        );

        return new ValidatePhoneNumberResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new ValidatePhoneNumberResponse.ValidatePhoneNumberHeaders
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

    public class ValidatePhoneNumberResponse
    {
        public ValidatePhoneNumberResp? Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required ValidatePhoneNumberHeaders Headers { get; init; }

        public class ValidatePhoneNumberHeaders
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
    public class ValidatePhoneNumberResp
    {
        [JsonPropertyName("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required ValidatePhoneNumberResponseRequest Request { get; init; }
        [JsonPropertyName("response")]
        [Newtonsoft.Json.JsonProperty("response")]
        public required ValidatePhoneNumberResults Response { get; init; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<ValidatePhoneNumberRespErrors?>? Errors { get; set; }
        public class ValidatePhoneNumberRespErrors { }
    }
    public class ValidatePhoneNumberRequestBody
    {
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required ValidatePhoneNumberRequest Request { get; init; }
    }
}
