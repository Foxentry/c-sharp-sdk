
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
public class LocationValidationResponse
{
    [JsonPropertyName("result")]
    public required LocationValidationResponseResult Result { get; init; }
    [JsonPropertyName("resultCorrected")]
    public LocationValidationResponseResultCorrected? ResultCorrected { get; set; }
    [JsonPropertyName("suggestions")]
    public IEnumerable<LocationValidationResponseSuggestions?>? Suggestions { get; set; }/**
     * Evaluation of the sent query.
     */
    public class LocationValidationResponseResult
    {
        [JsonPropertyName("isValid")]
        public required bool IsValid { get; init; }
        [JsonPropertyName("proposal")]
        public required LocationValidationResponseResultProposal Proposal { get; init; }
        [JsonPropertyName("data")]
        public required LocationData Data { get; init; }
        [JsonPropertyName("errors")]
        public IEnumerable<ILocationValidationResponseResultErrors?>? Errors { get; set; }
        public interface ILocationValidationResponseResultErrors
        { }
        public class ErrorSyntaxGlobalLocationValidationResponseResultErrors : ErrorSyntaxGlobal, ILocationValidationResponseResultErrors
        {

        }
        public class ErrorSyntaxLocationLocationValidationResponseResultErrors : ErrorSyntaxLocation, ILocationValidationResponseResultErrors
        {

        }
        public class ErrorFormatGlobalLocationValidationResponseResultErrors : ErrorFormatGlobal, ILocationValidationResponseResultErrors
        {

        }
        public class ErrorValueGlobalLocationValidationResponseResultErrors : ErrorValueGlobal, ILocationValidationResponseResultErrors
        {

        }
        /**
         * Proposed solution by Foxentry how you should process the response in your form or application.
         */
        [JsonConverter(typeof(StringValueEnumConverter<LocationValidationResponseResultProposal>))]
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
            INVALID_WITH_CORRECTION_WITH_SUGGESTION
        }
    }
    /**
     * Corrected version of the sent query.
     */
    public class LocationValidationResponseResultCorrected
    {
        [JsonPropertyName("isValid")]
        public required bool IsValid { get; init; }
        [JsonPropertyName("data")]
        public required LocationData Data { get; init; }
        [JsonPropertyName("errors")]
        public IEnumerable<ILocationValidationResponseResultCorrectedErrors?>? Errors { get; set; }
        [JsonPropertyName("fixes")]
        public IEnumerable<ILocationValidationResponseResultCorrectedFixes?>? Fixes { get; set; }
        public interface ILocationValidationResponseResultCorrectedErrors
        { }
        public class ErrorSyntaxGlobalLocationValidationResponseResultCorrectedErrors : ErrorSyntaxGlobal, ILocationValidationResponseResultCorrectedErrors
        {

        }
        public class ErrorSyntaxLocationLocationValidationResponseResultCorrectedErrors : ErrorSyntaxLocation, ILocationValidationResponseResultCorrectedErrors
        {

        }
        public class ErrorFormatGlobalLocationValidationResponseResultCorrectedErrors : ErrorFormatGlobal, ILocationValidationResponseResultCorrectedErrors
        {

        }
        public class ErrorValueGlobalLocationValidationResponseResultCorrectedErrors : ErrorValueGlobal, ILocationValidationResponseResultCorrectedErrors
        {

        }
        public interface ILocationValidationResponseResultCorrectedFixes
        { }
        public class FixFormatGlobalLocationValidationResponseResultCorrectedFixes : FixFormatGlobal, ILocationValidationResponseResultCorrectedFixes
        {

        }
        public class FixSyntaxGlobalLocationValidationResponseResultCorrectedFixes : FixSyntaxGlobal, ILocationValidationResponseResultCorrectedFixes
        {

        }
        public class FixSyntaxLocationLocationValidationResponseResultCorrectedFixes : FixSyntaxLocation, ILocationValidationResponseResultCorrectedFixes
        {

        }
        public class FixValueGlobalLocationValidationResponseResultCorrectedFixes : FixValueGlobal, ILocationValidationResponseResultCorrectedFixes
        {

        }
        public class FixValueLocationLocationValidationResponseResultCorrectedFixes : FixValueLocation, ILocationValidationResponseResultCorrectedFixes
        {

        }
    }
    public class LocationValidationResponseSuggestions
    {
        [JsonPropertyName("isValid")]
        public bool? IsValid { get; set; }
        [JsonPropertyName("data")]
        public required LocationData Data { get; init; }
        [JsonPropertyName("fixes")]
        public IEnumerable<ILocationValidationResponseSuggestionsFixes?>? Fixes { get; set; }
        [JsonPropertyName("errors")]
        public IEnumerable<ILocationValidationResponseSuggestionsErrors?>? Errors { get; set; }
        public interface ILocationValidationResponseSuggestionsFixes
        { }
        public class FixFormatGlobalLocationValidationResponseSuggestionsFixes : FixFormatGlobal, ILocationValidationResponseSuggestionsFixes
        {

        }
        public class FixSyntaxGlobalLocationValidationResponseSuggestionsFixes : FixSyntaxGlobal, ILocationValidationResponseSuggestionsFixes
        {

        }
        public class FixSyntaxLocationLocationValidationResponseSuggestionsFixes : FixSyntaxLocation, ILocationValidationResponseSuggestionsFixes
        {

        }
        public class FixValueGlobalLocationValidationResponseSuggestionsFixes : FixValueGlobal, ILocationValidationResponseSuggestionsFixes
        {

        }
        public class FixValueLocationLocationValidationResponseSuggestionsFixes : FixValueLocation, ILocationValidationResponseSuggestionsFixes
        {

        }
        public interface ILocationValidationResponseSuggestionsErrors
        { }
        public class ErrorSyntaxGlobalLocationValidationResponseSuggestionsErrors : ErrorSyntaxGlobal, ILocationValidationResponseSuggestionsErrors
        {

        }
        public class ErrorSyntaxLocationLocationValidationResponseSuggestionsErrors : ErrorSyntaxLocation, ILocationValidationResponseSuggestionsErrors
        {

        }
        public class ErrorFormatGlobalLocationValidationResponseSuggestionsErrors : ErrorFormatGlobal, ILocationValidationResponseSuggestionsErrors
        {

        }
        public class ErrorValueGlobalLocationValidationResponseSuggestionsErrors : ErrorValueGlobal, ILocationValidationResponseSuggestionsErrors
        {

        }
    }
}

