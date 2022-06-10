using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceCostActualsQbyte
    {
        public int? LiId { get; set; }
        public int? VoucherId { get; set; }
        public string? AfeId { get; set; }
        public string? AfeNumber { get; set; }
        public string? Uwi { get; set; }
        public string? CcNumber { get; set; }
        public string? EntityId { get; set; }
        public int? AccountingMonthKey { get; set; }
        public int? ActivityMonthKey { get; set; }
        public string? ScenarioKey { get; set; }
        public string? AccountKey { get; set; }
        public int? OrganizationKey { get; set; }
        public string? AfeClientId { get; set; }
        public int? VendorKey { get; set; }
        public string? AfeType { get; set; }
        public string? AfeStatus { get; set; }
        public int AfeJobTypeId { get; set; }
        public string AfeJobType { get; set; } = null!;
        public string AfeJobSubtype { get; set; } = null!;
        public int AfeJobStatusId { get; set; }
        public string AfeJobStatus1 { get; set; } = null!;
        public string AfeJobStatus2 { get; set; } = null!;
        public DateTime? AfeStartDate { get; set; }
        public string? ProjectApprovalStatus { get; set; }
        public string? ProjectExecutionStatus { get; set; }
        public string? EngineerAssigned { get; set; }
        public string? ProjectId { get; set; }
        public string? GrossNetIndicator { get; set; }
        public int? GrossNetKey { get; set; }
        public double? Cad { get; set; }
        public double? Usd { get; set; }
        public decimal? NetWorkingInterest { get; set; }
    }
}
