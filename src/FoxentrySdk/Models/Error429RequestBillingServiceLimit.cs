
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
public class Error429RequestBillingServiceLimit
{
    [JsonPropertyName("group")]
    public Error429RequestBillingServiceLimitGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error429RequestBillingServiceLimitType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error429RequestBillingServiceLimitSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error429RequestBillingServiceLimitSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error429RequestBillingServiceLimitDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestBillingServiceLimitGroup>))]
    public enum Error429RequestBillingServiceLimitGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestBillingServiceLimitType>))]
    public enum Error429RequestBillingServiceLimitType
    {
        [StringValue("BILLING")]
        BILLING
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestBillingServiceLimitSubtype>))]
    public enum Error429RequestBillingServiceLimitSubtype
    {
        [StringValue("SERVICE_LIMIT_REACHED")]
        SERVICE_LIMIT_REACHED
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestBillingServiceLimitSeverity>))]
    public enum Error429RequestBillingServiceLimitSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error429RequestBillingServiceLimitDescription>))]
    public enum Error429RequestBillingServiceLimitDescription
    {
        [StringValue("Requested API version is not available. Please check Foxentry.dev for the supported versions.")]
        REQUESTED_API_VERSION_IS_NOT_AVAILABLE_PLEASE_CHECK_FOXENTRY_DEV_FOR_THE_SUPPORTED_VERSIONS_
    }
}

