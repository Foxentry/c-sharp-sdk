
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
public class Error400RequestBodyNoRequest
{
    [JsonPropertyName("group")]
    public Error400RequestBodyNoRequestGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error400RequestBodyNoRequestType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error400RequestBodyNoRequestSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error400RequestBodyNoRequestSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error400RequestBodyNoRequestDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyNoRequestGroup>))]
    public enum Error400RequestBodyNoRequestGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyNoRequestType>))]
    public enum Error400RequestBodyNoRequestType
    {
        [StringValue("BODY")]
        BODY
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyNoRequestSubtype>))]
    public enum Error400RequestBodyNoRequestSubtype
    {
        [StringValue("NOT_JSON")]
        NOT_JSON
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyNoRequestSeverity>))]
    public enum Error400RequestBodyNoRequestSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error400RequestBodyNoRequestDescription>))]
    public enum Error400RequestBodyNoRequestDescription
    {
        [StringValue("Your API call body does not contain any requests.")]
        YOUR_API_CALL_BODY_DOES_NOT_CONTAIN_ANY_REQUESTS_
    }
}

