
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
public class EmailSearchResponse
{
    [JsonPropertyName("resultsCount")]
    public required double ResultsCount { get; init; }
    [JsonPropertyName("results")]
    public required IEnumerable<EmailSearchResponseResults?> Results { get; init; }
    public class EmailSearchResponseResults
    {
        [JsonPropertyName("data")]
        public required EmailSearchResponseResultsData Data { get; init; }
        public class EmailSearchResponseResultsData
        {
            [JsonPropertyName("email")]
            public required string Email { get; init; }
            [JsonPropertyName("user")]
            public string? User { get; set; }
            [JsonPropertyName("domain")]
            public required string Domain { get; init; }
        }
    }
}

