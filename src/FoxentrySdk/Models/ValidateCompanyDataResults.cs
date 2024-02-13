
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
public class ValidateCompanyDataResults
{
    [JsonPropertyName("result")]
    public required ValidateCompanyDataResultsResult Result { get; init; }
    [JsonPropertyName("resultCorrected")]
    public ValidateCompanyDataResultsResultCorrected? ResultCorrected { get; set; }
    [JsonPropertyName("suggestions")]
    public required IEnumerable<ValidateCompanyDataResultCorrected> Suggestions { get; init; }
    /**
     * Evaluation of the sent query.
     */
    public class ValidateCompanyDataResultsResult : CompanyResultsResponseResults
    {
        [JsonPropertyName("isValid")]
        public bool? IsValid { get; set; }
        [JsonPropertyName("proposal")]
        public ValidateCompanyDataResultsResultProposal? Proposal { get; set; }
        [JsonPropertyName("errors")]
        public IEnumerable<IValidateCompanyDataResultsResultErrors?>? Errors { get; set; }

        public interface IValidateCompanyDataResultsResultErrors
        { }
        public class ErrorSyntaxGlobalValidateCompanyDataResultsResultErrors : ErrorSyntaxGlobal, IValidateCompanyDataResultsResultErrors
        {

        }
        public class ErrorSyntaxCompanyValidateCompanyDataResultsResultErrors : ErrorSyntaxCompany, IValidateCompanyDataResultsResultErrors
        {

        }
        public class ErrorFormatGlobalValidateCompanyDataResultsResultErrors : ErrorFormatGlobal, IValidateCompanyDataResultsResultErrors
        {

        }
        public class ErrorValueGlobalValidateCompanyDataResultsResultErrors : ErrorValueGlobal, IValidateCompanyDataResultsResultErrors
        {

        }
        /**
         * Proposed solution by Foxentry how you should process the response in your form or application.
         */
        [JsonConverter(typeof(StringValueEnumConverter<ValidateCompanyDataResultsResultProposal>))]
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
        public bool? IsValid { get; set; }
        [JsonPropertyName("errors")]
        public IEnumerable<IValidateCompanyDataResultsResultCorrectedErrors?>? Errors { get; set; }
        [JsonPropertyName("fixes")]
        public IEnumerable<IValidateCompanyDataResultsResultCorrectedFixes?>? Fixes { get; set; }

        public interface IValidateCompanyDataResultsResultCorrectedErrors
        { }
        public class ErrorSyntaxGlobalValidateCompanyDataResultsResultCorrectedErrors : ErrorSyntaxGlobal, IValidateCompanyDataResultsResultCorrectedErrors
        {

        }
        public class ErrorSyntaxCompanyValidateCompanyDataResultsResultCorrectedErrors : ErrorSyntaxCompany, IValidateCompanyDataResultsResultCorrectedErrors
        {

        }
        public class ErrorFormatGlobalValidateCompanyDataResultsResultCorrectedErrors : ErrorFormatGlobal, IValidateCompanyDataResultsResultCorrectedErrors
        {

        }
        public class ErrorValueGlobalValidateCompanyDataResultsResultCorrectedErrors : ErrorValueGlobal, IValidateCompanyDataResultsResultCorrectedErrors
        {

        }
        public interface IValidateCompanyDataResultsResultCorrectedFixes
        { }
        public class FixFormatGlobalValidateCompanyDataResultsResultCorrectedFixes : FixFormatGlobal, IValidateCompanyDataResultsResultCorrectedFixes
        {

        }
        public class FixSyntaxGlobalValidateCompanyDataResultsResultCorrectedFixes : FixSyntaxGlobal, IValidateCompanyDataResultsResultCorrectedFixes
        {

        }
        public class FixSyntaxCompanyValidateCompanyDataResultsResultCorrectedFixes : FixSyntaxCompany, IValidateCompanyDataResultsResultCorrectedFixes
        {

        }
        public class FixValueGlobalValidateCompanyDataResultsResultCorrectedFixes : FixValueGlobal, IValidateCompanyDataResultsResultCorrectedFixes
        {

        }
    }/**
         * Alternatives suggested for the sent query.
         */
    public class ValidateCompanyDataResultsSuggestions { }
}

