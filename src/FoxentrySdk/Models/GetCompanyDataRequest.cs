
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
public class GetCompanyDataRequest
{
    [JsonPropertyName("customId")]
    public string? CustomId { get; set; }
    [JsonPropertyName("query")]
    public required GetCompanyDataRequestQuery Query { get; init; }
    [JsonPropertyName("options")]
    public CompanyDataRequestOption? Options { get; set; }
    [JsonPropertyName("client")]
    public ClientRequest? Client { get; set; }
    public class GetCompanyDataRequestQuery
    {
        [JsonPropertyName("country")]
        public required string Country { get; init; }
        [JsonPropertyName("registrationNumber")]
        public required string RegistrationNumber { get; init; }
    }
}

