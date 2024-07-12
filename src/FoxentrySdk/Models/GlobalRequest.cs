
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
public class GlobalRequest
{
    [JsonPropertyName("endpoint")]
    [Newtonsoft.Json.JsonProperty("endpoint")]
    public required virtual string Endpoint { get; init; }
    [JsonPropertyName("code")]
    [Newtonsoft.Json.JsonProperty("code")]
    public required string Code { get; init; }
    [JsonPropertyName("customId")]
    [Newtonsoft.Json.JsonProperty("customId")]
    public string? CustomId { get; set; }
}

