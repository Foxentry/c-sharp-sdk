
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
public class ValidateCompanyDataResultsRequest
{
    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; init; }
    [JsonPropertyName("code")]
    public required string Code { get; init; }
    [JsonPropertyName("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    public ValidateCompanyDataResultsRequestQuery? Query { get; set; }
    [JsonPropertyName("options")]
    public ValidateCompanyDataResultsRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    public ClientRequest? Client { get; set; }
    public class ValidateCompanyDataResultsRequestQuery
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        [JsonPropertyName("registrationNumber")]
        public string? RegistrationNumber { get; set; }
        [JsonPropertyName("taxNumber")]
        public string? TaxNumber { get; set; }
        [JsonPropertyName("vatNumber")]
        public string? VatNumber { get; set; }
    }
    /**
     * Query options.
     */
    public class ValidateCompanyDataResultsRequestOptions
    {
        [JsonPropertyName("dataScope")]
        public ValidateCompanyDataResultsRequestOptionsDataScope? DataScope { get; set; }
        [JsonPropertyName("dataSource")]
        public IEnumerable<string?>? DataSource { get; set; }
        [JsonPropertyName("includeTerminatedSubjects")]
        public bool? IncludeTerminatedSubjects { get; set; }
        [JsonPropertyName("resultsLimit")]
        public int? ResultsLimit { get; set; }
        [JsonPropertyName("zipFormat")]
        public bool? ZipFormat { get; set; }
        [JsonPropertyName("cityFormat")]
        public ValidateCompanyDataResultsRequestOptionsCityFormat? CityFormat { get; set; }
        /**
         * Data scope of returned data.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidateCompanyDataResultsRequestOptionsDataScope>))]
        public enum ValidateCompanyDataResultsRequestOptionsDataScope
        {
            [StringValue("basic")]
            BASIC,
            [StringValue("extended")]
            EXTENDED,
            [StringValue("full")]
            FULL
        }
        /**
         * This option determines in what format is city returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidateCompanyDataResultsRequestOptionsCityFormat>))]
        public enum ValidateCompanyDataResultsRequestOptionsCityFormat
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

