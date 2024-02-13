
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
public class NameValidationResultsData
{
    [JsonPropertyName("nameSurname")]
    public required string NameSurname { get; init; }
    [JsonPropertyName("name")]
    public required string Name { get; init; }
    [JsonPropertyName("surname")]
    public required string Surname { get; init; }
    [JsonPropertyName("context")]
    public required IEnumerable<string?> Context { get; init; }
    [JsonPropertyName("degreesBefore")]
    public required IEnumerable<string?> DegreesBefore { get; init; }
    [JsonPropertyName("degreesAfter")]
    public required IEnumerable<string?> DegreesAfter { get; init; }
}

