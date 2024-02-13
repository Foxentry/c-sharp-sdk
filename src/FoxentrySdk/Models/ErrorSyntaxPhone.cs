
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
public class ErrorSyntaxPhone
{
    [JsonPropertyName("group")]
    public ErrorSyntaxPhoneGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public ErrorSyntaxPhoneType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public ErrorSyntaxPhoneSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public ErrorSyntaxPhoneSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public ErrorSyntaxPhoneDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxPhoneGroup>))]
    public enum ErrorSyntaxPhoneGroup
    {
        [StringValue("SYNTAX")]
        SYNTAX
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxPhoneType>))]
    public enum ErrorSyntaxPhoneType
    {
        [StringValue("VALUE_PART_EXTRA")]
        VALUE_PART_EXTRA,
        [StringValue("VALUE_PART_MISSING")]
        VALUE_PART_MISSING
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxPhoneSubtype>))]
    public enum ErrorSyntaxPhoneSubtype
    {
        [StringValue("PLUS_SIGN")]
        PLUS_SIGN,
        [StringValue("NUMBER")]
        NUMBER,
        [StringValue("PREFIX")]
        PREFIX
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxPhoneSeverity>))]
    public enum ErrorSyntaxPhoneSeverity
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
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxPhoneDescription>))]
    public enum ErrorSyntaxPhoneDescription
    {
        [StringValue("Value contains duplicated \'+\' sign.")]
        VALUE_CONTAINS_DUPLICATED_SIGN_,
        [StringValue("Value is missing the number.")]
        VALUE_IS_MISSING_THE_NUMBER_,
        [StringValue("Value is missing the \'+\' sign.")]
        VALUE_IS_MISSING_THE_SIGN_,
        [StringValue("Value is missing the prefix.")]
        VALUE_IS_MISSING_THE_PREFIX_
    }
}

