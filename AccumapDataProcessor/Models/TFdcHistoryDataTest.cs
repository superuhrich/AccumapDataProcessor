using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TFdcHistoryDataTest
    {
        public string? SiteId { get; set; }
        public DateTime? ActvyDate { get; set; }
        public string? Period { get; set; }
        public string? Years { get; set; }
        public decimal? ProductionDaysOn { get; set; }
        public string? ProductionDaysOnId { get; set; }
        public string? CcHierarchy { get; set; }
        public string? WellStatus { get; set; }
        public string? PrimaryProduct { get; set; }
        public string? CcType { get; set; }
        public string? Scenario { get; set; }
        public string DataType { get; set; } = null!;
        public string? Organizations { get; set; }
        public string? GrsNet { get; set; }
        public string? OpNonop { get; set; }
        public string? ContractOp { get; set; }
        public string? BatteryNum { get; set; }
        public string? EssbaseUwi { get; set; }
        public string? RunId { get; set; }
        public string? BaseIncr { get; set; }
        public string? Play { get; set; }
        public string? Acquisition { get; set; }
        public DateTime? OnstreamDate { get; set; }
        public string? OnstreamYear { get; set; }
        public string? OwnerId { get; set; }
        public double? HoursOn { get; set; }
        public double? HoursDown { get; set; }
        public double? GasMetVolDly { get; set; }
        public double? GasImpVolDly { get; set; }
        public double? GasBoeVolDly { get; set; }
        public double? GasMcfeVolDly { get; set; }
        public double? OilMetVolDly { get; set; }
        public double? OilImpVolDly { get; set; }
        public double? OilBoeVolDly { get; set; }
        public double? OilMcfeVolDly { get; set; }
        public double? NglMetVolDly { get; set; }
        public double? NglImpVolDly { get; set; }
        public double? NglBoeVolDly { get; set; }
        public double? NglMcfeVolDly { get; set; }
        public double? CondensateMetVolDly { get; set; }
        public double? CondensateImpVolDly { get; set; }
        public double? CondensateBoeVolDly { get; set; }
        public double? CondensateMcfeVolDly { get; set; }
        public double? WaterMetVolDly { get; set; }
        public double? WaterImpVolDly { get; set; }
        public double? WaterBoeVolDly { get; set; }
        public double? WaterMcfeVolDly { get; set; }
        public double? TotalBoeVolDly { get; set; }
        public double? WellHeadPressure { get; set; }
        public double? InjectedSrcWater { get; set; }
        public double? InjectedProdWater { get; set; }
        public double? InjectedGas { get; set; }
        public double? InjectedCo2 { get; set; }
        public double? CasingPressure { get; set; }
        public double? TubingPressure { get; set; }
        public double? JointsInHole { get; set; }
        public double? InjectionPressure { get; set; }
        public double? ChokeSize { get; set; }
        public double? SwbWheadBswCut { get; set; }
        public double? SwbWheadSandCut { get; set; }
        public double? StrokeSpeed { get; set; }
        public double? RotarySpeed { get; set; }
        public double? ElectricCurrent { get; set; }
        public double? Usd { get; set; }
        public double? Cad { get; set; }
        public string? DataSource { get; set; }
        public string? SiteType { get; set; }
    }
}
