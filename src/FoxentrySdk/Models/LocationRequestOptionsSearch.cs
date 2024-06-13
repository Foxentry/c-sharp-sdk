
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
public class LocationRequestOptionsSearch
{
    [JsonPropertyName("dataScope")]
    [Newtonsoft.Json.JsonProperty("dataScope")]
    public LocationRequestOptionsSearchDataScope? DataScope { get; set; }
    [JsonPropertyName("dataSource")]
    [Newtonsoft.Json.JsonProperty("dataSource")]
    public IEnumerable<string?>? DataSource { get; set; }
    [JsonPropertyName("resultsLimit")]
    [Newtonsoft.Json.JsonProperty("resultsLimit")]
    public int? ResultsLimit { get; set; }
    [JsonPropertyName("allowPartialResults")]
    [Newtonsoft.Json.JsonProperty("allowPartialResults")]
    public bool? AllowPartialResults { get; set; }
    [JsonPropertyName("filterMode")]
    [Newtonsoft.Json.JsonProperty("filterMode")]
    public LocationRequestOptionsSearchFilterMode? FilterMode { get; set; }
    [JsonPropertyName("filterAcceptFormat")]
    [Newtonsoft.Json.JsonProperty("filterAcceptFormat")]
    public bool? FilterAcceptFormat { get; set; }
    [JsonPropertyName("filterAcceptAlternatives")]
    [Newtonsoft.Json.JsonProperty("filterAcceptAlternatives")]
    public bool? FilterAcceptAlternatives { get; set; }
    [JsonPropertyName("filterExactMatch")]
    [Newtonsoft.Json.JsonProperty("filterExactMatch")]
    public bool? FilterExactMatch { get; set; }
    [JsonPropertyName("zipFormat")]
    [Newtonsoft.Json.JsonProperty("zipFormat")]
    public bool? ZipFormat { get; set; }
    [JsonPropertyName("cityFormat")]
    [Newtonsoft.Json.JsonProperty("cityFormat")]
    public LocationRequestOptionsSearchCityFormat? CityFormat { get; set; }
    /**
     * Data scope of returned data.
     */
    [JsonConverter(typeof(StringValueEnumConverter<LocationRequestOptionsSearchDataScope>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LocationRequestOptionsSearchFilterMode
    {
        [StringValue("limit")]
        LIMIT,
        [StringValue("prefer")]
        PREFER
    }
    /**
     * This option determines the format in which the city is returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
     */
    [JsonConverter(typeof(StringValueEnumConverter<LocationRequestOptionsSearchCityFormat>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

