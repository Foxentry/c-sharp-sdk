
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
public class EmailSearchRequest
{
    [JsonPropertyName("customId")]
    [Newtonsoft.Json.JsonProperty("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    [Newtonsoft.Json.JsonProperty("query")]
    public EmailSearchRequestQuery? Query { get; set; }
    [JsonPropertyName("options")]
    [Newtonsoft.Json.JsonProperty("options")]
    public EmailSearchRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    [Newtonsoft.Json.JsonProperty("client")]
    public ClientRequest? Client { get; set; }
    public class EmailSearchRequestQuery
    {
        [JsonPropertyName("value")]
        [Newtonsoft.Json.JsonProperty("value")]
        public required string Value { get; init; }
    }
    /**
     * Query options.
     */
    public class EmailSearchRequestOptions
    {
        [JsonPropertyName("resultsLimit")]
        [Newtonsoft.Json.JsonProperty("resultsLimit")]
        public double? ResultsLimit { get; set; }
    }
}

