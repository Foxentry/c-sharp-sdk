
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
 * Query options.
 */
public class LocationRequestOptionsSearch
{
    [JsonPropertyName("dataScope")]
    public LocationRequestOptionsSearchDataScope? DataScope { get; set; }
    [JsonPropertyName("dataSource")]
    public IEnumerable<string?>? DataSource { get; set; }
    [JsonPropertyName("resultsLimit")]
    public int? ResultsLimit { get; set; }
    [JsonPropertyName("filterMode")]
    public LocationRequestOptionsSearchFilterMode? FilterMode { get; set; }
    [JsonPropertyName("filterAcceptFormat")]
    public bool? FilterAcceptFormat { get; set; }
    [JsonPropertyName("filterAcceptAlternatives")]
    public bool? FilterAcceptAlternatives { get; set; }
    [JsonPropertyName("filterExactMatch")]
    public bool? FilterExactMatch { get; set; }
    [JsonPropertyName("zipFormat")]
    public bool? ZipFormat { get; set; }
    [JsonPropertyName("cityFormat")]
    public LocationRequestOptionsSearchCityFormat? CityFormat { get; set; }
    /**
     * Data scope of returned data.
     */
    [JsonConverter(typeof(StringValueEnumConverter<LocationRequestOptionsSearchDataScope>))]
    public enum LocationRequestOptionsSearchDataScope
    {
        [StringValue("basic")]
        BASIC,
        [StringValue("full")]
        FULL
    }
    /**
     * <b>Prefer</b> = prefer results matching the filter parameters, <b>limit</b> = limit to results matching the filter parameters.
     */
    [JsonConverter(typeof(StringValueEnumConverter<LocationRequestOptionsSearchFilterMode>))]
    public enum LocationRequestOptionsSearchFilterMode
    {
        [StringValue("limit")]
        LIMIT,
        [StringValue("prefer")]
        PREFER
    }
    /**
     * This option determines in what format is city returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
     */
    [JsonConverter(typeof(StringValueEnumConverter<LocationRequestOptionsSearchCityFormat>))]
    public enum LocationRequestOptionsSearchCityFormat
    {
        [StringValue("minimal")]
        MINIMAL,
        [StringValue("basic")]
        BASIC,
        [StringValue("extended")]
        EXTENDED
    }
}

