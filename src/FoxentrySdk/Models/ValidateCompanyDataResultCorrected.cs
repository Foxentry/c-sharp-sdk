
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
public class ValidateCompanyDataResultCorrected : CompanyResultsResponseResults
{
    [JsonPropertyName("isValid")]
    [Newtonsoft.Json.JsonProperty("isValid")]
    public required bool IsValid { get; init; }
    [JsonPropertyName("errors")]
    [Newtonsoft.Json.JsonProperty("errors")]
    public required IEnumerable<IValidateCompanyDataResultCorrectedErrors?> Errors { get; init; }
    [JsonPropertyName("fixes")]
    [Newtonsoft.Json.JsonProperty("fixes")]
    public required IEnumerable<IValidateCompanyDataResultCorrectedFixes?> Fixes { get; init; }

    class IValidateCompanyDataResultCorrectedErrorsConverter : JsonConverter<IValidateCompanyDataResultCorrectedErrors>
    {
        public override IValidateCompanyDataResultCorrectedErrors Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
            if (obj.IsValid(ErrorSyntaxGlobalValidateCompanyDataResultCorrectedErrorsJsonSchema))
            {
                return obj.ToObject<ErrorSyntaxGlobalValidateCompanyDataResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxGlobalValidateCompanyDataResultCorrectedErrors");
            }
            if (obj.IsValid(ErrorSyntaxCompanyValidateCompanyDataResultCorrectedErrorsJsonSchema))
            {
                return obj.ToObject<ErrorSyntaxCompanyValidateCompanyDataResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorSyntaxCompanyValidateCompanyDataResultCorrectedErrors");
            }
            if (obj.IsValid(ErrorFormatGlobalValidateCompanyDataResultCorrectedErrorsJsonSchema))
            {
                return obj.ToObject<ErrorFormatGlobalValidateCompanyDataResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorFormatGlobalValidateCompanyDataResultCorrectedErrors");
            }
            if (obj.IsValid(ErrorValueGlobalValidateCompanyDataResultCorrectedErrorsJsonSchema))
            {
                return obj.ToObject<ErrorValueGlobalValidateCompanyDataResultCorrectedErrors>() ?? throw new JsonException("Unable to parse JSON to ErrorValueGlobalValidateCompanyDataResultCorrectedErrors");
            }
            throw new JsonException("Unable to parse JSON to IValidateCompanyDataResultCorrectedErrors");
        }
        public override void Write(Utf8JsonWriter writer, IValidateCompanyDataResultCorrectedErrors value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
    [JsonInterfaceConverter(typeof(IValidateCompanyDataResultCorrectedErrorsConverter))]
    public interface IValidateCompanyDataResultCorrectedErrors
    { }
    public static readonly JSchema ErrorSyntaxGlobalValidateCompanyDataResultCorrectedErrorsJsonSchema = typeof(ErrorSyntaxGlobalValidateCompanyDataResultCorrectedErrors).GetJsonSchema();
    public class ErrorSyntaxGlobalValidateCompanyDataResultCorrectedErrors : ErrorSyntaxGlobal, IValidateCompanyDataResultCorrectedErrors
    {

    }
    public static readonly JSchema ErrorSyntaxCompanyValidateCompanyDataResultCorrectedErrorsJsonSchema = typeof(ErrorSyntaxCompanyValidateCompanyDataResultCorrectedErrors).GetJsonSchema();
    public class ErrorSyntaxCompanyValidateCompanyDataResultCorrectedErrors : ErrorSyntaxCompany, IValidateCompanyDataResultCorrectedErrors
    {

    }
    public static readonly JSchema ErrorFormatGlobalValidateCompanyDataResultCorrectedErrorsJsonSchema = typeof(ErrorFormatGlobalValidateCompanyDataResultCorrectedErrors).GetJsonSchema();
    public class ErrorFormatGlobalValidateCompanyDataResultCorrectedErrors : ErrorFormatGlobal, IValidateCompanyDataResultCorrectedErrors
    {

    }
    public static readonly JSchema ErrorValueGlobalValidateCompanyDataResultCorrectedErrorsJsonSchema = typeof(ErrorValueGlobalValidateCompanyDataResultCorrectedErrors).GetJsonSchema();
    public class ErrorValueGlobalValidateCompanyDataResultCorrectedErrors : ErrorValueGlobal, IValidateCompanyDataResultCorrectedErrors
    {

    }
    class IValidateCompanyDataResultCorrectedFixesConverter : JsonConverter<IValidateCompanyDataResultCorrectedFixes>
    {
        public override IValidateCompanyDataResultCorrectedFixes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            JObject obj = JsonHelpers.ParseUtf8JsonReader(ref reader);
            if (obj.IsValid(FixFormatGlobalValidateCompanyDataResultCorrectedFixesJsonSchema))
            {
                return obj.ToObject<FixFormatGlobalValidateCompanyDataResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixFormatGlobalValidateCompanyDataResultCorrectedFixes");
            }
            if (obj.IsValid(FixSyntaxGlobalValidateCompanyDataResultCorrectedFixesJsonSchema))
            {
                return obj.ToObject<FixSyntaxGlobalValidateCompanyDataResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxGlobalValidateCompanyDataResultCorrectedFixes");
            }
            if (obj.IsValid(FixSyntaxCompanyValidateCompanyDataResultCorrectedFixesJsonSchema))
            {
                return obj.ToObject<FixSyntaxCompanyValidateCompanyDataResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixSyntaxCompanyValidateCompanyDataResultCorrectedFixes");
            }
            if (obj.IsValid(FixValueGlobalValidateCompanyDataResultCorrectedFixesJsonSchema))
            {
                return obj.ToObject<FixValueGlobalValidateCompanyDataResultCorrectedFixes>() ?? throw new JsonException("Unable to parse JSON to FixValueGlobalValidateCompanyDataResultCorrectedFixes");
            }
            throw new JsonException("Unable to parse JSON to IValidateCompanyDataResultCorrectedFixes");
        }
        public override void Write(Utf8JsonWriter writer, IValidateCompanyDataResultCorrectedFixes value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
    [JsonInterfaceConverter(typeof(IValidateCompanyDataResultCorrectedFixesConverter))]
    public interface IValidateCompanyDataResultCorrectedFixes
    { }
    public static readonly JSchema FixFormatGlobalValidateCompanyDataResultCorrectedFixesJsonSchema = typeof(FixFormatGlobalValidateCompanyDataResultCorrectedFixes).GetJsonSchema();
    public class FixFormatGlobalValidateCompanyDataResultCorrectedFixes : FixFormatGlobal, IValidateCompanyDataResultCorrectedFixes
    {

    }
    public static readonly JSchema FixSyntaxGlobalValidateCompanyDataResultCorrectedFixesJsonSchema = typeof(FixSyntaxGlobalValidateCompanyDataResultCorrectedFixes).GetJsonSchema();
    public class FixSyntaxGlobalValidateCompanyDataResultCorrectedFixes : FixSyntaxGlobal, IValidateCompanyDataResultCorrectedFixes
    {

    }
    public static readonly JSchema FixSyntaxCompanyValidateCompanyDataResultCorrectedFixesJsonSchema = typeof(FixSyntaxCompanyValidateCompanyDataResultCorrectedFixes).GetJsonSchema();
    public class FixSyntaxCompanyValidateCompanyDataResultCorrectedFixes : FixSyntaxCompany, IValidateCompanyDataResultCorrectedFixes
    {

    }
    public static readonly JSchema FixValueGlobalValidateCompanyDataResultCorrectedFixesJsonSchema = typeof(FixValueGlobalValidateCompanyDataResultCorrectedFixes).GetJsonSchema();
    public class FixValueGlobalValidateCompanyDataResultCorrectedFixes : FixValueGlobal, IValidateCompanyDataResultCorrectedFixes
    {

    }
}
