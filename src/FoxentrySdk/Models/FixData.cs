
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
/**
 * Data that has been changed
 */
public class FixData
{
    [JsonPropertyName("typeFrom")]
    public string? TypeFrom { get; set; }
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    [JsonPropertyName("valueFrom")]
    public string? ValueFrom { get; set; }
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

