
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
public class LocationLocalizationRequest
{
    [JsonPropertyName("customId")]
    [Newtonsoft.Json.JsonProperty("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    [Newtonsoft.Json.JsonProperty("query")]
    public required LocationLocalizationRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    [Newtonsoft.Json.JsonProperty("options")]
    public LocationLocalizationRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    [Newtonsoft.Json.JsonProperty("client")]
    public LocationLocalizationRequestClient? Client { get; set; }
    public class LocationLocalizationRequestOptions : LocationRequestOptions
    {
        [JsonPropertyName("radius")]
        [Newtonsoft.Json.JsonProperty("radius")]
        public int? Radius { get; set; }
        [JsonPropertyName("acceptNearest")]
        [Newtonsoft.Json.JsonProperty("acceptNearest")]
        public bool? AcceptNearest { get; set; }
    }
    public class LocationLocalizationRequestQuery
    {
        [JsonPropertyName("lat")]
        [Newtonsoft.Json.JsonProperty("lat")]
        public required double Lat { get; init; }
        [JsonPropertyName("lon")]
        [Newtonsoft.Json.JsonProperty("lon")]
        public required double Lon { get; init; }
    }
    /**
     * Additional information about your user (from whom you've obtained the data sent in query) in order to specify the results in response. Used mainly in web forms when you need more relevant search/autocomplete results.
     */
    public class LocationLocalizationRequestClient
    {
        [JsonPropertyName("ip")]
        [Newtonsoft.Json.JsonProperty("ip")]
        public string? Ip { get; set; }
        [JsonPropertyName("country")]
        [Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }
    }
}

