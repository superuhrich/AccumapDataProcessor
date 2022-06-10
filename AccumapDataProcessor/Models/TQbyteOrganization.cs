using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteOrganization
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public decimal? OrgId { get; set; }
        public string? OrgTypeCode { get; set; }
        public string? OrgName { get; set; }
        public string? OpCurrCode { get; set; }
        public string? ReportingCurrCode { get; set; }
        public DateTime? LastUpdtDate { get; set; }
        public string? LastUpdtUser { get; set; }
        public decimal? FiscalYearEnd { get; set; }
        public string? TaxCode { get; set; }
        public string? GstRegNum { get; set; }
        public DateTime? TermDate { get; set; }
        public string? TermUser { get; set; }
        public string? ProfileGroupCode { get; set; }
        public string? NonStandardVolumeEntryFlag { get; set; }
        public string? SelfSustainingFlag { get; set; }
        public string? AdminCcNum { get; set; }
        public string? MultiTierJibFlag { get; set; }
        public string? CashCallDrawDownFlag { get; set; }
        public decimal? JibInvcOrgId { get; set; }
        public string? CountryForTaxation { get; set; }
    }
}
