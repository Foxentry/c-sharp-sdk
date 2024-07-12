
/**
 * Foxentry API reference
 *
 * The version of the OpenAPI document: 2.0
 * Contact: info@foxentry.com
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
public class ValidatePhoneNumberRequest
{
    [JsonPropertyName("customId")]
    [Newtonsoft.Json.JsonProperty("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    [Newtonsoft.Json.JsonProperty("query")]
    public required IValidatePhoneNumberRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    [Newtonsoft.Json.JsonProperty("options")]
    public ValidatePhoneNumberRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    [Newtonsoft.Json.JsonProperty("client")]
    public ClientRequest? Client { get; set; }
    class IValidatePhoneNumberRequestQueryConverter : JsonConverter<IValidatePhoneNumberRequestQuery>
    {
        public override IValidatePhoneNumberRequestQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
            if (obj.IsValid(ByPrefixAndNumberValidatePhoneNumberRequestQueryJsonSchema))
            {
                return obj.ToObject<ByPrefixAndNumberValidatePhoneNumberRequestQuery>() ?? throw new JsonException("Unable to parse JSON to ByPrefixAndNumberValidatePhoneNumberRequestQuery");
            }
            if (obj.IsValid(ByNumberWithPrefixValidatePhoneNumberRequestQueryJsonSchema))
            {
                return obj.ToObject<ByNumberWithPrefixValidatePhoneNumberRequestQuery>() ?? throw new JsonException("Unable to parse JSON to ByNumberWithPrefixValidatePhoneNumberRequestQuery");
            }
            throw new JsonException("Unable to parse JSON to IValidatePhoneNumberRequestQuery");
        }
        public override void Write(Utf8JsonWriter writer, IValidatePhoneNumberRequestQuery value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
    [JsonInterfaceConverter(typeof(IValidatePhoneNumberRequestQueryConverter))]
    public interface IValidatePhoneNumberRequestQuery
    { }
    public static readonly JSchema ByPrefixAndNumberValidatePhoneNumberRequestQueryJsonSchema = typeof(ByPrefixAndNumberValidatePhoneNumberRequestQuery).GetJsonSchema();
    public class ByPrefixAndNumberValidatePhoneNumberRequestQuery : IValidatePhoneNumberRequestQuery
    {
        [JsonPropertyName("prefix")]
        [Newtonsoft.Json.JsonProperty("prefix")]
        public required string Prefix { get; init; }
        [JsonPropertyName("number")]
        [Newtonsoft.Json.JsonProperty("number")]
        public required string Number { get; init; }

    }
    public static readonly JSchema ByNumberWithPrefixValidatePhoneNumberRequestQueryJsonSchema = typeof(ByNumberWithPrefixValidatePhoneNumberRequestQuery).GetJsonSchema();
    public class ByNumberWithPrefixValidatePhoneNumberRequestQuery : IValidatePhoneNumberRequestQuery
    {
        [JsonPropertyName("numberWithPrefix")]
        [Newtonsoft.Json.JsonProperty("numberWithPrefix")]
        public required string NumberWithPrefix { get; init; }

    }
    /**
     * Query options.
     */
    public class ValidatePhoneNumberRequestOptions
    {
        [JsonPropertyName("validationType")]
        [Newtonsoft.Json.JsonProperty("validationType")]
        public ValidatePhoneNumberRequestOptionsValidationType? ValidationType { get; set; }
        [JsonPropertyName("allowedPrefixes")]
        [Newtonsoft.Json.JsonProperty("allowedPrefixes")]
        public IEnumerable<string?>? AllowedPrefixes { get; set; }
        [JsonPropertyName("preferredPrefixes")]
        [Newtonsoft.Json.JsonProperty("preferredPrefixes")]
        public IEnumerable<string?>? PreferredPrefixes { get; set; }
        [JsonPropertyName("defaultPrefix")]
        [Newtonsoft.Json.JsonProperty("defaultPrefix")]
        public string? DefaultPrefix { get; set; }
        [JsonPropertyName("formatNumber")]
        [Newtonsoft.Json.JsonProperty("formatNumber")]
        public bool? FormatNumber { get; set; }
        /**
         * Type of validation.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidatePhoneNumberRequestOptionsValidationType>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ValidatePhoneNumberRequestOptionsValidationType
        {
            [StringValue("basic")]
            BASIC,
            [StringValue("extended")]
            EXTENDED
        }
    }
}

