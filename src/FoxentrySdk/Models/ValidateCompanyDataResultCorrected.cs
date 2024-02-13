
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
public class ValidateCompanyDataResultCorrected : CompanyResultsResponseResults
{
    [JsonPropertyName("isValid")]
    public required bool IsValid { get; init; }
    [JsonPropertyName("errors")]
    public required IEnumerable<IValidateCompanyDataResultCorrectedErrors?> Errors { get; init; }
    [JsonPropertyName("fixes")]
    public required IEnumerable<IValidateCompanyDataResultCorrectedFixes?> Fixes { get; init; }

    public interface IValidateCompanyDataResultCorrectedErrors
    { }
    public class ErrorSyntaxGlobalValidateCompanyDataResultCorrectedErrors : ErrorSyntaxGlobal, IValidateCompanyDataResultCorrectedErrors
    {

    }
    public class ErrorSyntaxCompanyValidateCompanyDataResultCorrectedErrors : ErrorSyntaxCompany, IValidateCompanyDataResultCorrectedErrors
    {

    }
    public class ErrorFormatGlobalValidateCompanyDataResultCorrectedErrors : ErrorFormatGlobal, IValidateCompanyDataResultCorrectedErrors
    {

    }
    public class ErrorValueGlobalValidateCompanyDataResultCorrectedErrors : ErrorValueGlobal, IValidateCompanyDataResultCorrectedErrors
    {

    }
    public interface IValidateCompanyDataResultCorrectedFixes
    { }
    public class FixFormatGlobalValidateCompanyDataResultCorrectedFixes : FixFormatGlobal, IValidateCompanyDataResultCorrectedFixes
    {

    }
    public class FixSyntaxGlobalValidateCompanyDataResultCorrectedFixes : FixSyntaxGlobal, IValidateCompanyDataResultCorrectedFixes
    {

    }
    public class FixSyntaxCompanyValidateCompanyDataResultCorrectedFixes : FixSyntaxCompany, IValidateCompanyDataResultCorrectedFixes
    {

    }
    public class FixValueGlobalValidateCompanyDataResultCorrectedFixes : FixValueGlobal, IValidateCompanyDataResultCorrectedFixes
    {

    }
}
