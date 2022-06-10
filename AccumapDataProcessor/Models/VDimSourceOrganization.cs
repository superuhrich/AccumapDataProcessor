using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimSourceOrganization
    {
        public int? OrganizationId { get; set; }
        public string? OrganizationTypeCode { get; set; }
        public string OrganizationName { get; set; } = null!;
        public string? OperatingCurrencyCode { get; set; }
        public string? ReportingCurrencyCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateUser { get; set; }
        public decimal? FiscalYearEnd { get; set; }
        public string? TaxCode { get; set; }
        public string? GstRegistrationNumber { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string? TerminationUser { get; set; }
        public string? ProfileGroupCode { get; set; }
        public string? NonStandardVolumeEntryFlag { get; set; }
        public string? SelfSustainingFlag { get; set; }
        public string? AdminCostCentre { get; set; }
        public string? MultiTierJibFlag { get; set; }
        public string? CashCallDrawDownFlag { get; set; }
        public string? JibInvoiceOrgId { get; set; }
        public int? CountryForTaxation { get; set; }
        public string IsBaMatchingEntry { get; set; } = null!;
    }
}
