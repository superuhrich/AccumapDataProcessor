using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TPvrTwell
    {
        public string CompanyId { get; set; } = null!;
        public string BatteryId { get; set; } = null!;
        public string WellId { get; set; } = null!;
        public string WellName { get; set; } = null!;
        public string WellType { get; set; } = null!;
        public string SurveySystem { get; set; } = null!;
        public string WellLocation { get; set; } = null!;
        public string FieldLocation { get; set; } = null!;
        public string TestMeasureFlag { get; set; } = null!;
        public string? NewOldOil { get; set; }
        public decimal TestsRequired { get; set; }
        public decimal WaterGasRatio { get; set; }
        public decimal GasOilRatio { get; set; }
        public decimal CondGasRatio { get; set; }
        public string RoyaltyHoliday { get; set; } = null!;
        public string HorizontalWell { get; set; } = null!;
        public string CostCentreId { get; set; } = null!;
        public string? HorizonPool { get; set; }
        public decimal EntrySequenceNumber { get; set; }
        public string GasCharts { get; set; } = null!;
        public string MeterType { get; set; } = null!;
        public string TestMethod { get; set; } = null!;
        public string WellStatus { get; set; } = null!;
        public decimal LeaseFuelRate { get; set; }
        public decimal TractPercent { get; set; }
        public string MonitorWellFlag { get; set; } = null!;
        public string? MerakLocation { get; set; }
        public DateTime OnProductionDate { get; set; }
        public decimal? SatelliteSeqId { get; set; }
        public string? PaInterface { get; set; }
        public string? PaId { get; set; }
        public decimal? SubCatSeqId { get; set; }
        public string? Info1 { get; set; }
        public string? Info2 { get; set; }
        public string? Info3 { get; set; }
        public decimal? OilCapabilityPerDay { get; set; }
        public decimal? OilDeclineRatePerYear { get; set; }
        public DateTime? OilCapabilityDate { get; set; }
        public decimal? GasCapabilityPerDay { get; set; }
        public decimal? GasDeclineRatePerYear { get; set; }
        public DateTime? GasCapabilityDate { get; set; }
        public decimal DailyAllowable { get; set; }
        public decimal NativeCo2Fraction { get; set; }
        public string? DeliveryMeterId { get; set; }
        public string? GovBatteryCode { get; set; }
        public string AutoLoadWio { get; set; } = null!;
        public string OpNonopIndicator { get; set; } = null!;
        public string RecombLiq { get; set; } = null!;
        public string FlowHours { get; set; } = null!;
        public string UpdtUser { get; set; } = null!;
        public DateTime UpdtDte { get; set; }
        public byte[] PmGuid { get; set; } = null!;
        public string WetMeasuredGas { get; set; } = null!;
        public decimal? LinkFacilitySeqId { get; set; }
        public decimal? LinkFuncUnitSeqId { get; set; }
        public string? OilType { get; set; }
        public string? ReturnFuelMeterId { get; set; }
    }
}
