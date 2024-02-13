
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
public class LocationLocalizationRequest
{
    [JsonPropertyName("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    public required LocationLocalizationRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    public LocationLocalizationRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    public LocationLocalizationRequestClient? Client { get; set; }
    public class LocationLocalizationRequestOptions : LocationRequestOptions
    {
        [JsonPropertyName("radius")]
        public int? Radius { get; set; }
        [JsonPropertyName("acceptNearest")]
        public bool? AcceptNearest { get; set; }
    }
    public class LocationLocalizationRequestQuery
    {
        [JsonPropertyName("lat")]
        public required double Lat { get; init; }
        [JsonPropertyName("lon")]
        public required double Lon { get; init; }
    }
    /**
     * Additional information about your user (from whom you've obtained the data sent in query) in order to specify the results in response. Used mainly in web forms when you need more relevant search/autocomplete results.
     */
    public class LocationLocalizationRequestClient
    {
        [JsonPropertyName("ip")]
        public string? Ip { get; set; }
        [JsonPropertyName("country")]
        public string? Country { get; set; }
    }
}

