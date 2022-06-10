using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class WellMaster
    {
        public string CreateUser { get; set; } = null!;
        public string? CreateProgram { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LastUpdateUser { get; set; } = null!;
        public string? LastUpdateProgram { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal Version { get; set; }
        public decimal SysId { get; set; }
        public decimal ProductionDate { get; set; }
        public string Name { get; set; } = null!;
        public string UniqueWellIdentifier { get; set; } = null!;
        public string ProductionStatus { get; set; } = null!;
        public string SurveySystem { get; set; } = null!;
        public string? DlsLocationException { get; set; }
        public decimal? DlsSubDivision { get; set; }
        public decimal? DlsSection { get; set; }
        public decimal? DlsTownship { get; set; }
        public decimal? DlsRange { get; set; }
        public decimal? DlsMeridian { get; set; }
        public decimal? DlsEventSequence { get; set; }
        public string? NtsLocationException { get; set; }
        public string? NtsQuarterUnit { get; set; }
        public string? NtsUnit { get; set; }
        public string? NtsBlock { get; set; }
        public string? NtsMapNumber1 { get; set; }
        public string? NtsMapNumber2 { get; set; }
        public string? NtsMapNumber3 { get; set; }
        public decimal? NtsEventSequence { get; set; }
        public decimal? OffShoreBlock { get; set; }
        public string? OffShoreTract { get; set; }
        public decimal? OffShoreSubTract { get; set; }
        public string? OffShoreQuadrant { get; set; }
        public string? OnShoreTract { get; set; }
        public string? OnShoreLot { get; set; }
        public string? OnShoreConcession { get; set; }
        public string? OnShoreZone { get; set; }
        public string? FluidType { get; set; }
        public string? FieldCode { get; set; }
        public string? PoolCode { get; set; }
        public string? FieldPoolCode { get; set; }
        public decimal? GovernmentLicenseNumber { get; set; }
        public string? UserDefined1 { get; set; }
        public string? UserDefined2 { get; set; }
        public string? ReportLiquidAsCondensate { get; set; }
        public string? ReportZeroProduction { get; set; }
        public string? HeavyOil { get; set; }
        public string? PartnerOperatedRegistryId { get; set; }
        public string? MbWellType { get; set; }
        public string? CapSolutionWellType { get; set; }
        public string? CommingledWellType { get; set; }
        public string? RecombinedLiquidAndGas { get; set; }
        public string? MeasurementType { get; set; }
        public string? ReportingWellIdentifier { get; set; }
        public string? BatteryFacilityId { get; set; }
        public decimal? RoyaltyEntitySysId { get; set; }
        public decimal? OilRoyaltyEntitySysId { get; set; }
        public string? CostCentreCode { get; set; }
        public string WellId { get; set; } = null!;
        public string PaResponsibleUserId { get; set; } = null!;
        public string? WaterTypeCode { get; set; }
        public string? OnShoreTownship { get; set; }
        public decimal? WellDepth { get; set; }
    }
}
