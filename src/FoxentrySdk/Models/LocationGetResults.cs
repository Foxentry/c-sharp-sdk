
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
public class LocationGetResults
{
    [JsonPropertyName("results")]
    public required IEnumerable<LocationGetResultsResults?> Results { get; init; }
    public class LocationGetResultsResults
    {
        [JsonPropertyName("data")]
        public required LocationData Data { get; init; }
    }
}

