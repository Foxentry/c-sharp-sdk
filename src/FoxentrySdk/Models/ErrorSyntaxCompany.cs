
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
public class ErrorSyntaxCompany
{
    [JsonPropertyName("group")]
    [Newtonsoft.Json.JsonProperty("group")]
    public ErrorSyntaxCompanyGroup? Group { get; set; }
    [JsonPropertyName("type")]
    [Newtonsoft.Json.JsonProperty("type")]
    public ErrorSyntaxCompanyType? Type { get; set; }
    [JsonPropertyName("subtype")]
    [Newtonsoft.Json.JsonProperty("subtype")]
    public ErrorSyntaxCompanySubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    [Newtonsoft.Json.JsonProperty("severity")]
    public ErrorSyntaxCompanySeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    [Newtonsoft.Json.JsonProperty("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    [Newtonsoft.Json.JsonProperty("description")]
    public ErrorSyntaxCompanyDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxCompanyGroup>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ErrorSyntaxCompanyGroup
    {
        [StringValue("SYNTAX")]
        SYNTAX
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxCompanyType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ErrorSyntaxCompanyType
    {
        [StringValue("VALUE_PART_EXTRA")]
        VALUE_PART_EXTRA,
        [StringValue("VALUE_PART_MISSING")]
        VALUE_PART_MISSING
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxCompanySubtype>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ErrorSyntaxCompanySubtype
    {
        [StringValue("LEGAL_FORM")]
        LEGAL_FORM
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxCompanySeverity>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ErrorSyntaxCompanySeverity
    {
        [StringValue("info")]
        INFO,
        [StringValue("warning")]
        WARNING,
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxCompanyDescription>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ErrorSyntaxCompanyDescription
    {
        [StringValue("Value contains duplicated legal form.")]
        VALUE_CONTAINS_DUPLICATED_LEGAL_FORM_,
        [StringValue("Company name is missing the legal form.")]
        COMPANY_NAME_IS_MISSING_THE_LEGAL_FORM_
    }
}

