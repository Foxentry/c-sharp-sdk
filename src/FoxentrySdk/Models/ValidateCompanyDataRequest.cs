
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
public class ValidateCompanyDataRequest
{
    [JsonPropertyName("customId")]
    [Newtonsoft.Json.JsonProperty("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    [Newtonsoft.Json.JsonProperty("query")]
    public required ValidateCompanyDataRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    [Newtonsoft.Json.JsonProperty("options")]
    public ValidateCompanyDataRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    [Newtonsoft.Json.JsonProperty("client")]
    public ClientRequest? Client { get; set; }
    public class ValidateCompanyDataRequestQuery
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
    /**
     * Query options.
     */
    public class ValidateCompanyDataRequestOptions
    {
        [JsonPropertyName("dataScope")]
        [Newtonsoft.Json.JsonProperty("dataScope")]
        public ValidateCompanyDataRequestOptionsDataScope? DataScope { get; set; }
        [JsonPropertyName("dataSource")]
        [Newtonsoft.Json.JsonProperty("dataSource")]
        public IEnumerable<string?>? DataSource { get; set; }
        [JsonPropertyName("resultsLimit")]
        [Newtonsoft.Json.JsonProperty("resultsLimit")]
        public int? ResultsLimit { get; set; }
        [JsonPropertyName("includeTerminatedSubjects")]
        [Newtonsoft.Json.JsonProperty("includeTerminatedSubjects")]
        public bool? IncludeTerminatedSubjects { get; set; }
        [JsonPropertyName("zipFormat")]
        [Newtonsoft.Json.JsonProperty("zipFormat")]
        public bool? ZipFormat { get; set; }
        [JsonPropertyName("cityFormat")]
        [Newtonsoft.Json.JsonProperty("cityFormat")]
        public ValidateCompanyDataRequestOptionsCityFormat? CityFormat { get; set; }
        [JsonPropertyName("countryFormat")]
        [Newtonsoft.Json.JsonProperty("countryFormat")]
        public ValidateCompanyDataRequestOptionsCountryFormat? CountryFormat { get; set; }
        /**
         * Data scope of returned data.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidateCompanyDataRequestOptionsDataScope>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ValidateCompanyDataRequestOptionsDataScope
        {
            [StringValue("basic")]
            BASIC,
            [StringValue("extended")]
            EXTENDED,
            [StringValue("full")]
            FULL
        }
        /**
         * This option determines the format in which the city is returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidateCompanyDataRequestOptionsCityFormat>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ValidateCompanyDataRequestOptionsCityFormat
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
        [JsonConverter(typeof(StringValueEnumConverter<ValidateCompanyDataRequestOptionsCountryFormat>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ValidateCompanyDataRequestOptionsCountryFormat
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

