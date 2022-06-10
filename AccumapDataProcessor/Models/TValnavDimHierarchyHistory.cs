using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TValnavDimHierarchyHistory
    {
        public string? EntityGuid { get; set; }
        public string? Uwi { get; set; }
        public string? FormattedUwi { get; set; }
        public string? CcNum { get; set; }
        public string? CcName { get; set; }
        public string? UnitCcNum { get; set; }
        public string? UnitCcName { get; set; }
        public string? Facility { get; set; }
        public string? FacilityName { get; set; }
        public string? Area { get; set; }
        public string? AreaName { get; set; }
        public string? District { get; set; }
        public string? DistrictName { get; set; }
        public string? Region { get; set; }
        public string? RegionName { get; set; }
        public string? ZonePlay { get; set; }
        public string? WellDirection { get; set; }
        public string? OpNonop { get; set; }
        public string? CapitalType { get; set; }
        public string? BudgetYear { get; set; }
        public string? BudgetQuarter { get; set; }
        public string? DeRisk { get; set; }
        public string? Nra { get; set; }
        public string? ReserveRealizedDate { get; set; }
        public string? DrillDays { get; set; }
        public string? CapitalGroup { get; set; }
        public decimal? DepthGci { get; set; }
        public decimal? ChanceOfSuccess { get; set; }
        public decimal? WorkingInterest { get; set; }
        public decimal? RoyaltyIncomeInterest { get; set; }
        public string? Province { get; set; }
        public string? PrimaryProduct { get; set; }
        public string? AreaDisplay { get; set; }
        public string? FacilityDisplay { get; set; }
        public string? DistrictDisplay { get; set; }
        public string? RegionDisplay { get; set; }
        public string? OnProdDate { get; set; }
        public string? CurrentReserveProperty { get; set; }
        public string? YearEndReserveProperty { get; set; }
        public string? Cgu { get; set; }
        public string? BudgetGroup { get; set; }
    }
}
