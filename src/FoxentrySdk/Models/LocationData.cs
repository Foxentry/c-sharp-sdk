
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
public class LocationData
{
    [JsonPropertyName("country")]
    [Newtonsoft.Json.JsonProperty("country")]
    public required string Country { get; init; }
    [JsonPropertyName("region")]
    [Newtonsoft.Json.JsonProperty("region")]
    public string? Region { get; set; }
    [JsonPropertyName("district")]
    [Newtonsoft.Json.JsonProperty("district")]
    public string? District { get; set; }
    [JsonPropertyName("cityDistrict")]
    [Newtonsoft.Json.JsonProperty("cityDistrict")]
    public string? CityDistrict { get; set; }
    [JsonPropertyName("cityDistrictSpecial")]
    [Newtonsoft.Json.JsonProperty("cityDistrictSpecial")]
    public string? CityDistrictSpecial { get; set; }
    [JsonPropertyName("cityPart")]
    [Newtonsoft.Json.JsonProperty("cityPart")]
    public string? CityPart { get; set; }
    [JsonPropertyName("cityAdministrative")]
    [Newtonsoft.Json.JsonProperty("cityAdministrative")]
    public string? CityAdministrative { get; set; }
    [JsonPropertyName("cadastralArea")]
    [Newtonsoft.Json.JsonProperty("cadastralArea")]
    public string? CadastralArea { get; set; }
    [JsonPropertyName("ids")]
    [Newtonsoft.Json.JsonProperty("ids")]
    public required LocationDataIds Ids { get; init; }
    [JsonPropertyName("street")]
    [Newtonsoft.Json.JsonProperty("street")]
    public required string Street { get; init; }
    [JsonPropertyName("number")]
    [Newtonsoft.Json.JsonProperty("number")]
    public required LocationNumber Number { get; init; }
    [JsonPropertyName("streetWithNumber")]
    [Newtonsoft.Json.JsonProperty("streetWithNumber")]
    public required string StreetWithNumber { get; init; }
    [JsonPropertyName("city")]
    [Newtonsoft.Json.JsonProperty("city")]
    public required string City { get; init; }
    [JsonPropertyName("zip")]
    [Newtonsoft.Json.JsonProperty("zip")]
    public required string Zip { get; init; }
    [JsonPropertyName("postOffice")]
    [Newtonsoft.Json.JsonProperty("postOffice")]
    public LocationDataPostOffice? PostOffice { get; set; }
    [JsonPropertyName("geometry")]
    [Newtonsoft.Json.JsonProperty("geometry")]
    public DataGeometry? Geometry { get; set; }
    [JsonPropertyName("full")]
    [Newtonsoft.Json.JsonProperty("full")]
    public required string Full { get; init; }/**
     * Address internal & external ids.
     */
    public class LocationDataIds
    {
        [JsonPropertyName("internal")]
        [Newtonsoft.Json.JsonProperty("internal")]
        public string? Internal { get; set; }
        [JsonPropertyName("external")]
        [Newtonsoft.Json.JsonProperty("external")]
        public string? External { get; set; }
        [JsonPropertyName("region")]
        [Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }
        [JsonPropertyName("discrict")]
        [Newtonsoft.Json.JsonProperty("discrict")]
        public string? Discrict { get; set; }
        [JsonPropertyName("cityDistrictSpecial")]
        [Newtonsoft.Json.JsonProperty("cityDistrictSpecial")]
        public string? CityDistrictSpecial { get; set; }
        [JsonPropertyName("cityDistrict")]
        [Newtonsoft.Json.JsonProperty("cityDistrict")]
        public string? CityDistrict { get; set; }
        [JsonPropertyName("cityPart")]
        [Newtonsoft.Json.JsonProperty("cityPart")]
        public string? CityPart { get; set; }
        [JsonPropertyName("cadastralArea")]
        [Newtonsoft.Json.JsonProperty("cadastralArea")]
        public string? CadastralArea { get; set; }
        [JsonPropertyName("city")]
        [Newtonsoft.Json.JsonProperty("city")]
        public string? City { get; set; }
        [JsonPropertyName("street")]
        [Newtonsoft.Json.JsonProperty("street")]
        public string? Street { get; set; }
    }
    /**
     * In what post office jurisdiction the address falls under.
     */
    public class LocationDataPostOffice
    {
        [JsonPropertyName("name")]
        [Newtonsoft.Json.JsonProperty("name")]
        public required string Name { get; init; }
    }
}

