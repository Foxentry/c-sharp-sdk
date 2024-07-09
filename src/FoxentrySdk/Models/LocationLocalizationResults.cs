
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
public class LocationLocalizationResults
{
    [JsonPropertyName("resultsCount")]
    [Newtonsoft.Json.JsonProperty("resultsCount")]
    public required double ResultsCount { get; init; }
    [JsonPropertyName("results")]
    [Newtonsoft.Json.JsonProperty("results")]
    public required IEnumerable<LocationLocalizationResultsResults?> Results { get; init; }
    public class LocationLocalizationResultsResults
    {
        [JsonPropertyName("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public LocationData? Data { get; set; }
    }
}

