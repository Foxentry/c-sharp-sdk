
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
public class Error400RequestOptionParameterValueNotSupported
{
    [JsonPropertyName("group")]
    public Error400RequestOptionParameterValueNotSupportedGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error400RequestOptionParameterValueNotSupportedType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error400RequestOptionParameterValueNotSupportedSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error400RequestOptionParameterValueNotSupportedSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error400RequestOptionParameterValueNotSupportedDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionParameterValueNotSupportedGroup>))]
    public enum Error400RequestOptionParameterValueNotSupportedGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionParameterValueNotSupportedType>))]
    public enum Error400RequestOptionParameterValueNotSupportedType
    {
        [StringValue("OPTIONS")]
        OPTIONS
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionParameterValueNotSupportedSubtype>))]
    public enum Error400RequestOptionParameterValueNotSupportedSubtype
    {
        [StringValue("PARAMETER_VALUE_NOT_SUPPORTED")]
        PARAMETER_VALUE_NOT_SUPPORTED
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionParameterValueNotSupportedSeverity>))]
    public enum Error400RequestOptionParameterValueNotSupportedSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestOptionParameterValueNotSupportedDescription>))]
    public enum Error400RequestOptionParameterValueNotSupportedDescription
    {
        [StringValue("Value in paramater is not valid. Please check Foxentry.dev for more information.")]
        VALUE_IN_PARAMATER_IS_NOT_VALID_PLEASE_CHECK_FOXENTRY_DEV_FOR_MORE_INFORMATION_
    }
}

