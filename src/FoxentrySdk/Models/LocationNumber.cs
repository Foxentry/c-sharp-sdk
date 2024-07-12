
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
public class LocationNumber
{
    [JsonPropertyName("part1")]
    [Newtonsoft.Json.JsonProperty("part1")]
    public required string Part1 { get; init; }
    [JsonPropertyName("part1Number")]
    [Newtonsoft.Json.JsonProperty("part1Number")]
    public string? Part1Number { get; set; }
    [JsonPropertyName("part1Letter")]
    [Newtonsoft.Json.JsonProperty("part1Letter")]
    public string? Part1Letter { get; set; }
    [JsonPropertyName("part2")]
    [Newtonsoft.Json.JsonProperty("part2")]
    public required string Part2 { get; init; }
    [JsonPropertyName("part2Number")]
    [Newtonsoft.Json.JsonProperty("part2Number")]
    public string? Part2Number { get; set; }
    [JsonPropertyName("part2Letter")]
    [Newtonsoft.Json.JsonProperty("part2Letter")]
    public string? Part2Letter { get; set; }
    [JsonPropertyName("full")]
    [Newtonsoft.Json.JsonProperty("full")]
    public string? Full { get; set; }
}

