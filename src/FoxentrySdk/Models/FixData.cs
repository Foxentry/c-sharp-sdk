
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
/**
 * Data that has been changed
 */
public class FixData
{
    [JsonPropertyName("typeFrom")]
    [Newtonsoft.Json.JsonProperty("typeFrom")]
    public string? TypeFrom { get; set; }
    [JsonPropertyName("type")]
    [Newtonsoft.Json.JsonProperty("type")]
    public string? Type { get; set; }
    [JsonPropertyName("valueFrom")]
    [Newtonsoft.Json.JsonProperty("valueFrom")]
    public string? ValueFrom { get; set; }
    [JsonPropertyName("value")]
    [Newtonsoft.Json.JsonProperty("value")]
    public string? Value { get; set; }
}

