using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactAccumap
    {
        public string Uwi { get; set; } = null!;
        public int? ActivityDate { get; set; }
        public int OnProdDateKey { get; set; }
        public int SpudDateKey { get; set; }
        public int RigReleaseDateKey { get; set; }
        public string? LicenseNumber { get; set; }
        public string? Operator { get; set; }
        public string NormalizedDaysKey { get; set; } = null!;
        public double? GasMetricVolume { get; set; }
        public double? GasImperialVolume { get; set; }
        public double? GasBoeVolume { get; set; }
        public double? GasMcfeVolume { get; set; }
        public decimal? OilMetricVolume { get; set; }
        public decimal? OilImperialVolume { get; set; }
        public decimal? OilBoeVolume { get; set; }
        public decimal? OilMcfeVolume { get; set; }
        public double? CondensateMetricVolume { get; set; }
        public double? CondensateImperialVolume { get; set; }
        public double? CondensateBoeVolume { get; set; }
        public double? CondensateMcfeVolume { get; set; }
        public double? WaterMetricVolume { get; set; }
        public double? WaterImperialVolume { get; set; }
        public double? WaterBoeVolume { get; set; }
        public double? WaterMcfeVolume { get; set; }
        public double? TotalBoeVolume { get; set; }
        public double? PHours { get; set; }
        public int? DayCounter { get; set; }
        public decimal? ProdmthDayCounter { get; set; }
    }
}
