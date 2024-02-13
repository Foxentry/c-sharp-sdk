
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
public class Error429RequestRateLimitCreditPerDay
{
    [JsonPropertyName("group")]
    public Error429RequestRateLimitCreditPerDayGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error429RequestRateLimitCreditPerDayType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error429RequestRateLimitCreditPerDaySubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error429RequestRateLimitCreditPerDaySeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error429RequestRateLimitCreditPerDayDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestRateLimitCreditPerDayGroup>))]
    public enum Error429RequestRateLimitCreditPerDayGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestRateLimitCreditPerDayType>))]
    public enum Error429RequestRateLimitCreditPerDayType
    {
        [StringValue("RATE_LIMIT")]
        RATE_LIMIT
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestRateLimitCreditPerDaySubtype>))]
    public enum Error429RequestRateLimitCreditPerDaySubtype
    {
        [StringValue("CREDIT_PER_DAY")]
        CREDIT_PER_DAY
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestRateLimitCreditPerDaySeverity>))]
    public enum Error429RequestRateLimitCreditPerDaySeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestRateLimitCreditPerDayDescription>))]
    public enum Error429RequestRateLimitCreditPerDayDescription
    {
        [StringValue("The maximum daily limit has been reached. Adjust the settings in the project or wait until the limit is reset.")]
        THE_MAXIMUM_DAILY_LIMIT_HAS_BEEN_REACHED_ADJUST_THE_SETTINGS_IN_THE_PROJECT_OR_WAIT_UNTIL_THE_LIMIT_IS_RESET_
    }
}

