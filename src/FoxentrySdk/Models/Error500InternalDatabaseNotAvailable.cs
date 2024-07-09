
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
public class Error500InternalDatabaseNotAvailable
{
    [JsonPropertyName("group")]
    [Newtonsoft.Json.JsonProperty("group")]
    public Error500InternalDatabaseNotAvailableGroup? Group { get; set; }
    [JsonPropertyName("type")]
    [Newtonsoft.Json.JsonProperty("type")]
    public Error500InternalDatabaseNotAvailableType? Type { get; set; }
    [JsonPropertyName("subtype")]
    [Newtonsoft.Json.JsonProperty("subtype")]
    public Error500InternalDatabaseNotAvailableSubtype? Subtype { get; set; }
    [JsonPropertyName("severity")]
    [Newtonsoft.Json.JsonProperty("severity")]
    public string? Severity { get; set; }
    [JsonPropertyName("relatedTo")]
    [Newtonsoft.Json.JsonProperty("relatedTo")]
    public IEnumerable<string?>? RelatedTo { get; set; }
    [JsonPropertyName("description")]
    [Newtonsoft.Json.JsonProperty("description")]
    public Error500InternalDatabaseNotAvailableDescription? Description { get; set; }
    /**
     * Group of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalDatabaseNotAvailableGroup>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Error500InternalDatabaseNotAvailableGroup
    {
        [StringValue("INTERNAL")]
        INTERNAL
    }
    /**
     * Type of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalDatabaseNotAvailableType>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Error500InternalDatabaseNotAvailableType
    {
        [StringValue("DATABASE")]
        DATABASE
    }
    /**
     * Subtype of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalDatabaseNotAvailableSubtype>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Error500InternalDatabaseNotAvailableSubtype
    {
        [StringValue("NOT_AVAILABLE")]
        NOT_AVAILABLE
    }
    /**
     * Description of error.
     */
    [JsonConverter(typeof(StringValueEnumConverter<Error500InternalDatabaseNotAvailableDescription>))]
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Error500InternalDatabaseNotAvailableDescription
    {
        [StringValue("Internal datastore is not available at the moment. No operation on this datastore is possible.")]
        INTERNAL_DATASTORE_IS_NOT_AVAILABLE_AT_THE_MOMENT_NO_OPERATION_ON_THIS_DATASTORE_IS_POSSIBLE_
    }
}

