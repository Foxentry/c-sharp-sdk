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
     * @param requestBody
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @returns Task<LocationValidationResp?> Successful response
     * @throws ApiError
     */
    public async Task<LocationValidationResponse> LocationValidation(
      LocationValidationRequestBody? requestBody,
      bool? foxentryIncludeRequestDetails = false
    )
    {
        var headers = new Dictionary<string, string>();
        if (foxentryIncludeRequestDetails != null)
        {
            headers.Add("foxentry-include-request-details", foxentryIncludeRequestDetails.Value.ToString());
        }
        var result = await this.HttpRequest.Request<LocationValidationResp?>(
          new ApiRequestOptions
          {
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/location/validate"
          }
        );

        return new LocationValidationResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new LocationValidationResponse.LocationValidationHeaders
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

    public class LocationValidationResponse
    {
        public LocationValidationResp? Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required LocationValidationHeaders Headers { get; init; }

        public class LocationValidationHeaders
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
    public class LocationValidationResp
    {
        [JsonPropertyName("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required LocationValidationRespRequest Request { get; init; }
        [JsonPropertyName("response")]
        [Newtonsoft.Json.JsonProperty("response")]
        public required LocationValidationResponse Response { get; init; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public required IEnumerable<LocationValidationRespErrors?> Errors { get; init; }
        public class LocationValidationRespRequest : GlobalRequest
        {
            [JsonPropertyName("query")]
            [Newtonsoft.Json.JsonProperty("query")]
            public LocationValidationRespRequestQuery? Query { get; set; }

            [JsonPropertyName("options")]
            [Newtonsoft.Json.JsonProperty("options")]
            public LocationValidationRespRequestOptions? Options { get; set; }

            [JsonPropertyName("client")]
            [Newtonsoft.Json.JsonProperty("client")]
            public ClientRequest? Client { get; set; }

            [JsonPropertyName("endpoint")]
            [Newtonsoft.Json.JsonProperty("endpoint")]
            public required override string Endpoint { get; init; }

            public class LocationValidationRespRequestOptions : LocationRequestOptions
            {
                [JsonPropertyName("acceptPostOfficeAsCity")]
                [Newtonsoft.Json.JsonProperty("acceptPostOfficeAsCity")]
                public bool? AcceptPostOfficeAsCity { get; set; }

            }
            public class LocationValidationRespRequestQuery
            {
                [JsonPropertyName("street")]
                [Newtonsoft.Json.JsonProperty("street")]
                public string? Street { get; set; }
                [JsonPropertyName("streetWithNumber")]
                [Newtonsoft.Json.JsonProperty("streetWithNumber")]
                public string? StreetWithNumber { get; set; }
                [JsonPropertyName("'number.full'")]
                [Newtonsoft.Json.JsonProperty("'number.full'")]
                public string? NumberFull { get; set; }
                [JsonPropertyName("'number.part1'")]
                [Newtonsoft.Json.JsonProperty("'number.part1'")]
                public string? NumberPart1 { get; set; }
                [JsonPropertyName("'number.part1Number'")]
                [Newtonsoft.Json.JsonProperty("'number.part1Number'")]
                public string? NumberPart1Number { get; set; }
                [JsonPropertyName("'number.part1Letter'")]
                [Newtonsoft.Json.JsonProperty("'number.part1Letter'")]
                public string? NumberPart1Letter { get; set; }
                [JsonPropertyName("'number.part2'")]
                [Newtonsoft.Json.JsonProperty("'number.part2'")]
                public string? NumberPart2 { get; set; }
                [JsonPropertyName("'number.part2Number'")]
                [Newtonsoft.Json.JsonProperty("'number.part2Number'")]
                public string? NumberPart2Number { get; set; }
                [JsonPropertyName("'number.part2Letter'")]
                [Newtonsoft.Json.JsonProperty("'number.part2Letter'")]
                public string? NumberPart2Letter { get; set; }
                [JsonPropertyName("city")]
                [Newtonsoft.Json.JsonProperty("city")]
                public string? City { get; set; }
                [JsonPropertyName("zip")]
                [Newtonsoft.Json.JsonProperty("zip")]
                public string? Zip { get; set; }
                [JsonPropertyName("full")]
                [Newtonsoft.Json.JsonProperty("full")]
                public string? Full { get; set; }
                [JsonPropertyName("country")]
                [Newtonsoft.Json.JsonProperty("country")]
                public string? Country { get; set; }
            }
        }
        public class LocationValidationRespErrors { }
    }
    public class LocationValidationRequestBody
    {
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required LocationValidationRequest Request { get; init; }
    }
    /**
     * Search location
     * This enpoint mainly serves as <b>autocomplete</b> but can be used to search for specific addresses based on filter criteria as well. Foxentry will automatically offer you suggestions to complete the address you are writing down. <br><br>Pay attention to the <b>client</b> section in the request body. You can specify the user's location in order to receive more relevant suggestions.
     * @param requestBody
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @returns Task<LocationSearchResp?> Successful response
     * @throws ApiError
     */
    public async Task<LocationSearchResponse> LocationSearch(
      LocationSearchRequestBody? requestBody,
      bool? foxentryIncludeRequestDetails = false
    )
    {
        var headers = new Dictionary<string, string>();
        if (foxentryIncludeRequestDetails != null)
        {
            headers.Add("foxentry-include-request-details", foxentryIncludeRequestDetails.Value.ToString());
        }
        var result = await this.HttpRequest.Request<LocationSearchResp?>(
          new ApiRequestOptions
          {
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/location/search"
          }
        );

        return new LocationSearchResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new LocationSearchResponse.LocationSearchHeaders
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

    public class LocationSearchResponse
    {
        public LocationSearchResp? Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required LocationSearchHeaders Headers { get; init; }

        public class LocationSearchHeaders
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
    public class LocationSearchResp
    {
        [JsonPropertyName("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required LocationSearchRespRequest Request { get; init; }
        [JsonPropertyName("response")]
        [Newtonsoft.Json.JsonProperty("response")]
        public LocationSearchResponse? Response { get; set; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<LocationSearchRespErrors?>? Errors { get; set; }
        public class LocationSearchRespRequest : GlobalRequest
        {
            [JsonPropertyName("query")]
            [Newtonsoft.Json.JsonProperty("query")]
            public LocationSearchRespRequestQuery? Query { get; set; }

            [JsonPropertyName("options")]
            [Newtonsoft.Json.JsonProperty("options")]
            public LocationRequestOptionsSearch? Options { get; set; }

            [JsonPropertyName("client")]
            [Newtonsoft.Json.JsonProperty("client")]
            public ClientRequest? Client { get; set; }

            [JsonPropertyName("endpoint")]
            [Newtonsoft.Json.JsonProperty("endpoint")]
            public required override string Endpoint { get; init; }

            public class LocationSearchRespRequestQuery
            {
                [JsonPropertyName("type")]
                [Newtonsoft.Json.JsonProperty("type")]
                public LocationSearchRespRequestQueryType? Type { get; set; }
                [JsonPropertyName("value")]
                [Newtonsoft.Json.JsonProperty("value")]
                public string? Value { get; set; }
                [JsonPropertyName("filter")]
                [Newtonsoft.Json.JsonProperty("filter")]
                public LocationSearchRespRequestQueryFilter? Filter { get; set; }
                /**
                 * Type of search.
                 */
                [JsonConverter(typeof(StringValueEnumConverter<LocationSearchRespRequestQueryType>))]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
                    [Newtonsoft.Json.JsonProperty("street")]
                    public string? Street { get; set; }
                    [JsonPropertyName("streetWithNumber")]
                    [Newtonsoft.Json.JsonProperty("streetWithNumber")]
                    public string? StreetWithNumber { get; set; }
                    [JsonPropertyName("'number.full'")]
                    [Newtonsoft.Json.JsonProperty("'number.full'")]
                    public string? NumberFull { get; set; }
                    [JsonPropertyName("'number.part1'")]
                    [Newtonsoft.Json.JsonProperty("'number.part1'")]
                    public string? NumberPart1 { get; set; }
                    [JsonPropertyName("'number.part2'")]
                    [Newtonsoft.Json.JsonProperty("'number.part2'")]
                    public string? NumberPart2 { get; set; }
                    [JsonPropertyName("city")]
                    [Newtonsoft.Json.JsonProperty("city")]
                    public string? City { get; set; }
                    [JsonPropertyName("zip")]
                    [Newtonsoft.Json.JsonProperty("zip")]
                    public string? Zip { get; set; }
                    [JsonPropertyName("country")]
                    [Newtonsoft.Json.JsonProperty("country")]
                    public string? Country { get; set; }
                }
            }
        }
        public class LocationSearchRespErrors { }
    }
    public class LocationSearchRequestBody
    {
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required LocationSearchRequest Request { get; init; }
    }
    /**
     * Get location data
     * Foxentry allows you to get information about location based on the <b>dataScope</b> option. <b>Country</b> and <b>ID</b> parameters are required. You can either choose internal ID, which is assigned by Foxentry or external ID from the data source. <b>CZ external</b> = RUIAN, <b>PL external</b> = Gov data, <b>SK external does not exist</b>.
     * @param requestBody
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @returns Task<LocationGetResp?> Successful response
     * @throws ApiError
     */
    public async Task<LocationGetResponse> LocationGet(
      LocationGetRequestBody? requestBody,
      bool? foxentryIncludeRequestDetails = false
    )
    {
        var headers = new Dictionary<string, string>();
        if (foxentryIncludeRequestDetails != null)
        {
            headers.Add("foxentry-include-request-details", foxentryIncludeRequestDetails.Value.ToString());
        }
        var result = await this.HttpRequest.Request<LocationGetResp?>(
          new ApiRequestOptions
          {
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/location/get"
          }
        );

        return new LocationGetResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new LocationGetResponse.LocationGetHeaders
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

    public class LocationGetResponse
    {
        public LocationGetResp? Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required LocationGetHeaders Headers { get; init; }

        public class LocationGetHeaders
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
    public class LocationGetResp
    {
        [JsonPropertyName("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required LocationGetRespRequest Request { get; init; }
        [JsonPropertyName("response")]
        [Newtonsoft.Json.JsonProperty("response")]
        public required LocationGetResults Response { get; init; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public required IEnumerable<LocationGetRespErrors?> Errors { get; init; }
        public class LocationGetRespRequest : GlobalRequest
        {
            [JsonPropertyName("query")]
            [Newtonsoft.Json.JsonProperty("query")]
            public LocationGetRespRequestQuery? Query { get; set; }

            [JsonPropertyName("options")]
            [Newtonsoft.Json.JsonProperty("options")]
            public LocationGetRespRequestOptions? Options { get; set; }

            [JsonPropertyName("client")]
            [Newtonsoft.Json.JsonProperty("client")]
            public ClientRequest? Client { get; set; }

            [JsonPropertyName("endpoint")]
            [Newtonsoft.Json.JsonProperty("endpoint")]
            public required override string Endpoint { get; init; }

            public class LocationGetRespRequestQuery
            {
                [JsonPropertyName("country")]
                [Newtonsoft.Json.JsonProperty("country")]
                public required string Country { get; init; }
                [JsonPropertyName("id")]
                [Newtonsoft.Json.JsonProperty("id")]
                public required string Id { get; init; }
            }
            /**
             * Query options.
             */
            public class LocationGetRespRequestOptions
            {
                [JsonPropertyName("idType")]
                [Newtonsoft.Json.JsonProperty("idType")]
                public required LocationGetRespRequestOptionsIdType IdType { get; init; }
                [JsonPropertyName("dataScope")]
                [Newtonsoft.Json.JsonProperty("dataScope")]
                public required LocationGetRespRequestOptionsDataScope DataScope { get; init; }
                [JsonPropertyName("dataSource")]
                [Newtonsoft.Json.JsonProperty("dataSource")]
                public IEnumerable<string?>? DataSource { get; set; }
                [JsonPropertyName("zipFormat")]
                [Newtonsoft.Json.JsonProperty("zipFormat")]
                public bool? ZipFormat { get; set; }
                [JsonPropertyName("cityFormat")]
                [Newtonsoft.Json.JsonProperty("cityFormat")]
                public LocationGetRespRequestOptionsCityFormat? CityFormat { get; set; }
                /**
                 * Internal is assigned by Foxentry. External ID may vary for every supported country. CZ = RUIAN, PL = Government data, SK = no external ID.
                 */
                [JsonConverter(typeof(StringValueEnumConverter<LocationGetRespRequestOptionsIdType>))]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
                public enum LocationGetRespRequestOptionsDataScope
                {
                    [StringValue("basic")]
                    BASIC,
                    [StringValue("full")]
                    FULL
                }
                /**
                 * This option determines the format in which the city is returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
                 */
                [JsonConverter(typeof(StringValueEnumConverter<LocationGetRespRequestOptionsCityFormat>))]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        [Newtonsoft.Json.JsonProperty("request")]
        public required LocationGetRequest Request { get; init; }
    }
    /**
     * Localization
     * Foxentry allows you to check an area with GPS radius in order to return all the addresses within that area. It can also give you additional information about the addresses based on the <b>dataScope</b> option.<br><br>Please pay attention to the <b>singleLocationResultDistance</b> option, which determines the radius of the search area in meters.<br><br>
     * @param requestBody
     * @param foxentryIncludeRequestDetails Parameter to add details of your request.
     * @returns Task<LocationLocalizationResp?> Successful response
     * @throws ApiError
     */
    public async Task<LocationLocalizationResponse> LocationLocalization(
      LocationLocalizationRequestBody? requestBody,
      bool? foxentryIncludeRequestDetails = false
    )
    {
        var headers = new Dictionary<string, string>();
        if (foxentryIncludeRequestDetails != null)
        {
            headers.Add("foxentry-include-request-details", foxentryIncludeRequestDetails.Value.ToString());
        }
        var result = await this.HttpRequest.Request<LocationLocalizationResp?>(
          new ApiRequestOptions
          {
              Body = requestBody != null ? new JsonBody(requestBody) : null,
              Headers = headers,
              Method = HttpMethod.Post,
              Path = "/location/localize"
          }
        );

        return new LocationLocalizationResponse
        {
            Value = result.Value,
            Status = result.Status,
            Headers = new LocationLocalizationResponse.LocationLocalizationHeaders
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

    public class LocationLocalizationResponse
    {
        public LocationLocalizationResp? Value { get; set; }
        public HttpStatusCode Status { get; init; }
        public required LocationLocalizationHeaders Headers { get; init; }

        public class LocationLocalizationHeaders
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
    public class LocationLocalizationResp
    {
        [JsonPropertyName("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public required int Status { get; init; }
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required LocationLocalizationRespRequest Request { get; init; }
        [JsonPropertyName("response")]
        [Newtonsoft.Json.JsonProperty("response")]
        public required LocationLocalizationResults Response { get; init; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<LocationLocalizationRespErrors?>? Errors { get; set; }
        public class LocationLocalizationRespRequest : GlobalRequest
        {
            [JsonPropertyName("query")]
            [Newtonsoft.Json.JsonProperty("query")]
            public LocationLocalizationRespRequestQuery? Query { get; set; }

            [JsonPropertyName("options")]
            [Newtonsoft.Json.JsonProperty("options")]
            public LocationLocalizationRespRequestOptions? Options { get; set; }

            [JsonPropertyName("client")]
            [Newtonsoft.Json.JsonProperty("client")]
            public LocationLocalizationRespRequestClient? Client { get; set; }

            [JsonPropertyName("endpoint")]
            [Newtonsoft.Json.JsonProperty("endpoint")]
            public required override string Endpoint { get; init; }

            public class LocationLocalizationRespRequestQuery
            {
                [JsonPropertyName("lat")]
                [Newtonsoft.Json.JsonProperty("lat")]
                public required double Lat { get; init; }
                [JsonPropertyName("lon")]
                [Newtonsoft.Json.JsonProperty("lon")]
                public required double Lon { get; init; }
            }
            public class LocationLocalizationRespRequestOptions { }
            /**
             * Additional information about your user (from whom you've obtained the data sent in query) in order to specify the results in response. Used mainly in web forms when you need more relevant search/autocomplete results.
             */
            public class LocationLocalizationRespRequestClient
            {
                [JsonPropertyName("ip")]
                [Newtonsoft.Json.JsonProperty("ip")]
                public string? Ip { get; set; }
                [JsonPropertyName("country")]
                [Newtonsoft.Json.JsonProperty("country")]
                public string? Country { get; set; }
            }
        }
        public class LocationLocalizationRespErrors { }
    }
    public class LocationLocalizationRequestBody
    {
        [JsonPropertyName("request")]
        [Newtonsoft.Json.JsonProperty("request")]
        public required LocationLocalizationRequest Request { get; init; }
    }
}
