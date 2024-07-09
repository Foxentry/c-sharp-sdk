
/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Schema;
using FoxentrySdk.Core;
namespace FoxentrySdk.Models;
public class CompanySearchResultsRequest
{
    [JsonPropertyName("endpoint")]
    [Newtonsoft.Json.JsonProperty("endpoint")]
    public required string Endpoint { get; init; }
    [JsonPropertyName("code")]
    [Newtonsoft.Json.JsonProperty("code")]
    public required string Code { get; init; }
    [JsonPropertyName("customId")]
    [Newtonsoft.Json.JsonProperty("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    [Newtonsoft.Json.JsonProperty("query")]
    public CompanySearchResultsRequestQuery? Query { get; set; }
    [JsonPropertyName("options")]
    [Newtonsoft.Json.JsonProperty("options")]
    public CompanySearchResultsRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    [Newtonsoft.Json.JsonProperty("client")]
    public ClientRequest? Client { get; set; }
    public class CompanySearchResultsRequestQuery
    {
        [JsonPropertyName("type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public CompanySearchResultsRequestQueryType? Type { get; set; }
        [JsonPropertyName("value")]
        [Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }
        [JsonPropertyName("filter")]
        [Newtonsoft.Json.JsonProperty("filter")]
        public CompanySearchResultsRequestQueryFilter? Filter { get; set; }
        /**
         * Type of search.
         */
        [JsonConverter(typeof(StringValueEnumConverter<CompanySearchResultsRequestQueryType>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CompanySearchResultsRequestQueryType
        {
            [StringValue("name")]
            NAME,
            [StringValue("registrationNumber")]
            REGISTRATION_NUMBER,
            [StringValue("taxNumber")]
            TAX_NUMBER,
            [StringValue("vatNumber")]
            VAT_NUMBER
        }/**
         * Additional filter in order to specify the search results. You can for example set as a filter country CZ, so the the search engine would look for the companies only in the Czech republic. Pay attention to the options, which determines how the filter should behave.
         */
        public class CompanySearchResultsRequestQueryFilter
        {
            [JsonPropertyName("registrationNumber")]
            [Newtonsoft.Json.JsonProperty("registrationNumber")]
            public double? RegistrationNumber { get; set; }
            [JsonPropertyName("taxNumber")]
            [Newtonsoft.Json.JsonProperty("taxNumber")]
            public double? TaxNumber { get; set; }
            [JsonPropertyName("vatNumber")]
            [Newtonsoft.Json.JsonProperty("vatNumber")]
            public double? VatNumber { get; set; }
            [JsonPropertyName("name")]
            [Newtonsoft.Json.JsonProperty("name")]
            public string? Name { get; set; }
            [JsonPropertyName("country")]
            [Newtonsoft.Json.JsonProperty("country")]
            public string? Country { get; set; }
        }
    }
    /**
     * Query options.
     */
    public class CompanySearchResultsRequestOptions
    {
        [JsonPropertyName("dataScope")]
        [Newtonsoft.Json.JsonProperty("dataScope")]
        public CompanySearchResultsRequestOptionsDataScope? DataScope { get; set; }
        [JsonPropertyName("dataSource")]
        [Newtonsoft.Json.JsonProperty("dataSource")]
        public IEnumerable<string?>? DataSource { get; set; }
        [JsonPropertyName("resultsLimit")]
        [Newtonsoft.Json.JsonProperty("resultsLimit")]
        public int? ResultsLimit { get; set; }
        [JsonPropertyName("includeTerminatedSubjects")]
        [Newtonsoft.Json.JsonProperty("includeTerminatedSubjects")]
        public bool? IncludeTerminatedSubjects { get; set; }
        [JsonPropertyName("filterMode")]
        [Newtonsoft.Json.JsonProperty("filterMode")]
        public CompanySearchResultsRequestOptionsFilterMode? FilterMode { get; set; }
        [JsonPropertyName("filterAcceptFormat")]
        [Newtonsoft.Json.JsonProperty("filterAcceptFormat")]
        public bool? FilterAcceptFormat { get; set; }
        [JsonPropertyName("filterAcceptAlternatives")]
        [Newtonsoft.Json.JsonProperty("filterAcceptAlternatives")]
        public bool? FilterAcceptAlternatives { get; set; }
        [JsonPropertyName("filterExactMatch")]
        [Newtonsoft.Json.JsonProperty("filterExactMatch")]
        public bool? FilterExactMatch { get; set; }
        [JsonPropertyName("zipFormat")]
        [Newtonsoft.Json.JsonProperty("zipFormat")]
        public bool? ZipFormat { get; set; }
        [JsonPropertyName("cityFormat")]
        [Newtonsoft.Json.JsonProperty("cityFormat")]
        public CompanySearchResultsRequestOptionsCityFormat? CityFormat { get; set; }
        /**
         * Data scope of returned data.
         */
        [JsonConverter(typeof(StringValueEnumConverter<CompanySearchResultsRequestOptionsDataScope>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CompanySearchResultsRequestOptionsDataScope
        {
            [StringValue("basic")]
            BASIC,
            [StringValue("extended")]
            EXTENDED,
            [StringValue("full")]
            FULL
        }
        /**
         * <b>Prefer</b> = prefer results matching the filter parameters, <b>limit</b> = limit to results matching the filter parameters.
         */
        [JsonConverter(typeof(StringValueEnumConverter<CompanySearchResultsRequestOptionsFilterMode>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CompanySearchResultsRequestOptionsFilterMode
        {
            [StringValue("limit")]
            LIMIT,
            [StringValue("prefer")]
            PREFER
        }
        /**
         * This option determines the format in which the city is returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
         */
        [JsonConverter(typeof(StringValueEnumConverter<CompanySearchResultsRequestOptionsCityFormat>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CompanySearchResultsRequestOptionsCityFormat
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

