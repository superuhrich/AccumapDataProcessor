using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TTypecurvesEntSharedPlanDatum
    {
        public string ParentId { get; set; } = null!;
        public string PlanDefinitionId { get; set; } = null!;
        public string? CurrencyId { get; set; }
        public double? KellyBushing { get; set; }
        public double? CasingFlange { get; set; }
        public double? PerfTop { get; set; }
        public double? PerfBottom { get; set; }
        public double? MidPointPerf { get; set; }
        public double? WellDatum { get; set; }
        public double? PoolDatum { get; set; }
        public double? PoolDatumCorrection { get; set; }
        public string? OilProductType { get; set; }
        public string? GasProductType { get; set; }
        public double? GrossCompInterval { get; set; }
        public DateTime? SpudDate { get; set; }
        public double? MeasuredDepth { get; set; }
        public double? TotalMeasuredDepth { get; set; }
        public double? FormationTemperature { get; set; }
        public byte? UseUneconomicAbanRules { get; set; }
        public string? RingFenceRegimeId { get; set; }
        public int? AllowNegativeWedge { get; set; }
        public byte? ApplyTerminationToChildren { get; set; }
        public int? HonorChildLimit { get; set; }
        public double? TrueVerticalDepth { get; set; }
        public double? TrueVerticalDepthAvg { get; set; }
        public double? TrueVerticalDepthMax { get; set; }
        public double? LateralLength { get; set; }
        public double? TotalLateralLength { get; set; }
        public double? TotalProppantPlaced { get; set; }
        public int CompletionType { get; set; }
        public double? AcidConcentration { get; set; }
        public double? AcidFractureVolume { get; set; }
        public string? RingFenceCalculationId { get; set; }
        public int ForecastMode { get; set; }
    }
}
