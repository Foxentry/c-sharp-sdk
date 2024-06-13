
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
public class ErrorFormatGlobal
{
    [JsonPropertyName("group")]
    [Newtonsoft.Json.JsonProperty("group")]
    public ErrorFormatGlobalGroup? Group { get; set; }
    [JsonPropertyName("type")]
    [Newtonsoft.Json.JsonProperty("type")]
    public ErrorFormatGlobalType? Type { get; set; }
    [JsonPropertyName("subtype")]
    [Newtonsoft.Json.JsonProperty("subtype")]
    public ErrorFormatGlobalSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    [Newtonsoft.Json.JsonProperty("severity")]
    public ErrorFormatGlobalSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    [Newtonsoft.Json.JsonProperty("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    [Newtonsoft.Json.JsonProperty("description")]
    public ErrorFormatGlobalDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorFormatGlobalGroup>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ErrorFormatGlobalGroup
    {
        [StringValue("FORMAT")]
        FORMAT
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorFormatGlobalType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ErrorFormatGlobalType
    {
        [StringValue("CHARACTERS")]
        CHARACTERS
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorFormatGlobalSubtype>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ErrorFormatGlobalSubtype
    {
        [StringValue("CASE_SENSITIVITY")]
        CASE_SENSITIVITY,
        [StringValue("DIACRITICS")]
        DIACRITICS,
        [StringValue("SPECIAL")]
        SPECIAL,
        [StringValue("WHITESPACES")]
        WHITESPACES,

    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorFormatGlobalSeverity>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ErrorFormatGlobalSeverity
    {
        [StringValue("info")]
        INFO,
        [StringValue("warning")]
        WARNING,
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorFormatGlobalDescription>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ErrorFormatGlobalDescription
    {
        [StringValue("Invalid case sensitivity. Specific rules are applied to the use of upper and lower case letters.")]
        INVALID_CASE_SENSITIVITY_SPECIFIC_RULES_ARE_APPLIED_TO_THE_USE_OF_UPPER_AND_LOWER_CASE_LETTERS_,
        [StringValue("Invalid diacritics. Specific rules are applied to the use of diacritics.")]
        INVALID_DIACRITICS_SPECIFIC_RULES_ARE_APPLIED_TO_THE_USE_OF_DIACRITICS_,
        [StringValue("Invalid use of spaces. Specific rules are applied to the use of spaces.")]
        INVALID_USE_OF_SPACES_SPECIFIC_RULES_ARE_APPLIED_TO_THE_USE_OF_SPACES_,

    }
}

