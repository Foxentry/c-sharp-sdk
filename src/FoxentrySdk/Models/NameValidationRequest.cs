
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
public class NameValidationRequest
{
    [JsonPropertyName("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    public required INameValidationRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    public NameValidationRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    public ClientRequest? Client { get; set; }
    public interface INameValidationRequestQuery
    { }
    public class ByNameAndSurnameNameValidationRequestQuery : INameValidationRequestQuery
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("surname")]
        public string? Surname { get; set; }

    }
    public class ByNameSurnameNameValidationRequestQuery : INameValidationRequestQuery
    {
        [JsonPropertyName("nameSurname")]
        public required string NameSurname { get; init; }

    }
    /**
     * Query options.
     */
    public class NameValidationRequestOptions
    {
        [JsonPropertyName("dataScope")]
        public NameValidationRequestOptionsDataScope? DataScope { get; set; }
        [JsonPropertyName("dataSource")]
        public IEnumerable<string?>? DataSource { get; set; }
        [JsonPropertyName("acceptDegrees")]
        public bool? AcceptDegrees { get; set; }
        [JsonPropertyName("acceptContext")]
        public bool? AcceptContext { get; set; }
        [JsonPropertyName("validationDepth")]
        public NameValidationRequestOptionsValidationDepth? ValidationDepth { get; set; }
        [JsonPropertyName("smartMode")]
        public bool? SmartMode { get; set; }
        /**
         * Data scope of returned data. In full datascope information like <b>gender</b>, <b>vocative</b> and <b>date</b> of the name days is returned.
         */
        [JsonConverter(typeof(StringValueEnumConverter<NameValidationRequestOptionsDataScope>))]
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

