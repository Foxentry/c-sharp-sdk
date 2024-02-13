
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
public class LocationValidationRequest
{
    [JsonPropertyName("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    public required LocationValidationRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    public LocationValidationRequestOptions? Options { get; set; }
    [JsonPropertyName("client")]
    public ClientRequest? Client { get; set; }
    public class LocationValidationRequestOptions : LocationRequestOptions
    {
        [JsonPropertyName("acceptPostOfficeAsCity")]
        public bool? AcceptPostOfficeAsCity { get; set; }
    }
    public class LocationValidationRequestQuery
    {
        [JsonPropertyName("street")]
        public string? Street { get; set; }
        [JsonPropertyName("streetWithNumber")]
        public string? StreetWithNumber { get; set; }
        [JsonPropertyName("'number.full'")]
        public string? NumberFull { get; set; }
        [JsonPropertyName("'number.part1'")]
        public string? NumberPart1 { get; set; }
        [JsonPropertyName("'number.part1Number'")]
        public string? NumberPart1Number { get; set; }
        [JsonPropertyName("'number.part1Letter'")]
        public string? NumberPart1Letter { get; set; }
        [JsonPropertyName("'number.part2'")]
        public string? NumberPart2 { get; set; }
        [JsonPropertyName("'number.part2Number'")]
        public string? NumberPart2Number { get; set; }
        [JsonPropertyName("'number.part2Letter'")]
        public string? NumberPart2Letter { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
        [JsonPropertyName("zip")]
        public string? Zip { get; set; }
        [JsonPropertyName("full")]
        public string? Full { get; set; }
        [JsonPropertyName("country")]
        public string? Country { get; set; }
    }
}

