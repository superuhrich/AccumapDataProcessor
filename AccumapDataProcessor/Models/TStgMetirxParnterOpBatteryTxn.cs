using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgMetirxParnterOpBatteryTxn
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
        public string TransactionType { get; set; } = null!;
        public decimal? EnteredGrossVolume { get; set; }
        public decimal? EnteredGrossValue { get; set; }
        public decimal? EnteredGrossGigajoules { get; set; }
        public decimal? CalculatedGrossVolume { get; set; }
        public decimal? CalculatedGrossValue { get; set; }
        public decimal? CalculatedGrossGigajoules { get; set; }
        public decimal? EnteredNetVolume { get; set; }
        public decimal? EnteredNetValue { get; set; }
        public decimal? EnteredNetGigajoules { get; set; }
        public decimal? CalculatedNetVolume { get; set; }
        public decimal? CalculatedNetValue { get; set; }
        public decimal? CalculatedNetGigajoules { get; set; }
        public string? TaxType { get; set; }
        public decimal? ProducingHours { get; set; }
        public decimal? WellheadGasProduction { get; set; }
        public string BatteryFacilityId { get; set; } = null!;
        public string? OwnerId { get; set; }
        public string WellId { get; set; } = null!;
        public string? ProductCode { get; set; }
        public decimal? WellheadOilProduction { get; set; }
        public decimal? PurchaserSequenceNumber { get; set; }
        public decimal? DestinationFacilitySysId { get; set; }
        public string? DestinationDeliverySystemId { get; set; }
        public string? PricingCode { get; set; }
        public string? AllocationBasisCode { get; set; }
        public decimal? EnteredPrice { get; set; }
        public decimal? EnteredValue { get; set; }
        public string? PricingUserDefined1 { get; set; }
    }
}
