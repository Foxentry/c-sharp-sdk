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
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @param requestBody 
     * @param apiVersion API version.
     * @returns NameValidationResp? Successful response
     * @throws ApiError
     */
    public Task<NameValidationResp?> NameValidation(
      bool? foxentryIncludeRequestDetails,
      NameValidationRequestBody? requestBody,
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
        return this.HttpRequest.Request<NameValidationResp?>(
              new ApiRequestOptions
              {
                  Body = requestBody != null ? new JsonBody(requestBody) : null,
                  Headers = headers,
                  Method = HttpMethod.Post,
                  Path = "/name/validate"
              }
            );
    }
    /**
   * Successful response
   */
    public class NameValidationResp
    {
        [JsonPropertyName("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        public required NameValidationResponseRequest Request { get; init; }
        [JsonPropertyName("response")]
        public required NameValidationResults Response { get; init; }
        [JsonPropertyName("errors")]
        public required IEnumerable<IDictionary<string, object?>?> Errors { get; init; }
        public class NameValidationRespErrors { }
    }
    public class NameValidationRequestBody
    {
        [JsonPropertyName("request")]
        public required NameValidationRequest Request { get; init; }
    }
}
