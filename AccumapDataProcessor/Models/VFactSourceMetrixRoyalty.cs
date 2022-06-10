using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceMetrixRoyalty
    {
        public int? ActivityPeriod { get; set; }
        public string? RoyaltyOwnerId { get; set; }
        public string? Product { get; set; }
        public string RoyaltyType { get; set; } = null!;
        public string? PaymentType { get; set; }
        public string? ControlGroupId { get; set; }
        public string RoyaltyPayor { get; set; } = null!;
        public string? WellTractId { get; set; }
        public string? BatteryFacilityId { get; set; }
        public string RoyaltyObligationId { get; set; } = null!;
        public decimal? RoyaltyValue { get; set; }
        public decimal? RoyaltyVolumesMetric { get; set; }
        public decimal? RoyaltyVolumeImperial { get; set; }
        public decimal? RoyaltyVolumeBoe { get; set; }
    }
}
