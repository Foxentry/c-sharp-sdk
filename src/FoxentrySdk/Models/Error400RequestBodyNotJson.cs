
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
public class Error400RequestBodyNotJson
{
    [JsonPropertyName("group")]
    public Error400RequestBodyNotJsonGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error400RequestBodyNotJsonType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error400RequestBodyNotJsonSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error400RequestBodyNotJsonSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error400RequestBodyNotJsonDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyNotJsonGroup>))]
    public enum Error400RequestBodyNotJsonGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyNotJsonType>))]
    public enum Error400RequestBodyNotJsonType
    {
        [StringValue("BODY")]
        BODY
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyNotJsonSubtype>))]
    public enum Error400RequestBodyNotJsonSubtype
    {
        [StringValue("NOT_JSON")]
        NOT_JSON
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyNotJsonSeverity>))]
    public enum Error400RequestBodyNotJsonSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyNotJsonDescription>))]
    public enum Error400RequestBodyNotJsonDescription
    {
        [StringValue("Cannot process the request because the JSON is not valid. Please check Foxentry.dev for more information.")]
        CANNOT_PROCESS_THE_REQUEST_BECAUSE_THE_JSON_IS_NOT_VALID_PLEASE_CHECK_FOXENTRY_DEV_FOR_MORE_INFORMATION_
    }
}

