
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
public class Error404RequestApiVersion
{
    [JsonPropertyName("group")]
    public Error404RequestApiVersionGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error404RequestApiVersionType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public string? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error404RequestApiVersionSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error404RequestApiVersionDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404RequestApiVersionGroup>))]
    public enum Error404RequestApiVersionGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404RequestApiVersionType>))]
    public enum Error404RequestApiVersionType
    {
        [StringValue("API_VERSION")]
        API_VERSION
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404RequestApiVersionSeverity>))]
    public enum Error404RequestApiVersionSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404RequestApiVersionDescription>))]
    public enum Error404RequestApiVersionDescription
    {
        [StringValue("Requested API version is not available. Please check Foxentry.dev for the supported versions.")]
        REQUESTED_API_VERSION_IS_NOT_AVAILABLE_PLEASE_CHECK_FOXENTRY_DEV_FOR_THE_SUPPORTED_VERSIONS_
    }
}

