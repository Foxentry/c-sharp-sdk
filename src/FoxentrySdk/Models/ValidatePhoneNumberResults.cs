
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
public class ValidatePhoneNumberResults
{
    [JsonPropertyName("result")]
    [Newtonsoft.Json.JsonProperty("result")]
    public required ValidatePhoneNumberResultsResult Result { get; init; }
    [JsonPropertyName("resultCorrected")]
    [Newtonsoft.Json.JsonProperty("resultCorrected")]
    public ValidatePhoneNumberResultsResultCorrected? ResultCorrected { get; set; }
    [JsonPropertyName("suggestions")]
    [Newtonsoft.Json.JsonProperty("suggestions")]
    public required IEnumerable<ValidatePhoneNumberResultsSuggestions?> Suggestions { get; init; }/**
     * Evaluation of the sent query.
     */
    public class ValidatePhoneNumberResultsResult
    {
        [JsonPropertyName("isValid")]
        [Newtonsoft.Json.JsonProperty("isValid")]
        public required bool IsValid { get; init; }
        [JsonPropertyName("proposal")]
        [Newtonsoft.Json.JsonProperty("proposal")]
        public required ValidatePhoneNumberResultsResultProposal Proposal { get; init; }
        [JsonPropertyName("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public required ValidatePhoneNumberData Data { get; init; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public required IEnumerable<IValidatePhoneNumberResultsResultErrors?> Errors { get; init; }
        class IValidatePhoneNumberResultsResultErrorsConverter : JsonConverter<IValidatePhoneNumberResultsResultErrors>
        {
            public override IValidatePhoneNumberResultsResultErrors Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(ErrorSyntaxGlobalValidatePhoneNumberResultsResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxGlobalValidatePhoneNumberResultsResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxGlobalValidatePhoneNumberResultsResultErrors");
                }
                if (obj.IsValid(ErrorSyntaxPhoneValidatePhoneNumberResultsResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxPhoneValidatePhoneNumberResultsResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxPhoneValidatePhoneNumberResultsResultErrors");
                }
                if (obj.IsValid(ErrorFormatGlobalValidatePhoneNumberResultsResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorFormatGlobalValidatePhoneNumberResultsResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorFormatGlobalValidatePhoneNumberResultsResultErrors");
                }
                if (obj.IsValid(ErrorValueGlobalValidatePhoneNumberResultsResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValueGlobalValidatePhoneNumberResultsResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueGlobalValidatePhoneNumberResultsResultErrors");
                }
                if (obj.IsValid(ErrorValuePhoneValidatePhoneNumberResultsResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValuePhoneValidatePhoneNumberResultsResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValuePhoneValidatePhoneNumberResultsResultErrors");
                }
                throw new JsonException("Unable to parse JSON to IValidatePhoneNumberResultsResultErrors");
            }
            public override void Write(Utf8JsonWriter writer, IValidatePhoneNumberResultsResultErrors value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(IValidatePhoneNumberResultsResultErrorsConverter))]
        public interface IValidatePhoneNumberResultsResultErrors
        { }
        public static readonly JSchema ErrorSyntaxGlobalValidatePhoneNumberResultsResultErrorsJsonSchema = typeof(ErrorSyntaxGlobalValidatePhoneNumberResultsResultErrors).GetJsonSchema();
        public class ErrorSyntaxGlobalValidatePhoneNumberResultsResultErrors : ErrorSyntaxGlobal, IValidatePhoneNumberResultsResultErrors
        {

        }
        public static readonly JSchema ErrorSyntaxPhoneValidatePhoneNumberResultsResultErrorsJsonSchema = typeof(ErrorSyntaxPhoneValidatePhoneNumberResultsResultErrors).GetJsonSchema();
        public class ErrorSyntaxPhoneValidatePhoneNumberResultsResultErrors : ErrorSyntaxPhone, IValidatePhoneNumberResultsResultErrors
        {

        }
        public static readonly JSchema ErrorFormatGlobalValidatePhoneNumberResultsResultErrorsJsonSchema = typeof(ErrorFormatGlobalValidatePhoneNumberResultsResultErrors).GetJsonSchema();
        public class ErrorFormatGlobalValidatePhoneNumberResultsResultErrors : ErrorFormatGlobal, IValidatePhoneNumberResultsResultErrors
        {

        }
        public static readonly JSchema ErrorValueGlobalValidatePhoneNumberResultsResultErrorsJsonSchema = typeof(ErrorValueGlobalValidatePhoneNumberResultsResultErrors).GetJsonSchema();
        public class ErrorValueGlobalValidatePhoneNumberResultsResultErrors : ErrorValueGlobal, IValidatePhoneNumberResultsResultErrors
        {

        }
        public static readonly JSchema ErrorValuePhoneValidatePhoneNumberResultsResultErrorsJsonSchema = typeof(ErrorValuePhoneValidatePhoneNumberResultsResultErrors).GetJsonSchema();
        public class ErrorValuePhoneValidatePhoneNumberResultsResultErrors : ErrorValuePhone, IValidatePhoneNumberResultsResultErrors
        {

        }
        /**
         * Proposed solution by Foxentry how you should process the response in your form or application.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidatePhoneNumberResultsResultProposal>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ValidatePhoneNumberResultsResultProposal
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
    public class ValidatePhoneNumberResultsResultCorrected
    {
        [JsonPropertyName("isValid")]
        [Newtonsoft.Json.JsonProperty("isValid")]
        public bool? IsValid { get; set; }
        [JsonPropertyName("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public ValidatePhoneNumberData? Data { get; set; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<IValidatePhoneNumberResultsResultCorrectedErrors?>? Errors { get; set; }
        [JsonPropertyName("fixes")]
        [Newtonsoft.Json.JsonProperty("fixes")]
        public IEnumerable<IValidatePhoneNumberResultsResultCorrectedFixes?>? Fixes { get; set; }
        class IValidatePhoneNumberResultsResultCorrectedErrorsConverter : JsonConverter<IValidatePhoneNumberResultsResultCorrectedErrors>
        {
            public override IValidatePhoneNumberResultsResultCorrectedErrors Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(ErrorSyntaxGlobalValidatePhoneNumberResultsResultCorrectedErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxGlobalValidatePhoneNumberResultsResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxGlobalValidatePhoneNumberResultsResultCorrectedErrors");
                }
                if (obj.IsValid(ErrorSyntaxPhoneValidatePhoneNumberResultsResultCorrectedErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxPhoneValidatePhoneNumberResultsResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxPhoneValidatePhoneNumberResultsResultCorrectedErrors");
                }
                if (obj.IsValid(ErrorFormatGlobalValidatePhoneNumberResultsResultCorrectedErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorFormatGlobalValidatePhoneNumberResultsResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorFormatGlobalValidatePhoneNumberResultsResultCorrectedErrors");
                }
                if (obj.IsValid(ErrorValueGlobalValidatePhoneNumberResultsResultCorrectedErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValueGlobalValidatePhoneNumberResultsResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueGlobalValidatePhoneNumberResultsResultCorrectedErrors");
                }
                if (obj.IsValid(ErrorValuePhoneValidatePhoneNumberResultsResultCorrectedErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValuePhoneValidatePhoneNumberResultsResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValuePhoneValidatePhoneNumberResultsResultCorrectedErrors");
                }
                throw new JsonException("Unable to parse JSON to IValidatePhoneNumberResultsResultCorrectedErrors");
            }
            public override void Write(Utf8JsonWriter writer, IValidatePhoneNumberResultsResultCorrectedErrors value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(IValidatePhoneNumberResultsResultCorrectedErrorsConverter))]
        public interface IValidatePhoneNumberResultsResultCorrectedErrors
        { }
        public static readonly JSchema ErrorSyntaxGlobalValidatePhoneNumberResultsResultCorrectedErrorsJsonSchema = typeof(ErrorSyntaxGlobalValidatePhoneNumberResultsResultCorrectedErrors).GetJsonSchema();
        public class ErrorSyntaxGlobalValidatePhoneNumberResultsResultCorrectedErrors : ErrorSyntaxGlobal, IValidatePhoneNumberResultsResultCorrectedErrors
        {

        }
        public static readonly JSchema ErrorSyntaxPhoneValidatePhoneNumberResultsResultCorrectedErrorsJsonSchema = typeof(ErrorSyntaxPhoneValidatePhoneNumberResultsResultCorrectedErrors).GetJsonSchema();
        public class ErrorSyntaxPhoneValidatePhoneNumberResultsResultCorrectedErrors : ErrorSyntaxPhone, IValidatePhoneNumberResultsResultCorrectedErrors
        {

        }
        public static readonly JSchema ErrorFormatGlobalValidatePhoneNumberResultsResultCorrectedErrorsJsonSchema = typeof(ErrorFormatGlobalValidatePhoneNumberResultsResultCorrectedErrors).GetJsonSchema();
        public class ErrorFormatGlobalValidatePhoneNumberResultsResultCorrectedErrors : ErrorFormatGlobal, IValidatePhoneNumberResultsResultCorrectedErrors
        {

        }
        public static readonly JSchema ErrorValueGlobalValidatePhoneNumberResultsResultCorrectedErrorsJsonSchema = typeof(ErrorValueGlobalValidatePhoneNumberResultsResultCorrectedErrors).GetJsonSchema();
        public class ErrorValueGlobalValidatePhoneNumberResultsResultCorrectedErrors : ErrorValueGlobal, IValidatePhoneNumberResultsResultCorrectedErrors
        {

        }
        public static readonly JSchema ErrorValuePhoneValidatePhoneNumberResultsResultCorrectedErrorsJsonSchema = typeof(ErrorValuePhoneValidatePhoneNumberResultsResultCorrectedErrors).GetJsonSchema();
        public class ErrorValuePhoneValidatePhoneNumberResultsResultCorrectedErrors : ErrorValuePhone, IValidatePhoneNumberResultsResultCorrectedErrors
        {

        }
        class IValidatePhoneNumberResultsResultCorrectedFixesConverter : JsonConverter<IValidatePhoneNumberResultsResultCorrectedFixes>
        {
            public override IValidatePhoneNumberResultsResultCorrectedFixes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(FixFormatGlobalValidatePhoneNumberResultsResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixFormatGlobalValidatePhoneNumberResultsResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixFormatGlobalValidatePhoneNumberResultsResultCorrectedFixes");
                }
                if (obj.IsValid(FixSyntaxGlobalValidatePhoneNumberResultsResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixSyntaxGlobalValidatePhoneNumberResultsResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxGlobalValidatePhoneNumberResultsResultCorrectedFixes");
                }
                if (obj.IsValid(FixSyntaxPhoneValidatePhoneNumberResultsResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixSyntaxPhoneValidatePhoneNumberResultsResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxPhoneValidatePhoneNumberResultsResultCorrectedFixes");
                }
                if (obj.IsValid(FixValueGlobalValidatePhoneNumberResultsResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixValueGlobalValidatePhoneNumberResultsResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixValueGlobalValidatePhoneNumberResultsResultCorrectedFixes");
                }
                throw new JsonException("Unable to parse JSON to IValidatePhoneNumberResultsResultCorrectedFixes");
            }
            public override void Write(Utf8JsonWriter writer, IValidatePhoneNumberResultsResultCorrectedFixes value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(IValidatePhoneNumberResultsResultCorrectedFixesConverter))]
        public interface IValidatePhoneNumberResultsResultCorrectedFixes
        { }
        public static readonly JSchema FixFormatGlobalValidatePhoneNumberResultsResultCorrectedFixesJsonSchema = typeof(FixFormatGlobalValidatePhoneNumberResultsResultCorrectedFixes).GetJsonSchema();
        public class FixFormatGlobalValidatePhoneNumberResultsResultCorrectedFixes : FixFormatGlobal, IValidatePhoneNumberResultsResultCorrectedFixes
        {

        }
        public static readonly JSchema FixSyntaxGlobalValidatePhoneNumberResultsResultCorrectedFixesJsonSchema = typeof(FixSyntaxGlobalValidatePhoneNumberResultsResultCorrectedFixes).GetJsonSchema();
        public class FixSyntaxGlobalValidatePhoneNumberResultsResultCorrectedFixes : FixSyntaxGlobal, IValidatePhoneNumberResultsResultCorrectedFixes
        {

        }
        public static readonly JSchema FixSyntaxPhoneValidatePhoneNumberResultsResultCorrectedFixesJsonSchema = typeof(FixSyntaxPhoneValidatePhoneNumberResultsResultCorrectedFixes).GetJsonSchema();
        public class FixSyntaxPhoneValidatePhoneNumberResultsResultCorrectedFixes : FixSyntaxPhone, IValidatePhoneNumberResultsResultCorrectedFixes
        {

        }
        public static readonly JSchema FixValueGlobalValidatePhoneNumberResultsResultCorrectedFixesJsonSchema = typeof(FixValueGlobalValidatePhoneNumberResultsResultCorrectedFixes).GetJsonSchema();
        public class FixValueGlobalValidatePhoneNumberResultsResultCorrectedFixes : FixValueGlobal, IValidatePhoneNumberResultsResultCorrectedFixes
        {

        }
    }
    public class ValidatePhoneNumberResultsSuggestions
    {
        [JsonPropertyName("isValid")]
        [Newtonsoft.Json.JsonProperty("isValid")]
        public bool? IsValid { get; set; }
        [JsonPropertyName("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public ValidatePhoneNumberData? Data { get; set; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<IValidatePhoneNumberResultsSuggestionsErrors?>? Errors { get; set; }
        [JsonPropertyName("fixes")]
        [Newtonsoft.Json.JsonProperty("fixes")]
        public IEnumerable<IValidatePhoneNumberResultsSuggestionsFixes?>? Fixes { get; set; }
        class IValidatePhoneNumberResultsSuggestionsErrorsConverter : JsonConverter<IValidatePhoneNumberResultsSuggestionsErrors>
        {
            public override IValidatePhoneNumberResultsSuggestionsErrors Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(ErrorSyntaxGlobalValidatePhoneNumberResultsSuggestionsErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxGlobalValidatePhoneNumberResultsSuggestionsErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxGlobalValidatePhoneNumberResultsSuggestionsErrors");
                }
                if (obj.IsValid(ErrorSyntaxPhoneValidatePhoneNumberResultsSuggestionsErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxPhoneValidatePhoneNumberResultsSuggestionsErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxPhoneValidatePhoneNumberResultsSuggestionsErrors");
                }
                if (obj.IsValid(ErrorFormatGlobalValidatePhoneNumberResultsSuggestionsErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorFormatGlobalValidatePhoneNumberResultsSuggestionsErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorFormatGlobalValidatePhoneNumberResultsSuggestionsErrors");
                }
                if (obj.IsValid(ErrorValueGlobalValidatePhoneNumberResultsSuggestionsErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValueGlobalValidatePhoneNumberResultsSuggestionsErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueGlobalValidatePhoneNumberResultsSuggestionsErrors");
                }
                if (obj.IsValid(ErrorValuePhoneValidatePhoneNumberResultsSuggestionsErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValuePhoneValidatePhoneNumberResultsSuggestionsErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValuePhoneValidatePhoneNumberResultsSuggestionsErrors");
                }
                throw new JsonException("Unable to parse JSON to IValidatePhoneNumberResultsSuggestionsErrors");
            }
            public override void Write(Utf8JsonWriter writer, IValidatePhoneNumberResultsSuggestionsErrors value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(IValidatePhoneNumberResultsSuggestionsErrorsConverter))]
        public interface IValidatePhoneNumberResultsSuggestionsErrors
        { }
        public static readonly JSchema ErrorSyntaxGlobalValidatePhoneNumberResultsSuggestionsErrorsJsonSchema = typeof(ErrorSyntaxGlobalValidatePhoneNumberResultsSuggestionsErrors).GetJsonSchema();
        public class ErrorSyntaxGlobalValidatePhoneNumberResultsSuggestionsErrors : ErrorSyntaxGlobal, IValidatePhoneNumberResultsSuggestionsErrors
        {

        }
        public static readonly JSchema ErrorSyntaxPhoneValidatePhoneNumberResultsSuggestionsErrorsJsonSchema = typeof(ErrorSyntaxPhoneValidatePhoneNumberResultsSuggestionsErrors).GetJsonSchema();
        public class ErrorSyntaxPhoneValidatePhoneNumberResultsSuggestionsErrors : ErrorSyntaxPhone, IValidatePhoneNumberResultsSuggestionsErrors
        {

        }
        public static readonly JSchema ErrorFormatGlobalValidatePhoneNumberResultsSuggestionsErrorsJsonSchema = typeof(ErrorFormatGlobalValidatePhoneNumberResultsSuggestionsErrors).GetJsonSchema();
        public class ErrorFormatGlobalValidatePhoneNumberResultsSuggestionsErrors : ErrorFormatGlobal, IValidatePhoneNumberResultsSuggestionsErrors
        {

        }
        public static readonly JSchema ErrorValueGlobalValidatePhoneNumberResultsSuggestionsErrorsJsonSchema = typeof(ErrorValueGlobalValidatePhoneNumberResultsSuggestionsErrors).GetJsonSchema();
        public class ErrorValueGlobalValidatePhoneNumberResultsSuggestionsErrors : ErrorValueGlobal, IValidatePhoneNumberResultsSuggestionsErrors
        {

        }
        public static readonly JSchema ErrorValuePhoneValidatePhoneNumberResultsSuggestionsErrorsJsonSchema = typeof(ErrorValuePhoneValidatePhoneNumberResultsSuggestionsErrors).GetJsonSchema();
        public class ErrorValuePhoneValidatePhoneNumberResultsSuggestionsErrors : ErrorValuePhone, IValidatePhoneNumberResultsSuggestionsErrors
        {

        }
        class IValidatePhoneNumberResultsSuggestionsFixesConverter : JsonConverter<IValidatePhoneNumberResultsSuggestionsFixes>
        {
            public override IValidatePhoneNumberResultsSuggestionsFixes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(FixFormatGlobalValidatePhoneNumberResultsSuggestionsFixesJsonSchema))
                {
                    return obj.ToObject<FixFormatGlobalValidatePhoneNumberResultsSuggestionsFixes>() ?? throw new JsonException("Unable to parse JSON to FixFormatGlobalValidatePhoneNumberResultsSuggestionsFixes");
                }
                if (obj.IsValid(FixSyntaxGlobalValidatePhoneNumberResultsSuggestionsFixesJsonSchema))
                {
                    return obj.ToObject<FixSyntaxGlobalValidatePhoneNumberResultsSuggestionsFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxGlobalValidatePhoneNumberResultsSuggestionsFixes");
                }
                if (obj.IsValid(FixSyntaxPhoneValidatePhoneNumberResultsSuggestionsFixesJsonSchema))
                {
                    return obj.ToObject<FixSyntaxPhoneValidatePhoneNumberResultsSuggestionsFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxPhoneValidatePhoneNumberResultsSuggestionsFixes");
                }
                if (obj.IsValid(FixValueGlobalValidatePhoneNumberResultsSuggestionsFixesJsonSchema))
                {
                    return obj.ToObject<FixValueGlobalValidatePhoneNumberResultsSuggestionsFixes>() ?? throw new JsonException("Unable to parse JSON to FixValueGlobalValidatePhoneNumberResultsSuggestionsFixes");
                }
                throw new JsonException("Unable to parse JSON to IValidatePhoneNumberResultsSuggestionsFixes");
            }
            public override void Write(Utf8JsonWriter writer, IValidatePhoneNumberResultsSuggestionsFixes value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(IValidatePhoneNumberResultsSuggestionsFixesConverter))]
        public interface IValidatePhoneNumberResultsSuggestionsFixes
        { }
        public static readonly JSchema FixFormatGlobalValidatePhoneNumberResultsSuggestionsFixesJsonSchema = typeof(FixFormatGlobalValidatePhoneNumberResultsSuggestionsFixes).GetJsonSchema();
        public class FixFormatGlobalValidatePhoneNumberResultsSuggestionsFixes : FixFormatGlobal, IValidatePhoneNumberResultsSuggestionsFixes
        {

        }
        public static readonly JSchema FixSyntaxGlobalValidatePhoneNumberResultsSuggestionsFixesJsonSchema = typeof(FixSyntaxGlobalValidatePhoneNumberResultsSuggestionsFixes).GetJsonSchema();
        public class FixSyntaxGlobalValidatePhoneNumberResultsSuggestionsFixes : FixSyntaxGlobal, IValidatePhoneNumberResultsSuggestionsFixes
        {

        }
        public static readonly JSchema FixSyntaxPhoneValidatePhoneNumberResultsSuggestionsFixesJsonSchema = typeof(FixSyntaxPhoneValidatePhoneNumberResultsSuggestionsFixes).GetJsonSchema();
        public class FixSyntaxPhoneValidatePhoneNumberResultsSuggestionsFixes : FixSyntaxPhone, IValidatePhoneNumberResultsSuggestionsFixes
        {

        }
        public static readonly JSchema FixValueGlobalValidatePhoneNumberResultsSuggestionsFixesJsonSchema = typeof(FixValueGlobalValidatePhoneNumberResultsSuggestionsFixes).GetJsonSchema();
        public class FixValueGlobalValidatePhoneNumberResultsSuggestionsFixes : FixValueGlobal, IValidatePhoneNumberResultsSuggestionsFixes
        {

        }
    }
}

