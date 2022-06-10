using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgQbyteDeletedLineItemsIncr
    {
        public string? AuditAction { get; set; }
        public string? AuditUser { get; set; }
        public string? AuditTimestamp { get; set; }
        public string? AuditProgram { get; set; }
        public decimal? LiId { get; set; }
        public decimal? VoucherId { get; set; }
        public string? LiOriginCode { get; set; }
        public string? MajorAcct { get; set; }
        public string? MinorAcct { get; set; }
        public decimal? LiAmt { get; set; }
        public string? GlSubCode { get; set; }
        public string? AfeItemNum { get; set; }
        public decimal? DestOrgId { get; set; }
        public string? LiTypeCode { get; set; }
        public decimal? ReportingCurrAmt { get; set; }
        public decimal? GstAmt { get; set; }
        public decimal? GstFactor { get; set; }
        public decimal? OrgRepCurrAmt { get; set; }
        public decimal? OrgRepCurrTranslationRate { get; set; }
        public decimal? OrgRepCurrGrossUpAmt { get; set; }
        public decimal? LiVol { get; set; }
        public decimal? TranslationRate { get; set; }
        public DateTime? ActvyPerDate { get; set; }
        public DateTime? AllocDate { get; set; }
        public DateTime? BilledDate { get; set; }
        public string? AfeNum { get; set; }
        public string? ContinuityCode { get; set; }
        public decimal? CashTxId { get; set; }
        public string? CcNum { get; set; }
        public decimal? SrcInvcId { get; set; }
        public decimal? ResultInvcId { get; set; }
        public decimal? OriginalLiId { get; set; }
        public decimal? SrcAgrId { get; set; }
        public string? SrcAgrTypeCode { get; set; }
        public decimal? GovernAgrId { get; set; }
        public string? GovernAgrTypeCode { get; set; }
        public decimal? GrossUpAmt { get; set; }
        public decimal? GrossUpVol { get; set; }
        public string? LiRem { get; set; }
        public decimal? EtId { get; set; }
        public decimal? ReportingCurrGrossUpAmt { get; set; }
        public decimal? LiAsEnteredVol { get; set; }
        public decimal? AllocLiId { get; set; }
        public decimal? PreTaxAmt { get; set; }
        public decimal? ReportingCurrGstAmt { get; set; }
        public decimal? LiEnergyAmount { get; set; }
        public string? WarehouseHandlingFlag { get; set; }
        public decimal? GrossUpEnergyVal { get; set; }
        public string? JibReversedFlag { get; set; }
        public decimal? DiscountAmt { get; set; }
        public string? MiscellaneousIncomeCategory { get; set; }
        public string? GovernAgrOverrideFlag { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateUser { get; set; }
        public string? AllocationReversedFlag { get; set; }
    }
}
