
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
public class Error400RequestBodyEmpty
{
    [JsonPropertyName("group")]
    public Error400RequestBodyEmptyGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error400RequestBodyEmptyType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error400RequestBodyEmptySubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error400RequestBodyEmptySeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error400RequestBodyEmptyDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyEmptyGroup>))]
    public enum Error400RequestBodyEmptyGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyEmptyType>))]
    public enum Error400RequestBodyEmptyType
    {
        [StringValue("BODY")]
        BODY
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyEmptySubtype>))]
    public enum Error400RequestBodyEmptySubtype
    {
        [StringValue("EMPTY")]
        EMPTY
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyEmptySeverity>))]
    public enum Error400RequestBodyEmptySeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyEmptyDescription>))]
    public enum Error400RequestBodyEmptyDescription
    {
        [StringValue("Cannot process the request because of the empty body. Please check Foxentry.dev for more information.")]
        CANNOT_PROCESS_THE_REQUEST_BECAUSE_OF_THE_EMPTY_BODY_PLEASE_CHECK_FOXENTRY_DEV_FOR_MORE_INFORMATION_
    }
}

