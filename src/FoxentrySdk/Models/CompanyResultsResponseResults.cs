
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
public class CompanyResultsResponseResults
{
    [JsonPropertyName("data")]
    [Newtonsoft.Json.JsonProperty("data")]
    public required CompanyResultsResponseResultsData Data { get; init; }
    public class CompanyResultsResponseResultsData
    {
        [JsonPropertyName("country")]
        [Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }
        [JsonPropertyName("name")]
        [Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }
        [JsonPropertyName("registrationNumber")]
        [Newtonsoft.Json.JsonProperty("registrationNumber")]
        public string? RegistrationNumber { get; set; }
        [JsonPropertyName("taxNumber")]
        [Newtonsoft.Json.JsonProperty("taxNumber")]
        public string? TaxNumber { get; set; }
        [JsonPropertyName("vatNumber")]
        [Newtonsoft.Json.JsonProperty("vatNumber")]
        public string? VatNumber { get; set; }
        [JsonPropertyName("vatNumberSpecial")]
        [Newtonsoft.Json.JsonProperty("vatNumberSpecial")]
        public string? VatNumberSpecial { get; set; }
        [JsonPropertyName("address")]
        [Newtonsoft.Json.JsonProperty("address")]
        public CompanyResultsResponseResultsDataAddress? Address { get; set; }
        [JsonPropertyName("addressOfficial")]
        [Newtonsoft.Json.JsonProperty("addressOfficial")]
        public CompanyResultsResponseResultsDataAddressOfficial? AddressOfficial { get; set; }
        [JsonPropertyName("nace")]
        [Newtonsoft.Json.JsonProperty("nace")]
        public IEnumerable<CompanyResultsResponseResultsDataNace?>? Nace { get; set; }
        [JsonPropertyName("databoxes")]
        [Newtonsoft.Json.JsonProperty("databoxes")]
        public IEnumerable<CompanyResultsResponseResultsDataDataboxes?>? Databoxes { get; set; }
        [JsonPropertyName("registrations")]
        [Newtonsoft.Json.JsonProperty("registrations")]
        public IEnumerable<CompanyResultsResponseResultsDataRegistrations?>? Registrations { get; set; }
        [JsonPropertyName("legalForm")]
        [Newtonsoft.Json.JsonProperty("legalForm")]
        public CompanyResultsResponseResultsDataLegalForm? LegalForm { get; set; }
        [JsonPropertyName("legalFormSpecific")]
        [Newtonsoft.Json.JsonProperty("legalFormSpecific")]
        public CompanyResultsResponseResultsDataLegalFormSpecific? LegalFormSpecific { get; set; }
        [JsonPropertyName("esa2010")]
        [Newtonsoft.Json.JsonProperty("esa2010")]
        public CompanyResultsResponseResultsDataEsa2010? Esa2010 { get; set; }
        [JsonPropertyName("dates")]
        [Newtonsoft.Json.JsonProperty("dates")]
        public CompanyResultsResponseResultsDataDates? Dates { get; set; }
        [JsonPropertyName("employees")]
        [Newtonsoft.Json.JsonProperty("employees")]
        public CompanyResultsResponseResultsDataEmployees? Employees { get; set; }
        [JsonPropertyName("insolvency")]
        [Newtonsoft.Json.JsonProperty("insolvency")]
        public CompanyResultsResponseResultsDataInsolvency? Insolvency { get; set; }
        [JsonPropertyName("businessPremises")]
        [Newtonsoft.Json.JsonProperty("businessPremises")]
        public IEnumerable<CompanyResultsResponseResultsDataBusinessPremises?>? BusinessPremises { get; set; }
        [JsonPropertyName("authority")]
        [Newtonsoft.Json.JsonProperty("authority")]
        public IEnumerable<CompanyResultsResponseResultsDataAuthority?>? Authority { get; set; }
        [JsonPropertyName("capital")]
        [Newtonsoft.Json.JsonProperty("capital")]
        public CompanyResultsResponseResultsDataCapital? Capital { get; set; }
        [JsonPropertyName("tradeLicences")]
        [Newtonsoft.Json.JsonProperty("tradeLicences")]
        public IEnumerable<CompanyResultsResponseResultsDataTradeLicences?>? TradeLicences { get; set; }
        [JsonPropertyName("vat")]
        [Newtonsoft.Json.JsonProperty("vat")]
        public CompanyResultsResponseResultsDataVat? Vat { get; set; }
        public class CompanyResultsResponseResultsDataAddressOfficial : LocationOficial
        {
        }/**
         * Address data
         */
        public class CompanyResultsResponseResultsDataAddress
        {
            [JsonPropertyName("data")]
            [Newtonsoft.Json.JsonProperty("data")]
            public LocationData? Data { get; set; }
        }
        public class CompanyResultsResponseResultsDataNace
        {
            [JsonPropertyName("code")]
            [Newtonsoft.Json.JsonProperty("code")]
            public string? Code { get; set; }
            [JsonPropertyName("name")]
            [Newtonsoft.Json.JsonProperty("name")]
            public string? Name { get; set; }
            [JsonPropertyName("isPrimary")]
            [Newtonsoft.Json.JsonProperty("isPrimary")]
            public bool? IsPrimary { get; set; }
        }
        public class CompanyResultsResponseResultsDataDataboxes
        {
            [JsonPropertyName("code")]
            [Newtonsoft.Json.JsonProperty("code")]
            public string? Code { get; set; }
            [JsonPropertyName("name")]
            [Newtonsoft.Json.JsonProperty("name")]
            public string? Name { get; set; }
            [JsonPropertyName("receivingMessages")]
            [Newtonsoft.Json.JsonProperty("receivingMessages")]
            public bool? ReceivingMessages { get; set; }
        }
        public class CompanyResultsResponseResultsDataRegistrations
        {
            [JsonPropertyName("type")]
            [Newtonsoft.Json.JsonProperty("type")]
            public CompanyResultsResponseResultsDataRegistrationsType? Type { get; set; }
            [JsonPropertyName("data")]
            [Newtonsoft.Json.JsonProperty("data")]
            public CompanyResultsResponseResultsDataRegistrationsData? Data { get; set; }
            /**
             * Type of registration.
             */
            [JsonConverter(typeof(StringValueEnumConverter<CompanyResultsResponseResultsDataRegistrationsType>))]
            [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
                [Newtonsoft.Json.JsonProperty("registrator")]
                public CompanyResultsResponseResultsDataRegistrationsDataRegistrator? Registrator { get; set; }
                [JsonPropertyName("reference")]
                [Newtonsoft.Json.JsonProperty("reference")]
                public string? Reference { get; set; }/**
                             * Information about registrator.
                             */
                public class CompanyResultsResponseResultsDataRegistrationsDataRegistrator
                {
                    [JsonPropertyName("name")]
                    [Newtonsoft.Json.JsonProperty("name")]
                    public string? Name { get; set; }
                    [JsonPropertyName("detail")]
                    [Newtonsoft.Json.JsonProperty("detail")]
                    public string? Detail { get; set; }
                }
            }
        }
        public class CompanyResultsResponseResultsDataLegalForm
        {
            [JsonPropertyName("code")]
            [Newtonsoft.Json.JsonProperty("code")]
            public double? Code { get; set; }
            [JsonPropertyName("name")]
            [Newtonsoft.Json.JsonProperty("name")]
            public string? Name { get; set; }
        }
        /**
         * Specific cases of legalForm.
         */
        public class CompanyResultsResponseResultsDataLegalFormSpecific
        {
            [JsonPropertyName("code")]
            [Newtonsoft.Json.JsonProperty("code")]
            public string? Code { get; set; }
            [JsonPropertyName("name")]
            [Newtonsoft.Json.JsonProperty("name")]
            public string? Name { get; set; }
        }
        /**
         * The European System of National and Regional Accounts.
         */
        public class CompanyResultsResponseResultsDataEsa2010
        {
            [JsonPropertyName("code")]
            [Newtonsoft.Json.JsonProperty("code")]
            public double? Code { get; set; }
            [JsonPropertyName("name")]
            [Newtonsoft.Json.JsonProperty("name")]
            public string? Name { get; set; }
        }
        /**
         * Important dates associated with company.
         */
        public class CompanyResultsResponseResultsDataDates
        {
            [JsonPropertyName("created")]
            [Newtonsoft.Json.JsonProperty("created")]
            public string? Created { get; set; }
            [JsonPropertyName("terminated")]
            [Newtonsoft.Json.JsonProperty("terminated")]
            public string? Terminated { get; set; }
        }
        /**
         * Employees information.
         */
        public class CompanyResultsResponseResultsDataEmployees
        {
            [JsonPropertyName("count")]
            [Newtonsoft.Json.JsonProperty("count")]
            public double? Count { get; set; }
            [JsonPropertyName("category")]
            [Newtonsoft.Json.JsonProperty("category")]
            public string? Category { get; set; }
        }
        /**
         * Company insolvency status with history
         */
        public class CompanyResultsResponseResultsDataInsolvency
        {
            [JsonPropertyName("history")]
            [Newtonsoft.Json.JsonProperty("history")]
            public IEnumerable<CompanyResultsResponseResultsDataInsolvencyHistory?>? History { get; set; }
            public class CompanyResultsResponseResultsDataInsolvencyHistory
            {
                [JsonPropertyName("reference")]
                [Newtonsoft.Json.JsonProperty("reference")]
                public string? Reference { get; set; }
                [JsonPropertyName("dateFrom")]
                [Newtonsoft.Json.JsonProperty("dateFrom")]
                public string? DateFrom { get; set; }
                [JsonPropertyName("dateTo")]
                [Newtonsoft.Json.JsonProperty("dateTo")]
                public string? DateTo { get; set; }
                [JsonPropertyName("court")]
                [Newtonsoft.Json.JsonProperty("court")]
                public CompanyResultsResponseResultsDataInsolvencyHistoryCourt? Court { get; set; }
                [JsonPropertyName("status")]
                [Newtonsoft.Json.JsonProperty("status")]
                public string? Status { get; set; }
                [JsonPropertyName("detailUrl")]
                [Newtonsoft.Json.JsonProperty("detailUrl")]
                public string? DetailUrl { get; set; }
                public class CompanyResultsResponseResultsDataInsolvencyHistoryCourt
                {
                    [JsonPropertyName("name")]
                    [Newtonsoft.Json.JsonProperty("name")]
                    public string? Name { get; set; }
                }
            }
        }
        public class CompanyResultsResponseResultsDataBusinessPremises
        {
            [JsonPropertyName("label")]
            [Newtonsoft.Json.JsonProperty("label")]
            public string? Label { get; set; }
            [JsonPropertyName("address")]
            [Newtonsoft.Json.JsonProperty("address")]
            public CompanyResultsResponseResultsDataBusinessPremisesAddress? Address { get; set; }
            [JsonPropertyName("activitySubjects")]
            [Newtonsoft.Json.JsonProperty("activitySubjects")]
            public string? ActivitySubjects { get; set; }
            public class CompanyResultsResponseResultsDataBusinessPremisesAddress
            {
                [JsonPropertyName("full")]
                [Newtonsoft.Json.JsonProperty("full")]
                public string? Full { get; set; }
            }
        }
        public class CompanyResultsResponseResultsDataAuthority
        {
            [JsonPropertyName("name")]
            [Newtonsoft.Json.JsonProperty("name")]
            public string? Name { get; set; }
            [JsonPropertyName("members")]
            [Newtonsoft.Json.JsonProperty("members")]
            public IEnumerable<CompanyResultsResponseResultsDataAuthorityMembers?>? Members { get; set; }
            [JsonPropertyName("decisions")]
            [Newtonsoft.Json.JsonProperty("decisions")]
            public IEnumerable<string?>? Decisions { get; set; }
            public class CompanyResultsResponseResultsDataAuthorityMembers
            {
                [JsonPropertyName("name")]
                [Newtonsoft.Json.JsonProperty("name")]
                public string? Name { get; set; }
                [JsonPropertyName("address")]
                [Newtonsoft.Json.JsonProperty("address")]
                public CompanyResultsResponseResultsDataAuthorityMembersAddress? Address { get; set; }
                [JsonPropertyName("addressOficial")]
                [Newtonsoft.Json.JsonProperty("addressOficial")]
                public LocationOficial? AddressOficial { get; set; }
                [JsonPropertyName("function")]
                [Newtonsoft.Json.JsonProperty("function")]
                public string? Function { get; set; }
                [JsonPropertyName("birthDate")]
                [Newtonsoft.Json.JsonProperty("birthDate")]
                public string? BirthDate { get; set; }
                [JsonPropertyName("registrationNumber")]
                [Newtonsoft.Json.JsonProperty("registrationNumber")]
                public double? RegistrationNumber { get; set; }
                public class CompanyResultsResponseResultsDataAuthorityMembersAddress
                {
                    [JsonPropertyName("data")]
                    [Newtonsoft.Json.JsonProperty("data")]
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
            [Newtonsoft.Json.JsonProperty("value")]
            public CompanyResultsResponseResultsDataCapitalValue? Value { get; set; }
            [JsonPropertyName("shareholders")]
            [Newtonsoft.Json.JsonProperty("shareholders")]
            public IEnumerable<CompanyResultsResponseResultsDataCapitalShareholders?>? Shareholders { get; set; }
            [JsonPropertyName("stocks")]
            [Newtonsoft.Json.JsonProperty("stocks")]
            public IEnumerable<string?>? Stocks { get; set; }
            public class CompanyResultsResponseResultsDataCapitalValue
            {
                [JsonPropertyName("amount")]
                [Newtonsoft.Json.JsonProperty("amount")]
                public string? Amount { get; set; }
                [JsonPropertyName("currency")]
                [Newtonsoft.Json.JsonProperty("currency")]
                public string? Currency { get; set; }
            }
            public class CompanyResultsResponseResultsDataCapitalShareholders
            {
                [JsonPropertyName("shareholder")]
                [Newtonsoft.Json.JsonProperty("shareholder")]
                public string? Shareholder { get; set; }
                [JsonPropertyName("share")]
                [Newtonsoft.Json.JsonProperty("share")]
                public CompanyResultsResponseResultsDataCapitalShareholdersShare? Share { get; set; }
                [JsonPropertyName("info")]
                [Newtonsoft.Json.JsonProperty("info")]
                public IEnumerable<string?>? Info { get; set; }
                public class CompanyResultsResponseResultsDataCapitalShareholdersShare
                {
                    [JsonPropertyName("amount")]
                    [Newtonsoft.Json.JsonProperty("amount")]
                    public string? Amount { get; set; }
                    [JsonPropertyName("currency")]
                    [Newtonsoft.Json.JsonProperty("currency")]
                    public string? Currency { get; set; }
                    [JsonPropertyName("percent")]
                    [Newtonsoft.Json.JsonProperty("percent")]
                    public string? Percent { get; set; }
                    [JsonPropertyName("percentPaid")]
                    [Newtonsoft.Json.JsonProperty("percentPaid")]
                    public string? PercentPaid { get; set; }
                }
            }
        }
        public class CompanyResultsResponseResultsDataTradeLicences
        {
            [JsonPropertyName("type")]
            [Newtonsoft.Json.JsonProperty("type")]
            public string? Type { get; set; }
            [JsonPropertyName("name")]
            [Newtonsoft.Json.JsonProperty("name")]
            public string? Name { get; set; }
            [JsonPropertyName("valid")]
            [Newtonsoft.Json.JsonProperty("valid")]
            public CompanyResultsResponseResultsDataTradeLicencesValid? Valid { get; set; }
            [JsonPropertyName("interrupted")]
            [Newtonsoft.Json.JsonProperty("interrupted")]
            public CompanyResultsResponseResultsDataTradeLicencesInterrupted? Interrupted { get; set; }
            [JsonPropertyName("responsiblePerson")]
            [Newtonsoft.Json.JsonProperty("responsiblePerson")]
            public string? ResponsiblePerson { get; set; }
            [JsonPropertyName("activitySubject")]
            [Newtonsoft.Json.JsonProperty("activitySubject")]
            public IEnumerable<string?>? ActivitySubject { get; set; }
            public class CompanyResultsResponseResultsDataTradeLicencesValid
            {
                [JsonPropertyName("from")]
                [Newtonsoft.Json.JsonProperty("from")]
                public string? From { get; set; }
                [JsonPropertyName("fromText")]
                [Newtonsoft.Json.JsonProperty("fromText")]
                public string? FromText { get; set; }
                [JsonPropertyName("to")]
                [Newtonsoft.Json.JsonProperty("to")]
                public string? To { get; set; }
                [JsonPropertyName("toText")]
                [Newtonsoft.Json.JsonProperty("toText")]
                public string? ToText { get; set; }
            }
            /**
             * Dates of interuption.
             */
            public class CompanyResultsResponseResultsDataTradeLicencesInterrupted
            {
                [JsonPropertyName("from")]
                [Newtonsoft.Json.JsonProperty("from")]
                public string? From { get; set; }
                [JsonPropertyName("to")]
                [Newtonsoft.Json.JsonProperty("to")]
                public string? To { get; set; }
            }
        }
        /**
         * Vat payer information.
         */
        public class CompanyResultsResponseResultsDataVat
        {
            [JsonPropertyName("status")]
            [Newtonsoft.Json.JsonProperty("status")]
            public CompanyResultsResponseResultsDataVatStatus? Status { get; set; }
            [JsonPropertyName("reliability")]
            [Newtonsoft.Json.JsonProperty("reliability")]
            public CompanyResultsResponseResultsDataVatReliability? Reliability { get; set; }
            [JsonPropertyName("bankAccounts")]
            [Newtonsoft.Json.JsonProperty("bankAccounts")]
            public IEnumerable<CompanyResultsResponseResultsDataVatBankAccounts?>? BankAccounts { get; set; }
            [JsonPropertyName("history")]
            [Newtonsoft.Json.JsonProperty("history")]
            public IEnumerable<CompanyResultsResponseResultsDataVatHistory?>? History { get; set; }
            /**
             * Vat current status. Payer, non payer and subject. Subject means the company is a VAT payer only for non domestic transactions (identifikovaná osoba).
             */
            [JsonConverter(typeof(StringValueEnumConverter<CompanyResultsResponseResultsDataVatStatus>))]
            [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
                [Newtonsoft.Json.JsonProperty("reliable")]
                public bool? Reliable { get; set; }
                [JsonPropertyName("unreliableFrom")]
                [Newtonsoft.Json.JsonProperty("unreliableFrom")]
                public string? UnreliableFrom { get; set; }
            }
            public class CompanyResultsResponseResultsDataVatBankAccounts
            {
                [JsonPropertyName("number")]
                [Newtonsoft.Json.JsonProperty("number")]
                public string? Number { get; set; }
            }
            public class CompanyResultsResponseResultsDataVatHistory
            {
                [JsonPropertyName("vatNumber")]
                [Newtonsoft.Json.JsonProperty("vatNumber")]
                public string? VatNumber { get; set; }
                [JsonPropertyName("registrationType")]
                [Newtonsoft.Json.JsonProperty("registrationType")]
                public string? RegistrationType { get; set; }
                [JsonPropertyName("validFrom")]
                [Newtonsoft.Json.JsonProperty("validFrom")]
                public string? ValidFrom { get; set; }
                [JsonPropertyName("validTo")]
                [Newtonsoft.Json.JsonProperty("validTo")]
                public string? ValidTo { get; set; }
                [JsonPropertyName("isGroupRegistration")]
                [Newtonsoft.Json.JsonProperty("isGroupRegistration")]
                public bool? IsGroupRegistration { get; set; }
            }
        }
    }
}

