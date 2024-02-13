
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
public class EmailFlags
{
    [JsonPropertyName("isCatchAllServer")]
    public bool? IsCatchAllServer { get; set; }
    [JsonPropertyName("isDisposableEmailLocation")]
    public bool? IsDisposableEmailLocation { get; set; }
    [JsonPropertyName("isFreeMail")]
    public bool? IsFreeMail { get; set; }
}

