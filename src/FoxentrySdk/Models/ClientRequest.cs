
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
/**
 * Additional information about your user (from whom you've obtained the data sent in query) in order to specify the results in response. Used mainly in web forms when you need more relevant search/autocomplete results.
 */
public class ClientRequest
{
    [JsonPropertyName("ip")]
    [Newtonsoft.Json.JsonProperty("ip")]
    public string? Ip { get; set; }
    [JsonPropertyName("country")]
    [Newtonsoft.Json.JsonProperty("country")]
    public string? Country { get; set; }
    [JsonPropertyName("location")]
    [Newtonsoft.Json.JsonProperty("location")]
    public ClientRequestLocation? Location { get; set; }/**
     * Latitude & longitude of the client's aprox location.
     */
    public class ClientRequestLocation
    {
        [JsonPropertyName("lat")]
        [Newtonsoft.Json.JsonProperty("lat")]
        public double? Lat { get; set; }
        [JsonPropertyName("lon")]
        [Newtonsoft.Json.JsonProperty("lon")]
        public double? Lon { get; set; }
    }
}

