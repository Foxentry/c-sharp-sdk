
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
public class Error403RequestNotAllowedIp
{
    [JsonPropertyName("group")]
    public Error403RequestNotAllowedIpGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error403RequestNotAllowedIpType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error403RequestNotAllowedIpSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error403RequestNotAllowedIpSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error403RequestNotAllowedIpDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestNotAllowedIpGroup>))]
    public enum Error403RequestNotAllowedIpGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestNotAllowedIpType>))]
    public enum Error403RequestNotAllowedIpType
    {
        [StringValue("NOT_ALLOWED")]
        NOT_ALLOWED
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestNotAllowedIpSubtype>))]
    public enum Error403RequestNotAllowedIpSubtype
    {
        [StringValue("IP")]
        IP
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestNotAllowedIpSeverity>))]
    public enum Error403RequestNotAllowedIpSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestNotAllowedIpDescription>))]
    public enum Error403RequestNotAllowedIpDescription
    {
        [StringValue("The API key has IP limits set and your IP address is not allowed. Change the project settings at app.foxentry.com.")]
        THE_API_KEY_HAS_IP_LIMITS_SET_AND_YOUR_IP_ADDRESS_IS_NOT_ALLOWED_CHANGE_THE_PROJECT_SETTINGS_AT_APP_FOXENTRY_COM_
    }
}

