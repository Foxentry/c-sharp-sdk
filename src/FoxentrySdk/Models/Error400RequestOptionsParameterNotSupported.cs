
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
public class Error400RequestOptionsParameterNotSupported
{
    [JsonPropertyName("group")]
    public Error400RequestOptionsParameterNotSupportedGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error400RequestOptionsParameterNotSupportedType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error400RequestOptionsParameterNotSupportedSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error400RequestOptionsParameterNotSupportedSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error400RequestOptionsParameterNotSupportedDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionsParameterNotSupportedGroup>))]
    public enum Error400RequestOptionsParameterNotSupportedGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionsParameterNotSupportedType>))]
    public enum Error400RequestOptionsParameterNotSupportedType
    {
        [StringValue("OPTIONS")]
        OPTIONS
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionsParameterNotSupportedSubtype>))]
    public enum Error400RequestOptionsParameterNotSupportedSubtype
    {
        [StringValue("PARAMETER_NOT_SUPPORTED")]
        PARAMETER_NOT_SUPPORTED
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionsParameterNotSupportedSeverity>))]
    public enum Error400RequestOptionsParameterNotSupportedSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionsParameterNotSupportedDescription>))]
    public enum Error400RequestOptionsParameterNotSupportedDescription
    {
        [StringValue("Options parameter is not supported for this endpoint.")]
        OPTIONS_PARAMETER_IS_NOT_SUPPORTED_FOR_THIS_ENDPOINT_
    }
}

