
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
public class LocationRequestOptions
{
    [JsonPropertyName("dataScope")]
    public LocationRequestOptionsDataScope? DataScope { get; set; }
    [JsonPropertyName("dataSource")]
    public IEnumerable<string?>? DataSource { get; set; }
    [JsonPropertyName("resultsLimit")]
    public int? ResultsLimit { get; set; }
    [JsonPropertyName("zipFormat")]
    public bool? ZipFormat { get; set; }
    [JsonPropertyName("cityFormat")]
    public LocationRequestOptionsCityFormat? CityFormat { get; set; }
    /**
     * Data scope of returned data.
     */
    [JsonConverter(typeof(StringValueEnumConverter<LocationRequestOptionsDataScope>))]
    public enum LocationRequestOptionsDataScope
    {
        [StringValue("basic")]
        BASIC,
        [StringValue("full")]
        FULL
    }
    /**
     * This option determines in what format is city returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
     */
    [JsonConverter(typeof(StringValueEnumConverter<LocationRequestOptionsCityFormat>))]
    public enum LocationRequestOptionsCityFormat
    {
        [StringValue("minimal")]
        MINIMAL,
        [StringValue("basic")]
        BASIC,
        [StringValue("extended")]
        EXTENDED
    }
}

