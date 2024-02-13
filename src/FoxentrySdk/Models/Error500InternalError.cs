
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
public class Error500InternalError
{
    [JsonPropertyName("group")]
    public Error500InternalErrorGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error500InternalErrorType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public string? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error500InternalErrorSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error500InternalErrorDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalErrorGroup>))]
    public enum Error500InternalErrorGroup
    {
        [StringValue("INTERNAL")]
        INTERNAL
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalErrorType>))]
    public enum Error500InternalErrorType
    {
        [StringValue("ERROR")]
        ERROR
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalErrorSeverity>))]
    public enum Error500InternalErrorSeverity
    {
        [StringValue("CRITICAL")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalErrorDescription>))]
    public enum Error500InternalErrorDescription
    {
        [StringValue("Failed to process your request. Please try again later or contact us.")]
        FAILED_TO_PROCESS_YOUR_REQUEST_PLEASE_TRY_AGAIN_LATER_OR_CONTACT_US_
    }
}

