
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
public class FixSyntaxCompany
{
    [JsonPropertyName("group")]
    public FixSyntaxCompanyGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public FixSyntaxCompanyType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public FixSyntaxCompanySubtype? Subtype { get; set; }
    [JsonPropertyName("data")]
    public FixData? Data { get; set; }
    /**
     * Group of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxCompanyGroup>))]
    public enum FixSyntaxCompanyGroup
    {
        [StringValue("SYNTAX")]
        SYNTAX
    }
    /**
     * Type of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixSyntaxCompanyType>))]
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
    public enum FixSyntaxCompanySubtype
    {
        [StringValue("LEGAL_FORM")]
        LEGAL_FORM
    }
}

