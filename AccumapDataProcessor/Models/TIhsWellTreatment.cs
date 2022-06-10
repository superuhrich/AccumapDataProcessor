using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsWellTreatment
    {
        public string Uwi { get; set; } = null!;
        public string Source { get; set; } = null!;
        public decimal TreatmentObsNo { get; set; }
        public string DataSource { get; set; } = null!;
        public string? ActiveInd { get; set; }
        public string? AdditiveType { get; set; }
        public decimal? BaseDepth { get; set; }
        public string? BaseDepthOuom { get; set; }
        public decimal? BaseStratAge { get; set; }
        public string? BaseStratUnitId { get; set; }
        public decimal? BaseTvdDepth { get; set; }
        public string? BaseTvdDepthUom { get; set; }
        public decimal? CompletionObsNo { get; set; }
        public string? CompletionSource { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? EstimatedEndDate { get; set; }
        public DateTime? EstimatedStartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? FormBreakPressure { get; set; }
        public string? FormBreakPressureOuom { get; set; }
        public decimal? InjectionRate { get; set; }
        public string? InjectionRateOuom { get; set; }
        public decimal? InstantSiPressure { get; set; }
        public string? InstantSiPressureOuom { get; set; }
        public string? PpdmGuid { get; set; }
        public string? PressurePumpBaId { get; set; }
        public decimal? ProppantAgentAmount { get; set; }
        public string? ProppantAgentAmountOuom { get; set; }
        public string? ProppantAgentAmountUom { get; set; }
        public decimal? ProppantAgentMeshSize { get; set; }
        public string? ProppantAgentType { get; set; }
        public string ProvinceState { get; set; } = null!;
        public string? RefracReasonDesc { get; set; }
        public string? Remark { get; set; }
        public string? RunNum { get; set; }
        public string? StageNo { get; set; }
        public string? StageType { get; set; }
        public string? StratNameSetId { get; set; }
        public string? TestNum { get; set; }
        public string? TestType { get; set; }
        public decimal? TopDepth { get; set; }
        public string? TopDepthOuom { get; set; }
        public decimal? TopStratAge { get; set; }
        public string? TopStratUnitId { get; set; }
        public decimal? TopTvdDepth { get; set; }
        public string? TopTvdDepthUom { get; set; }
        public decimal? TreatmentAmount { get; set; }
        public string? TreatmentAmountOuom { get; set; }
        public string? TreatmentAmountUom { get; set; }
        public string? TreatmentBaId { get; set; }
        public DateTime? TreatmentDate { get; set; }
        public string? TreatmentFluidType { get; set; }
        public decimal? TreatmentPressure { get; set; }
        public string? TreatmentPressureOuom { get; set; }
        public string? TreatmentStatus { get; set; }
        public string? TreatmentStatusType { get; set; }
        public string? TreatmentType { get; set; }
        public string? WellTestSource { get; set; }
        public string? XCasingIndType { get; set; }
        public decimal? XFracGradient { get; set; }
        public string? XFracGradientUom { get; set; }
        public string? XLinerInd { get; set; }
        public decimal? XMaxInjectionRate { get; set; }
        public string? XMaxInjectionUom { get; set; }
        public decimal? XMaxTreatmentPressure { get; set; }
        public string? XMaxPressureUom { get; set; }
        public decimal? XTreatmentTemperature { get; set; }
        public string? XTemperatureUom { get; set; }
        public decimal? XTotalNumberStages { get; set; }
        public decimal? XTotalWaterVolume { get; set; }
        public string? XTotalWaterUom { get; set; }
        public DateTime? XTreatmentEndDate { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowQuality { get; set; }
        public string? CompletionDesign { get; set; }
    }
}
