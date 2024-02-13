
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
public class ErrorValuePhone
{
    [JsonPropertyName("group")]
    public ErrorValuePhoneGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public ErrorValuePhoneType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public ErrorValuePhoneSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public ErrorValuePhoneSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public ErrorValuePhoneDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValuePhoneGroup>))]
    public enum ErrorValuePhoneGroup
    {
        [StringValue("VALUE")]
        VALUE
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValuePhoneType>))]
    public enum ErrorValuePhoneType
    {
        [StringValue("INVALID")]
        INVALID,
        [StringValue("NOT_ALLOWED")]
        NOT_ALLOWED
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValuePhoneSubtype>))]
    public enum ErrorValuePhoneSubtype
    {
        [StringValue("PREFIX")]
        PREFIX
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValuePhoneSeverity>))]
    public enum ErrorValuePhoneSeverity
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
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValuePhoneDescription>))]
    public enum ErrorValuePhoneDescription
    {
        [StringValue("Prefix is invalid.")]
        PREFIX_IS_INVALID_,
        [StringValue("This prefix is not allowed. Check the \'allowedPrefixes\' option in the request.")]
        THIS_PREFIX_IS_NOT_ALLOWED_CHECK_THE_ALLOWED_PREFIXES_OPTION_IN_THE_REQUEST_
    }
}

