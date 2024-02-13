
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
public class EmailSearchRequest
{
    [JsonPropertyName("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    public EmailSearchRequestQuery? Query { get; set; }
    [JsonPropertyName("options")]
    public EmailSearchRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    public ClientRequest? Client { get; set; }
    public class EmailSearchRequestQuery
    {
        [JsonPropertyName("value")]
        public required string Value { get; init; }
    }
    /**
     * Query options.
     */
    public class EmailSearchRequestOptions
    {
        [JsonPropertyName("resultsLimit")]
        public double? ResultsLimit { get; set; }
    }
}

