
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
public class LocationValidationResponse
{
    [JsonPropertyName("result")]
    [Newtonsoft.Json.JsonProperty("result")]
    public required LocationValidationResponseResult Result { get; init; }
    [JsonPropertyName("resultCorrected")]
    [Newtonsoft.Json.JsonProperty("resultCorrected")]
    public LocationValidationResponseResultCorrected? ResultCorrected { get; set; }
    [JsonPropertyName("suggestions")]
    [Newtonsoft.Json.JsonProperty("suggestions")]
    public IEnumerable<LocationValidationResponseSuggestions?>? Suggestions { get; set; }/**
     * Evaluation of the sent query.
     */
    public class LocationValidationResponseResult
    {
        [JsonPropertyName("isValid")]
        [Newtonsoft.Json.JsonProperty("isValid")]
        public required bool IsValid { get; init; }
        [JsonPropertyName("proposal")]
        [Newtonsoft.Json.JsonProperty("proposal")]
        public required LocationValidationResponseResultProposal Proposal { get; init; }
        [JsonPropertyName("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public required LocationData Data { get; init; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<ILocationValidationResponseResultErrors?>? Errors { get; set; }
        class ILocationValidationResponseResultErrorsConverter : JsonConverter<ILocationValidationResponseResultErrors>
        {
            public override ILocationValidationResponseResultErrors Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(ErrorSyntaxGlobalLocationValidationResponseResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxGlobalLocationValidationResponseResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxGlobalLocationValidationResponseResultErrors");
                }
                if (obj.IsValid(ErrorSyntaxLocationLocationValidationResponseResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxLocationLocationValidationResponseResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxLocationLocationValidationResponseResultErrors");
                }
                if (obj.IsValid(ErrorFormatGlobalLocationValidationResponseResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorFormatGlobalLocationValidationResponseResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorFormatGlobalLocationValidationResponseResultErrors");
                }
                if (obj.IsValid(ErrorValueGlobalLocationValidationResponseResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValueGlobalLocationValidationResponseResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueGlobalLocationValidationResponseResultErrors");
                }
                throw new JsonException("Unable to parse JSON to ILocationValidationResponseResultErrors");
            }
            public override void Write(Utf8JsonWriter writer, ILocationValidationResponseResultErrors value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(ILocationValidationResponseResultErrorsConverter))]
        public interface ILocationValidationResponseResultErrors
        { }
        public static readonly JSchema ErrorSyntaxGlobalLocationValidationResponseResultErrorsJsonSchema = typeof(ErrorSyntaxGlobalLocationValidationResponseResultErrors).GetJsonSchema();
        public class ErrorSyntaxGlobalLocationValidationResponseResultErrors : ErrorSyntaxGlobal, ILocationValidationResponseResultErrors
        {

        }
        public static readonly JSchema ErrorSyntaxLocationLocationValidationResponseResultErrorsJsonSchema = typeof(ErrorSyntaxLocationLocationValidationResponseResultErrors).GetJsonSchema();
        public class ErrorSyntaxLocationLocationValidationResponseResultErrors : ErrorSyntaxLocation, ILocationValidationResponseResultErrors
        {

        }
        public static readonly JSchema ErrorFormatGlobalLocationValidationResponseResultErrorsJsonSchema = typeof(ErrorFormatGlobalLocationValidationResponseResultErrors).GetJsonSchema();
        public class ErrorFormatGlobalLocationValidationResponseResultErrors : ErrorFormatGlobal, ILocationValidationResponseResultErrors
        {

        }
        public static readonly JSchema ErrorValueGlobalLocationValidationResponseResultErrorsJsonSchema = typeof(ErrorValueGlobalLocationValidationResponseResultErrors).GetJsonSchema();
        public class ErrorValueGlobalLocationValidationResponseResultErrors : ErrorValueGlobal, ILocationValidationResponseResultErrors
        {

        }
        /**
         * Proposed solution by Foxentry how you should process the response in your form or application.
         */
        [JsonConverter(typeof(StringValueEnumConverter<LocationValidationResponseResultProposal>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum LocationValidationResponseResultProposal
        {
            [StringValue("valid")]
            VALID,
            [StringValue("validWithSuggestion")]
            VALID_WITH_SUGGESTION,
            [StringValue("invalid")]
            INVALID,
            [StringValue("invalidWithCorrection")]
            INVALID_WITH_CORRECTION,
            [StringValue("invalidWithPartialCorrection")]
            INVALID_WITH_PARTIAL_CORRECTION,
            [StringValue("invalidWithSuggestion")]
            INVALID_WITH_SUGGESTION,
            [StringValue("invalidWithCorrectionWithSuggestion")]
            INVALID_WITH_CORRECTION_WITH_SUGGESTION,

        }
    }
    /**
     * Corrected version of the sent query.
     */
    public class LocationValidationResponseResultCorrected
    {
        [JsonPropertyName("isValid")]
        [Newtonsoft.Json.JsonProperty("isValid")]
        public required bool IsValid { get; init; }
        [JsonPropertyName("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public required LocationData Data { get; init; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<ILocationValidationResponseResultCorrectedErrors?>? Errors { get; set; }
        [JsonPropertyName("fixes")]
        [Newtonsoft.Json.JsonProperty("fixes")]
        public IEnumerable<ILocationValidationResponseResultCorrectedFixes?>? Fixes { get; set; }
        class ILocationValidationResponseResultCorrectedErrorsConverter : JsonConverter<ILocationValidationResponseResultCorrectedErrors>
        {
            public override ILocationValidationResponseResultCorrectedErrors Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(ErrorSyntaxGlobalLocationValidationResponseResultCorrectedErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxGlobalLocationValidationResponseResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxGlobalLocationValidationResponseResultCorrectedErrors");
                }
                if (obj.IsValid(ErrorSyntaxLocationLocationValidationResponseResultCorrectedErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxLocationLocationValidationResponseResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxLocationLocationValidationResponseResultCorrectedErrors");
                }
                if (obj.IsValid(ErrorFormatGlobalLocationValidationResponseResultCorrectedErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorFormatGlobalLocationValidationResponseResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorFormatGlobalLocationValidationResponseResultCorrectedErrors");
                }
                if (obj.IsValid(ErrorValueGlobalLocationValidationResponseResultCorrectedErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValueGlobalLocationValidationResponseResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueGlobalLocationValidationResponseResultCorrectedErrors");
                }
                throw new JsonException("Unable to parse JSON to ILocationValidationResponseResultCorrectedErrors");
            }
            public override void Write(Utf8JsonWriter writer, ILocationValidationResponseResultCorrectedErrors value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(ILocationValidationResponseResultCorrectedErrorsConverter))]
        public interface ILocationValidationResponseResultCorrectedErrors
        { }
        public static readonly JSchema ErrorSyntaxGlobalLocationValidationResponseResultCorrectedErrorsJsonSchema = typeof(ErrorSyntaxGlobalLocationValidationResponseResultCorrectedErrors).GetJsonSchema();
        public class ErrorSyntaxGlobalLocationValidationResponseResultCorrectedErrors : ErrorSyntaxGlobal, ILocationValidationResponseResultCorrectedErrors
        {

        }
        public static readonly JSchema ErrorSyntaxLocationLocationValidationResponseResultCorrectedErrorsJsonSchema = typeof(ErrorSyntaxLocationLocationValidationResponseResultCorrectedErrors).GetJsonSchema();
        public class ErrorSyntaxLocationLocationValidationResponseResultCorrectedErrors : ErrorSyntaxLocation, ILocationValidationResponseResultCorrectedErrors
        {

        }
        public static readonly JSchema ErrorFormatGlobalLocationValidationResponseResultCorrectedErrorsJsonSchema = typeof(ErrorFormatGlobalLocationValidationResponseResultCorrectedErrors).GetJsonSchema();
        public class ErrorFormatGlobalLocationValidationResponseResultCorrectedErrors : ErrorFormatGlobal, ILocationValidationResponseResultCorrectedErrors
        {

        }
        public static readonly JSchema ErrorValueGlobalLocationValidationResponseResultCorrectedErrorsJsonSchema = typeof(ErrorValueGlobalLocationValidationResponseResultCorrectedErrors).GetJsonSchema();
        public class ErrorValueGlobalLocationValidationResponseResultCorrectedErrors : ErrorValueGlobal, ILocationValidationResponseResultCorrectedErrors
        {

        }
        class ILocationValidationResponseResultCorrectedFixesConverter : JsonConverter<ILocationValidationResponseResultCorrectedFixes>
        {
            public override ILocationValidationResponseResultCorrectedFixes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(FixFormatGlobalLocationValidationResponseResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixFormatGlobalLocationValidationResponseResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixFormatGlobalLocationValidationResponseResultCorrectedFixes");
                }
                if (obj.IsValid(FixSyntaxGlobalLocationValidationResponseResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixSyntaxGlobalLocationValidationResponseResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxGlobalLocationValidationResponseResultCorrectedFixes");
                }
                if (obj.IsValid(FixSyntaxLocationLocationValidationResponseResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixSyntaxLocationLocationValidationResponseResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxLocationLocationValidationResponseResultCorrectedFixes");
                }
                if (obj.IsValid(FixValueGlobalLocationValidationResponseResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixValueGlobalLocationValidationResponseResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixValueGlobalLocationValidationResponseResultCorrectedFixes");
                }
                if (obj.IsValid(FixValueLocationLocationValidationResponseResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixValueLocationLocationValidationResponseResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixValueLocationLocationValidationResponseResultCorrectedFixes");
                }
                throw new JsonException("Unable to parse JSON to ILocationValidationResponseResultCorrectedFixes");
            }
            public override void Write(Utf8JsonWriter writer, ILocationValidationResponseResultCorrectedFixes value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(ILocationValidationResponseResultCorrectedFixesConverter))]
        public interface ILocationValidationResponseResultCorrectedFixes
        { }
        public static readonly JSchema FixFormatGlobalLocationValidationResponseResultCorrectedFixesJsonSchema = typeof(FixFormatGlobalLocationValidationResponseResultCorrectedFixes).GetJsonSchema();
        public class FixFormatGlobalLocationValidationResponseResultCorrectedFixes : FixFormatGlobal, ILocationValidationResponseResultCorrectedFixes
        {

        }
        public static readonly JSchema FixSyntaxGlobalLocationValidationResponseResultCorrectedFixesJsonSchema = typeof(FixSyntaxGlobalLocationValidationResponseResultCorrectedFixes).GetJsonSchema();
        public class FixSyntaxGlobalLocationValidationResponseResultCorrectedFixes : FixSyntaxGlobal, ILocationValidationResponseResultCorrectedFixes
        {

        }
        public static readonly JSchema FixSyntaxLocationLocationValidationResponseResultCorrectedFixesJsonSchema = typeof(FixSyntaxLocationLocationValidationResponseResultCorrectedFixes).GetJsonSchema();
        public class FixSyntaxLocationLocationValidationResponseResultCorrectedFixes : FixSyntaxLocation, ILocationValidationResponseResultCorrectedFixes
        {

        }
        public static readonly JSchema FixValueGlobalLocationValidationResponseResultCorrectedFixesJsonSchema = typeof(FixValueGlobalLocationValidationResponseResultCorrectedFixes).GetJsonSchema();
        public class FixValueGlobalLocationValidationResponseResultCorrectedFixes : FixValueGlobal, ILocationValidationResponseResultCorrectedFixes
        {

        }
        public static readonly JSchema FixValueLocationLocationValidationResponseResultCorrectedFixesJsonSchema = typeof(FixValueLocationLocationValidationResponseResultCorrectedFixes).GetJsonSchema();
        public class FixValueLocationLocationValidationResponseResultCorrectedFixes : FixValueLocation, ILocationValidationResponseResultCorrectedFixes
        {

        }
    }
    public class LocationValidationResponseSuggestions
    {
        [JsonPropertyName("isValid")]
        [Newtonsoft.Json.JsonProperty("isValid")]
        public bool? IsValid { get; set; }
        [JsonPropertyName("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public required LocationData Data { get; init; }
        [JsonPropertyName("fixes")]
        [Newtonsoft.Json.JsonProperty("fixes")]
        public IEnumerable<ILocationValidationResponseSuggestionsFixes?>? Fixes { get; set; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<ILocationValidationResponseSuggestionsErrors?>? Errors { get; set; }
        class ILocationValidationResponseSuggestionsFixesConverter : JsonConverter<ILocationValidationResponseSuggestionsFixes>
        {
            public override ILocationValidationResponseSuggestionsFixes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(FixFormatGlobalLocationValidationResponseSuggestionsFixesJsonSchema))
                {
                    return obj.ToObject<FixFormatGlobalLocationValidationResponseSuggestionsFixes>() ?? throw new JsonException("Unable to parse JSON to FixFormatGlobalLocationValidationResponseSuggestionsFixes");
                }
                if (obj.IsValid(FixSyntaxGlobalLocationValidationResponseSuggestionsFixesJsonSchema))
                {
                    return obj.ToObject<FixSyntaxGlobalLocationValidationResponseSuggestionsFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxGlobalLocationValidationResponseSuggestionsFixes");
                }
                if (obj.IsValid(FixSyntaxLocationLocationValidationResponseSuggestionsFixesJsonSchema))
                {
                    return obj.ToObject<FixSyntaxLocationLocationValidationResponseSuggestionsFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxLocationLocationValidationResponseSuggestionsFixes");
                }
                if (obj.IsValid(FixValueGlobalLocationValidationResponseSuggestionsFixesJsonSchema))
                {
                    return obj.ToObject<FixValueGlobalLocationValidationResponseSuggestionsFixes>() ?? throw new JsonException("Unable to parse JSON to FixValueGlobalLocationValidationResponseSuggestionsFixes");
                }
                if (obj.IsValid(FixValueLocationLocationValidationResponseSuggestionsFixesJsonSchema))
                {
                    return obj.ToObject<FixValueLocationLocationValidationResponseSuggestionsFixes>() ?? throw new JsonException("Unable to parse JSON to FixValueLocationLocationValidationResponseSuggestionsFixes");
                }
                throw new JsonException("Unable to parse JSON to ILocationValidationResponseSuggestionsFixes");
            }
            public override void Write(Utf8JsonWriter writer, ILocationValidationResponseSuggestionsFixes value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(ILocationValidationResponseSuggestionsFixesConverter))]
        public interface ILocationValidationResponseSuggestionsFixes
        { }
        public static readonly JSchema FixFormatGlobalLocationValidationResponseSuggestionsFixesJsonSchema = typeof(FixFormatGlobalLocationValidationResponseSuggestionsFixes).GetJsonSchema();
        public class FixFormatGlobalLocationValidationResponseSuggestionsFixes : FixFormatGlobal, ILocationValidationResponseSuggestionsFixes
        {

        }
        public static readonly JSchema FixSyntaxGlobalLocationValidationResponseSuggestionsFixesJsonSchema = typeof(FixSyntaxGlobalLocationValidationResponseSuggestionsFixes).GetJsonSchema();
        public class FixSyntaxGlobalLocationValidationResponseSuggestionsFixes : FixSyntaxGlobal, ILocationValidationResponseSuggestionsFixes
        {

        }
        public static readonly JSchema FixSyntaxLocationLocationValidationResponseSuggestionsFixesJsonSchema = typeof(FixSyntaxLocationLocationValidationResponseSuggestionsFixes).GetJsonSchema();
        public class FixSyntaxLocationLocationValidationResponseSuggestionsFixes : FixSyntaxLocation, ILocationValidationResponseSuggestionsFixes
        {

        }
        public static readonly JSchema FixValueGlobalLocationValidationResponseSuggestionsFixesJsonSchema = typeof(FixValueGlobalLocationValidationResponseSuggestionsFixes).GetJsonSchema();
        public class FixValueGlobalLocationValidationResponseSuggestionsFixes : FixValueGlobal, ILocationValidationResponseSuggestionsFixes
        {

        }
        public static readonly JSchema FixValueLocationLocationValidationResponseSuggestionsFixesJsonSchema = typeof(FixValueLocationLocationValidationResponseSuggestionsFixes).GetJsonSchema();
        public class FixValueLocationLocationValidationResponseSuggestionsFixes : FixValueLocation, ILocationValidationResponseSuggestionsFixes
        {

        }
        class ILocationValidationResponseSuggestionsErrorsConverter : JsonConverter<ILocationValidationResponseSuggestionsErrors>
        {
            public override ILocationValidationResponseSuggestionsErrors Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(ErrorSyntaxGlobalLocationValidationResponseSuggestionsErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxGlobalLocationValidationResponseSuggestionsErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxGlobalLocationValidationResponseSuggestionsErrors");
                }
                if (obj.IsValid(ErrorSyntaxLocationLocationValidationResponseSuggestionsErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxLocationLocationValidationResponseSuggestionsErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxLocationLocationValidationResponseSuggestionsErrors");
                }
                if (obj.IsValid(ErrorFormatGlobalLocationValidationResponseSuggestionsErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorFormatGlobalLocationValidationResponseSuggestionsErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorFormatGlobalLocationValidationResponseSuggestionsErrors");
                }
                if (obj.IsValid(ErrorValueGlobalLocationValidationResponseSuggestionsErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValueGlobalLocationValidationResponseSuggestionsErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueGlobalLocationValidationResponseSuggestionsErrors");
                }
                throw new JsonException("Unable to parse JSON to ILocationValidationResponseSuggestionsErrors");
            }
            public override void Write(Utf8JsonWriter writer, ILocationValidationResponseSuggestionsErrors value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(ILocationValidationResponseSuggestionsErrorsConverter))]
        public interface ILocationValidationResponseSuggestionsErrors
        { }
        public static readonly JSchema ErrorSyntaxGlobalLocationValidationResponseSuggestionsErrorsJsonSchema = typeof(ErrorSyntaxGlobalLocationValidationResponseSuggestionsErrors).GetJsonSchema();
        public class ErrorSyntaxGlobalLocationValidationResponseSuggestionsErrors : ErrorSyntaxGlobal, ILocationValidationResponseSuggestionsErrors
        {

        }
        public static readonly JSchema ErrorSyntaxLocationLocationValidationResponseSuggestionsErrorsJsonSchema = typeof(ErrorSyntaxLocationLocationValidationResponseSuggestionsErrors).GetJsonSchema();
        public class ErrorSyntaxLocationLocationValidationResponseSuggestionsErrors : ErrorSyntaxLocation, ILocationValidationResponseSuggestionsErrors
        {

        }
        public static readonly JSchema ErrorFormatGlobalLocationValidationResponseSuggestionsErrorsJsonSchema = typeof(ErrorFormatGlobalLocationValidationResponseSuggestionsErrors).GetJsonSchema();
        public class ErrorFormatGlobalLocationValidationResponseSuggestionsErrors : ErrorFormatGlobal, ILocationValidationResponseSuggestionsErrors
        {

        }
        public static readonly JSchema ErrorValueGlobalLocationValidationResponseSuggestionsErrorsJsonSchema = typeof(ErrorValueGlobalLocationValidationResponseSuggestionsErrors).GetJsonSchema();
        public class ErrorValueGlobalLocationValidationResponseSuggestionsErrors : ErrorValueGlobal, ILocationValidationResponseSuggestionsErrors
        {

        }
    }
}

