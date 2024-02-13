
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
public class Error500InternalDatabaseConnection
{
    [JsonPropertyName("group")]
    public Error500InternalDatabaseConnectionGroup? Group { get; set; }
    [JsonPropertyName("type")]
    public Error500InternalDatabaseConnectionType? Type { get; set; }
    [JsonPropertyName("subtype")]
    public Error500InternalDatabaseConnectionSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    public Error500InternalDatabaseConnectionDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalDatabaseConnectionGroup>))]
    public enum Error500InternalDatabaseConnectionGroup
    {
        [StringValue("INTERNAL")]
        INTERNAL
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalDatabaseConnectionType>))]
    public enum Error500InternalDatabaseConnectionType
    {
        [StringValue("DATABASE")]
        DATABASE
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalDatabaseConnectionSubtype>))]
    public enum Error500InternalDatabaseConnectionSubtype
    {
        [StringValue("CONNECTION")]
        CONNECTION
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalDatabaseConnectionDescription>))]
    public enum Error500InternalDatabaseConnectionDescription
    {
        [StringValue("Failed to establish connection with the database server. Please contact us if the error persists.")]
        FAILED_TO_ESTABLISH_CONNECTION_WITH_THE_DATABASE_SERVER_PLEASE_CONTACT_US_IF_THE_ERROR_PERSISTS_
    }
}

