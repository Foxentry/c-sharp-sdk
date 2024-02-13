
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
public class Error403RequestNotAllowedDomain
{
    [JsonPropertyName("group")]
    public Error403RequestNotAllowedDomainGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error403RequestNotAllowedDomainType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error403RequestNotAllowedDomainSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error403RequestNotAllowedDomainSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error403RequestNotAllowedDomainDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestNotAllowedDomainGroup>))]
    public enum Error403RequestNotAllowedDomainGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestNotAllowedDomainType>))]
    public enum Error403RequestNotAllowedDomainType
    {
        [StringValue("NOT_ALLOWED")]
        NOT_ALLOWED
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestNotAllowedDomainSubtype>))]
    public enum Error403RequestNotAllowedDomainSubtype
    {
        [StringValue("DOMAIN")]
        DOMAIN
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestNotAllowedDomainSeverity>))]
    public enum Error403RequestNotAllowedDomainSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error403RequestNotAllowedDomainDescription>))]
    public enum Error403RequestNotAllowedDomainDescription
    {
        [StringValue("Website domain is not allowed in the project settings.")]
        WEBSITE_DOMAIN_IS_NOT_ALLOWED_IN_THE_PROJECT_SETTINGS_
    }
}

