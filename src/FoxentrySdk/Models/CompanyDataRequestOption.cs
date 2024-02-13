
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
/**
 * Query options.
 */
public class CompanyDataRequestOption
{
    [JsonPropertyName("dataScope")]
    public CompanyDataRequestOptionDataScope? DataScope { get; set; }
    [JsonPropertyName("dataSource")]
    public IEnumerable<string?>? DataSource { get; set; }
    [JsonPropertyName("includeTerminatedSubjects")]
    public bool? IncludeTerminatedSubjects { get; set; }
    [JsonPropertyName("zipFormat")]
    public bool? ZipFormat { get; set; }
    [JsonPropertyName("cityFormat")]
    public CompanyDataRequestOptionCityFormat? CityFormat { get; set; }
    /**
     * Data scope of returned data.
     */
    [JsonConverter(typeof(StringValueEnumConverter<CompanyDataRequestOptionDataScope>))]
    public enum CompanyDataRequestOptionDataScope
    {
        [StringValue("basic")]
        BASIC,
        [StringValue("extended")]
        EXTENDED,
        [StringValue("full")]
        FULL
    }
    /**
     * This option determines in what format is city returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
     */
    [JsonConverter(typeof(StringValueEnumConverter<CompanyDataRequestOptionCityFormat>))]
    public enum CompanyDataRequestOptionCityFormat
    {
        [StringValue("minimal")]
        MINIMAL,
        [StringValue("basic")]
        BASIC,
        [StringValue("extended")]
        EXTENDED
    }
}

