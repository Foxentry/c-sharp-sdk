
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
public class Error404RequestEndpointNotFound
{
    [JsonPropertyName("group")]
    public Error404RequestEndpointNotFoundGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error404RequestEndpointNotFoundType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error404RequestEndpointNotFoundSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error404RequestEndpointNotFoundSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error404RequestEndpointNotFoundDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404RequestEndpointNotFoundGroup>))]
    public enum Error404RequestEndpointNotFoundGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404RequestEndpointNotFoundType>))]
    public enum Error404RequestEndpointNotFoundType
    {
        [StringValue("ENDPOINT")]
        ENDPOINT
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404RequestEndpointNotFoundSubtype>))]
    public enum Error404RequestEndpointNotFoundSubtype
    {
        [StringValue("NOT_FOUND")]
        NOT_FOUND
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404RequestEndpointNotFoundSeverity>))]
    public enum Error404RequestEndpointNotFoundSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404RequestEndpointNotFoundDescription>))]
    public enum Error404RequestEndpointNotFoundDescription
    {
        [StringValue("Endpoint not found. Please check Foxentry.dev for the supported endpoints.")]
        ENDPOINT_NOT_FOUND_PLEASE_CHECK_FOXENTRY_DEV_FOR_THE_SUPPORTED_ENDPOINTS_
    }
}

