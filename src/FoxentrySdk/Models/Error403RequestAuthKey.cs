
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
public class Error403RequestAuthKey
{
    [JsonPropertyName("group")]
    public Error403RequestAuthKeyGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error403RequestAuthKeyType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error403RequestAuthKeySubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error403RequestAuthKeySeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error403RequestAuthKeyDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestAuthKeyGroup>))]
    public enum Error403RequestAuthKeyGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestAuthKeyType>))]
    public enum Error403RequestAuthKeyType
    {
        [StringValue("AUTH")]
        AUTH
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestAuthKeySubtype>))]
    public enum Error403RequestAuthKeySubtype
    {
        [StringValue("KEY")]
        KEY
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestAuthKeySeverity>))]
    public enum Error403RequestAuthKeySeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestAuthKeyDescription>))]
    public enum Error403RequestAuthKeyDescription
    {
        [StringValue("Provided API key is not valid. Please check the project settings at app.foxentry.com.")]
        PROVIDED_API_KEY_IS_NOT_VALID_PLEASE_CHECK_THE_PROJECT_SETTINGS_AT_APP_FOXENTRY_COM_
    }
}

