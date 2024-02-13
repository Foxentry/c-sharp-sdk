
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
public class FixValueLocation
{
    [JsonPropertyName("group")]
    public FixValueLocationGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public FixValueLocationType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public FixValueLocationSubtype? Subtype { get; set; }
    [JsonPropertyName("data")]
    public FixData? Data { get; set; }
    /**
     * Group of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixValueLocationGroup>))]
    public enum FixValueLocationGroup
    {
        [StringValue("VALUE")]
        VALUE
    }
    /**
     * Type of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixValueLocationType>))]
    public enum FixValueLocationType
    {
        [StringValue("PART_CHANGED")]
        PART_CHANGED
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixValueLocationSubtype>))]
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

