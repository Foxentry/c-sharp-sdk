
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
public class ErrorValueGlobal
{
    [JsonPropertyName("group")]
    public ErrorValueGlobalGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public ErrorValueGlobalType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public ErrorValueGlobalSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public ErrorValueGlobalSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public ErrorValueGlobalDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValueGlobalGroup>))]
    public enum ErrorValueGlobalGroup
    {
        [StringValue("VALUE")]
        VALUE
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValueGlobalType>))]
    public enum ErrorValueGlobalType
    {
        [StringValue("EMPTY")]
        EMPTY,
        [StringValue("INCORRECT_ORDER")]
        INCORRECT_ORDER,
        [StringValue("INVALID")]
        INVALID,
        [StringValue("INVALID_COMBINATION")]
        INVALID_COMBINATION,
        [StringValue("NOT_ALLOWED")]
        NOT_ALLOWED
    }/**
     * Subtype of error.
     */
    public class ErrorValueGlobalSubtype { }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValueGlobalSeverity>))]
    public enum ErrorValueGlobalSeverity
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
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValueGlobalDescription>))]
    public enum ErrorValueGlobalDescription
    {
        [StringValue("Value is empty.")]
        VALUE_IS_EMPTY_,
        [StringValue("Value contains parts in incorrect order.")]
        VALUE_CONTAINS_PARTS_IN_INCORRECT_ORDER_,
        [StringValue("Value is not valid.")]
        VALUE_IS_NOT_VALID_,
        [StringValue("The Combination of values listed in relatedTo section is not valid.")]
        THE_COMBINATION_OF_VALUES_LISTED_IN_RELATED_TO_SECTION_IS_NOT_VALID_,
        [StringValue("Context words are not allowed.")]
        CONTEXT_WORDS_ARE_NOT_ALLOWED_
    }
}

