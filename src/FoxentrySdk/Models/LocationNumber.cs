
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
public class LocationNumber
{
    [JsonPropertyName("part1")]
    public required string Part1 { get; init; }
    [JsonPropertyName("part1Number")]
    public string? Part1Number { get; set; }
    [JsonPropertyName("part1Letter")]
    public string? Part1Letter { get; set; }
    [JsonPropertyName("part2")]
    public required string Part2 { get; init; }
    [JsonPropertyName("part2Number")]
    public string? Part2Number { get; set; }
    [JsonPropertyName("part2Letter")]
    public string? Part2Letter { get; set; }
    [JsonPropertyName("full")]
    public string? Full { get; set; }
}

