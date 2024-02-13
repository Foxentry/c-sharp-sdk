
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
/**
 * Additional information about your user (from whom you've obtained the data sent in query) in order to specify the results in response. Used mainly in web forms when you need more relevant search/autocomplete results.
 */
public class ClientRequest
{
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
    [JsonPropertyName("country")]
    public string? Country { get; set; }
    [JsonPropertyName("location")]
    public ClientRequestLocation? Location { get; set; }/**
     * Latitude & longitude of the client's aprox location.
     */
    public class ClientRequestLocation
    {
        [JsonPropertyName("lat")]
        public double? Lat { get; set; }
        [JsonPropertyName("lon")]
        public double? Lon { get; set; }
    }
}

