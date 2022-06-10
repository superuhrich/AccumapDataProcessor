using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsWellFracCalculation
    {
        public string Uwi { get; set; } = null!;
        public decimal CalculationObsNo { get; set; }
        public string Source { get; set; } = null!;
        public string DataSource { get; set; } = null!;
        public string? ActiveInd { get; set; }
        public string? CalculationAttribute { get; set; }
        public string? CalculationPoint { get; set; }
        public string? CalculationType { get; set; }
        public decimal? CalculationValue { get; set; }
        public string? CalculationValueUom { get; set; }
        public string? CalculationFormula { get; set; }
        public decimal? CalculationRank { get; set; }
        public decimal? CompletionObsNo { get; set; }
        public string? CompletionSource { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? MaterialObsNo { get; set; }
        public string? MaterialSource { get; set; }
        public decimal? PerforationObsNo { get; set; }
        public string? PerforationSource { get; set; }
        public string? PpdmGuid { get; set; }
        public string? ProvinceState { get; set; }
        public string? Remark { get; set; }
        public string? StageNo { get; set; }
        public string? StimulationType { get; set; }
        public decimal? TreatmentObsNo { get; set; }
        public string? TreatmentSource { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowQuality { get; set; }
        public decimal? IngredientObsNo { get; set; }
    }
}
