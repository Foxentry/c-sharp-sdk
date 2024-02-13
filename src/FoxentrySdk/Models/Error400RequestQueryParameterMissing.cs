
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
public class Error400RequestQueryParameterMissing
{
    [JsonPropertyName("group")]
    public Error400RequestQueryParameterMissingGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error400RequestQueryParameterMissingType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error400RequestQueryParameterMissingSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error400RequestQueryParameterMissingSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error400RequestQueryParameterMissingDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterMissingGroup>))]
    public enum Error400RequestQueryParameterMissingGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterMissingType>))]
    public enum Error400RequestQueryParameterMissingType
    {
        [StringValue("QUERY")]
        QUERY
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterMissingSubtype>))]
    public enum Error400RequestQueryParameterMissingSubtype
    {
        [StringValue("PARAMETERS_MISSING")]
        PARAMETERS_MISSING
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterMissingSeverity>))]
    public enum Error400RequestQueryParameterMissingSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryParameterMissingDescription>))]
    public enum Error400RequestQueryParameterMissingDescription
    {
        [StringValue("Query parameter is missing. Please check Foxentry.dev for more information about how to set up the query properly.")]
        QUERY_PARAMETER_IS_MISSING_PLEASE_CHECK_FOXENTRY_DEV_FOR_MORE_INFORMATION_ABOUT_HOW_TO_SET_UP_THE_QUERY_PROPERLY_
    }
}

