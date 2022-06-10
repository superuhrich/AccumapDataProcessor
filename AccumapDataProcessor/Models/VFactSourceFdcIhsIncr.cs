using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceFdcIhsIncr
    {
        public string? SiteId { get; set; }
        public string? Uwi { get; set; }
        public string? CcNum { get; set; }
        public DateTime? ActivityDate { get; set; }
        public int? ActivityDateKey { get; set; }
        public string DataType { get; set; } = null!;
        public string ScenarioKey { get; set; } = null!;
        public int GrossNetKey { get; set; }
        public decimal? GasMetricVolume { get; set; }
        public decimal? GasImperialVolume { get; set; }
        public decimal? GasBoeVolume { get; set; }
        public decimal? GasMcfeVolume { get; set; }
        public decimal? OilMetricVolume { get; set; }
        public decimal? OilImperialVolume { get; set; }
        public decimal? OilBoeVolume { get; set; }
        public decimal? OilMcfeVolume { get; set; }
        public decimal? CondensateMetricVolume { get; set; }
        public decimal? CondensateImperialVolume { get; set; }
        public decimal? CondensateBoeVolume { get; set; }
        public decimal? CondensateMcfeVolume { get; set; }
        public decimal? TotalNglMetricVolume { get; set; }
        public decimal? TotalNglImperialVolume { get; set; }
        public decimal? TotalNglBoeVolume { get; set; }
        public decimal? TotalNglMcfeVolume { get; set; }
        public decimal? TotalLiquidMetricVolume { get; set; }
        public decimal? TotalLiquidImperialVolume { get; set; }
        public decimal? TotalLiquidBoeVolume { get; set; }
        public decimal? TotalLiquidMcfeVolume { get; set; }
        public decimal? TotalBoeVolume { get; set; }
        public decimal? WaterMetricVolume { get; set; }
        public decimal? WaterImperialVolume { get; set; }
        public decimal? WaterBoeVolume { get; set; }
        public decimal? WaterMcfeVolume { get; set; }
        public decimal? HoursOn { get; set; }
    }
}
