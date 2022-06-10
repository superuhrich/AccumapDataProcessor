using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceFdcQbyteSalesIncr
    {
        public string? SiteId { get; set; }
        public string? EntityKey { get; set; }
        public int? ActivityDateKey { get; set; }
        public int GrossNetKey { get; set; }
        public string ScenarioKey { get; set; } = null!;
        public string DataType { get; set; } = null!;
        public double? GasMetricVolume { get; set; }
        public double? GasImperialVolume { get; set; }
        public double? GasBoeVolume { get; set; }
        public double? GasMcfeVolume { get; set; }
        public double? OilMetricVolume { get; set; }
        public double? OilImperialVolume { get; set; }
        public double? OilBoeVolume { get; set; }
        public double? OilMcfeVolume { get; set; }
        public double? CondMetricVolume { get; set; }
        public double? CondImperialVolume { get; set; }
        public double? CondBoeVolume { get; set; }
        public double? CondMcfeVolume { get; set; }
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
        public double TotalNglMetricVolume { get; set; }
        public double TotalNglImperialVolume { get; set; }
        public double TotalNglBoeVolume { get; set; }
        public double TotalNglMcfeVolume { get; set; }
        public double TotalLiquidMetricVolume { get; set; }
        public double TotalLiquidImperialVolume { get; set; }
        public double TotalLiquidBoeVolume { get; set; }
        public double TotalLiquidMcfeVolume { get; set; }
        public double TotalBoeVolume { get; set; }
    }
}
