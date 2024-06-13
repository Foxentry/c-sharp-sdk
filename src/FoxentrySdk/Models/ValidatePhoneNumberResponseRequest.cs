
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
public class ValidatePhoneNumberResponseRequest
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
    public ValidatePhoneNumberResponseRequestQuery? Query { get; set; }
    [JsonPropertyName("options")]
    [Newtonsoft.Json.JsonProperty("options")]
    public ValidatePhoneNumberResponseRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    [Newtonsoft.Json.JsonProperty("client")]
    public ClientRequest? Client { get; set; }
    public class ValidatePhoneNumberResponseRequestQuery
    {
        [JsonPropertyName("prefix")]
        [Newtonsoft.Json.JsonProperty("prefix")]
        public string? Prefix { get; set; }
        [JsonPropertyName("number")]
        [Newtonsoft.Json.JsonProperty("number")]
        public string? Number { get; set; }
        [JsonPropertyName("numberWithPrefix")]
        [Newtonsoft.Json.JsonProperty("numberWithPrefix")]
        public string? NumberWithPrefix { get; set; }
    }
    /**
     * Query options.
     */
    public class ValidatePhoneNumberResponseRequestOptions
    {
        [JsonPropertyName("validationType")]
        [Newtonsoft.Json.JsonProperty("validationType")]
        public string? ValidationType { get; set; }
        [JsonPropertyName("allowedPrefixes")]
        [Newtonsoft.Json.JsonProperty("allowedPrefixes")]
        public IEnumerable<string?>? AllowedPrefixes { get; set; }
        [JsonPropertyName("formatNumber")]
        [Newtonsoft.Json.JsonProperty("formatNumber")]
        public bool? FormatNumber { get; set; }
        [JsonPropertyName("defaultPrefix")]
        [Newtonsoft.Json.JsonProperty("defaultPrefix")]
        public string? DefaultPrefix { get; set; }
    }
}

