using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimSourceMetrixWellTract
    {
        public decimal WellTractSysId { get; set; }
        public string WellTractId { get; set; } = null!;
        public string WellTractTypeCode { get; set; } = null!;
        public string WellTractType { get; set; } = null!;
        public string? WellTractProvince { get; set; }
        public string? WellTractName { get; set; }
        public string? CostCentreCode { get; set; }
        public string? UniqueIdentifier { get; set; }
        public string? Uwi { get; set; }
        public string? FormattedUwi { get; set; }
        public string? ProductionStatus { get; set; }
        public string? PrimaryProduct { get; set; }
        public string? WellFacilityId { get; set; }
        public string? WellPaResponsibleUserId { get; set; }
        public string WellPaResponsibleUser { get; set; } = null!;
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
        public string? ReportLiquidAsCondensate { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public string? UnitProvince { get; set; }
        public string? UnitGovtCode { get; set; }
        public string? UnitCostCentreCode { get; set; }
        public string? SpudDate { get; set; }
        public string? RigReleaseDate { get; set; }
        public string? OnProductionDate { get; set; }
        public string? CreateDate { get; set; }
        public string? CcTermDate { get; set; }
        public string? Cgu { get; set; }
        public string? CurrentReservesProperty { get; set; }
        public string? YearEndReservesProperty { get; set; }
        public string? DispositionPackage { get; set; }
        public string? RoyaltyEntityId { get; set; }
        public string? OilRoyaltyEntityId { get; set; }
        public string? ReserveCode { get; set; }
        public decimal? CrownRoyaltyPercent { get; set; }
        public decimal? FreeholdRoyaltyPercent { get; set; }
        public decimal? FederalPercent { get; set; }
        public string? AcquiredFrom { get; set; }
    }
}
