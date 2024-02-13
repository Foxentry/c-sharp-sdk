
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
public class ValidatePhoneNumberRequest
{
    [JsonPropertyName("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    public required IValidatePhoneNumberRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    public ValidatePhoneNumberRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    public ClientRequest? Client { get; set; }
    public interface IValidatePhoneNumberRequestQuery
    { }
    public class ByPrefixAndNumberValidatePhoneNumberRequestQuery : IValidatePhoneNumberRequestQuery
    {
        [JsonPropertyName("prefix")]
        public required string Prefix { get; init; }
        [JsonPropertyName("number")]
        public required string Number { get; init; }

    }
    public class ByNumberWithPrefixValidatePhoneNumberRequestQuery : IValidatePhoneNumberRequestQuery
    {
        [JsonPropertyName("numberWithPrefix")]
        public required string NumberWithPrefix { get; init; }

    }
    /**
     * Query options.
     */
    public class ValidatePhoneNumberRequestOptions
    {
        [JsonPropertyName("validationType")]
        public ValidatePhoneNumberRequestOptionsValidationType? ValidationType { get; set; }
        [JsonPropertyName("allowedPrefixes")]
        public IEnumerable<string?>? AllowedPrefixes { get; set; }
        [JsonPropertyName("defaultPrefix")]
        public string? DefaultPrefix { get; set; }
        [JsonPropertyName("formatNumber")]
        public bool? FormatNumber { get; set; }
        /**
         * Type of validation.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidatePhoneNumberRequestOptionsValidationType>))]
        public enum ValidatePhoneNumberRequestOptionsValidationType
        {
            [StringValue("basic")]
            BASIC,
            [StringValue("extended")]
            EXTENDED
        }
    }
}

