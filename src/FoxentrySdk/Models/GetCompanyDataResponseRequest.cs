
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
public class GetCompanyDataResponseRequest
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
    public GetCompanyDataResponseRequestQuery? Query { get; set; }
    [JsonPropertyName("options")]
    [Newtonsoft.Json.JsonProperty("options")]
    public GetCompanyDataResponseRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    [Newtonsoft.Json.JsonProperty("client")]
    public ClientRequest? Client { get; set; }
    public class GetCompanyDataResponseRequestQuery
    {
        [JsonPropertyName("country")]
        [Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }
        [JsonPropertyName("registrationNumber")]
        [Newtonsoft.Json.JsonProperty("registrationNumber")]
        public object? RegistrationNumber { get; set; }
    }
    /**
     * Query options.
     */
    public class GetCompanyDataResponseRequestOptions
    {
        [JsonPropertyName("dataScope")]
        [Newtonsoft.Json.JsonProperty("dataScope")]
        public GetCompanyDataResponseRequestOptionsDataScope? DataScope { get; set; }
        [JsonPropertyName("dataSource")]
        [Newtonsoft.Json.JsonProperty("dataSource")]
        public IEnumerable<string?>? DataSource { get; set; }
        [JsonPropertyName("includeTerminatedSubjects")]
        [Newtonsoft.Json.JsonProperty("includeTerminatedSubjects")]
        public bool? IncludeTerminatedSubjects { get; set; }
        /**
         * Data scope of returned data.
         */
        [JsonConverter(typeof(StringValueEnumConverter<GetCompanyDataResponseRequestOptionsDataScope>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

