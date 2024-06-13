
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
public class ValidatePhoneNumberData
{
    [JsonPropertyName("country")]
    [Newtonsoft.Json.JsonProperty("country")]
    public required ValidatePhoneNumberDataCountry Country { get; init; }
    [JsonPropertyName("number")]
    [Newtonsoft.Json.JsonProperty("number")]
    public required string Number { get; init; }
    [JsonPropertyName("numberWithPrefix")]
    [Newtonsoft.Json.JsonProperty("numberWithPrefix")]
    public required string NumberWithPrefix { get; init; }
    [JsonPropertyName("carrier")]
    [Newtonsoft.Json.JsonProperty("carrier")]
    public required ValidatePhoneNumberDataCarrier Carrier { get; init; }
    [JsonPropertyName("format")]
    [Newtonsoft.Json.JsonProperty("format")]
    public required ValidatePhoneNumberDataFormat Format { get; init; }
    public class ValidatePhoneNumberDataCountry
    {
        [JsonPropertyName("code")]
        [Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }
        [JsonPropertyName("prefix")]
        [Newtonsoft.Json.JsonProperty("prefix")]
        public string? Prefix { get; set; }
    }
    /**
     * Phone carrier information.
     */
    public class ValidatePhoneNumberDataCarrier
    {
        [JsonPropertyName("name")]
        [Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }
        [JsonPropertyName("type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public ValidatePhoneNumberDataCarrierType? Type { get; set; }
        /**
         * Type of carrier.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidatePhoneNumberDataCarrierType>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ValidatePhoneNumberDataCarrierType
        {
            [StringValue("landline")]
            LANDLINE,
            [StringValue("mobile")]
            MOBILE,
            [StringValue("voip")]
            VOIP,

        }
    }
    /**
     * Standardized international and local format.
     */
    public class ValidatePhoneNumberDataFormat
    {
        [JsonPropertyName("national")]
        [Newtonsoft.Json.JsonProperty("national")]
        public string? National { get; set; }
        [JsonPropertyName("nationalFormatted")]
        [Newtonsoft.Json.JsonProperty("nationalFormatted")]
        public string? NationalFormatted { get; set; }
        [JsonPropertyName("international")]
        [Newtonsoft.Json.JsonProperty("international")]
        public string? International { get; set; }
        [JsonPropertyName("internationalFormatted")]
        [Newtonsoft.Json.JsonProperty("internationalFormatted")]
        public string? InternationalFormatted { get; set; }
    }
}

