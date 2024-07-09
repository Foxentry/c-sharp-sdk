
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
 * Address data from the official registry. Not validated by Foxentry.
 */
public class LocationOficial
{
    [JsonPropertyName("data")]
    [Newtonsoft.Json.JsonProperty("data")]
    public LocationOficialData? Data { get; set; }
    public class LocationOficialData
    {
        [JsonPropertyName("country")]
        [Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }
        [JsonPropertyName("street")]
        [Newtonsoft.Json.JsonProperty("street")]
        public string? Street { get; set; }
        [JsonPropertyName("number")]
        [Newtonsoft.Json.JsonProperty("number")]
        public LocationNumber? Number { get; set; }
        [JsonPropertyName("streetWithNumber")]
        [Newtonsoft.Json.JsonProperty("streetWithNumber")]
        public string? StreetWithNumber { get; set; }
        [JsonPropertyName("city")]
        [Newtonsoft.Json.JsonProperty("city")]
        public string? City { get; set; }
        [JsonPropertyName("zip")]
        [Newtonsoft.Json.JsonProperty("zip")]
        public string? Zip { get; set; }
        [JsonPropertyName("full")]
        [Newtonsoft.Json.JsonProperty("full")]
        public string? Full { get; set; }
    }
}

