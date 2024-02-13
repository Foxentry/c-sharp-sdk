
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
public class FixSyntaxLocation
{
    [JsonPropertyName("group")]
    public FixSyntaxLocationGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public FixSyntaxLocationType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public FixSyntaxLocationSubtype? Subtype { get; set; }
    [JsonPropertyName("data")]
    public FixData? Data { get; set; }
    /**
     * Group of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxLocationGroup>))]
    public enum FixSyntaxLocationGroup
    {
        [StringValue("SYNTAX")]
        SYNTAX
    }
    /**
     * Type of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxLocationType>))]
    public enum FixSyntaxLocationType
    {
        [StringValue("VALUE_PART_ADDED")]
        VALUE_PART_ADDED
    }
    /**
     * Subtype of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxLocationSubtype>))]
    public enum FixSyntaxLocationSubtype
    {
        [StringValue("NUMBER")]
        NUMBER,
        [StringValue("NUMBER_PART")]
        NUMBER_PART
    }
}

