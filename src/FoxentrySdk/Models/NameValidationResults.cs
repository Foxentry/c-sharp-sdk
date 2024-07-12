
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
public class NameValidationResults
{
    [JsonPropertyName("result")]
    [Newtonsoft.Json.JsonProperty("result")]
    public required NameValidationResultsResult Result { get; init; }
    [JsonPropertyName("resultCorrected")]
    [Newtonsoft.Json.JsonProperty("resultCorrected")]
    public NameValidationResultsResultCorrected? ResultCorrected { get; set; }
    [JsonPropertyName("suggestions")]
    [Newtonsoft.Json.JsonProperty("suggestions")]
    public required IEnumerable<NameValidationResultsSuggestions?> Suggestions { get; init; }/**
     * Evaluation of the sent query.
     */
    public class NameValidationResultsResult
    {
        [JsonPropertyName("isValid")]
        [Newtonsoft.Json.JsonProperty("isValid")]
        public required bool IsValid { get; init; }
        [JsonPropertyName("proposal")]
        [Newtonsoft.Json.JsonProperty("proposal")]
        public required NameValidationResultsResultProposal Proposal { get; init; }
        [JsonPropertyName("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public required NameValidationResultsData Data { get; init; }
        [JsonPropertyName("details")]
        [Newtonsoft.Json.JsonProperty("details")]
        public NameValidationResultsDetails? Details { get; set; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<INameValidationResultsResultErrors?>? Errors { get; set; }
        class INameValidationResultsResultErrorsConverter : JsonConverter<INameValidationResultsResultErrors>
        {
            public override INameValidationResultsResultErrors Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(ErrorSyntaxGlobalNameValidationResultsResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxGlobalNameValidationResultsResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxGlobalNameValidationResultsResultErrors");
                }
                if (obj.IsValid(ErrorSyntaxNameNameValidationResultsResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxNameNameValidationResultsResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxNameNameValidationResultsResultErrors");
                }
                if (obj.IsValid(ErrorFormatGlobalNameValidationResultsResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorFormatGlobalNameValidationResultsResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorFormatGlobalNameValidationResultsResultErrors");
                }
                if (obj.IsValid(ErrorValueGlobalNameValidationResultsResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValueGlobalNameValidationResultsResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueGlobalNameValidationResultsResultErrors");
                }
                if (obj.IsValid(ErrorValueNameNameValidationResultsResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValueNameNameValidationResultsResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueNameNameValidationResultsResultErrors");
                }
                throw new JsonException("Unable to parse JSON to INameValidationResultsResultErrors");
            }
            public override void Write(Utf8JsonWriter writer, INameValidationResultsResultErrors value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(INameValidationResultsResultErrorsConverter))]
        public interface INameValidationResultsResultErrors
        { }
        public static readonly JSchema ErrorSyntaxGlobalNameValidationResultsResultErrorsJsonSchema = typeof(ErrorSyntaxGlobalNameValidationResultsResultErrors).GetJsonSchema();
        public class ErrorSyntaxGlobalNameValidationResultsResultErrors : ErrorSyntaxGlobal, INameValidationResultsResultErrors
        {

        }
        public static readonly JSchema ErrorSyntaxNameNameValidationResultsResultErrorsJsonSchema = typeof(ErrorSyntaxNameNameValidationResultsResultErrors).GetJsonSchema();
        public class ErrorSyntaxNameNameValidationResultsResultErrors : ErrorSyntaxName, INameValidationResultsResultErrors
        {

        }
        public static readonly JSchema ErrorFormatGlobalNameValidationResultsResultErrorsJsonSchema = typeof(ErrorFormatGlobalNameValidationResultsResultErrors).GetJsonSchema();
        public class ErrorFormatGlobalNameValidationResultsResultErrors : ErrorFormatGlobal, INameValidationResultsResultErrors
        {

        }
        public static readonly JSchema ErrorValueGlobalNameValidationResultsResultErrorsJsonSchema = typeof(ErrorValueGlobalNameValidationResultsResultErrors).GetJsonSchema();
        public class ErrorValueGlobalNameValidationResultsResultErrors : ErrorValueGlobal, INameValidationResultsResultErrors
        {

        }
        public static readonly JSchema ErrorValueNameNameValidationResultsResultErrorsJsonSchema = typeof(ErrorValueNameNameValidationResultsResultErrors).GetJsonSchema();
        public class ErrorValueNameNameValidationResultsResultErrors : ErrorValueName, INameValidationResultsResultErrors
        {

        }
        /**
         * Proposed solution by Foxentry how you should process the response in your form or application.
         */
        [JsonConverter(typeof(StringValueEnumConverter<NameValidationResultsResultProposal>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NameValidationResultsResultProposal
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
            INVALID_WITH_CORRECTION_WITH_SUGGESTION
        }
    }
    /**
     * Corrected version of the sent query.
     */
    public class NameValidationResultsResultCorrected
    {
        [JsonPropertyName("isValid")]
        [Newtonsoft.Json.JsonProperty("isValid")]
        public required bool IsValid { get; init; }
        [JsonPropertyName("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public required NameValidationResultsData Data { get; init; }
        [JsonPropertyName("details")]
        [Newtonsoft.Json.JsonProperty("details")]
        public NameValidationResultsDetails? Details { get; set; }
        [JsonPropertyName("fixes")]
        [Newtonsoft.Json.JsonProperty("fixes")]
        public required IEnumerable<INameValidationResultsResultCorrectedFixes?> Fixes { get; init; }
        class INameValidationResultsResultCorrectedFixesConverter : JsonConverter<INameValidationResultsResultCorrectedFixes>
        {
            public override INameValidationResultsResultCorrectedFixes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(FixFormatGlobalNameValidationResultsResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixFormatGlobalNameValidationResultsResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixFormatGlobalNameValidationResultsResultCorrectedFixes");
                }
                if (obj.IsValid(FixSyntaxGlobalNameValidationResultsResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixSyntaxGlobalNameValidationResultsResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxGlobalNameValidationResultsResultCorrectedFixes");
                }
                if (obj.IsValid(FixValueGlobalNameValidationResultsResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixValueGlobalNameValidationResultsResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixValueGlobalNameValidationResultsResultCorrectedFixes");
                }
                throw new JsonException("Unable to parse JSON to INameValidationResultsResultCorrectedFixes");
            }
            public override void Write(Utf8JsonWriter writer, INameValidationResultsResultCorrectedFixes value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(INameValidationResultsResultCorrectedFixesConverter))]
        public interface INameValidationResultsResultCorrectedFixes
        { }
        public static readonly JSchema FixFormatGlobalNameValidationResultsResultCorrectedFixesJsonSchema = typeof(FixFormatGlobalNameValidationResultsResultCorrectedFixes).GetJsonSchema();
        public class FixFormatGlobalNameValidationResultsResultCorrectedFixes : FixFormatGlobal, INameValidationResultsResultCorrectedFixes
        {

        }
        public static readonly JSchema FixSyntaxGlobalNameValidationResultsResultCorrectedFixesJsonSchema = typeof(FixSyntaxGlobalNameValidationResultsResultCorrectedFixes).GetJsonSchema();
        public class FixSyntaxGlobalNameValidationResultsResultCorrectedFixes : FixSyntaxGlobal, INameValidationResultsResultCorrectedFixes
        {

        }
        public static readonly JSchema FixValueGlobalNameValidationResultsResultCorrectedFixesJsonSchema = typeof(FixValueGlobalNameValidationResultsResultCorrectedFixes).GetJsonSchema();
        public class FixValueGlobalNameValidationResultsResultCorrectedFixes : FixValueGlobal, INameValidationResultsResultCorrectedFixes
        {

        }
    }
    /**
     * Alternatives suggested for the sent query.
     */
    public class NameValidationResultsSuggestions
    {
        [JsonPropertyName("isValid")]
        [Newtonsoft.Json.JsonProperty("isValid")]
        public required bool IsValid { get; init; }
        [JsonPropertyName("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public required NameValidationResultsData Data { get; init; }
        [JsonPropertyName("details")]
        [Newtonsoft.Json.JsonProperty("details")]
        public NameValidationResultsDetails? Details { get; set; }
        [JsonPropertyName("fixes")]
        [Newtonsoft.Json.JsonProperty("fixes")]
        public required IEnumerable<INameValidationResultsSuggestionsFixes?> Fixes { get; init; }
        class INameValidationResultsSuggestionsFixesConverter : JsonConverter<INameValidationResultsSuggestionsFixes>
        {
            public override INameValidationResultsSuggestionsFixes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(FixFormatGlobalNameValidationResultsSuggestionsFixesJsonSchema))
                {
                    return obj.ToObject<FixFormatGlobalNameValidationResultsSuggestionsFixes>() ?? throw new JsonException("Unable to parse JSON to FixFormatGlobalNameValidationResultsSuggestionsFixes");
                }
                if (obj.IsValid(FixSyntaxGlobalNameValidationResultsSuggestionsFixesJsonSchema))
                {
                    return obj.ToObject<FixSyntaxGlobalNameValidationResultsSuggestionsFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxGlobalNameValidationResultsSuggestionsFixes");
                }
                if (obj.IsValid(FixValueGlobalNameValidationResultsSuggestionsFixesJsonSchema))
                {
                    return obj.ToObject<FixValueGlobalNameValidationResultsSuggestionsFixes>() ?? throw new JsonException("Unable to parse JSON to FixValueGlobalNameValidationResultsSuggestionsFixes");
                }
                throw new JsonException("Unable to parse JSON to INameValidationResultsSuggestionsFixes");
            }
            public override void Write(Utf8JsonWriter writer, INameValidationResultsSuggestionsFixes value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(INameValidationResultsSuggestionsFixesConverter))]
        public interface INameValidationResultsSuggestionsFixes
        { }
        public static readonly JSchema FixFormatGlobalNameValidationResultsSuggestionsFixesJsonSchema = typeof(FixFormatGlobalNameValidationResultsSuggestionsFixes).GetJsonSchema();
        public class FixFormatGlobalNameValidationResultsSuggestionsFixes : FixFormatGlobal, INameValidationResultsSuggestionsFixes
        {

        }
        public static readonly JSchema FixSyntaxGlobalNameValidationResultsSuggestionsFixesJsonSchema = typeof(FixSyntaxGlobalNameValidationResultsSuggestionsFixes).GetJsonSchema();
        public class FixSyntaxGlobalNameValidationResultsSuggestionsFixes : FixSyntaxGlobal, INameValidationResultsSuggestionsFixes
        {

        }
        public static readonly JSchema FixValueGlobalNameValidationResultsSuggestionsFixesJsonSchema = typeof(FixValueGlobalNameValidationResultsSuggestionsFixes).GetJsonSchema();
        public class FixValueGlobalNameValidationResultsSuggestionsFixes : FixValueGlobal, INameValidationResultsSuggestionsFixes
        {

        }
    }
}

