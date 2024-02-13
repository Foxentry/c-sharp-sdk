
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
public class ErrorSyntaxName
{
    [JsonPropertyName("group")]
    public ErrorSyntaxNameGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public ErrorSyntaxNameType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public ErrorSyntaxNameSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public ErrorSyntaxNameSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public ErrorSyntaxNameDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxNameGroup>))]
    public enum ErrorSyntaxNameGroup
    {
        [StringValue("SYNTAX")]
        SYNTAX
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxNameType>))]
    public enum ErrorSyntaxNameType
    {
        [StringValue("VALUE_PART_MISSING")]
        VALUE_PART_MISSING,
        [StringValue("VALUE_PART_POSITION")]
        VALUE_PART_POSITION
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxNameSubtype>))]
    public enum ErrorSyntaxNameSubtype
    {
        [StringValue("NAME")]
        NAME,
        [StringValue("SURNAME")]
        SURNAME,
        [StringValue("DEGREE")]
        DEGREE
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxNameSeverity>))]
    public enum ErrorSyntaxNameSeverity
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
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxNameDescription>))]
    public enum ErrorSyntaxNameDescription
    {
        [StringValue("Value is missing the name part.")]
        VALUE_IS_MISSING_THE_NAME_PART_,
        [StringValue("Value is missing the surname part.")]
        VALUE_IS_MISSING_THE_SURNAME_PART_,
        [StringValue("The DEGREE part of the value is placed in the wrong position.")]
        THE_DEGREE_PART_OF_THE_VALUE_IS_PLACED_IN_THE_WRONG_POSITION_
    }
}

