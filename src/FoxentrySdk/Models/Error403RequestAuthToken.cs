
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
public class Error403RequestAuthToken
{
    [JsonPropertyName("group")]
    public Error403RequestAuthTokenGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error403RequestAuthTokenType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error403RequestAuthTokenSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error403RequestAuthTokenSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error403RequestAuthTokenDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestAuthTokenGroup>))]
    public enum Error403RequestAuthTokenGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestAuthTokenType>))]
    public enum Error403RequestAuthTokenType
    {
        [StringValue("AUTH")]
        AUTH
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestAuthTokenSubtype>))]
    public enum Error403RequestAuthTokenSubtype
    {
        [StringValue("TOKEN")]
        TOKEN
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestAuthTokenSeverity>))]
    public enum Error403RequestAuthTokenSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestAuthTokenDescription>))]
    public enum Error403RequestAuthTokenDescription
    {
        [StringValue("Provided access token is not valid. Please check the project settings at app.foxentry.com.")]
        PROVIDED_ACCESS_TOKEN_IS_NOT_VALID_PLEASE_CHECK_THE_PROJECT_SETTINGS_AT_APP_FOXENTRY_COM_
    }
}

