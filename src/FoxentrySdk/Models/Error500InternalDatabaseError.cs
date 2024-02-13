
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
public class Error500InternalDatabaseError
{
    [JsonPropertyName("group")]
    public Error500InternalDatabaseErrorGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error500InternalDatabaseErrorType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error500InternalDatabaseErrorSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error500InternalDatabaseErrorDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalDatabaseErrorGroup>))]
    public enum Error500InternalDatabaseErrorGroup
    {
        [StringValue("INTERNAL")]
        INTERNAL
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalDatabaseErrorType>))]
    public enum Error500InternalDatabaseErrorType
    {
        [StringValue("DATABASE")]
        DATABASE
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalDatabaseErrorSubtype>))]
    public enum Error500InternalDatabaseErrorSubtype
    {
        [StringValue("ERROR")]
        ERROR
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalDatabaseErrorDescription>))]
    public enum Error500InternalDatabaseErrorDescription
    {
        [StringValue("An error has occured during the communication with our database. Please contact us if the error persists.")]
        AN_ERROR_HAS_OCCURED_DURING_THE_COMMUNICATION_WITH_OUR_DATABASE_PLEASE_CONTACT_US_IF_THE_ERROR_PERSISTS_
    }
}

