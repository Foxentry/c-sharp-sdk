
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
public class EmailSearchResponse
{
    [JsonPropertyName("resultsCount")]
    [Newtonsoft.Json.JsonProperty("resultsCount")]
    public required double ResultsCount { get; init; }
    [JsonPropertyName("results")]
    [Newtonsoft.Json.JsonProperty("results")]
    public required IEnumerable<EmailSearchResponseResults?> Results { get; init; }
    public class EmailSearchResponseResults
    {
        [JsonPropertyName("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public required EmailSearchResponseResultsData Data { get; init; }
        public class EmailSearchResponseResultsData
        {
            [JsonPropertyName("email")]
            [Newtonsoft.Json.JsonProperty("email")]
            public required string Email { get; init; }
            [JsonPropertyName("user")]
            [Newtonsoft.Json.JsonProperty("user")]
            public string? User { get; set; }
            [JsonPropertyName("domain")]
            [Newtonsoft.Json.JsonProperty("domain")]
            public required string Domain { get; init; }
        }
    }
}

