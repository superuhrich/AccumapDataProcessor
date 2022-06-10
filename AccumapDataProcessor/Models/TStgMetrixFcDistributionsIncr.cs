using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgMetrixFcDistributionsIncr
    {
        public string CreateUser { get; set; } = null!;
        public string? CreateProgram { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LastUpdateUser { get; set; } = null!;
        public string? LastUpdateProgram { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal Version { get; set; }
        public decimal SysId { get; set; }
        public decimal ProductionDate { get; set; }
        public string? Province { get; set; }
        public decimal? ExpenseVolume { get; set; }
        public decimal? ExpenseValue { get; set; }
        public string? ExpenseDoiSubUsed { get; set; }
        public string? RevenueDoiSubUsed { get; set; }
        public string? ChargeGst { get; set; }
        public decimal? WorkingInterestPercent { get; set; }
        public decimal? GrossValue { get; set; }
        public decimal? GrossVolume { get; set; }
        public string? RevenueDoiSilentPartner { get; set; }
        public string? ExpenseDoiSilentPartner { get; set; }
        public decimal FacilityChargeSysId { get; set; }
        public decimal? ExpenseFacilitySysId { get; set; }
        public string? ExpenseCostCentreCode { get; set; }
        public string? RevenueCostCentreCode { get; set; }
        public string? ExpenseOwnerId { get; set; }
        public string? RevenueOwnerId { get; set; }
        public decimal? ExpenseWellTractSysId { get; set; }
        public string? ExpenseUnitId { get; set; }
        public string? DefaultSourceWell { get; set; }
        public decimal GrossGstValue { get; set; }
        public decimal GrossPstValue { get; set; }
        public decimal GstValue { get; set; }
        public decimal PstValue { get; set; }
    }
}
