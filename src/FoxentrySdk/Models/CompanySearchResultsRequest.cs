
/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.cz
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Text.Json.Serialization;
using System.Text.Json;
using FoxentrySdk.Core;
namespace FoxentrySdk.Models;
public class CompanySearchResultsRequest
{
    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; init; }
    [JsonPropertyName("code")]
    public required string Code { get; init; }
    [JsonPropertyName("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    public CompanySearchResultsRequestQuery? Query { get; set; }
    [JsonPropertyName("options")]
    public CompanySearchResultsRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    public ClientRequest? Client { get; set; }
    public class CompanySearchResultsRequestQuery
    {
        [JsonPropertyName("type")]
        public CompanySearchResultsRequestQueryType? Type { get; set; }
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        [JsonPropertyName("filter")]
        public CompanySearchResultsRequestQueryFilter? Filter { get; set; }
        /**
         * Type of search.
         */
        [JsonConverter(typeof(StringValueEnumConverter<CompanySearchResultsRequestQueryType>))]
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
            public double? RegistrationNumber { get; set; }
            [JsonPropertyName("taxNumber")]
            public double? TaxNumber { get; set; }
            [JsonPropertyName("vatNumber")]
            public double? VatNumber { get; set; }
            [JsonPropertyName("name")]
            public string? Name { get; set; }
            [JsonPropertyName("country")]
            public string? Country { get; set; }
        }
    }
    /**
     * Query options.
     */
    public class CompanySearchResultsRequestOptions
    {
        [JsonPropertyName("dataScope")]
        public CompanySearchResultsRequestOptionsDataScope? DataScope { get; set; }
        [JsonPropertyName("dataSource")]
        public IEnumerable<string?>? DataSource { get; set; }
        [JsonPropertyName("resultsLimit")]
        public int? ResultsLimit { get; set; }
        [JsonPropertyName("includeTerminatedSubjects")]
        public bool? IncludeTerminatedSubjects { get; set; }
        [JsonPropertyName("filterMode")]
        public CompanySearchResultsRequestOptionsFilterMode? FilterMode { get; set; }
        [JsonPropertyName("filterAcceptFormat")]
        public bool? FilterAcceptFormat { get; set; }
        [JsonPropertyName("filterAcceptAlternatives")]
        public bool? FilterAcceptAlternatives { get; set; }
        [JsonPropertyName("filterExactMatch")]
        public bool? FilterExactMatch { get; set; }
        [JsonPropertyName("zipFormat")]
        public bool? ZipFormat { get; set; }
        [JsonPropertyName("cityFormat")]
        public CompanySearchResultsRequestOptionsCityFormat? CityFormat { get; set; }
        /**
         * Data scope of returned data.
         */
        [JsonConverter(typeof(StringValueEnumConverter<CompanySearchResultsRequestOptionsDataScope>))]
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
        public enum CompanySearchResultsRequestOptionsFilterMode
        {
            [StringValue("limit")]
            LIMIT,
            [StringValue("prefer")]
            PREFER
        }
        /**
         * This option determines in what format is city returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
         */
        [JsonConverter(typeof(StringValueEnumConverter<CompanySearchResultsRequestOptionsCityFormat>))]
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

