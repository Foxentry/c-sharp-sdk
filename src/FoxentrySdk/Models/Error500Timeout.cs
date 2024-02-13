
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
public class Error500Timeout
{
    [JsonPropertyName("group")]
    public Error500TimeoutGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error500TimeoutType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public string? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error500TimeoutSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error500TimeoutDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500TimeoutGroup>))]
    public enum Error500TimeoutGroup
    {
        [StringValue("INTERNAL")]
        INTERNAL
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500TimeoutType>))]
    public enum Error500TimeoutType
    {
        [StringValue("TIMEOUT")]
        TIMEOUT
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500TimeoutSeverity>))]
    public enum Error500TimeoutSeverity
    {
        [StringValue("CRITICAL")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500TimeoutDescription>))]
    public enum Error500TimeoutDescription
    {
        [StringValue("API timeout in effect. Your request took too much time to process.")]
        API_TIMEOUT_IN_EFFECT_YOUR_REQUEST_TOOK_TOO_MUCH_TIME_TO_PROCESS_
    }
}

