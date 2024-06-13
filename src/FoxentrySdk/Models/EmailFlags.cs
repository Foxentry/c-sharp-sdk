
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
public class EmailFlags
{
    [JsonPropertyName("isCatchAllServer")]
    [Newtonsoft.Json.JsonProperty("isCatchAllServer")]
    public bool? IsCatchAllServer { get; set; }
    [JsonPropertyName("isDisposableEmailLocation")]
    [Newtonsoft.Json.JsonProperty("isDisposableEmailLocation")]
    public bool? IsDisposableEmailLocation { get; set; }
    [JsonPropertyName("isFreeMail")]
    [Newtonsoft.Json.JsonProperty("isFreeMail")]
    public bool? IsFreeMail { get; set; }
}

