
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
public class FixSyntaxEmail
{
    [JsonPropertyName("group")]
    [Newtonsoft.Json.JsonProperty("group")]
    public FixSyntaxEmailGroup? Group { get; set; }
    [JsonPropertyName("type")]
    [Newtonsoft.Json.JsonProperty("type")]
    public FixSyntaxEmailType? Type { get; set; }
    [JsonPropertyName("subtype")]
    [Newtonsoft.Json.JsonProperty("subtype")]
    public FixSyntaxEmailSubtype? Subtype { get; set; }
    [JsonPropertyName("data")]
    [Newtonsoft.Json.JsonProperty("data")]
    public FixData? Data { get; set; }
    /**
     * Group of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxEmailGroup>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FixSyntaxEmailGroup
    {
        [StringValue("SYNTAX")]
        SYNTAX
    }
    /**
     * Type of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxEmailType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

