using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsWellStimulation
    {
        public string Uwi { get; set; } = null!;
        public string Source { get; set; } = null!;
        public string DataSource { get; set; } = null!;
        public string StageNo { get; set; } = null!;
        public string StimulationType { get; set; } = null!;
        public decimal TreatmentObsNo { get; set; }
        public decimal StageOccurrenceNo { get; set; }
        public decimal? AcidSpearhead { get; set; }
        public string? AcidSpearheadUom { get; set; }
        public string? AcidType { get; set; }
        public string? ActiveInd { get; set; }
        public decimal? AverageHydraulicPower { get; set; }
        public string? AveragePowerUom { get; set; }
        public decimal? AverageInjectionRate { get; set; }
        public string? AverageInjRateUom { get; set; }
        public decimal? AveragePressure { get; set; }
        public string? AveragePressureUom { get; set; }
        public string? BaseFluid { get; set; }
        public string? ChemicalTraceType { get; set; }
        public decimal? CleanInjectionRate { get; set; }
        public string? CleanInjRateUom { get; set; }
        public string? CompletionDesign { get; set; }
        public decimal? CompletionObsNo { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? Energizer { get; set; }
        public string? EnergizerType { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? FormBreakPressure { get; set; }
        public string? FormBreakPressureUom { get; set; }
        public decimal? FracGradient { get; set; }
        public string? FracGradientUom { get; set; }
        public string? FractureType { get; set; }
        public string? GelType { get; set; }
        public decimal? InstantSiPressure { get; set; }
        public string? InstantSiPressureUom { get; set; }
        public decimal? MaxHydraulicPower { get; set; }
        public string? MaxPowerUom { get; set; }
        public decimal? MaxInjectionRate { get; set; }
        public string? MaxInjRateUom { get; set; }
        public decimal? MaxPressure { get; set; }
        public string? MaxPressureUom { get; set; }
        public decimal? MinHydraulicPower { get; set; }
        public string? MinPowerUom { get; set; }
        public decimal? MinPressure { get; set; }
        public string? MinPressureUom { get; set; }
        public decimal? PlugbackTd { get; set; }
        public string? PlugbackTdUom { get; set; }
        public decimal? PortDepth { get; set; }
        public string? PortDepthUom { get; set; }
        public decimal? PortTvdDepth { get; set; }
        public string? PortTvdUom { get; set; }
        public string? PpdmGuid { get; set; }
        public string? ProblemDesc { get; set; }
        public string? ProblemType { get; set; }
        public string ProvinceState { get; set; } = null!;
        public string? RadioactiveTraceType { get; set; }
        public string? Remark { get; set; }
        public decimal? ReportedInjectionRate { get; set; }
        public string? ReportedInjRateUom { get; set; }
        public decimal? ReportedPressure { get; set; }
        public string? ReportedPressureUom { get; set; }
        public string? ServiceCompany { get; set; }
        public decimal? SlurryInjectionRate { get; set; }
        public string? SlurryInjRateUom { get; set; }
        public decimal? StageBaseDepth { get; set; }
        public string? StageBaseDepthUom { get; set; }
        public decimal? StageBaseTvdDepth { get; set; }
        public string? StageBaseTvdDepthUom { get; set; }
        public decimal? StageDuration { get; set; }
        public string? StageDurationUom { get; set; }
        public DateTime? StageEndTime { get; set; }
        public DateTime? StageStartTime { get; set; }
        public string? StageTimeZone { get; set; }
        public decimal? StageTopDepth { get; set; }
        public string? StageTopDepthUom { get; set; }
        public decimal? StageTopTvdDepth { get; set; }
        public string? StageTopTvdDepthUom { get; set; }
        public string? StageType { get; set; }
        public decimal? TotalCleanFluidPumped { get; set; }
        public string? TotalCleanFluidUom { get; set; }
        public decimal? TotalCo2Pumped { get; set; }
        public string? TotalCo2PumpedUom { get; set; }
        public decimal? TotalCo2Temperature { get; set; }
        public string? TotalCo2TempUom { get; set; }
        public decimal? TotalFluidPumped { get; set; }
        public string? TotalFluidUom { get; set; }
        public decimal? TotalN2Pumped { get; set; }
        public string? TotalN2PumpedUom { get; set; }
        public decimal? TotalN2Temperature { get; set; }
        public string? TotalN2TempUom { get; set; }
        public decimal? TotalRecoveredFluid { get; set; }
        public string? TotalRecoveredFluidUom { get; set; }
        public decimal? TotalSlurryFluidPumped { get; set; }
        public string? TotalSlurryFluidUom { get; set; }
        public decimal? TreatmentTemperature { get; set; }
        public string? TreatmentTemperatureUom { get; set; }
        public decimal? TubingFlowPressure { get; set; }
        public string? TubingFlowPressureUom { get; set; }
        public decimal? WaterVolume { get; set; }
        public string? WaterVolumeUom { get; set; }
        public string? WellTestType { get; set; }
        public string? WellTestNum { get; set; }
        public string? WellTestRunNum { get; set; }
        public string? WellTestSource { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowQuality { get; set; }
        public string? MilledInd { get; set; }
        public string? ScreenoutInd { get; set; }
        public decimal? StageAttemptedNo { get; set; }
    }
}
