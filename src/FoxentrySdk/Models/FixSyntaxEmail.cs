
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
public class FixSyntaxEmail
{
    [JsonPropertyName("group")]
    public FixSyntaxEmailGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public FixSyntaxEmailType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public FixSyntaxEmailSubtype? Subtype { get; set; }
    [JsonPropertyName("data")]
    public FixData? Data { get; set; }
    /**
     * Group of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxEmailGroup>))]
    public enum FixSyntaxEmailGroup
    {
        [StringValue("SYNTAX")]
        SYNTAX
    }
    /**
     * Type of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxEmailType>))]
    public enum FixSyntaxEmailType
    {
        [StringValue("VALUE_PART_ADDED")]
        VALUE_PART_ADDED,
        [StringValue("VALUE_PART_CHANGED")]
        VALUE_PART_CHANGED,
        [StringValue("VALUE_PART_REMOVED")]
        VALUE_PART_REMOVED
    }
    /**
     * Subtype of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxEmailSubtype>))]
    public enum FixSyntaxEmailSubtype
    {
        [StringValue("AT_SIGN")]
        AT_SIGN,
        [StringValue("DOMAIN_TLD")]
        DOMAIN_TLD,
        [StringValue("DOMAIN")]
        DOMAIN
    }
}

