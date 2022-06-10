using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class MarketMasterPurchaser
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
        public string? PurchaserType { get; set; }
        public decimal? PurchaserSequence { get; set; }
        public string? ContractReference { get; set; }
        public string? ContractDescription { get; set; }
        public string? RevenueReceived { get; set; }
        public string? IncludeAllParticipants { get; set; }
        public string? ForceSales { get; set; }
        public string? RevenueNotReceivedReason { get; set; }
        public string? ShipperPipelineContract { get; set; }
        public string? IncludedBatteryId { get; set; }
        public string? PurchaserId { get; set; }
        public string? IncludedUnitId { get; set; }
        public string? FlowGroupOutId { get; set; }
        public string? FlowGroupInId { get; set; }
        public string? ParticipantGroupId { get; set; }
        public decimal? MarketMasterAllocGrpSysId { get; set; }
        public string? OverrideSplitOwnerId { get; set; }
    }
}
