
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
public class NameValidationResponseRequest
{
    [JsonPropertyName("endpoint")]
    [Newtonsoft.Json.JsonProperty("endpoint")]
    public required string Endpoint { get; init; }
    [JsonPropertyName("code")]
    [Newtonsoft.Json.JsonProperty("code")]
    public required string Code { get; init; }
    [JsonPropertyName("customId")]
    [Newtonsoft.Json.JsonProperty("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    [Newtonsoft.Json.JsonProperty("query")]
    public NameValidationResponseRequestQuery? Query { get; set; }
    [JsonPropertyName("options")]
    [Newtonsoft.Json.JsonProperty("options")]
    public NameValidationResponseRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    [Newtonsoft.Json.JsonProperty("client")]
    public NameValidationResponseRequestClient? Client { get; set; }
    public class NameValidationResponseRequestQuery
    {
        [JsonPropertyName("name")]
        [Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }
        [JsonPropertyName("surname")]
        [Newtonsoft.Json.JsonProperty("surname")]
        public string? Surname { get; set; }
        [JsonPropertyName("nameSurname")]
        [Newtonsoft.Json.JsonProperty("nameSurname")]
        public string? NameSurname { get; set; }
    }
    /**
     * Query options.
     */
    public class NameValidationResponseRequestOptions
    {
        [JsonPropertyName("dataScope")]
        [Newtonsoft.Json.JsonProperty("dataScope")]
        public NameValidationResponseRequestOptionsDataScope? DataScope { get; set; }
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
        public NameValidationResponseRequestOptionsValidationDepth? ValidationDepth { get; set; }
        [JsonPropertyName("smartMode")]
        [Newtonsoft.Json.JsonProperty("smartMode")]
        public bool? SmartMode { get; set; }
        /**
         * Data scope of returned data. In full datascope information like <b>gender</b>, <b>vocative</b> and <b>date</b> of the name days is returned.
         */
        [JsonConverter(typeof(StringValueEnumConverter<NameValidationResponseRequestOptionsDataScope>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NameValidationResponseRequestOptionsDataScope
        {
            [StringValue("basic")]
            BASIC,
            [StringValue("full")]
            FULL
        }
        /**
         * Specifies the depth of name validation. In other words how strict the validator should behave. <b>Minimal</b> = all the names are considered valid as long as there are no forbidden characters used or we are 100% sure the name is invalid. Usually the only thing corrected is format. <b>Moderate</b> = something in between the minimal and strict validation. There are more instances of corrections like typos etc. <b>Strict</b> = the most strict validation depth. Missing names in our database are marked as invalid, the scoring for corrections and suggestions is tweaked.
         */
        [JsonConverter(typeof(StringValueEnumConverter<NameValidationResponseRequestOptionsValidationDepth>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NameValidationResponseRequestOptionsValidationDepth
        {
            [StringValue("minimal")]
            MINIMAL,
            [StringValue("moderate")]
            MODERATE,
            [StringValue("strict")]
            STRICT,

        }
    }
    /**
     * The information about your client to help specify the search or validation.
     */
    public class NameValidationResponseRequestClient
    {
        [JsonPropertyName("country")]
        [Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }
        [JsonPropertyName("location")]
        [Newtonsoft.Json.JsonProperty("location")]
        public NameValidationResponseRequestClientLocation? Location { get; set; }/**
                 * Client's location.
                 */
        public class NameValidationResponseRequestClientLocation
        {
            [JsonPropertyName("lat")]
            [Newtonsoft.Json.JsonProperty("lat")]
            public double? Lat { get; set; }
            [JsonPropertyName("lon")]
            [Newtonsoft.Json.JsonProperty("lon")]
            public double? Lon { get; set; }
        }
    }
}

