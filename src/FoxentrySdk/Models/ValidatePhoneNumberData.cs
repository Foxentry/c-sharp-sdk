
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
public class ValidatePhoneNumberData
{
    [JsonPropertyName("country")]
    public required ValidatePhoneNumberDataCountry Country { get; init; }
    [JsonPropertyName("number")]
    public required string Number { get; init; }
    [JsonPropertyName("numberWithPrefix")]
    public required string NumberWithPrefix { get; init; }
    [JsonPropertyName("carrier")]
    public required ValidatePhoneNumberDataCarrier Carrier { get; init; }
    [JsonPropertyName("format")]
    public required ValidatePhoneNumberDataFormat Format { get; init; }
    public class ValidatePhoneNumberDataCountry
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        [JsonPropertyName("prefix")]
        public string? Prefix { get; set; }
    }
    /**
     * Phone carrier information.
     */
    public class ValidatePhoneNumberDataCarrier
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("type")]
        public ValidatePhoneNumberDataCarrierType? Type { get; set; }
        /**
         * Type of carrier.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidatePhoneNumberDataCarrierType>))]
        public enum ValidatePhoneNumberDataCarrierType
        {
            [StringValue("landline")]
            LANDLINE,
            [StringValue("mobile")]
            MOBILE,
            [StringValue("voip")]
            VOIP
        }
    }
    /**
     * Standardized international and local format.
     */
    public class ValidatePhoneNumberDataFormat
    {
        [JsonPropertyName("national")]
        public string? National { get; set; }
        [JsonPropertyName("nationalFormatted")]
        public string? NationalFormatted { get; set; }
        [JsonPropertyName("international")]
        public string? International { get; set; }
        [JsonPropertyName("internationalFormatted")]
        public string? InternationalFormatted { get; set; }
    }
}

