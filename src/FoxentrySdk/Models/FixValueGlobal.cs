
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
public class FixValueGlobal
{
    [JsonPropertyName("group")]
    public FixValueGlobalGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public FixValueGlobalType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public FixValueGlobalSubtype? Subtype { get; set; }
    [JsonPropertyName("data")]
    public FixData? Data { get; set; }
    /**
     * Group of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixValueGlobalGroup>))]
    public enum FixValueGlobalGroup
    {
        [StringValue("VALUE")]
        VALUE
    }
    /**
     * Type of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixValueGlobalType>))]
    public enum FixValueGlobalType
    {
        [StringValue("ADDED")]
        ADDED,
        [StringValue("CHANGED")]
        CHANGED,
        [StringValue("PART_CHANGED")]
        PART_CHANGED,
        [StringValue("REMOVED")]
        REMOVED
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixValueGlobalSubtype>))]
    public enum FixValueGlobalSubtype
    {
        [StringValue("INTERNAL_RULE")]
        INTERNAL_RULE,
        [StringValue("TYPO")]
        TYPO
    }
}

