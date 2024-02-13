
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
public class LocationGetRequest
{
    [JsonPropertyName("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    public required LocationGetRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    public LocationGetRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    public ClientRequest? Client { get; set; }
    public class LocationGetRequestQuery
    {
        [JsonPropertyName("country")]
        public required string Country { get; init; }
        [JsonPropertyName("id")]
        public required string Id { get; init; }
    }
    /**
     * Query options.
     */
    public class LocationGetRequestOptions
    {
        [JsonPropertyName("idType")]
        public required LocationGetRequestOptionsIdType IdType { get; init; }
        [JsonPropertyName("dataScope")]
        public required LocationGetRequestOptionsDataScope DataScope { get; init; }
        [JsonPropertyName("dataSource")]
        public IEnumerable<string?>? DataSource { get; set; }
        [JsonPropertyName("zipFormat")]
        public bool? ZipFormat { get; set; }
        [JsonPropertyName("cityFormat")]
        public LocationGetRequestOptionsCityFormat? CityFormat { get; set; }
        /**
         * Internal is assigned by Foxentry. External ID may vary for every supported country. CZ = RUIAN, PL = Government data, SK = no external ID.
         */
        [JsonConverter(typeof(StringValueEnumConverter<LocationGetRequestOptionsIdType>))]
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
        public enum LocationGetRequestOptionsDataScope
        {
            [StringValue("basic")]
            BASIC,
            [StringValue("full")]
            FULL
        }
        /**
         * This option determines in what format is city returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
         */
        [JsonConverter(typeof(StringValueEnumConverter<LocationGetRequestOptionsCityFormat>))]
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

