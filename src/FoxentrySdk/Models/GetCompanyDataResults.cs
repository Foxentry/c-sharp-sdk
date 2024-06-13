
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
public class GetCompanyDataResults
{
    [JsonPropertyName("results")]
    [Newtonsoft.Json.JsonProperty("results")]
    public required IEnumerable<CompanyResultsResponseResults> Results { get; init; }
    public class GetCompanyDataResultsResults { }
}

