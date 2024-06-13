
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
 * Query options.
 */
public class CompanyDataRequestOption
{
    [JsonPropertyName("dataScope")]
    [Newtonsoft.Json.JsonProperty("dataScope")]
    public CompanyDataRequestOptionDataScope? DataScope { get; set; }
    [JsonPropertyName("dataSource")]
    [Newtonsoft.Json.JsonProperty("dataSource")]
    public IEnumerable<string?>? DataSource { get; set; }
    [JsonPropertyName("includeTerminatedSubjects")]
    [Newtonsoft.Json.JsonProperty("includeTerminatedSubjects")]
    public bool? IncludeTerminatedSubjects { get; set; }
    [JsonPropertyName("zipFormat")]
    [Newtonsoft.Json.JsonProperty("zipFormat")]
    public bool? ZipFormat { get; set; }
    [JsonPropertyName("cityFormat")]
    [Newtonsoft.Json.JsonProperty("cityFormat")]
    public CompanyDataRequestOptionCityFormat? CityFormat { get; set; }
    [JsonPropertyName("countryFormat")]
    [Newtonsoft.Json.JsonProperty("countryFormat")]
    public CompanyDataRequestOptionCountryFormat? CountryFormat { get; set; }
    /**
     * Data scope of returned data.
     */
    [JsonConverter(typeof(StringValueEnumConverter<CompanyDataRequestOptionDataScope>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
     * This option determines the format in which the city is returned. <b>Minimal</b> = Praha, <b>basic</b> = Praha 8, <b>extended</b> = Praha 8 - Karlín.
     */
    [JsonConverter(typeof(StringValueEnumConverter<CompanyDataRequestOptionCityFormat>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompanyDataRequestOptionCityFormat
    {
        [StringValue("minimal")]
        MINIMAL,
        [StringValue("basic")]
        BASIC,
        [StringValue("extended")]
        EXTENDED
    }
    /**
     * This option determines the format in which the country is returned. Choices include local and international variants with their shortened counterparts as well as ISO 3166 alpha codes.
     */
    [JsonConverter(typeof(StringValueEnumConverter<CompanyDataRequestOptionCountryFormat>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompanyDataRequestOptionCountryFormat
    {
        [StringValue("alpha2")]
        ALPHA2,
        [StringValue("alpha3")]
        ALPHA3,
        [StringValue("local")]
        LOCAL,
        [StringValue("localShortened")]
        LOCAL_SHORTENED,
        [StringValue("international")]
        INTERNATIONAL,
        [StringValue("internationalShortened")]
        INTERNATIONAL_SHORTENED
    }
}

