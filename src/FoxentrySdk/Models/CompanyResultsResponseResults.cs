
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
public class CompanyResultsResponseResults
{
    [JsonPropertyName("data")]
    public required CompanyResultsResponseResultsData Data { get; init; }
    public class CompanyResultsResponseResultsData
    {
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("registrationNumber")]
        public string? RegistrationNumber { get; set; }
        [JsonPropertyName("taxNumber")]
        public string? TaxNumber { get; set; }
        [JsonPropertyName("vatNumber")]
        public string? VatNumber { get; set; }
        [JsonPropertyName("vatNumberSpecial")]
        public string? VatNumberSpecial { get; set; }
        [JsonPropertyName("address")]
        public CompanyResultsResponseResultsDataAddress? Address { get; set; }
        [JsonPropertyName("addressOfficial")]
        public CompanyResultsResponseResultsDataAddressOfficial? AddressOfficial { get; set; }
        [JsonPropertyName("nace")]
        public IEnumerable<CompanyResultsResponseResultsDataNace?>? Nace { get; set; }
        [JsonPropertyName("databoxes")]
        public IEnumerable<CompanyResultsResponseResultsDataDataboxes?>? Databoxes { get; set; }
        [JsonPropertyName("registrations")]
        public IEnumerable<CompanyResultsResponseResultsDataRegistrations?>? Registrations { get; set; }
        [JsonPropertyName("legalForm")]
        public CompanyResultsResponseResultsDataLegalForm? LegalForm { get; set; }
        [JsonPropertyName("legalFormSpecific")]
        public CompanyResultsResponseResultsDataLegalFormSpecific? LegalFormSpecific { get; set; }
        [JsonPropertyName("esa2010")]
        public CompanyResultsResponseResultsDataEsa2010? Esa2010 { get; set; }
        [JsonPropertyName("dates")]
        public CompanyResultsResponseResultsDataDates? Dates { get; set; }
        [JsonPropertyName("employees")]
        public CompanyResultsResponseResultsDataEmployees? Employees { get; set; }
        [JsonPropertyName("insolvency")]
        public CompanyResultsResponseResultsDataInsolvency? Insolvency { get; set; }
        [JsonPropertyName("businessPremises")]
        public IEnumerable<CompanyResultsResponseResultsDataBusinessPremises?>? BusinessPremises { get; set; }
        [JsonPropertyName("authority")]
        public IEnumerable<CompanyResultsResponseResultsDataAuthority?>? Authority { get; set; }
        [JsonPropertyName("capital")]
        public CompanyResultsResponseResultsDataCapital? Capital { get; set; }
        [JsonPropertyName("tradeLicences")]
        public IEnumerable<CompanyResultsResponseResultsDataTradeLicences?>? TradeLicences { get; set; }
        [JsonPropertyName("vat")]
        public CompanyResultsResponseResultsDataVat? Vat { get; set; }
        public class CompanyResultsResponseResultsDataAddressOfficial : LocationOficial
        {
        }/**
         * Address data
         */
        public class CompanyResultsResponseResultsDataAddress
        {
            [JsonPropertyName("data")]
            public LocationData? Data { get; set; }
        }
        public class CompanyResultsResponseResultsDataNace
        {
            [JsonPropertyName("code")]
            public string? Code { get; set; }
            [JsonPropertyName("name")]
            public string? Name { get; set; }
            [JsonPropertyName("isPrimary")]
            public bool? IsPrimary { get; set; }
        }
        public class CompanyResultsResponseResultsDataDataboxes
        {
            [JsonPropertyName("code")]
            public string? Code { get; set; }
            [JsonPropertyName("name")]
            public string? Name { get; set; }
            [JsonPropertyName("receivingMessages")]
            public bool? ReceivingMessages { get; set; }
        }
        public class CompanyResultsResponseResultsDataRegistrations
        {
            [JsonPropertyName("type")]
            public CompanyResultsResponseResultsDataRegistrationsType? Type { get; set; }
            [JsonPropertyName("data")]
            public CompanyResultsResponseResultsDataRegistrationsData? Data { get; set; }
            /**
             * Type of registration.
             */
            [JsonConverter(typeof(StringValueEnumConverter<CompanyResultsResponseResultsDataRegistrationsType>))]
            public enum CompanyResultsResponseResultsDataRegistrationsType
            {
                [StringValue("businessRegister")]
                BUSINESS_REGISTER,
                [StringValue("vatRegister")]
                VAT_REGISTER
            }
            public class CompanyResultsResponseResultsDataRegistrationsData
            {
                [JsonPropertyName("registrator")]
                public CompanyResultsResponseResultsDataRegistrationsDataRegistrator? Registrator { get; set; }
                [JsonPropertyName("reference")]
                public string? Reference { get; set; }/**
                             * Information about registrator.
                             */
                public class CompanyResultsResponseResultsDataRegistrationsDataRegistrator
                {
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }
                    [JsonPropertyName("detail")]
                    public string? Detail { get; set; }
                }
            }
        }
        public class CompanyResultsResponseResultsDataLegalForm
        {
            [JsonPropertyName("code")]
            public double? Code { get; set; }
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }
        /**
         * Specific cases of legalForm.
         */
        public class CompanyResultsResponseResultsDataLegalFormSpecific
        {
            [JsonPropertyName("code")]
            public string? Code { get; set; }
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }
        /**
         * The European System of National and Regional Accounts.
         */
        public class CompanyResultsResponseResultsDataEsa2010
        {
            [JsonPropertyName("code")]
            public double? Code { get; set; }
            [JsonPropertyName("name")]
            public string? Name { get; set; }
        }
        /**
         * Important dates associated with company.
         */
        public class CompanyResultsResponseResultsDataDates
        {
            [JsonPropertyName("created")]
            public string? Created { get; set; }
            [JsonPropertyName("terminated")]
            public string? Terminated { get; set; }
        }
        /**
         * Employees information.
         */
        public class CompanyResultsResponseResultsDataEmployees
        {
            [JsonPropertyName("count")]
            public double? Count { get; set; }
            [JsonPropertyName("category")]
            public string? Category { get; set; }
        }
        /**
         * Company insolvency status with history
         */
        public class CompanyResultsResponseResultsDataInsolvency
        {
            [JsonPropertyName("history")]
            public IEnumerable<CompanyResultsResponseResultsDataInsolvencyHistory?>? History { get; set; }
            public class CompanyResultsResponseResultsDataInsolvencyHistory
            {
                [JsonPropertyName("reference")]
                public string? Reference { get; set; }
                [JsonPropertyName("dateFrom")]
                public string? DateFrom { get; set; }
                [JsonPropertyName("dateTo")]
                public string? DateTo { get; set; }
                [JsonPropertyName("court")]
                public CompanyResultsResponseResultsDataInsolvencyHistoryCourt? Court { get; set; }
                [JsonPropertyName("status")]
                public string? Status { get; set; }
                [JsonPropertyName("detailUrl")]
                public string? DetailUrl { get; set; }
                public class CompanyResultsResponseResultsDataInsolvencyHistoryCourt
                {
                    [JsonPropertyName("name")]
                    public string? Name { get; set; }
                }
            }
        }
        public class CompanyResultsResponseResultsDataBusinessPremises
        {
            [JsonPropertyName("label")]
            public string? Label { get; set; }
            [JsonPropertyName("address")]
            public CompanyResultsResponseResultsDataBusinessPremisesAddress? Address { get; set; }
            [JsonPropertyName("activitySubjects")]
            public string? ActivitySubjects { get; set; }
            public class CompanyResultsResponseResultsDataBusinessPremisesAddress
            {
                [JsonPropertyName("full")]
                public string? Full { get; set; }
            }
        }
        public class CompanyResultsResponseResultsDataAuthority
        {
            [JsonPropertyName("name")]
            public string? Name { get; set; }
            [JsonPropertyName("members")]
            public IEnumerable<CompanyResultsResponseResultsDataAuthorityMembers?>? Members { get; set; }
            [JsonPropertyName("decisions")]
            public IEnumerable<string?>? Decisions { get; set; }
            public class CompanyResultsResponseResultsDataAuthorityMembers
            {
                [JsonPropertyName("name")]
                public string? Name { get; set; }
                [JsonPropertyName("address")]
                public CompanyResultsResponseResultsDataAuthorityMembersAddress? Address { get; set; }
                [JsonPropertyName("addressOficial")]
                public LocationOficial? AddressOficial { get; set; }
                [JsonPropertyName("function")]
                public string? Function { get; set; }
                [JsonPropertyName("birthDate")]
                public string? BirthDate { get; set; }
                [JsonPropertyName("registrationNumber")]
                public double? RegistrationNumber { get; set; }
                public class CompanyResultsResponseResultsDataAuthorityMembersAddress
                {
                    [JsonPropertyName("data")]
                    public LocationData? Data { get; set; }
                }
            }
        }
        /**
         * Company's funding
         */
        public class CompanyResultsResponseResultsDataCapital
        {
            [JsonPropertyName("value")]
            public CompanyResultsResponseResultsDataCapitalValue? Value { get; set; }
            [JsonPropertyName("shareholders")]
            public IEnumerable<CompanyResultsResponseResultsDataCapitalShareholders?>? Shareholders { get; set; }
            [JsonPropertyName("stocks")]
            public IEnumerable<string?>? Stocks { get; set; }
            public class CompanyResultsResponseResultsDataCapitalValue
            {
                [JsonPropertyName("amount")]
                public string? Amount { get; set; }
                [JsonPropertyName("currency")]
                public string? Currency { get; set; }
            }
            public class CompanyResultsResponseResultsDataCapitalShareholders
            {
                [JsonPropertyName("shareholder")]
                public string? Shareholder { get; set; }
                [JsonPropertyName("share")]
                public CompanyResultsResponseResultsDataCapitalShareholdersShare? Share { get; set; }
                [JsonPropertyName("info")]
                public IEnumerable<string?>? Info { get; set; }
                public class CompanyResultsResponseResultsDataCapitalShareholdersShare
                {
                    [JsonPropertyName("amount")]
                    public string? Amount { get; set; }
                    [JsonPropertyName("currency")]
                    public string? Currency { get; set; }
                    [JsonPropertyName("percent")]
                    public string? Percent { get; set; }
                    [JsonPropertyName("percentPaid")]
                    public string? PercentPaid { get; set; }
                }
            }
        }
        public class CompanyResultsResponseResultsDataTradeLicences
        {
            [JsonPropertyName("type")]
            public string? Type { get; set; }
            [JsonPropertyName("name")]
            public string? Name { get; set; }
            [JsonPropertyName("valid")]
            public CompanyResultsResponseResultsDataTradeLicencesValid? Valid { get; set; }
            [JsonPropertyName("interrupted")]
            public CompanyResultsResponseResultsDataTradeLicencesInterrupted? Interrupted { get; set; }
            [JsonPropertyName("responsiblePerson")]
            public string? ResponsiblePerson { get; set; }
            [JsonPropertyName("activitySubject")]
            public IEnumerable<string?>? ActivitySubject { get; set; }
            public class CompanyResultsResponseResultsDataTradeLicencesValid
            {
                [JsonPropertyName("from")]
                public string? From { get; set; }
                [JsonPropertyName("fromText")]
                public string? FromText { get; set; }
                [JsonPropertyName("to")]
                public string? To { get; set; }
                [JsonPropertyName("toText")]
                public string? ToText { get; set; }
            }
            /**
             * Dates of interuption.
             */
            public class CompanyResultsResponseResultsDataTradeLicencesInterrupted
            {
                [JsonPropertyName("from")]
                public string? From { get; set; }
                [JsonPropertyName("to")]
                public string? To { get; set; }
            }
        }
        /**
         * Vat payer information.
         */
        public class CompanyResultsResponseResultsDataVat
        {
            [JsonPropertyName("status")]
            public CompanyResultsResponseResultsDataVatStatus? Status { get; set; }
            [JsonPropertyName("reliability")]
            public CompanyResultsResponseResultsDataVatReliability? Reliability { get; set; }
            [JsonPropertyName("bankAccounts")]
            public IEnumerable<CompanyResultsResponseResultsDataVatBankAccounts?>? BankAccounts { get; set; }
            [JsonPropertyName("history")]
            public IEnumerable<CompanyResultsResponseResultsDataVatHistory?>? History { get; set; }
            /**
             * Vat current status. Payer, non payer and subject. Subject means the company is a VAT payer only for non domestic transactions (identifikovaná osoba).
             */
            [JsonConverter(typeof(StringValueEnumConverter<CompanyResultsResponseResultsDataVatStatus>))]
            public enum CompanyResultsResponseResultsDataVatStatus
            {
                [StringValue("payer")]
                PAYER,
                [StringValue("nonpayer")]
                NONPAYER,
                [StringValue("subject")]
                SUBJECT
            }/**
                                                                             * Reliability of the VAT payer.
                                                                             */
            public class CompanyResultsResponseResultsDataVatReliability
            {
                [JsonPropertyName("reliable")]
                public bool? Reliable { get; set; }
                [JsonPropertyName("unreliableFrom")]
                public string? UnreliableFrom { get; set; }
            }
            public class CompanyResultsResponseResultsDataVatBankAccounts
            {
                [JsonPropertyName("number")]
                public string? Number { get; set; }
            }
            public class CompanyResultsResponseResultsDataVatHistory
            {
                [JsonPropertyName("vatNumber")]
                public string? VatNumber { get; set; }
                [JsonPropertyName("registrationType")]
                public string? RegistrationType { get; set; }
                [JsonPropertyName("validFrom")]
                public string? ValidFrom { get; set; }
                [JsonPropertyName("validTo")]
                public string? ValidTo { get; set; }
                [JsonPropertyName("isGroupRegistration")]
                public bool? IsGroupRegistration { get; set; }
            }
        }
    }
}

