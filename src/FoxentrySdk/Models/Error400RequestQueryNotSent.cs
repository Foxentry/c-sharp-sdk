
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
public class Error400RequestQueryNotSent
{
    [JsonPropertyName("group")]
    public Error400RequestQueryNotSentGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error400RequestQueryNotSentType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error400RequestQueryNotSentSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error400RequestQueryNotSentSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error400RequestQueryNotSentDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryNotSentGroup>))]
    public enum Error400RequestQueryNotSentGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryNotSentType>))]
    public enum Error400RequestQueryNotSentType
    {
        [StringValue("QUERY")]
        QUERY
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryNotSentSubtype>))]
    public enum Error400RequestQueryNotSentSubtype
    {
        [StringValue("NOT_SENT")]
        NOT_SENT
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryNotSentSeverity>))]
    public enum Error400RequestQueryNotSentSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestQueryNotSentDescription>))]
    public enum Error400RequestQueryNotSentDescription
    {
        [StringValue("Your request query is empty. Please check Foxentry.dev for more information about how to set up the query properly.")]
        YOUR_REQUEST_QUERY_IS_EMPTY_PLEASE_CHECK_FOXENTRY_DEV_FOR_MORE_INFORMATION_ABOUT_HOW_TO_SET_UP_THE_QUERY_PROPERLY_
    }
}

