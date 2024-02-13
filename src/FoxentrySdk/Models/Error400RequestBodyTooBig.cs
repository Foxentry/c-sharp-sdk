
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
public class Error400RequestBodyTooBig
{
    [JsonPropertyName("group")]
    public Error400RequestBodyTooBigGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error400RequestBodyTooBigType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error400RequestBodyTooBigSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error400RequestBodyTooBigSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error400RequestBodyTooBigDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyTooBigGroup>))]
    public enum Error400RequestBodyTooBigGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyTooBigType>))]
    public enum Error400RequestBodyTooBigType
    {
        [StringValue("BODY")]
        BODY
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyTooBigSubtype>))]
    public enum Error400RequestBodyTooBigSubtype
    {
        [StringValue("TOO_BIG")]
        TOO_BIG
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyTooBigSeverity>))]
    public enum Error400RequestBodyTooBigSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyTooBigDescription>))]
    public enum Error400RequestBodyTooBigDescription
    {
        [StringValue("Your request length is bigger than allowed. Please contact us if you think this is a mistake.")]
        YOUR_REQUEST_LENGTH_IS_BIGGER_THAN_ALLOWED_PLEASE_CONTACT_US_IF_YOU_THINK_THIS_IS_A_MISTAKE_
    }
}

