
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
public class Error500InternalBilling
{
    [JsonPropertyName("group")]
    public Error500InternalBillingGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error500InternalBillingType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public string? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error500InternalBillingDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalBillingGroup>))]
    public enum Error500InternalBillingGroup
    {
        [StringValue("INTERNAL")]
        INTERNAL
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalBillingType>))]
    public enum Error500InternalBillingType
    {
        [StringValue("BILLING")]
        BILLING
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalBillingDescription>))]
    public enum Error500InternalBillingDescription
    {
        [StringValue("Failed to process your request due to a billing internal error. Please contact us if the error persists.")]
        FAILED_TO_PROCESS_YOUR_REQUEST_DUE_TO_A_BILLING_INTERNAL_ERROR_PLEASE_CONTACT_US_IF_THE_ERROR_PERSISTS_
    }
}

