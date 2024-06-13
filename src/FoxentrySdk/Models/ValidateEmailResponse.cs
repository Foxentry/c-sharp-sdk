
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
public class ValidateEmailResponse
{
    [JsonPropertyName("result")]
    [Newtonsoft.Json.JsonProperty("result")]
    public required ValidateEmailResponseResult Result { get; init; }
    [JsonPropertyName("resultCorrected")]
    [Newtonsoft.Json.JsonProperty("resultCorrected")]
    public ValidateEmailResponseResultCorrected? ResultCorrected { get; set; }
    [JsonPropertyName("suggestions")]
    [Newtonsoft.Json.JsonProperty("suggestions")]
    public IEnumerable<ValidateEmailResponseSuggestions?>? Suggestions { get; set; }/**
     * Evaluation of the sent query.
     */
    public class ValidateEmailResponseResult
    {
        [JsonPropertyName("isValid")]
        [Newtonsoft.Json.JsonProperty("isValid")]
        public required bool IsValid { get; init; }
        [JsonPropertyName("proposal")]
        [Newtonsoft.Json.JsonProperty("proposal")]
        public required ValidateEmailResponseResultProposal Proposal { get; init; }
        [JsonPropertyName("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public required EmailData Data { get; init; }
        [JsonPropertyName("flags")]
        [Newtonsoft.Json.JsonProperty("flags")]
        public EmailFlags? Flags { get; set; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<IValidateEmailResponseResultErrors?>? Errors { get; set; }
        class IValidateEmailResponseResultErrorsConverter : JsonConverter<IValidateEmailResponseResultErrors>
        {
            public override IValidateEmailResponseResultErrors Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(ErrorSyntaxGlobalValidateEmailResponseResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxGlobalValidateEmailResponseResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxGlobalValidateEmailResponseResultErrors");
                }
                if (obj.IsValid(ErrorSyntaxEmailValidateEmailResponseResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxEmailValidateEmailResponseResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxEmailValidateEmailResponseResultErrors");
                }
                if (obj.IsValid(ErrorFormatGlobalValidateEmailResponseResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorFormatGlobalValidateEmailResponseResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorFormatGlobalValidateEmailResponseResultErrors");
                }
                if (obj.IsValid(ErrorValueGlobalValidateEmailResponseResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValueGlobalValidateEmailResponseResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueGlobalValidateEmailResponseResultErrors");
                }
                if (obj.IsValid(ErrorValueEmailValidateEmailResponseResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValueEmailValidateEmailResponseResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueEmailValidateEmailResponseResultErrors");
                }
                throw new JsonException("Unable to parse JSON to IValidateEmailResponseResultErrors");
            }
            public override void Write(Utf8JsonWriter writer, IValidateEmailResponseResultErrors value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(IValidateEmailResponseResultErrorsConverter))]
        public interface IValidateEmailResponseResultErrors
        { }
        public static readonly JSchema ErrorSyntaxGlobalValidateEmailResponseResultErrorsJsonSchema = typeof(ErrorSyntaxGlobalValidateEmailResponseResultErrors).GetJsonSchema();
        public class ErrorSyntaxGlobalValidateEmailResponseResultErrors : ErrorSyntaxGlobal, IValidateEmailResponseResultErrors
        {

        }
        public static readonly JSchema ErrorSyntaxEmailValidateEmailResponseResultErrorsJsonSchema = typeof(ErrorSyntaxEmailValidateEmailResponseResultErrors).GetJsonSchema();
        public class ErrorSyntaxEmailValidateEmailResponseResultErrors : ErrorSyntaxEmail, IValidateEmailResponseResultErrors
        {

        }
        public static readonly JSchema ErrorFormatGlobalValidateEmailResponseResultErrorsJsonSchema = typeof(ErrorFormatGlobalValidateEmailResponseResultErrors).GetJsonSchema();
        public class ErrorFormatGlobalValidateEmailResponseResultErrors : ErrorFormatGlobal, IValidateEmailResponseResultErrors
        {

        }
        public static readonly JSchema ErrorValueGlobalValidateEmailResponseResultErrorsJsonSchema = typeof(ErrorValueGlobalValidateEmailResponseResultErrors).GetJsonSchema();
        public class ErrorValueGlobalValidateEmailResponseResultErrors : ErrorValueGlobal, IValidateEmailResponseResultErrors
        {

        }
        public static readonly JSchema ErrorValueEmailValidateEmailResponseResultErrorsJsonSchema = typeof(ErrorValueEmailValidateEmailResponseResultErrors).GetJsonSchema();
        public class ErrorValueEmailValidateEmailResponseResultErrors : ErrorValueEmail, IValidateEmailResponseResultErrors
        {

        }
        /**
         * Proposed solution by Foxentry how you should process the response in your form or application.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidateEmailResponseResultProposal>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ValidateEmailResponseResultProposal
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
            [StringValue("unknownWithCorrection")]
            UNKNOWN_WITH_CORRECTION,
            [StringValue("unknownWithPartialCorrection")]
            UNKNOWN_WITH_PARTIAL_CORRECTION
        }
    }
    /**
     * Corrected version of the sent query.
     */
    public class ValidateEmailResponseResultCorrected
    {
        [JsonPropertyName("isValid")]
        [Newtonsoft.Json.JsonProperty("isValid")]
        public required bool IsValid { get; init; }
        [JsonPropertyName("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public EmailData? Data { get; set; }
        [JsonPropertyName("flags")]
        [Newtonsoft.Json.JsonProperty("flags")]
        public EmailFlags? Flags { get; set; }
        [JsonPropertyName("fixes")]
        [Newtonsoft.Json.JsonProperty("fixes")]
        public IEnumerable<IValidateEmailResponseResultCorrectedFixes?>? Fixes { get; set; }
        class IValidateEmailResponseResultCorrectedFixesConverter : JsonConverter<IValidateEmailResponseResultCorrectedFixes>
        {
            public override IValidateEmailResponseResultCorrectedFixes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(FixFormatGlobalValidateEmailResponseResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixFormatGlobalValidateEmailResponseResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixFormatGlobalValidateEmailResponseResultCorrectedFixes");
                }
                if (obj.IsValid(FixSyntaxGlobalValidateEmailResponseResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixSyntaxGlobalValidateEmailResponseResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxGlobalValidateEmailResponseResultCorrectedFixes");
                }
                if (obj.IsValid(FixSyntaxEmailValidateEmailResponseResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixSyntaxEmailValidateEmailResponseResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxEmailValidateEmailResponseResultCorrectedFixes");
                }
                if (obj.IsValid(FixValueGlobalValidateEmailResponseResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixValueGlobalValidateEmailResponseResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixValueGlobalValidateEmailResponseResultCorrectedFixes");
                }
                throw new JsonException("Unable to parse JSON to IValidateEmailResponseResultCorrectedFixes");
            }
            public override void Write(Utf8JsonWriter writer, IValidateEmailResponseResultCorrectedFixes value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(IValidateEmailResponseResultCorrectedFixesConverter))]
        public interface IValidateEmailResponseResultCorrectedFixes
        { }
        public static readonly JSchema FixFormatGlobalValidateEmailResponseResultCorrectedFixesJsonSchema = typeof(FixFormatGlobalValidateEmailResponseResultCorrectedFixes).GetJsonSchema();
        public class FixFormatGlobalValidateEmailResponseResultCorrectedFixes : FixFormatGlobal, IValidateEmailResponseResultCorrectedFixes
        {

        }
        public static readonly JSchema FixSyntaxGlobalValidateEmailResponseResultCorrectedFixesJsonSchema = typeof(FixSyntaxGlobalValidateEmailResponseResultCorrectedFixes).GetJsonSchema();
        public class FixSyntaxGlobalValidateEmailResponseResultCorrectedFixes : FixSyntaxGlobal, IValidateEmailResponseResultCorrectedFixes
        {

        }
        public static readonly JSchema FixSyntaxEmailValidateEmailResponseResultCorrectedFixesJsonSchema = typeof(FixSyntaxEmailValidateEmailResponseResultCorrectedFixes).GetJsonSchema();
        public class FixSyntaxEmailValidateEmailResponseResultCorrectedFixes : FixSyntaxEmail, IValidateEmailResponseResultCorrectedFixes
        {

        }
        public static readonly JSchema FixValueGlobalValidateEmailResponseResultCorrectedFixesJsonSchema = typeof(FixValueGlobalValidateEmailResponseResultCorrectedFixes).GetJsonSchema();
        public class FixValueGlobalValidateEmailResponseResultCorrectedFixes : FixValueGlobal, IValidateEmailResponseResultCorrectedFixes
        {

        }
    }
    public class ValidateEmailResponseSuggestions
    {
        [JsonPropertyName("isValid")]
        [Newtonsoft.Json.JsonProperty("isValid")]
        public bool? IsValid { get; set; }
        [JsonPropertyName("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public EmailData? Data { get; set; }
        [JsonPropertyName("flags")]
        [Newtonsoft.Json.JsonProperty("flags")]
        public EmailFlags? Flags { get; set; }
        [JsonPropertyName("fixes")]
        [Newtonsoft.Json.JsonProperty("fixes")]
        public IEnumerable<EmailFixes>? Fixes { get; set; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<IValidateEmailResponseSuggestionsErrors?>? Errors { get; set; }
        class IValidateEmailResponseSuggestionsErrorsConverter : JsonConverter<IValidateEmailResponseSuggestionsErrors>
        {
            public override IValidateEmailResponseSuggestionsErrors Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(ErrorSyntaxGlobalValidateEmailResponseSuggestionsErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxGlobalValidateEmailResponseSuggestionsErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxGlobalValidateEmailResponseSuggestionsErrors");
                }
                if (obj.IsValid(ErrorSyntaxEmailValidateEmailResponseSuggestionsErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxEmailValidateEmailResponseSuggestionsErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxEmailValidateEmailResponseSuggestionsErrors");
                }
                if (obj.IsValid(ErrorFormatGlobalValidateEmailResponseSuggestionsErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorFormatGlobalValidateEmailResponseSuggestionsErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorFormatGlobalValidateEmailResponseSuggestionsErrors");
                }
                if (obj.IsValid(ErrorValueGlobalValidateEmailResponseSuggestionsErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValueGlobalValidateEmailResponseSuggestionsErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueGlobalValidateEmailResponseSuggestionsErrors");
                }
                if (obj.IsValid(ErrorValueEmailValidateEmailResponseSuggestionsErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValueEmailValidateEmailResponseSuggestionsErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueEmailValidateEmailResponseSuggestionsErrors");
                }
                throw new JsonException("Unable to parse JSON to IValidateEmailResponseSuggestionsErrors");
            }
            public override void Write(Utf8JsonWriter writer, IValidateEmailResponseSuggestionsErrors value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(IValidateEmailResponseSuggestionsErrorsConverter))]
        public interface IValidateEmailResponseSuggestionsErrors
        { }
        public static readonly JSchema ErrorSyntaxGlobalValidateEmailResponseSuggestionsErrorsJsonSchema = typeof(ErrorSyntaxGlobalValidateEmailResponseSuggestionsErrors).GetJsonSchema();
        public class ErrorSyntaxGlobalValidateEmailResponseSuggestionsErrors : ErrorSyntaxGlobal, IValidateEmailResponseSuggestionsErrors
        {

        }
        public static readonly JSchema ErrorSyntaxEmailValidateEmailResponseSuggestionsErrorsJsonSchema = typeof(ErrorSyntaxEmailValidateEmailResponseSuggestionsErrors).GetJsonSchema();
        public class ErrorSyntaxEmailValidateEmailResponseSuggestionsErrors : ErrorSyntaxEmail, IValidateEmailResponseSuggestionsErrors
        {

        }
        public static readonly JSchema ErrorFormatGlobalValidateEmailResponseSuggestionsErrorsJsonSchema = typeof(ErrorFormatGlobalValidateEmailResponseSuggestionsErrors).GetJsonSchema();
        public class ErrorFormatGlobalValidateEmailResponseSuggestionsErrors : ErrorFormatGlobal, IValidateEmailResponseSuggestionsErrors
        {

        }
        public static readonly JSchema ErrorValueGlobalValidateEmailResponseSuggestionsErrorsJsonSchema = typeof(ErrorValueGlobalValidateEmailResponseSuggestionsErrors).GetJsonSchema();
        public class ErrorValueGlobalValidateEmailResponseSuggestionsErrors : ErrorValueGlobal, IValidateEmailResponseSuggestionsErrors
        {

        }
        public static readonly JSchema ErrorValueEmailValidateEmailResponseSuggestionsErrorsJsonSchema = typeof(ErrorValueEmailValidateEmailResponseSuggestionsErrors).GetJsonSchema();
        public class ErrorValueEmailValidateEmailResponseSuggestionsErrors : ErrorValueEmail, IValidateEmailResponseSuggestionsErrors
        {

        }
        /**
         * List of all changes applied to the query data in order to get the suggested result.
         */
        public class ValidateEmailResponseSuggestionsFixes { }
    }
}

