
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
public class FixFormatGlobal
{
    [JsonPropertyName("group")]
    public FixFormatGlobalGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public FixFormatGlobalType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public FixFormatGlobalSubtype? Subtype { get; set; }
    [JsonPropertyName("data")]
    public FixData? Data { get; set; }
    /**
     * Group of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixFormatGlobalGroup>))]
    public enum FixFormatGlobalGroup
    {
        [StringValue("FORMAT")]
        FORMAT
    }
    /**
     * Type of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixFormatGlobalType>))]
    public enum FixFormatGlobalType
    {
        [StringValue("CHANGED")]
        CHANGED
    }
    /**
     * Subtype of fix.
     */
    [JsonConverter(typeof(StringValueEnumConverter<FixFormatGlobalSubtype>))]
    public enum FixFormatGlobalSubtype
    {
        [StringValue("CASE_SENSITIVITY")]
        CASE_SENSITIVITY,
        [StringValue("DIACRITICS")]
        DIACRITICS,
        [StringValue("WHITESPACES")]
        WHITESPACES
    }
}

