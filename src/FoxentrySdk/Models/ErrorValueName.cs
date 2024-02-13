
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
public class ErrorValueName
{
    [JsonPropertyName("group")]
    public ErrorValueNameGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public ErrorValueNameType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public ErrorValueNameSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public ErrorValueNameSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public ErrorValueNameDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValueNameGroup>))]
    public enum ErrorValueNameGroup
    {
        [StringValue("VALUE")]
        VALUE
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValueNameType>))]
    public enum ErrorValueNameType
    {
        [StringValue("INVALID")]
        INVALID,
        [StringValue("NOT_ALLOWED")]
        NOT_ALLOWED
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValueNameSubtype>))]
    public enum ErrorValueNameSubtype
    {
        [StringValue("DEGREE")]
        DEGREE,
        [StringValue("NAME")]
        NAME,
        [StringValue("NAMESURNAME")]
        NAMESURNAME,
        [StringValue("SURNAME")]
        SURNAME,
        [StringValue("CONTEXT")]
        CONTEXT
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValueNameSeverity>))]
    public enum ErrorValueNameSeverity
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
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValueNameDescription>))]
    public enum ErrorValueNameDescription
    {
        [StringValue("Degree value is invalid.")]
        DEGREE_VALUE_IS_INVALID_,
        [StringValue("Name has not been found in our database.")]
        NAME_HAS_NOT_BEEN_FOUND_IN_OUR_DATABASE_,
        [StringValue("NameSurname has not been found in our database.")]
        NAME_SURNAME_HAS_NOT_BEEN_FOUND_IN_OUR_DATABASE_,
        [StringValue("Surname has not been found in our database.")]
        SURNAME_HAS_NOT_BEEN_FOUND_IN_OUR_DATABASE_,
        [StringValue("Degrees are not allowed.")]
        DEGREES_ARE_NOT_ALLOWED_
    }
}

