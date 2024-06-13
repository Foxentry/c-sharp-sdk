
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
public class NameValidationResultsData
{
    [JsonPropertyName("nameSurname")]
    [Newtonsoft.Json.JsonProperty("nameSurname")]
    public required string NameSurname { get; init; }
    [JsonPropertyName("name")]
    [Newtonsoft.Json.JsonProperty("name")]
    public required string Name { get; init; }
    [JsonPropertyName("surname")]
    [Newtonsoft.Json.JsonProperty("surname")]
    public required string Surname { get; init; }
    [JsonPropertyName("context")]
    [Newtonsoft.Json.JsonProperty("context")]
    public required IEnumerable<string?> Context { get; init; }
    [JsonPropertyName("degreesBefore")]
    [Newtonsoft.Json.JsonProperty("degreesBefore")]
    public required IEnumerable<string?> DegreesBefore { get; init; }
    [JsonPropertyName("degreesAfter")]
    [Newtonsoft.Json.JsonProperty("degreesAfter")]
    public required IEnumerable<string?> DegreesAfter { get; init; }
}

