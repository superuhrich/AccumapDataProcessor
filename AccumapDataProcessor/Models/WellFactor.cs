using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class WellFactor
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
        public string RemainingGasUsage { get; set; } = null!;
        public decimal? WaterGasRatioFactor { get; set; }
        public DateTime? WaterGasRatioTestDate { get; set; }
        public decimal? OilMeterFactor { get; set; }
        public decimal? EorHorRate { get; set; }
        public decimal CrownRoyaltyPercent { get; set; }
        public decimal FreeholdRoyaltyPercent { get; set; }
        public decimal CrownAcquiredPercent { get; set; }
        public decimal FederalPercent { get; set; }
        public string MarginalWell { get; set; } = null!;
        public string? ProcessForCrownInvoice { get; set; }
        public string? FourthTierGor { get; set; }
        public decimal? OilDensity { get; set; }
        public decimal? RoyaltyOilHolidaySysId { get; set; }
        public string WellId { get; set; } = null!;
        public string? CrownRoyaltyCalcTypeCode { get; set; }
        public string? EquivalentUseSubTypeCode { get; set; }
        public string? PartMonthCrownRoyaltyCode { get; set; }
        public string AllOilToBeRecovered { get; set; } = null!;
        public string AllWaterToBeRecovered { get; set; } = null!;
        public decimal? GasMeterFactor { get; set; }
        public string? OilGasRatioCode { get; set; }
        public decimal? OilGasRatioFactor { get; set; }
        public DateTime? OilGasRatioTestDate { get; set; }
        public string? WaterGasRatioCode { get; set; }
        public decimal? WaterMeterFactor { get; set; }
        public string? BatteryGorExempt { get; set; }
    }
}
