
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
public class NameValidationResults
{
    [JsonPropertyName("result")]
    public required NameValidationResultsResult Result { get; init; }
    [JsonPropertyName("resultCorrected")]
    public NameValidationResultsResultCorrected? ResultCorrected { get; set; }
    [JsonPropertyName("suggestions")]
    public required IEnumerable<NameValidationResultsSuggestions?> Suggestions { get; init; }/**
     * Evaluation of the sent query.
     */
    public class NameValidationResultsResult
    {
        [JsonPropertyName("isValid")]
        public required bool IsValid { get; init; }
        [JsonPropertyName("proposal")]
        public required NameValidationResultsResultProposal Proposal { get; init; }
        [JsonPropertyName("data")]
        public required NameValidationResultsData Data { get; init; }
        [JsonPropertyName("details")]
        public NameValidationResultsDetails? Details { get; set; }
        [JsonPropertyName("errors")]
        public IEnumerable<INameValidationResultsResultErrors?>? Errors { get; set; }
        public interface INameValidationResultsResultErrors
        { }
        public class ErrorSyntaxGlobalNameValidationResultsResultErrors : ErrorSyntaxGlobal, INameValidationResultsResultErrors
        {

        }
        public class ErrorSyntaxNameNameValidationResultsResultErrors : ErrorSyntaxName, INameValidationResultsResultErrors
        {

        }
        public class ErrorFormatGlobalNameValidationResultsResultErrors : ErrorFormatGlobal, INameValidationResultsResultErrors
        {

        }
        public class ErrorValueGlobalNameValidationResultsResultErrors : ErrorValueGlobal, INameValidationResultsResultErrors
        {

        }
        public class ErrorValueNameNameValidationResultsResultErrors : ErrorValueName, INameValidationResultsResultErrors
        {

        }
        /**
         * Proposed solution by Foxentry how you should process the response in your form or application.
         */
        [JsonConverter(typeof(StringValueEnumConverter<NameValidationResultsResultProposal>))]
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
        public required bool IsValid { get; init; }
        [JsonPropertyName("data")]
        public required NameValidationResultsData Data { get; init; }
        [JsonPropertyName("details")]
        public NameValidationResultsDetails? Details { get; set; }
        [JsonPropertyName("fixes")]
        public required IEnumerable<INameValidationResultsResultCorrectedFixes?> Fixes { get; init; }
        public interface INameValidationResultsResultCorrectedFixes
        { }
        public class FixFormatGlobalNameValidationResultsResultCorrectedFixes : FixFormatGlobal, INameValidationResultsResultCorrectedFixes
        {

        }
        public class FixSyntaxGlobalNameValidationResultsResultCorrectedFixes : FixSyntaxGlobal, INameValidationResultsResultCorrectedFixes
        {

        }
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
        public required bool IsValid { get; init; }
        [JsonPropertyName("data")]
        public required NameValidationResultsData Data { get; init; }
        [JsonPropertyName("details")]
        public NameValidationResultsDetails? Details { get; set; }
        [JsonPropertyName("fixes")]
        public required IEnumerable<INameValidationResultsSuggestionsFixes?> Fixes { get; init; }
        public interface INameValidationResultsSuggestionsFixes
        { }
        public class FixFormatGlobalNameValidationResultsSuggestionsFixes : FixFormatGlobal, INameValidationResultsSuggestionsFixes
        {

        }
        public class FixSyntaxGlobalNameValidationResultsSuggestionsFixes : FixSyntaxGlobal, INameValidationResultsSuggestionsFixes
        {

        }
        public class FixValueGlobalNameValidationResultsSuggestionsFixes : FixValueGlobal, INameValidationResultsSuggestionsFixes
        {

        }
    }
}

