
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
public class ErrorValueEmail
{
    [JsonPropertyName("group")]
    public ErrorValueEmailGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public ErrorValueEmailType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public ErrorValueEmailSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public ErrorValueEmailSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public ErrorValueEmailDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValueEmailGroup>))]
    public enum ErrorValueEmailGroup
    {
        [StringValue("VALUE")]
        VALUE
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValueEmailType>))]
    public enum ErrorValueEmailType
    {
        [StringValue("INVALID")]
        INVALID,
        [StringValue("NOT_ALLOWED")]
        NOT_ALLOWED
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValueEmailSubtype>))]
    public enum ErrorValueEmailSubtype
    {
        [StringValue("DOMAIN")]
        DOMAIN,
        [StringValue("DOMAIN_DNS")]
        DOMAIN_DNS,
        [StringValue("DISPOSABLE")]
        DISPOSABLE,
        [StringValue("FREEMAIL")]
        FREEMAIL
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValueEmailSeverity>))]
    public enum ErrorValueEmailSeverity
    {
        [StringValue("info")]
        INFO,
        [StringValue("warning")]
        WARNING,
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorValueEmailDescription>))]
    public enum ErrorValueEmailDescription
    {
        [StringValue("Domain name is invalid.")]
        DOMAIN_NAME_IS_INVALID_,
        [StringValue("Domain does not have DNS records set properly for receiving emails.")]
        DOMAIN_DOES_NOT_HAVE_DNS_RECORDS_SET_PROPERLY_FOR_RECEIVING_EMAILS_,
        [StringValue("Disposable emails are not allowed.")]
        DISPOSABLE_EMAILS_ARE_NOT_ALLOWED_,
        [StringValue("Freemails are not allowed.")]
        FREEMAILS_ARE_NOT_ALLOWED_
    }
}

