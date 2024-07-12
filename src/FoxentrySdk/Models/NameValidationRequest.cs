
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
public class NameValidationRequest
{
    [JsonPropertyName("customId")]
    [Newtonsoft.Json.JsonProperty("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    [Newtonsoft.Json.JsonProperty("query")]
    public required INameValidationRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    [Newtonsoft.Json.JsonProperty("options")]
    public NameValidationRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    [Newtonsoft.Json.JsonProperty("client")]
    public ClientRequest? Client { get; set; }
    class INameValidationRequestQueryConverter : JsonConverter<INameValidationRequestQuery>
    {
        public override INameValidationRequestQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
            if (obj.IsValid(ByNameAndSurnameNameValidationRequestQueryJsonSchema))
            {
                return obj.ToObject<ByNameAndSurnameNameValidationRequestQuery>() ?? throw new JsonException("Unable to parse JSON to ByNameAndSurnameNameValidationRequestQuery");
            }
            if (obj.IsValid(ByNameSurnameNameValidationRequestQueryJsonSchema))
            {
                return obj.ToObject<ByNameSurnameNameValidationRequestQuery>() ?? throw new JsonException("Unable to parse JSON to ByNameSurnameNameValidationRequestQuery");
            }
            throw new JsonException("Unable to parse JSON to INameValidationRequestQuery");
        }
        public override void Write(Utf8JsonWriter writer, INameValidationRequestQuery value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
    [JsonInterfaceConverter(typeof(INameValidationRequestQueryConverter))]
    public interface INameValidationRequestQuery
    { }
    public static readonly JSchema ByNameAndSurnameNameValidationRequestQueryJsonSchema = typeof(ByNameAndSurnameNameValidationRequestQuery).GetJsonSchema();
    public class ByNameAndSurnameNameValidationRequestQuery : INameValidationRequestQuery
    {
        [JsonPropertyName("name")]
        [Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }
        [JsonPropertyName("surname")]
        [Newtonsoft.Json.JsonProperty("surname")]
        public string? Surname { get; set; }

    }
    public static readonly JSchema ByNameSurnameNameValidationRequestQueryJsonSchema = typeof(ByNameSurnameNameValidationRequestQuery).GetJsonSchema();
    public class ByNameSurnameNameValidationRequestQuery : INameValidationRequestQuery
    {
        [JsonPropertyName("nameSurname")]
        [Newtonsoft.Json.JsonProperty("nameSurname")]
        public required string NameSurname { get; init; }

    }
    /**
     * Query options.
     */
    public class NameValidationRequestOptions
    {
        [JsonPropertyName("dataScope")]
        [Newtonsoft.Json.JsonProperty("dataScope")]
        public NameValidationRequestOptionsDataScope? DataScope { get; set; }
        [JsonPropertyName("dataSource")]
        [Newtonsoft.Json.JsonProperty("dataSource")]
        public IEnumerable<string?>? DataSource { get; set; }
        [JsonPropertyName("acceptDegrees")]
        [Newtonsoft.Json.JsonProperty("acceptDegrees")]
        public bool? AcceptDegrees { get; set; }
        [JsonPropertyName("acceptContext")]
        [Newtonsoft.Json.JsonProperty("acceptContext")]
        public bool? AcceptContext { get; set; }
        [JsonPropertyName("validationDepth")]
        [Newtonsoft.Json.JsonProperty("validationDepth")]
        public NameValidationRequestOptionsValidationDepth? ValidationDepth { get; set; }
        [JsonPropertyName("smartMode")]
        [Newtonsoft.Json.JsonProperty("smartMode")]
        public bool? SmartMode { get; set; }
        /**
         * Data scope of returned data. In full datascope information like <b>gender</b>, <b>vocative</b> and <b>date</b> of the name days is returned.
         */
        [JsonConverter(typeof(StringValueEnumConverter<NameValidationRequestOptionsDataScope>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NameValidationRequestOptionsDataScope
        {
            [StringValue("basic")]
            BASIC,
            [StringValue("full")]
            FULL
        }
        /**
         * Specifies the depth of name validation. In other words how strict the validator should behave. <b>Minimal</b> = all the names are considered valid as long as there are no forbidden characters used or we are 100% sure the name is invalid. Usually the only thing corrected is format. <b>Moderate</b> = something in between the minimal and strict validation. There are more instances of corrections like typos etc. <b>Strict</b> = the most strict validation depth. Missing names in our database are marked as invalid, the scoring for corrections and suggestions is tweaked.
         */
        [JsonConverter(typeof(StringValueEnumConverter<NameValidationRequestOptionsValidationDepth>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NameValidationRequestOptionsValidationDepth
        {
            [StringValue("minimal")]
            MINIMAL,
            [StringValue("moderate")]
            MODERATE,
            [StringValue("strict")]
            STRICT
        }
    }
}

