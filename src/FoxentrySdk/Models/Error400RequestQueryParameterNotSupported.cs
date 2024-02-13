
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
public class Error400RequestQueryParameterNotSupported
{
    [JsonPropertyName("group")]
    public Error400RequestQueryParameterNotSupportedGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error400RequestQueryParameterNotSupportedType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error400RequestQueryParameterNotSupportedSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error400RequestQueryParameterNotSupportedSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error400RequestQueryParameterNotSupportedDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterNotSupportedGroup>))]
    public enum Error400RequestQueryParameterNotSupportedGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterNotSupportedType>))]
    public enum Error400RequestQueryParameterNotSupportedType
    {
        [StringValue("QUERY")]
        QUERY
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterNotSupportedSubtype>))]
    public enum Error400RequestQueryParameterNotSupportedSubtype
    {
        [StringValue("PARAMETERS_NOT_SUPPORTED")]
        PARAMETERS_NOT_SUPPORTED
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterNotSupportedSeverity>))]
    public enum Error400RequestQueryParameterNotSupportedSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterNotSupportedDescription>))]
    public enum Error400RequestQueryParameterNotSupportedDescription
    {
        [StringValue("Query parameter is not supported for this endpoint.")]
        QUERY_PARAMETER_IS_NOT_SUPPORTED_FOR_THIS_ENDPOINT_
    }
}

