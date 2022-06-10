using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class ControlGroupMaster
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
        public string? Name { get; set; }
        public string? ProducePartnerReporting { get; set; }
        public string? GasFlowEnabled { get; set; }
        public string? GenerateMarketMasters { get; set; }
        public string? LockedForOilProcessing { get; set; }
        public string? AllowPricingZeroOil { get; set; }
        public string? AllowHeavyOilProcessing { get; set; }
        public string? AllowInterOilWaterXfer { get; set; }
        public string? RegionId { get; set; }
        public string? ControlGroupId { get; set; }
        public string? DefaultOilPurchaserId { get; set; }
        public string? PaResponsibleUserId { get; set; }
        public string? ReportZeroTransfersFlag { get; set; }
        public decimal? ReportGroupSysId { get; set; }
        public string? DisableArchivingFlag { get; set; }
        public string? GenerateOilProcOrderFlag { get; set; }
        public string AllowGenerationTypSelection { get; set; } = null!;
    }
}
