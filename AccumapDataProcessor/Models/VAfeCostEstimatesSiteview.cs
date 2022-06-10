using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VAfeCostEstimatesSiteview
    {
        public string? AfeNum { get; set; }
        public string? AfeName { get; set; }
        public string? CcNum { get; set; }
        public string? Uwi { get; set; }
        public string? GlAccount { get; set; }
        public string? GlNetAccount { get; set; }
        public string? ProjectId { get; set; }
        public string? CapitalProjectNumber { get; set; }
        public string? Organizations { get; set; }
        public decimal? OrgId { get; set; }
        public string OpFlag { get; set; } = null!;
        public decimal? OperatorClientId { get; set; }
        public decimal? ContractOperatorClientId { get; set; }
        public string? VendorId { get; set; }
        public string AfeJobType { get; set; } = null!;
        public string AfeJobSubtype { get; set; } = null!;
        public string AfeJobStatus1 { get; set; } = null!;
        public string AfeJobStatus2 { get; set; } = null!;
        public string? WellStatus { get; set; }
        public string? PrimaryProduct { get; set; }
        public string? TaxStream { get; set; }
        public string? EngineerAssigned { get; set; }
        public string? RunId { get; set; }
        public string? BaseIncr { get; set; }
        public string? Play { get; set; }
        public string? Acquisitions { get; set; }
        public string? Dispositions { get; set; }
        public string? PayoutType { get; set; }
        public string Province { get; set; } = null!;
        public string? OpCurrCode { get; set; }
        public string? ReportingCurrCode { get; set; }
        public string AfeClientId { get; set; } = null!;
        public string? AfeClientName { get; set; }
        public string? AfeStartDate { get; set; }
        public DateTime? AfeApprovalDate { get; set; }
        public string? BudgetYear { get; set; }
        public string ProjectApprovalStatus { get; set; } = null!;
        public string ProjectExecutionStatus { get; set; } = null!;
        public DateTime? AfeDate { get; set; }
        public string? AcctMnth { get; set; }
        public int? AcctYr { get; set; }
        public string? ProdMnth { get; set; }
        public int? ProdYr { get; set; }
        public string GrsNetIndicator { get; set; } = null!;
        public string? AfeType { get; set; }
        public string? MajClassCode { get; set; }
        public string WipExpenses { get; set; } = null!;
        public string CapitalOrDryHoleExpense { get; set; } = null!;
        public string? TaxCode { get; set; }
        public string? AfeStatus { get; set; }
        public string? StartDate { get; set; }
        public double? UsDollarAmt { get; set; }
        public double? CanDollarAmt { get; set; }
        public decimal? NetWorkingInterest { get; set; }
        public string IsCapital { get; set; } = null!;
    }
}
