using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteClient
    {
        public decimal? ClientId { get; set; }
        public string? ClientName1 { get; set; }
        public string? PaymentCode { get; set; }
        public string? ClientCode { get; set; }
        public string? ClientName2 { get; set; }
        public string? ClientAddress1 { get; set; }
        public string? ClientAddress2 { get; set; }
        public string? ClientAddress3 { get; set; }
        public string? ClientAddress4 { get; set; }
        public string? ClientCity { get; set; }
        public string? ClientProvince { get; set; }
        public string? ClientCountryCode { get; set; }
        public string? ClientPostalcode { get; set; }
        public string? PhoneNum { get; set; }
        public string? FaxNum { get; set; }
        public string? TelexNum { get; set; }
        public decimal? ApCreditDays { get; set; }
        public decimal? ArCreditDays { get; set; }
        public string? BillingCode { get; set; }
        public string? AdxNum { get; set; }
        public string? WorkersCompFlag { get; set; }
        public string? WitholdingTaxFlag { get; set; }
        public string? GstRegNum { get; set; }
        public string? DunAndBradstreetRef { get; set; }
        public DateTime? HoldDate { get; set; }
        public decimal? TransactingClientId { get; set; }
        public decimal? ChangedToClientId { get; set; }
        public decimal? PayToClientId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? TermDate { get; set; }
        public string? TermUser { get; set; }
        public DateTime? LastUpdtDate { get; set; }
        public string? LastUpdtUser { get; set; }
        public decimal? OrgRefId { get; set; }
        public decimal? ArCreditLimitAmt { get; set; }
        public DateTime? CreditRevisedDate { get; set; }
        public string? SinSsn { get; set; }
        public string? RecFormatCode { get; set; }
        public string? SendFormatCode { get; set; }
        public string? SendMethodCode { get; set; }
        public string? UseJibeDoiEditsFlag { get; set; }
        public string? ClientLegalName { get; set; }
        public decimal? ChangedToAltAddressId { get; set; }
        public decimal? DiscountCreditDays { get; set; }
        public decimal? DiscountPct { get; set; }
        public decimal? SubsystemComponentId { get; set; }
        public string? ExternalLinkRef { get; set; }
        public string? AlternateClientIdReqd { get; set; }
        public string? ClientTypeCode { get; set; }
        public string? DefaultAddressShortName { get; set; }
        public decimal? DefaultBaAddressId { get; set; }
    }
}
