
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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Schema;
using FoxentrySdk.Core;
namespace FoxentrySdk.Models;
/**
 * Query options.
 */
public class LocationRequestOptions
{
    [JsonPropertyName("dataScope")]
    [Newtonsoft.Json.JsonProperty("dataScope")]
    public LocationRequestOptionsDataScope? DataScope { get; set; }
    [JsonPropertyName("dataSource")]
    [Newtonsoft.Json.JsonProperty("dataSource")]
    public IEnumerable<string?>? DataSource { get; set; }
    [JsonPropertyName("resultsLimit")]
    [Newtonsoft.Json.JsonProperty("resultsLimit")]
    public int? ResultsLimit { get; set; }
    [JsonPropertyName("zipFormat")]
    [Newtonsoft.Json.JsonProperty("zipFormat")]
    public bool? ZipFormat { get; set; }
    [JsonPropertyName("cityFormat")]
    [Newtonsoft.Json.JsonProperty("cityFormat")]
    public LocationRequestOptionsCityFormat? CityFormat { get; set; }
    /**
     * Data scope of returned data.
     */
    [JsonConverter(typeof(StringValueEnumConverter<LocationRequestOptionsDataScope>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LocationRequestOptionsDataScope
    {
        [StringValue("basic")]
        BASIC,
        [StringValue("full")]
        FULL
    }
    /**
     * This option determines the format in which the city is returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
     */
    [JsonConverter(typeof(StringValueEnumConverter<LocationRequestOptionsCityFormat>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

