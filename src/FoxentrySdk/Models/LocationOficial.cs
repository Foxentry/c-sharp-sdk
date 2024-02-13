
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
 * Address data from the official registry. Not validated by Foxentry.
 */
public class LocationOficial
{
    [JsonPropertyName("data")]
    public LocationOficialData? Data { get; set; }
    public class LocationOficialData
    {
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        [JsonPropertyName("street")]
        public string? Street { get; set; }
        [JsonPropertyName("number")]
        public LocationNumber? Number { get; set; }
        [JsonPropertyName("streetWithNumber")]
        public string? StreetWithNumber { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
        [JsonPropertyName("zip")]
        public string? Zip { get; set; }
        [JsonPropertyName("full")]
        public string? Full { get; set; }
    }
}

