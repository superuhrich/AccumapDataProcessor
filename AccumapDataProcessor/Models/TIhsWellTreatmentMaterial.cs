using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsWellTreatmentMaterial
    {
        public string Uwi { get; set; } = null!;
        public string Source { get; set; } = null!;
        public string DataSource { get; set; } = null!;
        public decimal TreatmentObsNo { get; set; }
        public string StageNo { get; set; } = null!;
        public decimal MaterialObsNo { get; set; }
        public decimal IngredientObsNo { get; set; }
        public string? ActiveInd { get; set; }
        public decimal? AdditiveConc { get; set; }
        public string? AdditiveConcUom { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? HazardousInd { get; set; }
        public decimal? HfFluidConc { get; set; }
        public string? HfFluidConcUom { get; set; }
        public string? MaterialCas { get; set; }
        public string? MaterialDescription { get; set; }
        public string? MaterialDescType { get; set; }
        public decimal? MaterialPumped { get; set; }
        public string? MaterialPumpedUom { get; set; }
        public decimal? MaterialPlaced { get; set; }
        public string? MaterialPlacedUom { get; set; }
        public string? MaterialOrigin { get; set; }
        public string MaterialPurpose { get; set; } = null!;
        public DateTime? MaterialStartTime { get; set; }
        public DateTime? MaterialEndTime { get; set; }
        public string? MaterialTimeZone { get; set; }
        public string? MeshSize { get; set; }
        public string? PpdmGuid { get; set; }
        public string ProvinceState { get; set; } = null!;
        public string? PurposeType { get; set; }
        public string? Remark { get; set; }
        public string? StageType { get; set; }
        public string? Supplier { get; set; }
        public string? TradeName { get; set; }
        public string? TradeSecretInd { get; set; }
        public string? WellTestType { get; set; }
        public string? WellTestNum { get; set; }
        public string? WellTestRunNum { get; set; }
        public string? WellTestSource { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowQuality { get; set; }
    }
}
