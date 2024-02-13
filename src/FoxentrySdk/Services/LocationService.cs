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


public class LocationService
{
    public IHttpRequest HttpRequest { get; }

    public LocationService(IHttpRequest httpRequest)
    {
        this.HttpRequest = httpRequest;
    }

    /**
     * Validate location data
     * This endpoint requires at least 1 query parameter and will check if the parameters and their combinations are valid. Returns information about the location based on the datascope set in the options.<br><br> Foxentry validator is able not only to evaluate the validity of the inputed information but it also can fix various typos, errors and missing data. Foxentry can also suggest more suitable alternatives to the data sent in query. Please pay attention to the <b>result</b>, <b>resultCorrected</b> and <b>suggestions</b> in the response.<br><br> Always check <b>result.proposal</b> in the response for a proposed solution by Foxentry how you should process the response in your form or application.
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @param requestBody
     * @param apiVersion API version.
     * @returns LocationValidationResp? Successful response
     * @throws ApiError
     */
    public Task<LocationValidationResp?> LocationValidation(
      bool? foxentryIncludeRequestDetails,
      LocationValidationRequestBody? requestBody,
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
        return this.HttpRequest.Request<LocationValidationResp?>(
              new ApiRequestOptions
              {
                  Body = requestBody != null ? new JsonBody(requestBody) : null,
                  Headers = headers,
                  Method = HttpMethod.Post,
                  Path = "/location/validate"
              }
            );
    }
    /**
   * Successful response
   */
    public class LocationValidationResp
    {
        [JsonPropertyName("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        public required LocationValidationRespRequest Request { get; init; }
        [JsonPropertyName("response")]
        public required LocationValidationResponse Response { get; init; }
        [JsonPropertyName("errors")]
        public required IEnumerable<IDictionary<string, object?>?> Errors { get; init; }
        public class LocationValidationRespRequest : GlobalRequest
        {
            [JsonPropertyName("endpoint")]
            public override required string Endpoint { get; init; }

            [JsonPropertyName("query")]
            public LocationValidationRespRequestQuery? Query { get; set; }

            [JsonPropertyName("options")]
            public LocationValidationRespRequestOptions? Options { get; set; }

            [JsonPropertyName("client")]
            public ClientRequest? Client { get; set; }

            public class LocationValidationRespRequestOptions : LocationRequestOptions
            {
                [JsonPropertyName("acceptPostOfficeAsCity")]
                public bool? AcceptPostOfficeAsCity { get; set; }

            }
            public class LocationValidationRespRequestQuery
            {
                [JsonPropertyName("street")]
                public string? Street { get; set; }
                [JsonPropertyName("streetWithNumber")]
                public string? StreetWithNumber { get; set; }
                [JsonPropertyName("'number.full'")]
                public string? NumberFull { get; set; }
                [JsonPropertyName("'number.part1'")]
                public string? NumberPart1 { get; set; }
                [JsonPropertyName("'number.part1Number'")]
                public string? NumberPart1Number { get; set; }
                [JsonPropertyName("'number.part1Letter'")]
                public string? NumberPart1Letter { get; set; }
                [JsonPropertyName("'number.part2'")]
                public string? NumberPart2 { get; set; }
                [JsonPropertyName("'number.part2Number'")]
                public string? NumberPart2Number { get; set; }
                [JsonPropertyName("'number.part2Letter'")]
                public string? NumberPart2Letter { get; set; }
                [JsonPropertyName("city")]
                public string? City { get; set; }
                [JsonPropertyName("zip")]
                public string? Zip { get; set; }
                [JsonPropertyName("full")]
                public string? Full { get; set; }
                [JsonPropertyName("country")]
                public string? Country { get; set; }
            }
        }
        public class LocationValidationRespErrors { }
    }
    public class LocationValidationRequestBody
    {
        [JsonPropertyName("request")]
        public required LocationValidationRequest Request { get; init; }
    }
    /**
     * Search location
     * This enpoint mainly serves as <b>autocomplete</b> but can be used to search for specific addresses based on filter criteria as well. Foxentry will automatically offer you suggestions to complete the address you are writing down. <br><br>Pay attention to the <b>client</b> section in the request body. You can specify the user's location in order to receive more relevant suggestions.
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @param requestBody
     * @param apiVersion API version.
     * @returns LocationSearchResp? Successful response
     * @throws ApiError
     */
    public Task<LocationSearchResp?> LocationSearch(
      bool? foxentryIncludeRequestDetails,
      LocationSearchRequestBody? requestBody,
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
        return this.HttpRequest.Request<LocationSearchResp?>(
              new ApiRequestOptions
              {
                  Body = requestBody != null ? new JsonBody(requestBody) : null,
                  Headers = headers,
                  Method = HttpMethod.Post,
                  Path = "/location/search"
              }
            );
    }
    /**
   * Successful response
   */
    public class LocationSearchResp
    {
        [JsonPropertyName("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        public required LocationSearchRespRequest Request { get; init; }
        [JsonPropertyName("response")]
        public LocationSearchResponse? Response { get; set; }
        [JsonPropertyName("errors")]
        public IEnumerable<IDictionary<string, object?>?>? Errors { get; set; }
        public class LocationSearchRespRequest : GlobalRequest
        {
            [JsonPropertyName("endpoint")]
            public override required string Endpoint { get; init; }

            [JsonPropertyName("query")]
            public LocationSearchRespRequestQuery? Query { get; set; }

            [JsonPropertyName("options")]
            public LocationRequestOptionsSearch? Options { get; set; }

            [JsonPropertyName("client")]
            public ClientRequest? Client { get; set; }

            public class LocationSearchRespRequestQuery
            {
                [JsonPropertyName("type")]
                public LocationSearchRespRequestQueryType? Type { get; set; }
                [JsonPropertyName("value")]
                public string? Value { get; set; }
                [JsonPropertyName("filter")]
                public LocationSearchRespRequestQueryFilter? Filter { get; set; }
                /**
                 * Type of search.
                 */
                [JsonConverter(typeof(StringValueEnumConverter<LocationSearchRespRequestQueryType>))]
                public enum LocationSearchRespRequestQueryType
                {
                    [StringValue("street")]
                    STREET,
                    [StringValue("streetWithNumber")]
                    STREET_WITH_NUMBER,
                    [StringValue("number.full")]
                    NUMBER_FULL,
                    [StringValue("number.part1")]
                    NUMBER_PART1,
                    [StringValue("number.part1Number")]
                    NUMBER_PART1NUMBER,
                    [StringValue("number.part2")]
                    NUMBER_PART2,
                    [StringValue("number.part2Number")]
                    NUMBER_PART2NUMBER,
                    [StringValue("city")]
                    CITY,
                    [StringValue("zip")]
                    ZIP,
                    [StringValue("full")]
                    FULL
                }/**
 * Additional filter in order to specify the search results. You can for example set as a filter city of Prague, so the the search engine would look for the addresses only in Prague. Pay attention to the options, which determines how the filter should behave.
 */
                public class LocationSearchRespRequestQueryFilter
                {
                    [JsonPropertyName("street")]
                    public string? Street { get; set; }
                    [JsonPropertyName("streetWithNumber")]
                    public string? StreetWithNumber { get; set; }
                    [JsonPropertyName("'number.full'")]
                    public string? NumberFull { get; set; }
                    [JsonPropertyName("'number.part1'")]
                    public string? NumberPart1 { get; set; }
                    [JsonPropertyName("'number.part2'")]
                    public string? NumberPart2 { get; set; }
                    [JsonPropertyName("city")]
                    public string? City { get; set; }
                    [JsonPropertyName("zip")]
                    public string? Zip { get; set; }
                    [JsonPropertyName("country")]
                    public string? Country { get; set; }
                }
            }
        }
        public class LocationSearchRespErrors { }
    }
    public class LocationSearchRequestBody
    {
        [JsonPropertyName("request")]
        public required LocationSearchRequest Request { get; init; }
    }
    /**
     * Get location data
     * Foxentry allows you to get information about location based on the <b>dataScope</b> option. <b>Country</b> and <b>ID</b> parameters are required. You can either choose internal ID, which is assigned by Foxentry or external ID from the data source. <b>CZ external</b> = RUIAN, <b>PL external</b> = Gov data, <b>SK external does not exist</b>.
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @param requestBody
     * @param apiVersion API version.
     * @returns LocationGetResp? Successful response
     * @throws ApiError
     */
    public Task<LocationGetResp?> LocationGet(
      bool? foxentryIncludeRequestDetails,
      LocationGetRequestBody? requestBody,
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
        return this.HttpRequest.Request<LocationGetResp?>(
              new ApiRequestOptions
              {
                  Body = requestBody != null ? new JsonBody(requestBody) : null,
                  Headers = headers,
                  Method = HttpMethod.Post,
                  Path = "/location/get"
              }
            );
    }
    /**
   * Successful response
   */
    public class LocationGetResp
    {
        [JsonPropertyName("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        public required LocationGetRespRequest Request { get; init; }
        [JsonPropertyName("response")]
        public required LocationGetResults Response { get; init; }
        [JsonPropertyName("errors")]
        public required IEnumerable<IDictionary<string, object?>?> Errors { get; init; }
        public class LocationGetRespRequest : GlobalRequest
        {
            [JsonPropertyName("endpoint")]
            public override required string Endpoint { get; init; }

            [JsonPropertyName("query")]
            public LocationGetRespRequestQuery? Query { get; set; }

            [JsonPropertyName("options")]
            public LocationGetRespRequestOptions? Options { get; set; }

            [JsonPropertyName("client")]
            public ClientRequest? Client { get; set; }

            public class LocationGetRespRequestQuery
            {
                [JsonPropertyName("country")]
                public required string Country { get; init; }
                [JsonPropertyName("id")]
                public required string Id { get; init; }
            }
            /**
             * Query options.
             */
            public class LocationGetRespRequestOptions
            {
                [JsonPropertyName("idType")]
                public required LocationGetRespRequestOptionsIdType IdType { get; init; }
                [JsonPropertyName("dataScope")]
                public required LocationGetRespRequestOptionsDataScope DataScope { get; init; }
                [JsonPropertyName("dataSource")]
                public IEnumerable<string?>? DataSource { get; set; }
                [JsonPropertyName("zipFormat")]
                public bool? ZipFormat { get; set; }
                [JsonPropertyName("cityFormat")]
                public LocationGetRespRequestOptionsCityFormat? CityFormat { get; set; }
                /**
                 * Internal is assigned by Foxentry. External ID may vary for every supported country. CZ = RUIAN, PL = Government data, SK = no external ID.
                 */
                [JsonConverter(typeof(StringValueEnumConverter<LocationGetRespRequestOptionsIdType>))]
                public enum LocationGetRespRequestOptionsIdType
                {
                    [StringValue("internal")]
                    INTERNAL,
                    [StringValue("external")]
                    EXTERNAL
                }
                /**
                 * Data scope of returned data.
                 */
                [JsonConverter(typeof(StringValueEnumConverter<LocationGetRespRequestOptionsDataScope>))]
                public enum LocationGetRespRequestOptionsDataScope
                {
                    [StringValue("basic")]
                    BASIC,
                    [StringValue("full")]
                    FULL
                }
                /**
                 * This option determines in what format is city returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
                 */
                [JsonConverter(typeof(StringValueEnumConverter<LocationGetRespRequestOptionsCityFormat>))]
                public enum LocationGetRespRequestOptionsCityFormat
                {
                    [StringValue("minimal")]
                    MINIMAL,
                    [StringValue("basic")]
                    BASIC,
                    [StringValue("extended")]
                    EXTENDED
                }
            }
        }
        public class LocationGetRespErrors { }
    }
    public class LocationGetRequestBody
    {
        [JsonPropertyName("request")]
        public required LocationGetRequest Request { get; init; }
    }
    /**
     * Localization
     * Foxentry allows you to check an area with GPS radius in order to return all the addresses within that area. It can also give you additional information about the addresses based on the <b>dataScope</b> option.<br><br>Please pay attention to the <b>singleLocationResultDistance</b> option, which determines the radius of the search area in meters.<br><br>
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @param requestBody
     * @param apiVersion API version.
     * @returns LocationLocalizationResp? Successful response
     * @throws ApiError
     */
    public Task<LocationLocalizationResp?> LocationLocalization(
      bool? foxentryIncludeRequestDetails,
      LocationLocalizationRequestBody? requestBody,
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
        return this.HttpRequest.Request<LocationLocalizationResp?>(
              new ApiRequestOptions
              {
                  Body = requestBody != null ? new JsonBody(requestBody) : null,
                  Headers = headers,
                  Method = HttpMethod.Post,
                  Path = "/location/localize"
              }
            );
    }
    /**
   * Successful response
   */
    public class LocationLocalizationResp
    {
        [JsonPropertyName("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        public required LocationLocalizationRespRequest Request { get; init; }
        [JsonPropertyName("response")]
        public required LocationLocalizationResults Response { get; init; }
        [JsonPropertyName("errors")]
        public IEnumerable<IDictionary<string, object?>?>? Errors { get; set; }
        public class LocationLocalizationRespRequest : GlobalRequest
        {
            [JsonPropertyName("endpoint")]
            public override required string Endpoint { get; init; }

            [JsonPropertyName("query")]
            public LocationLocalizationRespRequestQuery? Query { get; set; }

            [JsonPropertyName("options")]
            public LocationLocalizationRespRequestOptions? Options { get; set; }

            [JsonPropertyName("client")]
            public LocationLocalizationRespRequestClient? Client { get; set; }

            public class LocationLocalizationRespRequestQuery
            {
                [JsonPropertyName("lat")]
                public required double Lat { get; init; }
                [JsonPropertyName("lon")]
                public required double Lon { get; init; }
            }
            public class LocationLocalizationRespRequestOptions { }
            /**
             * Additional information about your user (from whom you've obtained the data sent in query) in order to specify the results in response. Used mainly in web forms when you need more relevant search/autocomplete results.
             */
            public class LocationLocalizationRespRequestClient
            {
                [JsonPropertyName("ip")]
                public string? Ip { get; set; }
                [JsonPropertyName("country")]
                public string? Country { get; set; }
            }
        }
        public class LocationLocalizationRespErrors { }
    }
    public class LocationLocalizationRequestBody
    {
        [JsonPropertyName("request")]
        public required LocationLocalizationRequest Request { get; init; }
    }
}
