
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
/**
 * List of all changes applied to the query data in order to get the corrected result.
 */
public class EmailFixes
{
    [JsonPropertyName("type")]
    [Newtonsoft.Json.JsonProperty("type")]
    public string? Type { get; set; }
    [JsonPropertyName("subtype")]
    [Newtonsoft.Json.JsonProperty("subtype")]
    public string? Subtype { get; set; }
    [JsonPropertyName("data")]
    [Newtonsoft.Json.JsonProperty("data")]
    public EmailFixesData? Data { get; set; }
    public class EmailFixesData
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
}

