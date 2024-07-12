
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
public class LocationGetRequest
{
    [JsonPropertyName("customId")]
    [Newtonsoft.Json.JsonProperty("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    [Newtonsoft.Json.JsonProperty("query")]
    public required LocationGetRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    [Newtonsoft.Json.JsonProperty("options")]
    public LocationGetRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    [Newtonsoft.Json.JsonProperty("client")]
    public ClientRequest? Client { get; set; }
    public class LocationGetRequestQuery
    {
        [JsonPropertyName("country")]
        [Newtonsoft.Json.JsonProperty("country")]
        public required string Country { get; init; }
        [JsonPropertyName("id")]
        [Newtonsoft.Json.JsonProperty("id")]
        public required string Id { get; init; }
    }
    /**
     * Query options.
     */
    public class LocationGetRequestOptions
    {
        [JsonPropertyName("idType")]
        [Newtonsoft.Json.JsonProperty("idType")]
        public required LocationGetRequestOptionsIdType IdType { get; init; }
        [JsonPropertyName("dataScope")]
        [Newtonsoft.Json.JsonProperty("dataScope")]
        public required LocationGetRequestOptionsDataScope DataScope { get; init; }
        [JsonPropertyName("dataSource")]
        [Newtonsoft.Json.JsonProperty("dataSource")]
        public IEnumerable<string?>? DataSource { get; set; }
        [JsonPropertyName("zipFormat")]
        [Newtonsoft.Json.JsonProperty("zipFormat")]
        public bool? ZipFormat { get; set; }
        [JsonPropertyName("cityFormat")]
        [Newtonsoft.Json.JsonProperty("cityFormat")]
        public LocationGetRequestOptionsCityFormat? CityFormat { get; set; }
        /**
         * Internal is assigned by Foxentry. External ID may vary for every supported country. CZ = RUIAN, PL = Government data, SK = no external ID.
         */
        [JsonConverter(typeof(StringValueEnumConverter<LocationGetRequestOptionsIdType>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum LocationGetRequestOptionsIdType
        {
            [StringValue("internal")]
            INTERNAL,
            [StringValue("external")]
            EXTERNAL
        }
        /**
         * Data scope of returned data.
         */
        [JsonConverter(typeof(StringValueEnumConverter<LocationGetRequestOptionsDataScope>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum LocationGetRequestOptionsDataScope
        {
            [StringValue("basic")]
            BASIC,
            [StringValue("full")]
            FULL
        }
        /**
         * This option determines the format in which the city is returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
         */
        [JsonConverter(typeof(StringValueEnumConverter<LocationGetRequestOptionsCityFormat>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum LocationGetRequestOptionsCityFormat
        {
            [StringValue("minimal")]
            MINIMAL,
            [StringValue("basic")]
            BASIC,
            [StringValue("extended")]
            EXTENDED
        }
    }
}

