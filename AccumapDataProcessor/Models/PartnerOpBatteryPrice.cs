using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class PartnerOpBatteryPrice
    {
        public decimal SysId { get; set; }
        public string CreateUser { get; set; } = null!;
        public string? CreateProgram { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LastUpdateUser { get; set; } = null!;
        public string? LastUpdateProgram { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal Version { get; set; }
        public decimal ProductionDate { get; set; }
        public string BatteryFacilityId { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string TransactionType { get; set; } = null!;
        public string? OwnerId { get; set; }
        public decimal? PurchaserSequenceNumber { get; set; }
        public decimal? DestinationFacilitySysId { get; set; }
        public string? DestinationDeliverySystemId { get; set; }
        public string AllocationBasisCode { get; set; } = null!;
        public string PricingCode { get; set; } = null!;
        public decimal? EnteredPrice { get; set; }
        public decimal? EnteredValue { get; set; }
        public decimal? FacilitySysId { get; set; }
        public string? UserDefined1 { get; set; }
    }
}
