
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
public class ErrorSyntaxCompany
{
    [JsonPropertyName("group")]
    public ErrorSyntaxCompanyGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public ErrorSyntaxCompanyType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public ErrorSyntaxCompanySubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public ErrorSyntaxCompanySeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public ErrorSyntaxCompanyDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxCompanyGroup>))]
    public enum ErrorSyntaxCompanyGroup
    {
        [StringValue("SYNTAX")]
        SYNTAX
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxCompanyType>))]
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
    public enum ErrorSyntaxCompanySubtype
    {
        [StringValue("LEGAL_FORM")]
        LEGAL_FORM
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<ErrorSyntaxCompanySeverity>))]
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
    public enum ErrorSyntaxCompanyDescription
    {
        [StringValue("Value contains duplicated legal form.")]
        VALUE_CONTAINS_DUPLICATED_LEGAL_FORM_,
        [StringValue("Company name is missing the legal form.")]
        COMPANY_NAME_IS_MISSING_THE_LEGAL_FORM_
    }
}

