
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
public class Error401RequestAuth
{
    [JsonPropertyName("group")]
    public Error401RequestAuthGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error401RequestAuthType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public string? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error401RequestAuthSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error401RequestAuthDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error401RequestAuthGroup>))]
    public enum Error401RequestAuthGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error401RequestAuthType>))]
    public enum Error401RequestAuthType
    {
        [StringValue("AUTH")]
        AUTH
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error401RequestAuthSeverity>))]
    public enum Error401RequestAuthSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error401RequestAuthDescription>))]
    public enum Error401RequestAuthDescription
    {
        [StringValue("Invalid authorization credentials sent. Check Foxentry.dev for more information how to set up the AUTH properly.")]
        INVALID_AUTHORIZATION_CREDENTIALS_SENT_CHECK_FOXENTRY_DEV_FOR_MORE_INFORMATION_HOW_TO_SET_UP_THE_AUTH_PROPERLY_
    }
}

