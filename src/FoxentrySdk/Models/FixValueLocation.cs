
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
public class FixValueLocation
{
    [JsonPropertyName("group")]
    [Newtonsoft.Json.JsonProperty("group")]
    public FixValueLocationGroup? Group { get; set; }
    [JsonPropertyName("type")]
    [Newtonsoft.Json.JsonProperty("type")]
    public FixValueLocationType? Type { get; set; }
    [JsonPropertyName("subtype")]
    [Newtonsoft.Json.JsonProperty("subtype")]
    public FixValueLocationSubtype? Subtype { get; set; }
    [JsonPropertyName("data")]
    [Newtonsoft.Json.JsonProperty("data")]
    public FixData? Data { get; set; }
    /**
     * Group of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixValueLocationGroup>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FixValueLocationGroup
    {
        [StringValue("VALUE")]
        VALUE
    }
    /**
     * Type of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixValueLocationType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FixValueLocationType
    {
        [StringValue("PART_CHANGED")]
        PART_CHANGED
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixValueLocationSubtype>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FixValueLocationSubtype
    {
        [StringValue("CITY")]
        CITY,
        [StringValue("NUMBER")]
        NUMBER,
        [StringValue("STREET")]
        STREET,
        [StringValue("ZIP")]
        ZIP
    }
}

