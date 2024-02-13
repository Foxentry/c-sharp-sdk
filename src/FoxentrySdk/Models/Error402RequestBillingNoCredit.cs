
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
public class Error402RequestBillingNoCredit
{
    [JsonPropertyName("group")]
    public Error402RequestBillingNoCreditGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error402RequestBillingNoCreditType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error402RequestBillingNoCreditSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error402RequestBillingNoCreditSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error402RequestBillingNoCreditDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error402RequestBillingNoCreditGroup>))]
    public enum Error402RequestBillingNoCreditGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error402RequestBillingNoCreditType>))]
    public enum Error402RequestBillingNoCreditType
    {
        [StringValue("BILLING")]
        BILLING
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error402RequestBillingNoCreditSubtype>))]
    public enum Error402RequestBillingNoCreditSubtype
    {
        [StringValue("NO_CREDIT")]
        NO_CREDIT
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error402RequestBillingNoCreditSeverity>))]
    public enum Error402RequestBillingNoCreditSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error402RequestBillingNoCreditDescription>))]
    public enum Error402RequestBillingNoCreditDescription
    {
        [StringValue("No credit available. You need to purchase a sufficient ammount of credits in the project administration at app.foxentry.com.")]
        NO_CREDIT_AVAILABLE_YOU_NEED_TO_PURCHASE_A_SUFFICIENT_AMMOUNT_OF_CREDITS_IN_THE_PROJECT_ADMINISTRATION_AT_APP_FOXENTRY_COM_
    }
}

