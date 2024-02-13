
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
public class DataGeometry
{
    [JsonPropertyName("gps")]
    public DataGeometryGps? Gps { get; set; }
    [JsonPropertyName("custom")]
    public IEnumerable<DataGeometryCustom?>? Custom { get; set; }
    public class DataGeometryGps
    {
        [JsonPropertyName("lat")]
        public required double Lat { get; init; }
        [JsonPropertyName("lon")]
        public required double Lon { get; init; }
    }
    public class DataGeometryCustom
    {
        [JsonPropertyName("type")]
        public DataGeometryCustomType? Type { get; set; }
        [JsonPropertyName("coordinates")]
        public DataGeometryCustomCoordinates? Coordinates { get; set; }
        /**
         * Type of coordinate system.
         */
        [JsonConverter(typeof(StringValueEnumConverter<DataGeometryCustomType>))]
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
            public double? X { get; set; }
            [JsonPropertyName("'y'")]
            public double? Y { get; set; }
        }
    }
}

