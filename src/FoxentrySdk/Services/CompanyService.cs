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
using System.Text.Json.Serialization;
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
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @param requestBody 
     * @param apiVersion API version.
     * @returns ValidateCompanyDataResp? Successful response
     * @throws ApiError
     */
    public Task<ValidateCompanyDataResp?> ValidateCompanyData(
      bool? foxentryIncludeRequestDetails,
      ValidateCompanyDataRequestBody? requestBody,
      string? apiVersion = "2.0"
    )
    {
        var headers = new Dictionary<string, string>();
        if (foxentryIncludeRequestDetails != null)
        {
            headers.Add("Foxentry-Include-Request-Details", foxentryIncludeRequestDetails.Value.ToString());
        }
        if (apiVersion != null)
        {
            headers.Add("Api-Version", apiVersion);
        }
        return this.HttpRequest.Request<ValidateCompanyDataResp?>(
              new ApiRequestOptions
              {
                  Body = requestBody != null ? new JsonBody(requestBody) : null,
                  Headers = headers,
                  Method = HttpMethod.Post,
                  Path = "/company/validate"
              }
            );
    }
    /**
   * Successful response
   */
    public class ValidateCompanyDataResp
    {
        [JsonPropertyName("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        public required ValidateCompanyDataResultsRequest Request { get; init; }
        [JsonPropertyName("response")]
        public required ValidateCompanyDataResults Response { get; init; }
        [JsonPropertyName("errors")]
        public IEnumerable<IDictionary<string, object?>?>? Errors { get; set; }
        public class ValidateCompanyDataRespErrors { }
    }
    public class ValidateCompanyDataRequestBody
    {
        [JsonPropertyName("request")]
        public required ValidateCompanyDataRequest Request { get; init; }
    }
    /**
     * Search company
     * This enpoint mainly serves as <b>autocomplete</b> but can be used to search for specific companies based on filter criteria as well. Foxentry will automatically offer you suggestions to complete the company you are writing down. <br><br>Pay attention to the <b>client</b> section in the request body. You can specify the user's location in order to receive more relevant suggestions.
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @param requestBody 
     * @param apiVersion API version.
     * @returns CompanySearchResp? Successful response
     * @throws ApiError
     */
    public Task<CompanySearchResp?> CompanySearch(
      bool? foxentryIncludeRequestDetails,
      CompanySearchRequestBody? requestBody,
      string? apiVersion = "2.0"
    )
    {
        var headers = new Dictionary<string, string>();
        if (foxentryIncludeRequestDetails != null)
        {
            headers.Add("Foxentry-Include-Request-Details", foxentryIncludeRequestDetails.Value.ToString());
        }
        if (apiVersion != null)
        {
            headers.Add("Api-Version", apiVersion);
        }
        return this.HttpRequest.Request<CompanySearchResp?>(
              new ApiRequestOptions
              {
                  Body = requestBody != null ? new JsonBody(requestBody) : null,
                  Headers = headers,
                  Method = HttpMethod.Post,
                  Path = "/company/search"
              }
            );
    }
    /**
   * Successful response
   */
    public class CompanySearchResp
    {
        [JsonPropertyName("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        public required CompanySearchResultsRequest Request { get; init; }
        [JsonPropertyName("response")]
        public required CompanySearchResults Response { get; init; }
        [JsonPropertyName("errors")]
        public IEnumerable<IDictionary<string, object?>?>? Errors { get; set; }
        public class CompanySearchRespErrors { }
    }
    public class CompanySearchRequestBody
    {
        [JsonPropertyName("request")]
        public required CompanySearchRequest Request { get; init; }
    }
    /**
     * Get company data
     * Foxentry allows you to get information about company based on the <b>dataScope</b> option. <b>Country</b> and <b>registrationNumber</b> parameters are required.
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @param requestBody 
     * @param apiVersion API version.
     * @returns GetCompanyDataResp? Successful response
     * @throws ApiError
     */
    public Task<GetCompanyDataResp?> GetCompanyData(
      bool? foxentryIncludeRequestDetails,
      GetCompanyDataRequestBody? requestBody,
      string? apiVersion = "2.0"
    )
    {
        var headers = new Dictionary<string, string>();
        if (foxentryIncludeRequestDetails != null)
        {
            headers.Add("Foxentry-Include-Request-Details", foxentryIncludeRequestDetails.Value.ToString());
        }
        if (apiVersion != null)
        {
            headers.Add("Api-Version", apiVersion);
        }
        return this.HttpRequest.Request<GetCompanyDataResp?>(
              new ApiRequestOptions
              {
                  Body = requestBody != null ? new JsonBody(requestBody) : null,
                  Headers = headers,
                  Method = HttpMethod.Post,
                  Path = "/company/get"
              }
            );
    }
    /**
   * Successful response
   */
    public class GetCompanyDataResp
    {
        [JsonPropertyName("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        public required GetCompanyDataResponseRequest Request { get; init; }
        [JsonPropertyName("response")]
        public required GetCompanyDataResults Response { get; init; }
        [JsonPropertyName("errors")]
        public IEnumerable<IDictionary<string, object?>?>? Errors { get; set; }
        public class GetCompanyDataRespErrors { }
    }
    public class GetCompanyDataRequestBody
    {
        [JsonPropertyName("request")]
        public required GetCompanyDataRequest Request { get; init; }
    }
}
