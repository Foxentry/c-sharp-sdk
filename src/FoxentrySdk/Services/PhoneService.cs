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
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @param requestBody 
     * @param apiVersion API version.
     * @returns ValidatePhoneNumberResp? Successful response
     * @throws ApiError
     */
    public Task<ValidatePhoneNumberResp?> ValidatePhoneNumber(
      bool? foxentryIncludeRequestDetails,
      ValidatePhoneNumberRequestBody? requestBody,
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
        return this.HttpRequest.Request<ValidatePhoneNumberResp?>(
              new ApiRequestOptions
              {
                  Body = requestBody != null ? new JsonBody(requestBody) : null,
                  Headers = headers,
                  Method = HttpMethod.Post,
                  Path = "/phone/validate"
              }
            );
    }
    /**
   * Successful response
   */
    public class ValidatePhoneNumberResp
    {
        [JsonPropertyName("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        public required ValidatePhoneNumberResponseRequest Request { get; init; }
        [JsonPropertyName("response")]
        public required ValidatePhoneNumberResults Response { get; init; }
        [JsonPropertyName("errors")]
        public IEnumerable<IDictionary<string, object?>?>? Errors { get; set; }
        public class ValidatePhoneNumberRespErrors { }
    }
    public class ValidatePhoneNumberRequestBody
    {
        [JsonPropertyName("request")]
        public required ValidatePhoneNumberRequest Request { get; init; }
    }
}
