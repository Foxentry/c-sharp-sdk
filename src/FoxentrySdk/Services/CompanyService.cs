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


public class CompanyService
{
    public IHttpRequest HttpRequest { get; }

    public CompanyService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Validate company data
     * This endpoint requires at least 1 query parameter and will check if the parameters and their combinations are valid. Returns information about the company based on the datascope set in the options.<br><br> Foxentry validator is able not only to evaluate the validity of the inputed information but it also can fix various typos, errors and missing data. Foxentry can also suggest more suitable alternatives to the data sent in query. Please pay attention to the <b>result</b>, <b>resultCorrected</b> and <b>suggestions</b> in the response.<br><br> Always check <b>result.proposal</b> in the response for a proposed solution by Foxentry how you should process the response in your form or application.
     * @param requestBody
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @returns Task<ValidateCompanyDataResp?> Successful response
     * @throws ApiError
     */
    public async Task<ValidateCompanyDataResponse> ValidateCompanyData(
      ValidateCompanyDataRequestBody? requestBody,
      bool? foxentryIncludeRequestDetails = false
    )
    {
        var headers = new Dictionary<string, string>();
        if (foxentryIncludeRequestDetails != null)
        {
            headers.Add("foxentry-include-request-details", foxentryIncludeRequestDetails.Value.ToString());
        }
        var result = await this.HttpRequest.Request<ValidateCompanyDataResp?>(
          new ApiRequestOptions
          {
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/company/validate"
          }
        );

        return new ValidateCompanyDataResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new ValidateCompanyDataResponse.ValidateCompanyDataHeaders
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

    public class ValidateCompanyDataResponse
    {
        public ValidateCompanyDataResp? Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required ValidateCompanyDataHeaders Headers { get; init; }

        public class ValidateCompanyDataHeaders
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
    public class ValidateCompanyDataResp
    {
        [JsonPropertyName("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required ValidateCompanyDataResultsRequest Request { get; init; }
        [JsonPropertyName("response")]
        [Newtonsoft.Json.JsonProperty("response")]
        public required ValidateCompanyDataResults Response { get; init; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<ValidateCompanyDataRespErrors?>? Errors { get; set; }
        public class ValidateCompanyDataRespErrors { }
    }
    public class ValidateCompanyDataRequestBody
    {
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required ValidateCompanyDataRequest Request { get; init; }
    }
    /**
     * Search company
     * This enpoint mainly serves as <b>autocomplete</b> but can be used to search for specific companies based on filter criteria as well. Foxentry will automatically offer you suggestions to complete the company you are writing down. <br><br>Pay attention to the <b>client</b> section in the request body. You can specify the user's location in order to receive more relevant suggestions.
     * @param requestBody
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @returns Task<CompanySearchResp?> Successful response
     * @throws ApiError
     */
    public async Task<CompanySearchResponse> CompanySearch(
      CompanySearchRequestBody? requestBody,
      bool? foxentryIncludeRequestDetails = false
    )
    {
        var headers = new Dictionary<string, string>();
        if (foxentryIncludeRequestDetails != null)
        {
            headers.Add("foxentry-include-request-details", foxentryIncludeRequestDetails.Value.ToString());
        }
        var result = await this.HttpRequest.Request<CompanySearchResp?>(
          new ApiRequestOptions
          {
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/company/search"
          }
        );

        return new CompanySearchResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new CompanySearchResponse.CompanySearchHeaders
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

    public class CompanySearchResponse
    {
        public CompanySearchResp? Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required CompanySearchHeaders Headers { get; init; }

        public class CompanySearchHeaders
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
    public class CompanySearchResp
    {
        [JsonPropertyName("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required CompanySearchResultsRequest Request { get; init; }
        [JsonPropertyName("response")]
        [Newtonsoft.Json.JsonProperty("response")]
        public required CompanySearchResults Response { get; init; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<CompanySearchRespErrors?>? Errors { get; set; }
        public class CompanySearchRespErrors { }
    }
    public class CompanySearchRequestBody
    {
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required CompanySearchRequest Request { get; init; }
    }
    /**
     * Get company data
     * Foxentry allows you to get information about company based on the <b>dataScope</b> option. <b>Country</b> and <b>registrationNumber</b> parameters are required.
     * @param requestBody
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @returns Task<GetCompanyDataResp?> Successful response
     * @throws ApiError
     */
    public async Task<GetCompanyDataResponse> GetCompanyData(
      GetCompanyDataRequestBody? requestBody,
      bool? foxentryIncludeRequestDetails = false
    )
    {
        var headers = new Dictionary<string, string>();
        if (foxentryIncludeRequestDetails != null)
        {
            headers.Add("foxentry-include-request-details", foxentryIncludeRequestDetails.Value.ToString());
        }
        var result = await this.HttpRequest.Request<GetCompanyDataResp?>(
          new ApiRequestOptions
          {
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/company/get"
          }
        );

        return new GetCompanyDataResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new GetCompanyDataResponse.GetCompanyDataHeaders
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

    public class GetCompanyDataResponse
    {
        public GetCompanyDataResp? Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required GetCompanyDataHeaders Headers { get; init; }

        public class GetCompanyDataHeaders
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
    public class GetCompanyDataResp
    {
        [JsonPropertyName("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required GetCompanyDataResponseRequest Request { get; init; }
        [JsonPropertyName("response")]
        [Newtonsoft.Json.JsonProperty("response")]
        public required GetCompanyDataResults Response { get; init; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<GetCompanyDataRespErrors?>? Errors { get; set; }
        public class GetCompanyDataRespErrors { }
    }
    public class GetCompanyDataRequestBody
    {
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required GetCompanyDataRequest Request { get; init; }
    }
}
