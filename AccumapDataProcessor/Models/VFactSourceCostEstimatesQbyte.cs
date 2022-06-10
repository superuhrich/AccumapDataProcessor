using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceCostEstimatesQbyte
    {
        public long? AfeId { get; set; }
        public string? AfeNumber { get; set; }
        public string? Uwi { get; set; }
        public string? EntityId { get; set; }
        public string? CcNumber { get; set; }
        public int? AcctPerId { get; set; }
        public DateTime? AcctPerDate { get; set; }
        public string? AcctMnth { get; set; }
        public int? AcctYr { get; set; }
        public int? ActvyPerId { get; set; }
        public DateTime? ActvyPerDate { get; set; }
        public string? ActvyMnth { get; set; }
        public int? ActvyYr { get; set; }
        public string Scenario { get; set; } = null!;
        public string? GlNetAccount { get; set; }
        public string? CapitalProjectNumber { get; set; }
        public decimal? OrgId { get; set; }
        public string AfeClientId { get; set; } = null!;
        public string VendorId { get; set; } = null!;
        public string? BaseIncr { get; set; }
        public string? Play { get; set; }
        public string? TaxStream { get; set; }
        public string? Acquisitions { get; set; }
        public string? Dispositions { get; set; }
        public string? TaxCode { get; set; }
        public string WipExpenses { get; set; } = null!;
        public string CapitalOrDryHoleExpense { get; set; } = null!;
        public string? AfeType { get; set; }
        public string? AfeStatus { get; set; }
        public int AfeJobTypeId { get; set; }
        public string AfeJobType { get; set; } = null!;
        public string AfeJobSubtype { get; set; } = null!;
        public int AfeJobStatusId { get; set; }
        public string AfeJobStatus1 { get; set; } = null!;
        public string AfeJobStatus2 { get; set; } = null!;
        public string? AfeStartDate { get; set; }
        public string? BudgetYear { get; set; }
        public string ProjectApprovalStatus { get; set; } = null!;
        public string ProjectExecutionStatus { get; set; } = null!;
        public string? EngineerAssigned { get; set; }
        public string GrsNet { get; set; } = null!;
        public string? ProjectId { get; set; }
        public string BudgetWedgeId { get; set; } = null!;
        public decimal? UsDollarAmt { get; set; }
        public decimal? CanDollarAmt { get; set; }
        public decimal? NetWorkingInterest { get; set; }
    }
}
