
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
public class FixSyntaxGlobal
{
    [JsonPropertyName("group")]
    public FixSyntaxGlobalGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public FixSyntaxGlobalType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public FixSyntaxGlobalSubtype? Subtype { get; set; }
    [JsonPropertyName("data")]
    public FixData? Data { get; set; }
    /**
     * Group of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxGlobalGroup>))]
    public enum FixSyntaxGlobalGroup
    {
        [StringValue("SYNTAX")]
        SYNTAX
    }
    /**
     * Type of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxGlobalType>))]
    public enum FixSyntaxGlobalType
    {
        [StringValue("VALUE_CHANGED")]
        VALUE_CHANGED,
        [StringValue("VALUE_PART_CHANGED")]
        VALUE_PART_CHANGED,
        [StringValue("VALUE_PART_REMOVED")]
        VALUE_PART_REMOVED
    }
    /**
     * Subtype of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxGlobalSubtype>))]
    public enum FixSyntaxGlobalSubtype
    {
        [StringValue("CHARACTERS")]
        CHARACTERS,
        [StringValue("WHITESPACES")]
        WHITESPACES,
        [StringValue("CONTEXT")]
        CONTEXT,
        [StringValue("DUPLICITY")]
        DUPLICITY
    }
}

