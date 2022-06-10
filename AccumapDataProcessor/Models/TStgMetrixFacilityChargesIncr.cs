using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgMetrixFacilityChargesIncr
    {
        public string? CreateUser { get; set; }
        public string? CreateProgram { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string? LastUpdateUser { get; set; }
        public string? LastUpdateProgram { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal? Version { get; set; }
        public decimal? SysId { get; set; }
        public decimal? ProductionDate { get; set; }
        public decimal? SequenceNumber { get; set; }
        public decimal? ExpenseDoiExtension { get; set; }
        public decimal? RevenueDoiExtension { get; set; }
        public string? OwnerSelection { get; set; }
        public string? FromToSelection { get; set; }
        public string? PurchaserSelection { get; set; }
        public string? EntitySelection { get; set; }
        public string? GstApplicable { get; set; }
        public string? BookAtUnit { get; set; }
        public string? ControlGroupId { get; set; }
        public string? FacilityChargeFormulaId { get; set; }
        public decimal? FacilitySysId { get; set; }
        public string? ProductCode { get; set; }
        public string? UnitId { get; set; }
        public string? ChargeTypeCode { get; set; }
        public string? RevenueCostCentreCode { get; set; }
        public string? EntitySelectionType { get; set; }
        public string? ActiveFlag { get; set; }
    }
}
