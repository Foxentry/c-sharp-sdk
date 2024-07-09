
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
public class NameValidationResultsDetails : System.Collections.Generic.List<NameValidationResultsDetailsItem>
{ }
public class NameValidationResultsDetailsItem
{
    [JsonPropertyName("type")]
    [Newtonsoft.Json.JsonProperty("type")]
    public required NameValidationResultsDetailsItemType Type { get; init; }
    [JsonPropertyName("value")]
    [Newtonsoft.Json.JsonProperty("value")]
    public required string Value { get; init; }
    [JsonPropertyName("gender")]
    [Newtonsoft.Json.JsonProperty("gender")]
    public required NameValidationResultsDetailsItemGender Gender { get; init; }
    [JsonPropertyName("vocative")]
    [Newtonsoft.Json.JsonProperty("vocative")]
    public required string Vocative { get; init; }
    [JsonPropertyName("nameDays")]
    [Newtonsoft.Json.JsonProperty("nameDays")]
    public required IEnumerable<NameValidationResultsDetailsItemNameDays?> NameDays { get; init; }
    /**
     * Type of detail.
     */
    [JsonConverter(typeof(StringValueEnumConverter<NameValidationResultsDetailsItemType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NameValidationResultsDetailsItemType
    {
        [StringValue("name")]
        NAME,
        [StringValue("surname")]
        SURNAME,
        [StringValue("nameSurname")]
        NAME_SURNAME
    }
    /**
     * Gender of name. 0 for unspecified, 1 for men, 2 for women
     */
    [JsonConverter(typeof(StringValueEnumConverter<NameValidationResultsDetailsItemGender>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NameValidationResultsDetailsItemGender
    {
        [StringValue("0")]
        _0,
        [StringValue("1")]
        _1,
        [StringValue("2")]
        _2
    }
    public class NameValidationResultsDetailsItemNameDays
    {
        [JsonPropertyName("country")]
        [Newtonsoft.Json.JsonProperty("country")]
        public required string Country { get; init; }
        [JsonPropertyName("month")]
        [Newtonsoft.Json.JsonProperty("month")]
        public required double Month { get; init; }
        [JsonPropertyName("day")]
        [Newtonsoft.Json.JsonProperty("day")]
        public required double Day { get; init; }
    }
}

