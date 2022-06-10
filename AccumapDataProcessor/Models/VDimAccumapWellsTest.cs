using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimAccumapWellsTest
    {
        public string BottomHoleLocation { get; set; } = null!;
        public string? SurfaceLocation { get; set; }
        public string? CurrentEventSequence { get; set; }
        public string? WellName { get; set; }
        public string? CurrentLicensee { get; set; }
        public string? LicenseNumber { get; set; }
        public DateTime? LicenseDate { get; set; }
        public string? CurrentStatus { get; set; }
        public string? Zone { get; set; }
        public string? Pool { get; set; }
        public string? Lahee { get; set; }
        public string? Field { get; set; }
        public DateTime? SpudDate { get; set; }
        public DateTime? RigRelease { get; set; }
        public string? Unit { get; set; }
        public string ConfidentialIndicator { get; set; } = null!;
        public DateTime? LastStatusUpdate { get; set; }
        public DateTime? OnProductionDate { get; set; }
        public string? WellType { get; set; }
        public string Province { get; set; } = null!;
        public string? Location { get; set; }
        public string? WellId { get; set; }
        public decimal? TvdDepth { get; set; }
        public decimal? TotalDepth { get; set; }
        public string? Meridian { get; set; }
        public string? Range { get; set; }
        public string? Township { get; set; }
        public string? Section { get; set; }
        public string? Operator { get; set; }
        public string? OperatorAbrev { get; set; }
        public string? OperatorDesc { get; set; }
        public int WellRowCount { get; set; }
        public decimal? SurfaceLatitude { get; set; }
        public decimal? SurfaceLongitude { get; set; }
        public decimal? BottomHoleLatitude { get; set; }
        public decimal? BottomHoleLongitude { get; set; }
        public decimal? KbElevation { get; set; }
        public decimal? GroundElevation { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int? NumOfStages { get; set; }
        public decimal? LowestUpperDepth { get; set; }
        public decimal? HighestLowerDepth { get; set; }
        public decimal? LateralLength { get; set; }
        public string? ServiceCompany { get; set; }
        public string? TreatmentType { get; set; }
        public string? CasingType { get; set; }
        public decimal? TotalStageCount { get; set; }
        public string? WaterVolume { get; set; }
        public string? StimulatedLength { get; set; }
        public string? AverageStageSpacing { get; set; }
        public string ProppantPlaced { get; set; } = null!;
        public string ProppantPumped { get; set; } = null!;
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Fluid { get; set; } = null!;
        public decimal? AfeAmount { get; set; }
        public decimal? FracCost { get; set; }
        public string ProppantPlacedPerStage { get; set; } = null!;
        public string ProppantPumpedPerStage { get; set; } = null!;
        public string FluidPerStage { get; set; } = null!;
        public string WaterPerStage { get; set; } = null!;
        public decimal? StimulatedLengthValue { get; set; }
        public string ProppantPlacedPerStimLength { get; set; } = null!;
        public string ProppantPumpedPerStimLength { get; set; } = null!;
        public string FluidPerStimLength { get; set; } = null!;
        public string WaterPerStimLength { get; set; } = null!;
    }
}
