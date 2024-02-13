
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
public class LocationData
{
    [JsonPropertyName("country")]
    public required string Country { get; init; }
    [JsonPropertyName("region")]
    public string? Region { get; set; }
    [JsonPropertyName("district")]
    public string? District { get; set; }
    [JsonPropertyName("cityDistrict")]
    public string? CityDistrict { get; set; }
    [JsonPropertyName("cityDistrictSpecial")]
    public string? CityDistrictSpecial { get; set; }
    [JsonPropertyName("cityPart")]
    public string? CityPart { get; set; }
    [JsonPropertyName("cityAdministrative")]
    public string? CityAdministrative { get; set; }
    [JsonPropertyName("cadastralArea")]
    public string? CadastralArea { get; set; }
    [JsonPropertyName("ids")]
    public required LocationDataIds Ids { get; init; }
    [JsonPropertyName("street")]
    public required string Street { get; init; }
    [JsonPropertyName("number")]
    public required LocationNumber Number { get; init; }
    [JsonPropertyName("streetWithNumber")]
    public required string StreetWithNumber { get; init; }
    [JsonPropertyName("city")]
    public required string City { get; init; }
    [JsonPropertyName("zip")]
    public required string Zip { get; init; }
    [JsonPropertyName("postOffice")]
    public LocationDataPostOffice? PostOffice { get; set; }
    [JsonPropertyName("geometry")]
    public DataGeometry? Geometry { get; set; }
    [JsonPropertyName("full")]
    public required string Full { get; init; }/**
     * Address internal & external ids.
     */
    public class LocationDataIds
    {
        [JsonPropertyName("internal")]
        public string? Internal { get; set; }
        [JsonPropertyName("external")]
        public string? External { get; set; }
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        [JsonPropertyName("discrict")]
        public string? Discrict { get; set; }
        [JsonPropertyName("cityDistrictSpecial")]
        public string? CityDistrictSpecial { get; set; }
        [JsonPropertyName("cityDistrict")]
        public string? CityDistrict { get; set; }
        [JsonPropertyName("cityPart")]
        public string? CityPart { get; set; }
        [JsonPropertyName("cadastralArea")]
        public string? CadastralArea { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
        [JsonPropertyName("street")]
        public string? Street { get; set; }
    }
    /**
     * In what post office jurisdiction the address falls under.
     */
    public class LocationDataPostOffice
    {
        [JsonPropertyName("name")]
        public required string Name { get; init; }
    }
}

