using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceFdcHistoryFact
    {
        public string? SiteId { get; set; }
        public string? EntityKey { get; set; }
        public int? ActivityDateKey { get; set; }
        public string? ScenarioKey { get; set; }
        public int GrossNetKey { get; set; }
        public string? DataType { get; set; }
        public double? GasMetricVolume { get; set; }
        public double? GasImperialVolume { get; set; }
        public double? GasBoeVolume { get; set; }
        public double? GasMcfeVolume { get; set; }
        public double? OilMetricVolume { get; set; }
        public double? OilImperialVolume { get; set; }
        public double? OilBoeVolume { get; set; }
        public double? OilMcfeVolume { get; set; }
        public int? EthaneMetricVolume { get; set; }
        public int? EthaneImperialVolume { get; set; }
        public int? EthaneBoeVolume { get; set; }
        public int? EthaneMcfeVolume { get; set; }
        public double? PropaneMetricVolume { get; set; }
        public double? PropaneImperialVolume { get; set; }
        public double? PropaneBoeVolume { get; set; }
        public double? PropaneMcfeVolume { get; set; }
        public int? ButaneMetricVolume { get; set; }
        public int? ButaneImperialVolume { get; set; }
        public int? ButaneBoeVolume { get; set; }
        public int? ButaneMcfeVolume { get; set; }
        public int? PentaneMetricVolume { get; set; }
        public int? PentaneImperialVolume { get; set; }
        public int? PentaneBoeVolume { get; set; }
        public int? PentaneMcfeVolume { get; set; }
        public double? CondensateMetricVolume { get; set; }
        public double? CondensateImperialVolume { get; set; }
        public double? CondensateBoeVolume { get; set; }
        public double? CondensateMcfeVolume { get; set; }
        public double TotalNglMetricVolume { get; set; }
        public double TotalNglImperialVolume { get; set; }
        public double TotalNglBoeVolume { get; set; }
        public double TotalNglMcfeVolume { get; set; }
        public double TotalLiquidMetricVolume { get; set; }
        public double TotalLiquidImperialVolume { get; set; }
        public double TotalLiquidBoeVolume { get; set; }
        public double TotalLiquidMcfeVolume { get; set; }
        public double? TotalBoeVolume { get; set; }
        public double? WaterMetricVolume { get; set; }
        public double? WaterImperialVolume { get; set; }
        public double? WaterBoeVolume { get; set; }
        public double? WaterMcfeVolume { get; set; }
        public double? HoursOn { get; set; }
        public double? HoursDown { get; set; }
        public double? CasingPressure { get; set; }
        public double? TubingPressure { get; set; }
        public double? InjectedSrcWater { get; set; }
        public double? InjectedProdWater { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
