
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
public class ValidateEmailResponse
{
    [JsonPropertyName("result")]
    public required ValidateEmailResponseResult Result { get; init; }
    [JsonPropertyName("resultCorrected")]
    public ValidateEmailResponseResultCorrected? ResultCorrected { get; set; }
    [JsonPropertyName("suggestions")]
    public IEnumerable<ValidateEmailResponseSuggestions?>? Suggestions { get; set; }/**
     * Evaluation of the sent query.
     */
    public class ValidateEmailResponseResult
    {
        [JsonPropertyName("isValid")]
        public required bool IsValid { get; init; }
        [JsonPropertyName("proposal")]
        public required ValidateEmailResponseResultProposal Proposal { get; init; }
        [JsonPropertyName("data")]
        public required EmailData Data { get; init; }
        [JsonPropertyName("flags")]
        public EmailFlags? Flags { get; set; }
        [JsonPropertyName("errors")]
        public IEnumerable<IValidateEmailResponseResultErrors?>? Errors { get; set; }
        public interface IValidateEmailResponseResultErrors
        { }
        public class ErrorSyntaxGlobalValidateEmailResponseResultErrors : ErrorSyntaxGlobal, IValidateEmailResponseResultErrors
        {

        }
        public class ErrorSyntaxEmailValidateEmailResponseResultErrors : ErrorSyntaxEmail, IValidateEmailResponseResultErrors
        {

        }
        public class ErrorFormatGlobalValidateEmailResponseResultErrors : ErrorFormatGlobal, IValidateEmailResponseResultErrors
        {

        }
        public class ErrorValueGlobalValidateEmailResponseResultErrors : ErrorValueGlobal, IValidateEmailResponseResultErrors
        {

        }
        public class ErrorValueEmailValidateEmailResponseResultErrors : ErrorValueEmail, IValidateEmailResponseResultErrors
        {

        }
        /**
         * Proposed solution by Foxentry how you should process the response in your form or application.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidateEmailResponseResultProposal>))]
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
        public required bool IsValid { get; init; }
        [JsonPropertyName("data")]
        public EmailData? Data { get; set; }
        [JsonPropertyName("flags")]
        public EmailFlags? Flags { get; set; }
        [JsonPropertyName("fixes")]
        public IEnumerable<IValidateEmailResponseResultCorrectedFixes?>? Fixes { get; set; }
        public interface IValidateEmailResponseResultCorrectedFixes
        { }
        public class FixFormatGlobalValidateEmailResponseResultCorrectedFixes : FixFormatGlobal, IValidateEmailResponseResultCorrectedFixes
        {

        }
        public class FixSyntaxGlobalValidateEmailResponseResultCorrectedFixes : FixSyntaxGlobal, IValidateEmailResponseResultCorrectedFixes
        {

        }
        public class FixSyntaxEmailValidateEmailResponseResultCorrectedFixes : FixSyntaxEmail, IValidateEmailResponseResultCorrectedFixes
        {

        }
        public class FixValueGlobalValidateEmailResponseResultCorrectedFixes : FixValueGlobal, IValidateEmailResponseResultCorrectedFixes
        {

        }
    }
    public class ValidateEmailResponseSuggestions
    {
        [JsonPropertyName("isValid")]
        public bool? IsValid { get; set; }
        [JsonPropertyName("data")]
        public EmailData? Data { get; set; }
        [JsonPropertyName("flags")]
        public EmailFlags? Flags { get; set; }
        [JsonPropertyName("fixes")]
        public IEnumerable<EmailFixes>? Fixes { get; set; }
        [JsonPropertyName("errors")]
        public IEnumerable<IValidateEmailResponseSuggestionsErrors?>? Errors { get; set; }
        public interface IValidateEmailResponseSuggestionsErrors
        { }
        public class ErrorSyntaxGlobalValidateEmailResponseSuggestionsErrors : ErrorSyntaxGlobal, IValidateEmailResponseSuggestionsErrors
        {

        }
        public class ErrorSyntaxEmailValidateEmailResponseSuggestionsErrors : ErrorSyntaxEmail, IValidateEmailResponseSuggestionsErrors
        {

        }
        public class ErrorFormatGlobalValidateEmailResponseSuggestionsErrors : ErrorFormatGlobal, IValidateEmailResponseSuggestionsErrors
        {

        }
        public class ErrorValueGlobalValidateEmailResponseSuggestionsErrors : ErrorValueGlobal, IValidateEmailResponseSuggestionsErrors
        {

        }
        public class ErrorValueEmailValidateEmailResponseSuggestionsErrors : ErrorValueEmail, IValidateEmailResponseSuggestionsErrors
        {

        }
        /**
         * All changes listed in comparison to the sent query.
         */
        public class ValidateEmailResponseSuggestionsFixes { }
    }
}

