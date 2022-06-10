using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimValnavCorporateHierarchyBcd
    {
        public string? EntityKey { get; set; }
        public string? EntityName { get; set; }
        public string? FormattedUwi { get; set; }
        public string CostCentre { get; set; } = null!;
        public string CostCentreName { get; set; } = null!;
        public string? UnitCcNum { get; set; }
        public string? UnitCcName { get; set; }
        public string Facility { get; set; } = null!;
        public string FacilityName { get; set; } = null!;
        public string? FacilityCode { get; set; }
        public string Area { get; set; } = null!;
        public string AreaName { get; set; } = null!;
        public string? AreaCode { get; set; }
        public string District { get; set; } = null!;
        public string DistrictName { get; set; } = null!;
        public string? DistrictCode { get; set; }
        public string Region { get; set; } = null!;
        public string RegionName { get; set; } = null!;
        public string? RegionCode { get; set; }
        public string Corp { get; set; } = null!;
        public string CorpName { get; set; } = null!;
        public string? Province { get; set; }
        public string? ZonePlay { get; set; }
        public string? WellDirection { get; set; }
        public string? OpNonop { get; set; }
        public string? CapitalType { get; set; }
        public string? BudgetYear { get; set; }
        public string? ValnavBudgetYear { get; set; }
        public string? BudgetQuarter { get; set; }
        public string? DeRisk { get; set; }
        public string? Nra { get; set; }
        public string? ReserveRealizedDate { get; set; }
        public string? SpudDate { get; set; }
        public string? RigReleaseDate { get; set; }
        public string? DrillDays { get; set; }
        public string? CapitalGroup { get; set; }
        public decimal? DepthGci { get; set; }
        public decimal? ChanceOfSuccess { get; set; }
        public decimal? WorkingInterestPct { get; set; }
        public decimal? RoyaltyIncomeInterest { get; set; }
        public string BaseDeclineFlag { get; set; } = null!;
        public string? PrimaryProduct { get; set; }
        public string? OnProductionDate { get; set; }
        public string? LastProductionDate { get; set; }
        public string? YearEndReservesProperty { get; set; }
        public string? CurrentReservesProperty { get; set; }
        public string? Cgu { get; set; }
        public string? BudgetGroup { get; set; }
        public string? CcType { get; set; }
        public string? CcTypeCode { get; set; }
        public string? BudgetYearGroup { get; set; }
        public string? FocusAreaFlag { get; set; }
        public string? Origin { get; set; }
        public string? OriginGroup { get; set; }
        public string? TaxPools { get; set; }
        public string? AcquiredFrom { get; set; }
        public string? DisposedFlag { get; set; }
        public string? DispositionArea { get; set; }
        public string? DispositionFacility { get; set; }
        public string? DispositionPackage { get; set; }
        public string? DispositionType { get; set; }
        public decimal? CcNumWorkingInterestPct { get; set; }
        public decimal? LateralLength { get; set; }
        public string? SegmentStartDate { get; set; }
        public string? SurveySystemCode { get; set; }
        public string? Meridian { get; set; }
        public string? Range { get; set; }
        public string? Township { get; set; }
        public string? Section { get; set; }
        public string? CompletionType { get; set; }
        public double? TotalProppantPlaced { get; set; }
        public double? CStar { get; set; }
        public string? ProductionCategory { get; set; }
        public string? IncentiveType { get; set; }
        public string? MeterStation { get; set; }
        public string? TypeCurveKpi { get; set; }
        public string? RoyaltyType { get; set; }
        public string? FirstProdMonth { get; set; }
        public string? Group01 { get; set; }
        public string? Group02 { get; set; }
        public string? Group03 { get; set; }
        public string? Group04 { get; set; }
        public string? Group05 { get; set; }
        public string? Group06 { get; set; }
        public string? Group07 { get; set; }
        public string? Group08 { get; set; }
        public string? Group09 { get; set; }
        public string? Group10 { get; set; }
    }
}
