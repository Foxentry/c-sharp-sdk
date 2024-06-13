
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
public class EmailData
{
    [JsonPropertyName("email")]
    [Newtonsoft.Json.JsonProperty("email")]
    public string? Email { get; set; }
    [JsonPropertyName("user")]
    [Newtonsoft.Json.JsonProperty("user")]
    public string? User { get; set; }
    [JsonPropertyName("domain")]
    [Newtonsoft.Json.JsonProperty("domain")]
    public string? Domain { get; set; }
}

