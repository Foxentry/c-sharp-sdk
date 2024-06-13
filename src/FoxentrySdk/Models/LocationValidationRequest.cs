
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
public class LocationValidationRequest
{
    [JsonPropertyName("customId")]
    [Newtonsoft.Json.JsonProperty("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    [Newtonsoft.Json.JsonProperty("query")]
    public required LocationValidationRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    [Newtonsoft.Json.JsonProperty("options")]
    public LocationValidationRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    [Newtonsoft.Json.JsonProperty("client")]
    public ClientRequest? Client { get; set; }
    public class LocationValidationRequestOptions : LocationRequestOptions
    {
        [JsonPropertyName("acceptPostOfficeAsCity")]
        [Newtonsoft.Json.JsonProperty("acceptPostOfficeAsCity")]
        public bool? AcceptPostOfficeAsCity { get; set; }
    }
    public class LocationValidationRequestQuery
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
        [JsonPropertyName("'number.part1Number'")]
        [Newtonsoft.Json.JsonProperty("'number.part1Number'")]
        public string? NumberPart1Number { get; set; }
        [JsonPropertyName("'number.part1Letter'")]
        [Newtonsoft.Json.JsonProperty("'number.part1Letter'")]
        public string? NumberPart1Letter { get; set; }
        [JsonPropertyName("'number.part2'")]
        [Newtonsoft.Json.JsonProperty("'number.part2'")]
        public string? NumberPart2 { get; set; }
        [JsonPropertyName("'number.part2Number'")]
        [Newtonsoft.Json.JsonProperty("'number.part2Number'")]
        public string? NumberPart2Number { get; set; }
        [JsonPropertyName("'number.part2Letter'")]
        [Newtonsoft.Json.JsonProperty("'number.part2Letter'")]
        public string? NumberPart2Letter { get; set; }
        [JsonPropertyName("city")]
        [Newtonsoft.Json.JsonProperty("city")]
        public string? City { get; set; }
        [JsonPropertyName("zip")]
        [Newtonsoft.Json.JsonProperty("zip")]
        public string? Zip { get; set; }
        [JsonPropertyName("full")]
        [Newtonsoft.Json.JsonProperty("full")]
        public string? Full { get; set; }
        [JsonPropertyName("country")]
        [Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }
    }
}

