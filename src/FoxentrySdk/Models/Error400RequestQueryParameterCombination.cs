
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
public class Error400RequestQueryParameterCombination
{
    [JsonPropertyName("group")]
    public Error400RequestQueryParameterCombinationGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error400RequestQueryParameterCombinationType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error400RequestQueryParameterCombinationSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error400RequestQueryParameterCombinationSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error400RequestQueryParameterCombinationDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterCombinationGroup>))]
    public enum Error400RequestQueryParameterCombinationGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterCombinationType>))]
    public enum Error400RequestQueryParameterCombinationType
    {
        [StringValue("QUERY")]
        QUERY
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterCombinationSubtype>))]
    public enum Error400RequestQueryParameterCombinationSubtype
    {
        [StringValue("PARAMETERS_COMBINATION")]
        PARAMETERS_COMBINATION
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterCombinationSeverity>))]
    public enum Error400RequestQueryParameterCombinationSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterCombinationDescription>))]
    public enum Error400RequestQueryParameterCombinationDescription
    {
        [StringValue("It is not possible to use these parameters at the same time in one request.")]
        IT_IS_NOT_POSSIBLE_TO_USE_THESE_PARAMETERS_AT_THE_SAME_TIME_IN_ONE_REQUEST_
    }
}

