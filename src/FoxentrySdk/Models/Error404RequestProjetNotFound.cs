
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
public class Error404RequestProjetNotFound
{
    [JsonPropertyName("group")]
    public Error404RequestProjetNotFoundGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error404RequestProjetNotFoundType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error404RequestProjetNotFoundSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public Error404RequestProjetNotFoundSeverity? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error404RequestProjetNotFoundDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404RequestProjetNotFoundGroup>))]
    public enum Error404RequestProjetNotFoundGroup
    {
        [StringValue("REQUEST")]
        REQUEST
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404RequestProjetNotFoundType>))]
    public enum Error404RequestProjetNotFoundType
    {
        [StringValue("PROJECT")]
        PROJECT
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404RequestProjetNotFoundSubtype>))]
    public enum Error404RequestProjetNotFoundSubtype
    {
        [StringValue("NOT_FOUND")]
        NOT_FOUND
    }
    /**
     * Severity of error. <b>Info</b> = cosmetic changes that don't change the overall meaning. <b>Warning</b> = typos and other errors that could affect the meaning. <b>Critical</b> = critical errors.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404RequestProjetNotFoundSeverity>))]
    public enum Error404RequestProjetNotFoundSeverity
    {
        [StringValue("critical")]
        CRITICAL
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error404RequestProjetNotFoundDescription>))]
    public enum Error404RequestProjetNotFoundDescription
    {
        [StringValue("The project does not exist. Please check the available projects at app.foxentry.com or contact the support.")]
        THE_PROJECT_DOES_NOT_EXIST_PLEASE_CHECK_THE_AVAILABLE_PROJECTS_AT_APP_FOXENTRY_COM_OR_CONTACT_THE_SUPPORT_
    }
}

