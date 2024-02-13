
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
public class ValidatePhoneNumberResults
{
    [JsonPropertyName("result")]
    public required ValidatePhoneNumberResultsResult Result { get; init; }
    [JsonPropertyName("resultCorrected")]
    public ValidatePhoneNumberResultsResultCorrected? ResultCorrected { get; set; }
    [JsonPropertyName("suggestions")]
    public required IEnumerable<ValidatePhoneNumberResultsSuggestions?> Suggestions { get; init; }/**
     * Evaluation of the sent query.
     */
    public class ValidatePhoneNumberResultsResult
    {
        [JsonPropertyName("isValid")]
        public required bool IsValid { get; init; }
        [JsonPropertyName("proposal")]
        public required ValidatePhoneNumberResultsResultProposal Proposal { get; init; }
        [JsonPropertyName("data")]
        public required ValidatePhoneNumberData Data { get; init; }
        [JsonPropertyName("errors")]
        public required IEnumerable<IValidatePhoneNumberResultsResultErrors?> Errors { get; init; }
        public interface IValidatePhoneNumberResultsResultErrors
        { }
        public class ErrorSyntaxGlobalValidatePhoneNumberResultsResultErrors : ErrorSyntaxGlobal, IValidatePhoneNumberResultsResultErrors
        {

        }
        public class ErrorSyntaxPhoneValidatePhoneNumberResultsResultErrors : ErrorSyntaxPhone, IValidatePhoneNumberResultsResultErrors
        {

        }
        public class ErrorFormatGlobalValidatePhoneNumberResultsResultErrors : ErrorFormatGlobal, IValidatePhoneNumberResultsResultErrors
        {

        }
        public class ErrorValueGlobalValidatePhoneNumberResultsResultErrors : ErrorValueGlobal, IValidatePhoneNumberResultsResultErrors
        {

        }
        public class ErrorValuePhoneValidatePhoneNumberResultsResultErrors : ErrorValuePhone, IValidatePhoneNumberResultsResultErrors
        {

        }
        /**
         * Proposed solution by Foxentry how you should process the response in your form or application.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidatePhoneNumberResultsResultProposal>))]
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
            INVALID_WITH_CORRECTION_WITH_SUGGESTION
        }
    }
    /**
     * Corrected version of the sent query.
     */
    public class ValidatePhoneNumberResultsResultCorrected
    {
        [JsonPropertyName("isValid")]
        public bool? IsValid { get; set; }
        [JsonPropertyName("data")]
        public ValidatePhoneNumberData? Data { get; set; }
        [JsonPropertyName("errors")]
        public IEnumerable<IValidatePhoneNumberResultsResultCorrectedErrors?>? Errors { get; set; }
        [JsonPropertyName("fixes")]
        public IEnumerable<IValidatePhoneNumberResultsResultCorrectedFixes?>? Fixes { get; set; }
        public interface IValidatePhoneNumberResultsResultCorrectedErrors
        { }
        public class ErrorSyntaxGlobalValidatePhoneNumberResultsResultCorrectedErrors : ErrorSyntaxGlobal, IValidatePhoneNumberResultsResultCorrectedErrors
        {

        }
        public class ErrorSyntaxPhoneValidatePhoneNumberResultsResultCorrectedErrors : ErrorSyntaxPhone, IValidatePhoneNumberResultsResultCorrectedErrors
        {

        }
        public class ErrorFormatGlobalValidatePhoneNumberResultsResultCorrectedErrors : ErrorFormatGlobal, IValidatePhoneNumberResultsResultCorrectedErrors
        {

        }
        public class ErrorValueGlobalValidatePhoneNumberResultsResultCorrectedErrors : ErrorValueGlobal, IValidatePhoneNumberResultsResultCorrectedErrors
        {

        }
        public class ErrorValuePhoneValidatePhoneNumberResultsResultCorrectedErrors : ErrorValuePhone, IValidatePhoneNumberResultsResultCorrectedErrors
        {

        }
        public interface IValidatePhoneNumberResultsResultCorrectedFixes
        { }
        public class FixFormatGlobalValidatePhoneNumberResultsResultCorrectedFixes : FixFormatGlobal, IValidatePhoneNumberResultsResultCorrectedFixes
        {

        }
        public class FixSyntaxGlobalValidatePhoneNumberResultsResultCorrectedFixes : FixSyntaxGlobal, IValidatePhoneNumberResultsResultCorrectedFixes
        {

        }
        public class FixSyntaxPhoneValidatePhoneNumberResultsResultCorrectedFixes : FixSyntaxPhone, IValidatePhoneNumberResultsResultCorrectedFixes
        {

        }
        public class FixValueGlobalValidatePhoneNumberResultsResultCorrectedFixes : FixValueGlobal, IValidatePhoneNumberResultsResultCorrectedFixes
        {

        }
    }
    public class ValidatePhoneNumberResultsSuggestions
    {
        [JsonPropertyName("isValid")]
        public bool? IsValid { get; set; }
        [JsonPropertyName("data")]
        public ValidatePhoneNumberData? Data { get; set; }
        [JsonPropertyName("errors")]
        public IEnumerable<IValidatePhoneNumberResultsSuggestionsErrors?>? Errors { get; set; }
        [JsonPropertyName("fixes")]
        public IEnumerable<IValidatePhoneNumberResultsSuggestionsFixes?>? Fixes { get; set; }
        public interface IValidatePhoneNumberResultsSuggestionsErrors
        { }
        public class ErrorSyntaxGlobalValidatePhoneNumberResultsSuggestionsErrors : ErrorSyntaxGlobal, IValidatePhoneNumberResultsSuggestionsErrors
        {

        }
        public class ErrorSyntaxPhoneValidatePhoneNumberResultsSuggestionsErrors : ErrorSyntaxPhone, IValidatePhoneNumberResultsSuggestionsErrors
        {

        }
        public class ErrorFormatGlobalValidatePhoneNumberResultsSuggestionsErrors : ErrorFormatGlobal, IValidatePhoneNumberResultsSuggestionsErrors
        {

        }
        public class ErrorValueGlobalValidatePhoneNumberResultsSuggestionsErrors : ErrorValueGlobal, IValidatePhoneNumberResultsSuggestionsErrors
        {

        }
        public class ErrorValuePhoneValidatePhoneNumberResultsSuggestionsErrors : ErrorValuePhone, IValidatePhoneNumberResultsSuggestionsErrors
        {

        }
        public interface IValidatePhoneNumberResultsSuggestionsFixes
        { }
        public class FixFormatGlobalValidatePhoneNumberResultsSuggestionsFixes : FixFormatGlobal, IValidatePhoneNumberResultsSuggestionsFixes
        {

        }
        public class FixSyntaxGlobalValidatePhoneNumberResultsSuggestionsFixes : FixSyntaxGlobal, IValidatePhoneNumberResultsSuggestionsFixes
        {

        }
        public class FixSyntaxPhoneValidatePhoneNumberResultsSuggestionsFixes : FixSyntaxPhone, IValidatePhoneNumberResultsSuggestionsFixes
        {

        }
        public class FixValueGlobalValidatePhoneNumberResultsSuggestionsFixes : FixValueGlobal, IValidatePhoneNumberResultsSuggestionsFixes
        {

        }
    }
}

