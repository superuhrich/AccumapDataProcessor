using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceMetrixFee
    {
        public int? ActivityPeriod { get; set; }
        public string? ControlGroupId { get; set; }
        public string? FacilityId { get; set; }
        public string? ProductCode { get; set; }
        public string? ChargeTypeCode { get; set; }
        public string? FacilityChargeFormulaId { get; set; }
        public int? ChargeSequenceNumber { get; set; }
        public string? EntityType { get; set; }
        public string? EntityId { get; set; }
        public string? ExpenseCostCentreCode { get; set; }
        public string? ExpenseOwnerId { get; set; }
        public string? RevenueCostCentreCode { get; set; }
        public string? RevenueOwnerId { get; set; }
        public string? ExpenseDoiSubUsed { get; set; }
        public string? RevenueDoiSubUsed { get; set; }
        public decimal? ExpenseValue { get; set; }
        public decimal? ExpenseVolume { get; set; }
        public decimal GstValue { get; set; }
        public decimal PstValue { get; set; }
        public decimal? ExpenseVolumeImperial { get; set; }
        public decimal? ExpenseVolumeBoe { get; set; }
    }
}
