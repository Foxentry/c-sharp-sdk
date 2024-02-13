
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
public class ErrorSyntaxGlobal
{
    [JsonPropertyName("group")]
    public ErrorSyntaxGlobalGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public ErrorSyntaxGlobalType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public ErrorSyntaxGlobalSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public ErrorSyntaxGlobalSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public ErrorSyntaxGlobalDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxGlobalGroup>))]
    public enum ErrorSyntaxGlobalGroup
    {
        [StringValue("SYNTAX")]
        SYNTAX
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxGlobalType>))]
    public enum ErrorSyntaxGlobalType
    {
        [StringValue("CHARACTERS")]
        CHARACTERS,
        [StringValue("INVALID")]
        INVALID,
        [StringValue("UNABLE_TO_PROCESS")]
        UNABLE_TO_PROCESS,
        [StringValue("VALUE_LENGTH")]
        VALUE_LENGTH,
        [StringValue("VALUE_PART_EXTRA")]
        VALUE_PART_EXTRA,
        [StringValue("VALUE_PART_MISSING")]
        VALUE_PART_MISSING
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxGlobalSubtype>))]
    public enum ErrorSyntaxGlobalSubtype
    {
        [StringValue("NOT_ALLOWED")]
        NOT_ALLOWED,
        [StringValue("WHITESPACES")]
        WHITESPACES,
        [StringValue("TOO_LONG")]
        TOO_LONG,
        [StringValue("TOO_SHORT")]
        TOO_SHORT,
        [StringValue("CONTEXT")]
        CONTEXT
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxGlobalSeverity>))]
    public enum ErrorSyntaxGlobalSeverity
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
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxGlobalDescription>))]
    public enum ErrorSyntaxGlobalDescription
    {
        [StringValue("Disallowed characters were used in the value.")]
        DISALLOWED_CHARACTERS_WERE_USED_IN_THE_VALUE_,
        [StringValue("Value contains invalid use of spaces.")]
        VALUE_CONTAINS_INVALID_USE_OF_SPACES_,
        [StringValue("Value has invalid syntax.")]
        VALUE_HAS_INVALID_SYNTAX_,
        [StringValue("Cannot be processed due to the invalid syntax.")]
        CANNOT_BE_PROCESSED_DUE_TO_THE_INVALID_SYNTAX_,
        [StringValue("Value is too long.")]
        VALUE_IS_TOO_LONG_,
        [StringValue("Value is too short.")]
        VALUE_IS_TOO_SHORT_,
        [StringValue("Value contains unneccessary context.")]
        VALUE_CONTAINS_UNNECCESSARY_CONTEXT_
    }
}

