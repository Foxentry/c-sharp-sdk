
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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Schema;
using FoxentrySdk.Core;
namespace FoxentrySdk.Models;
public class CompanySearchRequest
{
    [JsonPropertyName("customId")]
    [Newtonsoft.Json.JsonProperty("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    [Newtonsoft.Json.JsonProperty("query")]
    public required CompanySearchRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    [Newtonsoft.Json.JsonProperty("options")]
    public CompanySearchRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    [Newtonsoft.Json.JsonProperty("client")]
    public ClientRequest? Client { get; set; }
    public class CompanySearchRequestQuery
    {
        [JsonPropertyName("type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public required CompanySearchRequestQueryType Type { get; init; }
        [JsonPropertyName("value")]
        [Newtonsoft.Json.JsonProperty("value")]
        public required string Value { get; init; }
        [JsonPropertyName("filter")]
        [Newtonsoft.Json.JsonProperty("filter")]
        public CompanySearchRequestQueryFilter? Filter { get; set; }
        /**
         * Type of search.
         */
        [JsonConverter(typeof(StringValueEnumConverter<CompanySearchRequestQueryType>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CompanySearchRequestQueryType
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
        public class CompanySearchRequestQueryFilter
        {
            [JsonPropertyName("name")]
            [Newtonsoft.Json.JsonProperty("name")]
            public string? Name { get; set; }
            [JsonPropertyName("country")]
            [Newtonsoft.Json.JsonProperty("country")]
            public string? Country { get; set; }
            [JsonPropertyName("registrationNumber")]
            [Newtonsoft.Json.JsonProperty("registrationNumber")]
            public string? RegistrationNumber { get; set; }
            [JsonPropertyName("taxNumber")]
            [Newtonsoft.Json.JsonProperty("taxNumber")]
            public string? TaxNumber { get; set; }
            [JsonPropertyName("vatNumber")]
            [Newtonsoft.Json.JsonProperty("vatNumber")]
            public string? VatNumber { get; set; }
        }
    }
    /**
     * Query options.
     */
    public class CompanySearchRequestOptions
    {
        [JsonPropertyName("dataScope")]
        [Newtonsoft.Json.JsonProperty("dataScope")]
        public CompanySearchRequestOptionsDataScope? DataScope { get; set; }
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
        public CompanySearchRequestOptionsFilterMode? FilterMode { get; set; }
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
        public CompanySearchRequestOptionsCityFormat? CityFormat { get; set; }
        [JsonPropertyName("countryFormat")]
        [Newtonsoft.Json.JsonProperty("countryFormat")]
        public CompanySearchRequestOptionsCountryFormat? CountryFormat { get; set; }
        /**
         * Data scope of returned data.
         */
        [JsonConverter(typeof(StringValueEnumConverter<CompanySearchRequestOptionsDataScope>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CompanySearchRequestOptionsDataScope
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
        [JsonConverter(typeof(StringValueEnumConverter<CompanySearchRequestOptionsFilterMode>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CompanySearchRequestOptionsFilterMode
        {
            [StringValue("limit")]
            LIMIT,
            [StringValue("prefer")]
            PREFER
        }
        /**
         * This option determines the format in which the city is returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
         */
        [JsonConverter(typeof(StringValueEnumConverter<CompanySearchRequestOptionsCityFormat>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CompanySearchRequestOptionsCityFormat
        {
            [StringValue("minimal")]
            MINIMAL,
            [StringValue("basic")]
            BASIC,
            [StringValue("extended")]
            EXTENDED
        }
        /**
         * This option determines the format in which the country is returned. Choices include local and international variants with their shortened counterparts as well as ISO 3166 alpha codes.
         */
        [JsonConverter(typeof(StringValueEnumConverter<CompanySearchRequestOptionsCountryFormat>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CompanySearchRequestOptionsCountryFormat
        {
            [StringValue("alpha2")]
            ALPHA2,
            [StringValue("alpha3")]
            ALPHA3,
            [StringValue("local")]
            LOCAL,
            [StringValue("localShortened")]
            LOCAL_SHORTENED,
            [StringValue("international")]
            INTERNATIONAL,
            [StringValue("internationalShortened")]
            INTERNATIONAL_SHORTENED
        }
    }
}

