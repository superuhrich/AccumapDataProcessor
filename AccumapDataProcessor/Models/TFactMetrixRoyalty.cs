using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TFactMetrixRoyalty
    {
        public int? ActivityPeriod { get; set; }
        public string? RoyaltyOwnerId { get; set; }
        public string? ProductCode { get; set; }
        public string? RoyaltyType { get; set; }
        public string? PaymentType { get; set; }
        public string? ControlGroupId { get; set; }
        public string? RoyaltyPayorId { get; set; }
        public string? WellTractId { get; set; }
        public string? BatteryId { get; set; }
        public string? RoyaltyObligationSequence { get; set; }
        public decimal? RoyaltyValue { get; set; }
        public decimal? RoyaltyVolumeMetric { get; set; }
        public decimal? RoyaltyVolumeImperial { get; set; }
        public decimal? RoyaltyVolumeBoe { get; set; }
    }
}
