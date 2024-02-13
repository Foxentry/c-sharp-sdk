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
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @param requestBody
     * @param apiVersion API version.
     * @returns ValidateEmailResp? Successful response
     * @throws ApiError
     */
    public Task<ValidateEmailResp?> ValidateEmail(
      bool? foxentryIncludeRequestDetails,
      ValidateEmailRequestBody? requestBody,
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
        return this.HttpRequest.Request<ValidateEmailResp?>(
              new ApiRequestOptions
              {
                  Body = requestBody != null ? new JsonBody(requestBody) : null,
                  Headers = headers,
                  Method = HttpMethod.Post,
                  Path = "/email/validate"
              }
            );
    }
    /**
   * Successful response
   */
    public class ValidateEmailResp
    {
        [JsonPropertyName("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        public required ValidateEmailRespRequest Request { get; init; }
        [JsonPropertyName("response")]
        public required ValidateEmailResponse Response { get; init; }
        [JsonPropertyName("errors")]
        public required IEnumerable<IDictionary<string, object?>?> Errors { get; init; }
        public class ValidateEmailRespRequest : GlobalRequest
        {
            [JsonPropertyName("endpoint")]
            public override required string? Endpoint { get; init; }

            [JsonPropertyName("query")]
            public ValidateEmailRespRequestQuery? Query { get; set; }

            [JsonPropertyName("options")]
            public ValidateEmailRespRequestOptions? Options { get; set; }

            [JsonPropertyName("client")]
            public ClientRequest? Client { get; set; }

            public class ValidateEmailRespRequestQuery
            {
                [JsonPropertyName("email")]
                public required string Email { get; init; }
            }
            /**
             * Query options.
             */
            public class ValidateEmailRespRequestOptions
            {
                [JsonPropertyName("validationType")]
                public ValidateEmailRespRequestOptionsValidationType? ValidationType { get; set; }
                [JsonPropertyName("acceptDisposableEmails")]
                public bool? AcceptDisposableEmails { get; set; }
                [JsonPropertyName("acceptFreemails")]
                public bool? AcceptFreemails { get; set; }
                /**
                 * Type of validation. <b>Basic</b> = only the format of e-mail is checked and only standard corrections are included. <b>Extended</b> = in depth check of deliverability. Additional information is returned such as temporary mail check or freemail check. More complicated corrections are included.
                 */
                [JsonConverter(typeof(StringValueEnumConverter<ValidateEmailRespRequestOptionsValidationType>))]
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
        public required ValidateEmailRequest Request { get; init; }
    }
    /**
     * Search email
     * Foxentry will automatically offer you suggestions to complete the e-mail address you are writing down. This mainly serves as <b>autocomplete</b>.<br><br> Pay attention to the <b>client</b> section in the request body. You can specify the user's location in order to receive more relevant suggestions.
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @param requestBody
     * @param apiVersion API version.
     * @returns EmailSearchResp? Successful response
     * @throws ApiError
     */
    public Task<EmailSearchResp?> EmailSearch(
      bool? foxentryIncludeRequestDetails,
      EmailSearchRequestBody? requestBody,
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
        return this.HttpRequest.Request<EmailSearchResp?>(
              new ApiRequestOptions
              {
                  Body = requestBody != null ? new JsonBody(requestBody) : null,
                  Headers = headers,
                  Method = HttpMethod.Post,
                  Path = "/email/search"
              }
            );
    }
    /**
   * Successful response
   */
    public class EmailSearchResp
    {
        [JsonPropertyName("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        public required EmailSearchRespRequest Request { get; init; }
        [JsonPropertyName("response")]
        public EmailSearchResponse? Response { get; set; }
        [JsonPropertyName("errors")]
        public IEnumerable<IDictionary<string, object?>?>? Errors { get; set; }
        public class EmailSearchRespRequest : GlobalRequest
        {
            [JsonPropertyName("endpoint")]
            public override required string? Endpoint { get; init; }

            [JsonPropertyName("query")]
            public EmailSearchRespRequestQuery? Query { get; set; }

            [JsonPropertyName("options")]
            public EmailSearchRespRequestOptions? Options { get; set; }

            [JsonPropertyName("client")]
            public ClientRequest? Client { get; set; }

            public class EmailSearchRespRequestQuery
            {
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
            /**
             * Query options.
             */
            public class EmailSearchRespRequestOptions
            {
                [JsonPropertyName("resultsLimit")]
                public double? ResultsLimit { get; set; }
            }
        }
        public class EmailSearchRespErrors { }
    }
    public class EmailSearchRequestBody
    {
        [JsonPropertyName("request")]
        public required EmailSearchRequest Request { get; init; }
    }
}
