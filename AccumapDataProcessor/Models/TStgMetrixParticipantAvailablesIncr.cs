using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgMetrixParticipantAvailablesIncr
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
        public string? DoiSubUsed { get; set; }
        public decimal? WorkingInterestPercent { get; set; }
        public string? DefaultSourceWell { get; set; }
        public decimal? OpeningInventory { get; set; }
        public decimal? TransferReceived { get; set; }
        public decimal? ClosingInventory { get; set; }
        public decimal? ProductionVolume { get; set; }
        public decimal? TransferVolume { get; set; }
        public decimal? AvailableForSaleVolume { get; set; }
        public decimal? SalesVolume { get; set; }
        public decimal? OpeningGigajoules { get; set; }
        public decimal? ProductionGigajoules { get; set; }
        public decimal? SalesGigajoules { get; set; }
        public decimal? ClosingGigajoules { get; set; }
        public string? SpecialPlantReceipt { get; set; }
        public string? SendingBatteryFacilityId { get; set; }
        public string? ReceivingBatteryFacilityId { get; set; }
        public decimal? RoyaltyObligationSysId { get; set; }
        public decimal FacilitySysId { get; set; }
        public decimal? TransferFacilitySysId { get; set; }
        public string? OwnerId { get; set; }
        public string? WorkingInterestOwnerId { get; set; }
        public decimal? WellTractSysId { get; set; }
        public string ProductCode { get; set; } = null!;
        public string? FlowGroupId { get; set; }
        public string? ParticipantTypeCode { get; set; }
        public decimal? VolumeSentForFrac { get; set; }
        public decimal? VolumeFromFrac { get; set; }
    }
}
