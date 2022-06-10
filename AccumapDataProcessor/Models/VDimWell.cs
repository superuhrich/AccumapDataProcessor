using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimWell
    {
        public decimal? WellTractSysId { get; set; }
        public string? WellTractId { get; set; }
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
        public string? WellPaResponsibleUser { get; set; }
        public string? CostCentreName { get; set; }
        public string Corp { get; set; } = null!;
        public string CorpName { get; set; } = null!;
        public string Region { get; set; } = null!;
        public string RegionName { get; set; } = null!;
        public string RegionCode { get; set; } = null!;
        public string District { get; set; } = null!;
        public string DistrictName { get; set; } = null!;
        public string DistrictCode { get; set; } = null!;
        public string Area { get; set; } = null!;
        public string AreaName { get; set; } = null!;
        public string AreaCode { get; set; } = null!;
        public string Facility { get; set; } = null!;
        public string FacilityName { get; set; } = null!;
        public string FacilityCode { get; set; } = null!;
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
