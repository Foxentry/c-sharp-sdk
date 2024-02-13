
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
public class GetCompanyDataResponseRequest
{
    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; init; }
    [JsonPropertyName("code")]
    public required string Code { get; init; }
    [JsonPropertyName("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    public GetCompanyDataResponseRequestQuery? Query { get; set; }
    [JsonPropertyName("options")]
    public GetCompanyDataResponseRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    public ClientRequest? Client { get; set; }
    public class GetCompanyDataResponseRequestQuery
    {
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        [JsonPropertyName("registrationNumber")]
        public object? RegistrationNumber { get; set; }
    }
    /**
     * Query options.
     */
    public class GetCompanyDataResponseRequestOptions
    {
        [JsonPropertyName("dataScope")]
        public GetCompanyDataResponseRequestOptionsDataScope? DataScope { get; set; }
        [JsonPropertyName("dataSource")]
        public IEnumerable<string?>? DataSource { get; set; }
        [JsonPropertyName("includeTerminatedSubjects")]
        public bool? IncludeTerminatedSubjects { get; set; }
        /**
         * Data scope of returned data.
         */
        [JsonConverter(typeof(StringValueEnumConverter<GetCompanyDataResponseRequestOptionsDataScope>))]
        public enum GetCompanyDataResponseRequestOptionsDataScope
        {
            [StringValue("basic")]
            BASIC,
            [StringValue("extended")]
            EXTENDED,
            [StringValue("full")]
            FULL
        }
    }
}

