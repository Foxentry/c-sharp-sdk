
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
public class Error400RequestOptionsParameterCombination
{
    [JsonPropertyName("group")]
    public Error400RequestOptionsParameterCombinationGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error400RequestOptionsParameterCombinationType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error400RequestOptionsParameterCombinationSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error400RequestOptionsParameterCombinationSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error400RequestOptionsParameterCombinationDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionsParameterCombinationGroup>))]
    public enum Error400RequestOptionsParameterCombinationGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionsParameterCombinationType>))]
    public enum Error400RequestOptionsParameterCombinationType
    {
        [StringValue("OPTIONS")]
        OPTIONS
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionsParameterCombinationSubtype>))]
    public enum Error400RequestOptionsParameterCombinationSubtype
    {
        [StringValue("PARAMETERS_COMBINATION")]
        PARAMETERS_COMBINATION
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionsParameterCombinationSeverity>))]
    public enum Error400RequestOptionsParameterCombinationSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionsParameterCombinationDescription>))]
    public enum Error400RequestOptionsParameterCombinationDescription
    {
        [StringValue("Combination of options or their values is not valid.")]
        COMBINATION_OF_OPTIONS_OR_THEIR_VALUES_IS_NOT_VALID_
    }
}

