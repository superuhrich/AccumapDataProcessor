using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TblTest
    {
        public string DataType { get; set; } = null!;
        public string? EntityKey { get; set; }
        public double? GasMetricVolume { get; set; }
        public double? GasImperialVolume { get; set; }
        public double? GasBoeVolume { get; set; }
        public double? GasMcfeVolume { get; set; }
        public double? OilMetricVolume { get; set; }
        public double? OilImperialVolume { get; set; }
        public double? OilBoeVolume { get; set; }
        public double? OilMcfeVolume { get; set; }
        public double? EthaneMetricVolume { get; set; }
        public double? EthaneImperialVolume { get; set; }
        public double? EthaneBoeVolume { get; set; }
        public double? EthaneMcfeVolume { get; set; }
        public double? PropaneMetricVolume { get; set; }
        public double? PropaneImperialVolume { get; set; }
        public double? PropaneBoeVolume { get; set; }
        public double? PropaneMcfeVolume { get; set; }
        public double? ButaneMetricVolume { get; set; }
        public double? ButaneImperialVolume { get; set; }
        public double? ButaneBoeVolume { get; set; }
        public double? ButaneMcfeVolume { get; set; }
        public double? PentaneMetricVolume { get; set; }
        public double? PentaneImperialVolume { get; set; }
        public double? PentaneBoeVolume { get; set; }
        public double? PentaneMcfeVolume { get; set; }
        public double? CondensateMetricVolume { get; set; }
        public double? CondensateImperialVolume { get; set; }
        public double? CondensateBoeVolume { get; set; }
        public double? CondensateMcfeVolume { get; set; }
        public double? TotalNglMetricVolume { get; set; }
        public double? TotalNglImperialVolume { get; set; }
        public double? TotalNglBoeVolume { get; set; }
        public double? TotalNglMcfeVolume { get; set; }
        public double? TotalLiquidMetricVolume { get; set; }
        public double? TotalLiquidImperialVolume { get; set; }
        public double? TotalLiquidBoeVolume { get; set; }
        public double? TotalLiquidMcfeVolume { get; set; }
        public double? TotalBoeVolume { get; set; }
        public double? WaterMetricVolume { get; set; }
        public double? WaterImperialVolume { get; set; }
        public double? WaterBoeVolume { get; set; }
        public double? WaterMcfeVolume { get; set; }
        public double? HoursOn { get; set; }
        public double? HoursDown { get; set; }
    }
}
