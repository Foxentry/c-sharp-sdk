
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
public class Error400RequestQueryParameterRequired
{
    [JsonPropertyName("group")]
    public Error400RequestQueryParameterRequiredGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error400RequestQueryParameterRequiredType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error400RequestQueryParameterRequiredSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error400RequestQueryParameterRequiredSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error400RequestQueryParameterRequiredDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterRequiredGroup>))]
    public enum Error400RequestQueryParameterRequiredGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterRequiredType>))]
    public enum Error400RequestQueryParameterRequiredType
    {
        [StringValue("QUERY")]
        QUERY
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterRequiredSubtype>))]
    public enum Error400RequestQueryParameterRequiredSubtype
    {
        [StringValue("PARAMETERS_REQUIRED")]
        PARAMETERS_REQUIRED
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterRequiredSeverity>))]
    public enum Error400RequestQueryParameterRequiredSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterRequiredDescription>))]
    public enum Error400RequestQueryParameterRequiredDescription
    {
        [StringValue("At least one of listed parameters is required.")]
        AT_LEAST_ONE_OF_LISTED_PARAMETERS_IS_REQUIRED_
    }
}

