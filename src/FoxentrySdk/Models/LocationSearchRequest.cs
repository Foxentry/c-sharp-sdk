
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
public class LocationSearchRequest
{
    [JsonPropertyName("customId")]
    [Newtonsoft.Json.JsonProperty("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    [Newtonsoft.Json.JsonProperty("query")]
    public required LocationSearchRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    [Newtonsoft.Json.JsonProperty("options")]
    public LocationRequestOptionsSearch? Options { get; set; }
    [JsonPropertyName("client")]
    [Newtonsoft.Json.JsonProperty("client")]
    public ClientRequest? Client { get; set; }
    public class LocationSearchRequestQuery
    {
        [JsonPropertyName("type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public required LocationSearchRequestQueryType Type { get; init; }
        [JsonPropertyName("value")]
        [Newtonsoft.Json.JsonProperty("value")]
        public required string Value { get; init; }
        [JsonPropertyName("filter")]
        [Newtonsoft.Json.JsonProperty("filter")]
        public LocationSearchRequestQueryFilter? Filter { get; set; }
        /**
         * Type of search.
         */
        [JsonConverter(typeof(StringValueEnumConverter<LocationSearchRequestQueryType>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum LocationSearchRequestQueryType
        {
            [StringValue("street")]
            STREET,
            [StringValue("streetWithNumber")]
            STREET_WITH_NUMBER,
            [StringValue("number.full")]
            NUMBER_FULL,
            [StringValue("number.part1")]
            NUMBER_PART1,
            [StringValue("number.part2")]
            NUMBER_PART2,
            [StringValue("city")]
            CITY,
            [StringValue("zip")]
            ZIP,
            [StringValue("full")]
            FULL
        }/**
         * Additional filter in order to specify the search results. You can for example set as a filter city of Prague, so the the search engine would look for the addresses only in Prague. Pay attention to the options, which determines how the filter should behave.
         */
        public class LocationSearchRequestQueryFilter
        {
            [JsonPropertyName("street")]
            [Newtonsoft.Json.JsonProperty("street")]
            public string? Street { get; set; }
            [JsonPropertyName("streetWithNumber")]
            [Newtonsoft.Json.JsonProperty("streetWithNumber")]
            public string? StreetWithNumber { get; set; }
            [JsonPropertyName("'number.full'")]
            [Newtonsoft.Json.JsonProperty("'number.full'")]
            public string? NumberFull { get; set; }
            [JsonPropertyName("'number.part1'")]
            [Newtonsoft.Json.JsonProperty("'number.part1'")]
            public string? NumberPart1 { get; set; }
            [JsonPropertyName("'number.part2'")]
            [Newtonsoft.Json.JsonProperty("'number.part2'")]
            public string? NumberPart2 { get; set; }
            [JsonPropertyName("city")]
            [Newtonsoft.Json.JsonProperty("city")]
            public string? City { get; set; }
            [JsonPropertyName("zip")]
            [Newtonsoft.Json.JsonProperty("zip")]
            public string? Zip { get; set; }
            [JsonPropertyName("country")]
            [Newtonsoft.Json.JsonProperty("country")]
            public string? Country { get; set; }
        }
    }
}

