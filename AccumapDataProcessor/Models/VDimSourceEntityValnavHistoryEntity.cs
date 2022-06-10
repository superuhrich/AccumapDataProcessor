﻿using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimSourceEntityValnavHistoryEntity
    {
        public string? EntityKey { get; set; }
        public string? EntityName { get; set; }
        public string? CostCentre { get; set; }
        public string? CostCentreName { get; set; }
        public string? Corp { get; set; }
        public string? CorpName { get; set; }
        public string? Region { get; set; }
        public string? RegionName { get; set; }
        public string? RegionCode { get; set; }
        public string? District { get; set; }
        public string? DistrictName { get; set; }
        public string? DistrictCode { get; set; }
        public string? Area { get; set; }
        public string? AreaName { get; set; }
        public string? AreaCode { get; set; }
        public string? Facility { get; set; }
        public string? FacilityName { get; set; }
        public string? FacilityCode { get; set; }
        public string? CcType { get; set; }
        public string? CcTypeCode { get; set; }
        public string? BudgetGroup { get; set; }
        public string? BudgetYear { get; set; }
        public string? ValnavBudgetYear { get; set; }
        public string? OpNonop { get; set; }
        public string? Origin { get; set; }
        public string? Province { get; set; }
        public string? CreateDate { get; set; }
        public string? SpudDate { get; set; }
        public string? OnProductionDate { get; set; }
        public string? LastProductionDate { get; set; }
        public string? AcquiredFrom { get; set; }
        public string? CurrentReserveProperty { get; set; }
        public string? DispositionPackage { get; set; }
        public string? DispositionType { get; set; }
        public string? DispositionArea { get; set; }
        public string? DispositionFacility { get; set; }
        public string? DisposedFlag { get; set; }
        public string? FocusAreaFlag { get; set; }
        public string? PrimaryProduct { get; set; }
        public string? Cgu { get; set; }
        public decimal? WorkingInterest { get; set; }
        public string? YearEndReserveProperty { get; set; }
        public string? UnitCcNum { get; set; }
        public string? UnitCcName { get; set; }
        public string? SurveySystemCode { get; set; }
        public string? Uwi { get; set; }
        public string? UwiDesc { get; set; }
        public string? Meridian { get; set; }
        public string? Range { get; set; }
        public string? Township { get; set; }
        public string? Section { get; set; }
        public string? TaxPools { get; set; }
        public string? StratUnitId { get; set; }
        public string? CrstatusDesc { get; set; }
        public string? LicenseNo { get; set; }
        public string? SurfLocation { get; set; }
        public decimal? TvdDepth { get; set; }
        public decimal? TotalDepth { get; set; }
        public string? ZoneDesc { get; set; }
        public string? DeviationFlag { get; set; }
        public string? FormattedUwi { get; set; }
        public decimal? BottomHoleLatitude { get; set; }
        public decimal? BottomHoleLongitude { get; set; }
        public decimal? SurfaceLatitude { get; set; }
        public decimal? SurfaceLongitude { get; set; }
        public decimal? GasShrinkageFactor { get; set; }
        public decimal? NglYieldFactor { get; set; }
        public string? PvunitCompletionName { get; set; }
        public string? PvunitName { get; set; }
        public string? PvunitShortName { get; set; }
        public string EntitySource { get; set; } = null!;
        public int IsCcDim { get; set; }
        public string? CcTermDate { get; set; }
        public decimal? ChanceOfSuccess { get; set; }
        public string? BudgetQuarter { get; set; }
        public string? CapitalGroup { get; set; }
        public string? CapitalType { get; set; }
        public string? DeRisk { get; set; }
        public decimal? DepthGci { get; set; }
        public string? DrillDays { get; set; }
        public string? Nra { get; set; }
        public string? ReserveRealizedDate { get; set; }
        public decimal? RoyaltyIncomeInterest { get; set; }
        public string? WellDirection { get; set; }
        public string? ZonePlay { get; set; }
        public int IsValnav { get; set; }
        public string? BudgetYearGroup { get; set; }
        public string? OriginGroup { get; set; }
        public decimal? CcNumWorkingInterestPct { get; set; }
    }
}
