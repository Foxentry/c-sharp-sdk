
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
public class ValidateCompanyDataResults
{
    [JsonPropertyName("result")]
    [Newtonsoft.Json.JsonProperty("result")]
    public required ValidateCompanyDataResultsResult Result { get; init; }
    [JsonPropertyName("resultCorrected")]
    [Newtonsoft.Json.JsonProperty("resultCorrected")]
    public ValidateCompanyDataResultsResultCorrected? ResultCorrected { get; set; }
    [JsonPropertyName("suggestions")]
    [Newtonsoft.Json.JsonProperty("suggestions")]
    public required IEnumerable<ValidateCompanyDataResultCorrected> Suggestions { get; init; }
    /**
     * Evaluation of the sent query.
     */
    public class ValidateCompanyDataResultsResult : CompanyResultsResponseResults
    {
        [JsonPropertyName("isValid")]
        [Newtonsoft.Json.JsonProperty("isValid")]
        public bool? IsValid { get; set; }
        [JsonPropertyName("proposal")]
        [Newtonsoft.Json.JsonProperty("proposal")]
        public ValidateCompanyDataResultsResultProposal? Proposal { get; set; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<IValidateCompanyDataResultsResultErrors?>? Errors { get; set; }

        class IValidateCompanyDataResultsResultErrorsConverter : JsonConverter<IValidateCompanyDataResultsResultErrors>
        {
            public override IValidateCompanyDataResultsResultErrors Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(ErrorSyntaxGlobalValidateCompanyDataResultsResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxGlobalValidateCompanyDataResultsResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxGlobalValidateCompanyDataResultsResultErrors");
                }
                if (obj.IsValid(ErrorSyntaxCompanyValidateCompanyDataResultsResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxCompanyValidateCompanyDataResultsResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxCompanyValidateCompanyDataResultsResultErrors");
                }
                if (obj.IsValid(ErrorFormatGlobalValidateCompanyDataResultsResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorFormatGlobalValidateCompanyDataResultsResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorFormatGlobalValidateCompanyDataResultsResultErrors");
                }
                if (obj.IsValid(ErrorValueGlobalValidateCompanyDataResultsResultErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValueGlobalValidateCompanyDataResultsResultErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueGlobalValidateCompanyDataResultsResultErrors");
                }
                throw new JsonException("Unable to parse JSON to IValidateCompanyDataResultsResultErrors");
            }
            public override void Write(Utf8JsonWriter writer, IValidateCompanyDataResultsResultErrors value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(IValidateCompanyDataResultsResultErrorsConverter))]
        public interface IValidateCompanyDataResultsResultErrors
        { }
        public static readonly JSchema ErrorSyntaxGlobalValidateCompanyDataResultsResultErrorsJsonSchema = typeof(ErrorSyntaxGlobalValidateCompanyDataResultsResultErrors).GetJsonSchema();
        public class ErrorSyntaxGlobalValidateCompanyDataResultsResultErrors : ErrorSyntaxGlobal, IValidateCompanyDataResultsResultErrors
        {

        }
        public static readonly JSchema ErrorSyntaxCompanyValidateCompanyDataResultsResultErrorsJsonSchema = typeof(ErrorSyntaxCompanyValidateCompanyDataResultsResultErrors).GetJsonSchema();
        public class ErrorSyntaxCompanyValidateCompanyDataResultsResultErrors : ErrorSyntaxCompany, IValidateCompanyDataResultsResultErrors
        {

        }
        public static readonly JSchema ErrorFormatGlobalValidateCompanyDataResultsResultErrorsJsonSchema = typeof(ErrorFormatGlobalValidateCompanyDataResultsResultErrors).GetJsonSchema();
        public class ErrorFormatGlobalValidateCompanyDataResultsResultErrors : ErrorFormatGlobal, IValidateCompanyDataResultsResultErrors
        {

        }
        public static readonly JSchema ErrorValueGlobalValidateCompanyDataResultsResultErrorsJsonSchema = typeof(ErrorValueGlobalValidateCompanyDataResultsResultErrors).GetJsonSchema();
        public class ErrorValueGlobalValidateCompanyDataResultsResultErrors : ErrorValueGlobal, IValidateCompanyDataResultsResultErrors
        {

        }
        /**
         * Proposed solution by Foxentry how you should process the response in your form or application.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidateCompanyDataResultsResultProposal>))]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ValidateCompanyDataResultsResultProposal
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
    public class ValidateCompanyDataResultsResultCorrected : CompanyResultsResponseResults
    {
        [JsonPropertyName("isValid")]
        [Newtonsoft.Json.JsonProperty("isValid")]
        public bool? IsValid { get; set; }
        [JsonPropertyName("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public IEnumerable<IValidateCompanyDataResultsResultCorrectedErrors?>? Errors { get; set; }
        [JsonPropertyName("fixes")]
        [Newtonsoft.Json.JsonProperty("fixes")]
        public IEnumerable<IValidateCompanyDataResultsResultCorrectedFixes?>? Fixes { get; set; }

        class IValidateCompanyDataResultsResultCorrectedErrorsConverter : JsonConverter<IValidateCompanyDataResultsResultCorrectedErrors>
        {
            public override IValidateCompanyDataResultsResultCorrectedErrors Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(ErrorSyntaxGlobalValidateCompanyDataResultsResultCorrectedErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxGlobalValidateCompanyDataResultsResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxGlobalValidateCompanyDataResultsResultCorrectedErrors");
                }
                if (obj.IsValid(ErrorSyntaxCompanyValidateCompanyDataResultsResultCorrectedErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorSyntaxCompanyValidateCompanyDataResultsResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxCompanyValidateCompanyDataResultsResultCorrectedErrors");
                }
                if (obj.IsValid(ErrorFormatGlobalValidateCompanyDataResultsResultCorrectedErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorFormatGlobalValidateCompanyDataResultsResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorFormatGlobalValidateCompanyDataResultsResultCorrectedErrors");
                }
                if (obj.IsValid(ErrorValueGlobalValidateCompanyDataResultsResultCorrectedErrorsJsonSchema))
                {
                    return obj.ToObject<ErrorValueGlobalValidateCompanyDataResultsResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueGlobalValidateCompanyDataResultsResultCorrectedErrors");
                }
                throw new JsonException("Unable to parse JSON to IValidateCompanyDataResultsResultCorrectedErrors");
            }
            public override void Write(Utf8JsonWriter writer, IValidateCompanyDataResultsResultCorrectedErrors value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(IValidateCompanyDataResultsResultCorrectedErrorsConverter))]
        public interface IValidateCompanyDataResultsResultCorrectedErrors
        { }
        public static readonly JSchema ErrorSyntaxGlobalValidateCompanyDataResultsResultCorrectedErrorsJsonSchema = typeof(ErrorSyntaxGlobalValidateCompanyDataResultsResultCorrectedErrors).GetJsonSchema();
        public class ErrorSyntaxGlobalValidateCompanyDataResultsResultCorrectedErrors : ErrorSyntaxGlobal, IValidateCompanyDataResultsResultCorrectedErrors
        {

        }
        public static readonly JSchema ErrorSyntaxCompanyValidateCompanyDataResultsResultCorrectedErrorsJsonSchema = typeof(ErrorSyntaxCompanyValidateCompanyDataResultsResultCorrectedErrors).GetJsonSchema();
        public class ErrorSyntaxCompanyValidateCompanyDataResultsResultCorrectedErrors : ErrorSyntaxCompany, IValidateCompanyDataResultsResultCorrectedErrors
        {

        }
        public static readonly JSchema ErrorFormatGlobalValidateCompanyDataResultsResultCorrectedErrorsJsonSchema = typeof(ErrorFormatGlobalValidateCompanyDataResultsResultCorrectedErrors).GetJsonSchema();
        public class ErrorFormatGlobalValidateCompanyDataResultsResultCorrectedErrors : ErrorFormatGlobal, IValidateCompanyDataResultsResultCorrectedErrors
        {

        }
        public static readonly JSchema ErrorValueGlobalValidateCompanyDataResultsResultCorrectedErrorsJsonSchema = typeof(ErrorValueGlobalValidateCompanyDataResultsResultCorrectedErrors).GetJsonSchema();
        public class ErrorValueGlobalValidateCompanyDataResultsResultCorrectedErrors : ErrorValueGlobal, IValidateCompanyDataResultsResultCorrectedErrors
        {

        }
        class IValidateCompanyDataResultsResultCorrectedFixesConverter : JsonConverter<IValidateCompanyDataResultsResultCorrectedFixes>
        {
            public override IValidateCompanyDataResultsResultCorrectedFixes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
                if (obj.IsValid(FixFormatGlobalValidateCompanyDataResultsResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixFormatGlobalValidateCompanyDataResultsResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixFormatGlobalValidateCompanyDataResultsResultCorrectedFixes");
                }
                if (obj.IsValid(FixSyntaxGlobalValidateCompanyDataResultsResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixSyntaxGlobalValidateCompanyDataResultsResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxGlobalValidateCompanyDataResultsResultCorrectedFixes");
                }
                if (obj.IsValid(FixSyntaxCompanyValidateCompanyDataResultsResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixSyntaxCompanyValidateCompanyDataResultsResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxCompanyValidateCompanyDataResultsResultCorrectedFixes");
                }
                if (obj.IsValid(FixValueGlobalValidateCompanyDataResultsResultCorrectedFixesJsonSchema))
                {
                    return obj.ToObject<FixValueGlobalValidateCompanyDataResultsResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixValueGlobalValidateCompanyDataResultsResultCorrectedFixes");
                }
                throw new JsonException("Unable to parse JSON to IValidateCompanyDataResultsResultCorrectedFixes");
            }
            public override void Write(Utf8JsonWriter writer, IValidateCompanyDataResultsResultCorrectedFixes value, JsonSerializerOptions options)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
        [JsonInterfaceConverter(typeof(IValidateCompanyDataResultsResultCorrectedFixesConverter))]
        public interface IValidateCompanyDataResultsResultCorrectedFixes
        { }
        public static readonly JSchema FixFormatGlobalValidateCompanyDataResultsResultCorrectedFixesJsonSchema = typeof(FixFormatGlobalValidateCompanyDataResultsResultCorrectedFixes).GetJsonSchema();
        public class FixFormatGlobalValidateCompanyDataResultsResultCorrectedFixes : FixFormatGlobal, IValidateCompanyDataResultsResultCorrectedFixes
        {

        }
        public static readonly JSchema FixSyntaxGlobalValidateCompanyDataResultsResultCorrectedFixesJsonSchema = typeof(FixSyntaxGlobalValidateCompanyDataResultsResultCorrectedFixes).GetJsonSchema();
        public class FixSyntaxGlobalValidateCompanyDataResultsResultCorrectedFixes : FixSyntaxGlobal, IValidateCompanyDataResultsResultCorrectedFixes
        {

        }
        public static readonly JSchema FixSyntaxCompanyValidateCompanyDataResultsResultCorrectedFixesJsonSchema = typeof(FixSyntaxCompanyValidateCompanyDataResultsResultCorrectedFixes).GetJsonSchema();
        public class FixSyntaxCompanyValidateCompanyDataResultsResultCorrectedFixes : FixSyntaxCompany, IValidateCompanyDataResultsResultCorrectedFixes
        {

        }
        public static readonly JSchema FixValueGlobalValidateCompanyDataResultsResultCorrectedFixesJsonSchema = typeof(FixValueGlobalValidateCompanyDataResultsResultCorrectedFixes).GetJsonSchema();
        public class FixValueGlobalValidateCompanyDataResultsResultCorrectedFixes : FixValueGlobal, IValidateCompanyDataResultsResultCorrectedFixes
        {

        }
    }/**
         * Alternatives suggested for the sent query.
         */
    public class ValidateCompanyDataResultsSuggestions { }
}

