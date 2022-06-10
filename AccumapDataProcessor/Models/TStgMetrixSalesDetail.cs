using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgMetrixSalesDetail
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
        public decimal? DeliverySequence { get; set; }
        public decimal? PurchaserSequence { get; set; }
        public string? PurchaserType { get; set; }
        public decimal? SalesVolume { get; set; }
        public string? RevenueNotReceivedReason { get; set; }
        public decimal? GasAnalysisFactor { get; set; }
        public decimal? TheoreticalGigajoules { get; set; }
        public decimal? ActualGigajoules { get; set; }
        public decimal? AllocationNumber { get; set; }
        public string? SpecialPlantReceipt { get; set; }
        public string? SplitLoadOil { get; set; }
        public string? DoiSubUsed { get; set; }
        public decimal? WorkingInterestPercent { get; set; }
        public string? DefaultSourceWell { get; set; }
        public string? InjectionWellUserDefined1 { get; set; }
        public decimal? TotalValue { get; set; }
        public decimal? TotalVolume { get; set; }
        public decimal? SalesValue { get; set; }
        public decimal? SalesValueNetOfTransport { get; set; }
        public string? BatteryFacilityId { get; set; }
        public string? OriginalBatteryFacilityId { get; set; }
        public string? ControlGroupId { get; set; }
        public decimal? RoyaltyObligationSysId { get; set; }
        public decimal? FacilitySysId { get; set; }
        public decimal? DeliveryFacilitySysId { get; set; }
        public decimal? TransferFacilitySysId { get; set; }
        public string? OwnerId { get; set; }
        public string? ReferenceOwnerId { get; set; }
        public string? PurchaserId { get; set; }
        public decimal? WellTractSysId { get; set; }
        public string? InjectionWellId { get; set; }
        public string? ProductCode { get; set; }
        public string? DeliveryDispositionTypeCode { get; set; }
        public string? DeliverySystemId { get; set; }
        public string? FlowGroupId { get; set; }
        public string? OwnerTypeCode { get; set; }
        public string? ReportAsProductCode { get; set; }
        public string? PricingUserDefined1 { get; set; }
        public string? PurchaseFlag { get; set; }
    }
}
