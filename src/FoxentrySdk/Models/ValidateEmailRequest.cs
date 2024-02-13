
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
public class ValidateEmailRequest
{
    [JsonPropertyName("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    public required ValidateEmailRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    public ValidateEmailRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    public ClientRequest? Client { get; set; }
    public class ValidateEmailRequestQuery
    {
        [JsonPropertyName("email")]
        public required string Email { get; init; }
    }
    /**
     * Query options.
     */
    public class ValidateEmailRequestOptions
    {
        [JsonPropertyName("validationType")]
        public ValidateEmailRequestOptionsValidationType? ValidationType { get; set; }
        [JsonPropertyName("acceptDisposableEmails")]
        public bool? AcceptDisposableEmails { get; set; }
        [JsonPropertyName("acceptFreemails")]
        public bool? AcceptFreemails { get; set; }
        /**
         * Type of validation. <b>Basic</b> = only the format of e-mail is checked and only standard corrections are included. <b>Extended</b> = in depth check of deliverability. Additional information is returned such as temporary mail check or freemail check. More complicated corrections are included.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidateEmailRequestOptionsValidationType>))]
        public enum ValidateEmailRequestOptionsValidationType
        {
            [StringValue("basic")]
            BASIC,
            [StringValue("extended")]
            EXTENDED
        }
    }
}

