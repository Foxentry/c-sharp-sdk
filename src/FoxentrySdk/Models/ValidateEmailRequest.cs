
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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Schema;
using FoxentrySdk.Core;
namespace FoxentrySdk.Models;
public class ValidateEmailRequest
{
    [JsonPropertyName("customId")]
    [Newtonsoft.Json.JsonProperty("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    [Newtonsoft.Json.JsonProperty("query")]
    public required ValidateEmailRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    [Newtonsoft.Json.JsonProperty("options")]
    public ValidateEmailRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    [Newtonsoft.Json.JsonProperty("client")]
    public ClientRequest? Client { get; set; }
    public class ValidateEmailRequestQuery
    {
        [JsonPropertyName("email")]
        [Newtonsoft.Json.JsonProperty("email")]
        public required string Email { get; init; }
    }
    /**
     * Query options.
     */
    public class ValidateEmailRequestOptions
    {
        [JsonPropertyName("validationType")]
        [Newtonsoft.Json.JsonProperty("validationType")]
        public ValidateEmailRequestOptionsValidationType? ValidationType { get; set; }
        [JsonPropertyName("acceptDisposableEmails")]
        [Newtonsoft.Json.JsonProperty("acceptDisposableEmails")]
        public bool? AcceptDisposableEmails { get; set; }
        [JsonPropertyName("acceptFreemails")]
        [Newtonsoft.Json.JsonProperty("acceptFreemails")]
        public bool? AcceptFreemails { get; set; }
        /**
         * Type of validation. <b>Basic</b> = only the format of e-mail is checked and only standard corrections are included. <b>Extended</b> = in depth check of deliverability. Additional information is returned such as temporary mail check or freemail check. More complicated corrections are included.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidateEmailRequestOptionsValidationType>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ValidateEmailRequestOptionsValidationType
        {
            [StringValue("basic")]
            BASIC,
            [StringValue("extended")]
            EXTENDED
        }
    }
}

