using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceMetrixSalesIncr
    {
        public int? ActivityPeriod { get; set; }
        public string? PurchaserId { get; set; }
        public string? Product { get; set; }
        public string? SalesType { get; set; }
        public string? SalesTik { get; set; }
        public string? ControlGroupId { get; set; }
        public string? OwnerId { get; set; }
        public string? WellTractId { get; set; }
        public string? BatteryId { get; set; }
        public string? SourceFacilityId { get; set; }
        public string? TargetFacilityId { get; set; }
        public string? PurchaserSequence { get; set; }
        public string? DeliverySequence { get; set; }
        public string? RoyaltyPayor { get; set; }
        public string? ArContract { get; set; }
        public decimal? SalesValue { get; set; }
        public decimal? SalesVolume { get; set; }
        public decimal? SalesValueNetOfTransport { get; set; }
        public decimal? ActualGigajoules { get; set; }
        public decimal? OpeningInventory { get; set; }
        public decimal? TransferReceived { get; set; }
        public decimal? ProductionVolume { get; set; }
        public decimal? TransferSent { get; set; }
        public decimal? ClosingInventory { get; set; }
        public decimal? SalesVolumeImperial { get; set; }
        public decimal? SalesVolumeBoe { get; set; }
    }
}
