
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
public class FixSyntaxCompany
{
    [JsonPropertyName("group")]
    [Newtonsoft.Json.JsonProperty("group")]
    public FixSyntaxCompanyGroup? Group { get; set; }
    [JsonPropertyName("type")]
    [Newtonsoft.Json.JsonProperty("type")]
    public FixSyntaxCompanyType? Type { get; set; }
    [JsonPropertyName("subtype")]
    [Newtonsoft.Json.JsonProperty("subtype")]
    public FixSyntaxCompanySubtype? Subtype { get; set; }
    [JsonPropertyName("data")]
    [Newtonsoft.Json.JsonProperty("data")]
    public FixData? Data { get; set; }
    /**
     * Group of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxCompanyGroup>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FixSyntaxCompanyGroup
    {
        [StringValue("SYNTAX")]
        SYNTAX
    }
    /**
     * Type of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxCompanyType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FixSyntaxCompanyType
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
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxCompanySubtype>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FixSyntaxCompanySubtype
    {
        [StringValue("LEGAL_FORM")]
        LEGAL_FORM
    }
}

