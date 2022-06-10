using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsPden
    {
        public string PdenId { get; set; } = null!;
        public string PdenType { get; set; } = null!;
        public string Source { get; set; } = null!;
        public string? ActiveInd { get; set; }
        public string? Country { get; set; }
        public string? CurrentOperator { get; set; }
        public string? CurrentProdStrName { get; set; }
        public DateTime? CurrentStatusDate { get; set; }
        public string? CurrentWellStrNumber { get; set; }
        public string? District { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? EnhancedRecoveryType { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? FieldId { get; set; }
        public string? GeographicRegion { get; set; }
        public string? GeologicProvince { get; set; }
        public DateTime? LastInjectionDate { get; set; }
        public DateTime? LastProductionDate { get; set; }
        public DateTime? LastReportedDate { get; set; }
        public string? LocationDesc { get; set; }
        public string? LocationDescType { get; set; }
        public DateTime? OnInjectionDate { get; set; }
        public DateTime? OnProductionDate { get; set; }
        public string? PdenName { get; set; }
        public string? PdenShortName { get; set; }
        public string? PdenStatus { get; set; }
        public string? PlotName { get; set; }
        public string? PlotSymbol { get; set; }
        public string? PoolId { get; set; }
        public string? PpdmGuid { get; set; }
        public string? PrimaryProduct { get; set; }
        public string? ProductionMethod { get; set; }
        public string? ProprietaryInd { get; set; }
        public string? ProvinceState { get; set; }
        public string? Remark { get; set; }
        public string? StateOrFederalWaters { get; set; }
        public string? StratNameSetId { get; set; }
        public string? StratUnitId { get; set; }
        public string? StringSerialNumber { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowQuality { get; set; }
        public decimal? XTopDepth { get; set; }
        public decimal? XBaseDepth { get; set; }
        public string? XUnitId { get; set; }
        public string? XAllowType { get; set; }
        public string? XBlockId { get; set; }
        public string? XPsuSurplusInd { get; set; }
        public string? XProjectId { get; set; }
        public string? XProdFreq { get; set; }
        public string? XProdSpacingUnit { get; set; }
        public decimal? XUnitOilInterest { get; set; }
        public decimal? XUnitGasInterest { get; set; }
        public string? XSpecialPsuSurplus { get; set; }
        public string? XSpecialPenaltyRelief { get; set; }
        public string? XPenaltyRelief { get; set; }
        public DateTime? XSetGorDate { get; set; }
        public decimal? XSetGor { get; set; }
        public string? XPendS4Ind { get; set; }
        public string? XFacilityId { get; set; }
        public string? XControlWellInd { get; set; }
        public string? XOilDensity { get; set; }
        public string? XOffTarget { get; set; }
        public string? XDispInjApproval { get; set; }
        public decimal? XDispInjApprovalNumber { get; set; }
        public decimal? XWellheadPress { get; set; }
        public string? XBatteryId { get; set; }
        public string? XCommingled { get; set; }
        public decimal? TopStratAge { get; set; }
        public decimal? BaseStratAge { get; set; }
        public DateTime? XOnprodOil { get; set; }
        public DateTime? XOnprodGas { get; set; }
        public DateTime? XOnprodWater { get; set; }
        public string? FacilityType { get; set; }
    }
}
