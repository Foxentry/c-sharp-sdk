
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
public class Error405RequestNotAllowedMethod
{
    [JsonPropertyName("group")]
    public Error405RequestNotAllowedMethodGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error405RequestNotAllowedMethodType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error405RequestNotAllowedMethodSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error405RequestNotAllowedMethodSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error405RequestNotAllowedMethodDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error405RequestNotAllowedMethodGroup>))]
    public enum Error405RequestNotAllowedMethodGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error405RequestNotAllowedMethodType>))]
    public enum Error405RequestNotAllowedMethodType
    {
        [StringValue("ENDPOINT")]
        ENDPOINT
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error405RequestNotAllowedMethodSubtype>))]
    public enum Error405RequestNotAllowedMethodSubtype
    {
        [StringValue("NOT_ALLOWED")]
        NOT_ALLOWED
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error405RequestNotAllowedMethodSeverity>))]
    public enum Error405RequestNotAllowedMethodSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error405RequestNotAllowedMethodDescription>))]
    public enum Error405RequestNotAllowedMethodDescription
    {
        [StringValue("HTTP method is not allowed for this endpoint. Please check Foxentry.dev for more information.")]
        HTTP_METHOD_IS_NOT_ALLOWED_FOR_THIS_ENDPOINT_PLEASE_CHECK_FOXENTRY_DEV_FOR_MORE_INFORMATION_
    }
}

