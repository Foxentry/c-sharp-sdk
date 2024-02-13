
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
public class LocationLocalizationResults
{
    [JsonPropertyName("resultsCount")]
    public required double ResultsCount { get; init; }
    [JsonPropertyName("results")]
    public required IEnumerable<LocationLocalizationResultsResults?> Results { get; init; }
    public class LocationLocalizationResultsResults
    {
        [JsonPropertyName("data")]
        public LocationData? Data { get; set; }
    }
}

