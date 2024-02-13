
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
public class Error429RequestRateLimitCreditPerIp
{
    [JsonPropertyName("group")]
    public Error429RequestRateLimitCreditPerIpGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error429RequestRateLimitCreditPerIpType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error429RequestRateLimitCreditPerIpSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error429RequestRateLimitCreditPerIpSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error429RequestRateLimitCreditPerIpDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestRateLimitCreditPerIpGroup>))]
    public enum Error429RequestRateLimitCreditPerIpGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestRateLimitCreditPerIpType>))]
    public enum Error429RequestRateLimitCreditPerIpType
    {
        [StringValue("RATE_LIMIT")]
        RATE_LIMIT
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestRateLimitCreditPerIpSubtype>))]
    public enum Error429RequestRateLimitCreditPerIpSubtype
    {
        [StringValue("CREDIT_PER_IP")]
        CREDIT_PER_IP
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestRateLimitCreditPerIpSeverity>))]
    public enum Error429RequestRateLimitCreditPerIpSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestRateLimitCreditPerIpDescription>))]
    public enum Error429RequestRateLimitCreditPerIpDescription
    {
        [StringValue("The maximum daily limit per IP address has been reached. Adjust the settings in the project or wait until the limit is reset.")]
        THE_MAXIMUM_DAILY_LIMIT_PER_IP_ADDRESS_HAS_BEEN_REACHED_ADJUST_THE_SETTINGS_IN_THE_PROJECT_OR_WAIT_UNTIL_THE_LIMIT_IS_RESET_
    }
}

