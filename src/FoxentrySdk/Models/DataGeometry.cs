
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
public class DataGeometry
{
    [JsonPropertyName("gps")]
    [Newtonsoft.Json.JsonProperty("gps")]
    public DataGeometryGps? Gps { get; set; }
    [JsonPropertyName("custom")]
    [Newtonsoft.Json.JsonProperty("custom")]
    public IEnumerable<DataGeometryCustom?>? Custom { get; set; }
    public class DataGeometryGps
    {
        [JsonPropertyName("lat")]
        [Newtonsoft.Json.JsonProperty("lat")]
        public required double Lat { get; init; }
        [JsonPropertyName("lon")]
        [Newtonsoft.Json.JsonProperty("lon")]
        public required double Lon { get; init; }
    }
    public class DataGeometryCustom
    {
        [JsonPropertyName("type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public DataGeometryCustomType? Type { get; set; }
        [JsonPropertyName("coordinates")]
        [Newtonsoft.Json.JsonProperty("coordinates")]
        public DataGeometryCustomCoordinates? Coordinates { get; set; }
        /**
         * Type of coordinate system.
         */
        [JsonConverter(typeof(StringValueEnumConverter<DataGeometryCustomType>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum DataGeometryCustomType
        {
            [StringValue("JTSK")]
            JTSK,
            [StringValue("ETRS89")]
            ETRS89
        }
        public class DataGeometryCustomCoordinates
        {
            [JsonPropertyName("'x'")]
            [Newtonsoft.Json.JsonProperty("'x'")]
            public double? X { get; set; }
            [JsonPropertyName("'y'")]
            [Newtonsoft.Json.JsonProperty("'y'")]
            public double? Y { get; set; }
        }
    }
}

