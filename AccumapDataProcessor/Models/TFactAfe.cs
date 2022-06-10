using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TFactAfe
    {
        public string? TransactionPk { get; set; }
        public int? AfeId { get; set; }
        public string? AfeNumber { get; set; }
        public int? ActivityPeriodId { get; set; }
        public int? AccountingPeriodId { get; set; }
        public int? EntityId { get; set; }
        public string? CcNumber { get; set; }
        public string? Uwi { get; set; }
        public string? GlAccount { get; set; }
        public string? AfeType { get; set; }
        public decimal? AfeJobType { get; set; }
        public decimal? AfeJobStatus { get; set; }
        public string? OrgBaId { get; set; }
        public string? Scenario { get; set; }
        public string? DataSource { get; set; }
        public string? VendorBaId { get; set; }
        public string? GrossNetIndicator { get; set; }
        public string? ProjectId { get; set; }
        public string? BudgetWedgeId { get; set; }
        public double? HeadCount { get; set; }
        public double? DurationOfWork { get; set; }
        public double? NumberOfReports { get; set; }
        public double? NumberOfPermits { get; set; }
        public double? CdnDollars { get; set; }
        public double? UsDollars { get; set; }
        public double? NetWorkingInterest { get; set; }
        public decimal? TransactionLastLoadId { get; set; }
        public DateTime? TransactionLastLoadDate { get; set; }
        public string? EtlStatus { get; set; }
    }
}
