
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
public class ErrorSyntaxEmail
{
    [JsonPropertyName("group")]
    public ErrorSyntaxEmailGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public ErrorSyntaxEmailType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public ErrorSyntaxEmailSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public ErrorSyntaxEmailSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public ErrorSyntaxEmailDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxEmailGroup>))]
    public enum ErrorSyntaxEmailGroup
    {
        [StringValue("SYNTAX")]
        SYNTAX
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxEmailType>))]
    public enum ErrorSyntaxEmailType
    {
        [StringValue("VALUE_PART")]
        VALUE_PART,
        [StringValue("VALUE_PART_EXTRA")]
        VALUE_PART_EXTRA,
        [StringValue("VALUE_PART_MISSING")]
        VALUE_PART_MISSING,
        [StringValue("VALUE_PART_POSITION")]
        VALUE_PART_POSITION
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxEmailSubtype>))]
    public enum ErrorSyntaxEmailSubtype
    {
        [StringValue("DOMAIN")]
        DOMAIN,
        [StringValue("AT_SIGN")]
        AT_SIGN,
        [StringValue("TLD")]
        TLD
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxEmailSeverity>))]
    public enum ErrorSyntaxEmailSeverity
    {
        [StringValue("info")]
        INFO,
        [StringValue("warning")]
        WARNING,
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxEmailDescription>))]
    public enum ErrorSyntaxEmailDescription
    {
        [StringValue("The domain contains invalid syntax.")]
        THE_DOMAIN_CONTAINS_INVALID_SYNTAX_,
        [StringValue("Value contains duplicated \'@\' sign.")]
        VALUE_CONTAINS_DUPLICATED_SIGN_,
        [StringValue("Value does not contain \'@\' sign.")]
        VALUE_DOES_NOT_CONTAIN_SIGN_,
        [StringValue("Value is missing the top level domain.")]
        VALUE_IS_MISSING_THE_TOP_LEVEL_DOMAIN_,
        [StringValue("The TLD part of the value is placed in the wrong position.")]
        THE_TLD_PART_OF_THE_VALUE_IS_PLACED_IN_THE_WRONG_POSITION_
    }
}

