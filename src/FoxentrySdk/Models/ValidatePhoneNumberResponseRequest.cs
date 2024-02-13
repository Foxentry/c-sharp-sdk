
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
public class ValidatePhoneNumberResponseRequest
{
    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; init; }
    [JsonPropertyName("code")]
    public required string Code { get; init; }
    [JsonPropertyName("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    public ValidatePhoneNumberResponseRequestQuery? Query { get; set; }
    [JsonPropertyName("options")]
    public ValidatePhoneNumberResponseRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    public ClientRequest? Client { get; set; }
    public class ValidatePhoneNumberResponseRequestQuery
    {
        [JsonPropertyName("prefix")]
        public string? Prefix { get; set; }
        [JsonPropertyName("number")]
        public string? Number { get; set; }
        [JsonPropertyName("numberWithPrefix")]
        public string? NumberWithPrefix { get; set; }
    }
    /**
     * Query options.
     */
    public class ValidatePhoneNumberResponseRequestOptions
    {
        [JsonPropertyName("validationType")]
        public string? ValidationType { get; set; }
        [JsonPropertyName("allowedPrefixes")]
        public IEnumerable<string?>? AllowedPrefixes { get; set; }
        [JsonPropertyName("formatNumber")]
        public bool? FormatNumber { get; set; }
        [JsonPropertyName("defaultPrefix")]
        public string? DefaultPrefix { get; set; }
    }
}

