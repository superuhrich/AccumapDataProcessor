using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class PlantMaster
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
        public string? UserDefined1 { get; set; }
        public string? UserDefined2 { get; set; }
        public string? RegistryProvince { get; set; }
        public string? RegistryEntityType { get; set; }
        public string? RegistryGovernmentCode { get; set; }
        public string GovernmentCode { get; set; } = null!;
        public string? CostCentreCode { get; set; }
        public string ProductionStatus { get; set; } = null!;
        public string EndOfStreamFacility { get; set; } = null!;
        public string SurveySystem { get; set; } = null!;
        public string? DlsLocationException { get; set; }
        public decimal? DlsSubDivision { get; set; }
        public decimal? DlsRange { get; set; }
        public decimal? DlsSection { get; set; }
        public decimal? DlsTownship { get; set; }
        public decimal? DlsEventSequence { get; set; }
        public string? NtsLocationException { get; set; }
        public string? NtsQuarterUnit { get; set; }
        public string? NtsUnit { get; set; }
        public decimal? DlsMeridian { get; set; }
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
        public string? OilPipelineSplit { get; set; }
        public string? GasPipelineSplit { get; set; }
        public string? PraFacility { get; set; }
        public string? ProcessVolumetrics { get; set; }
        public string? Bc08Facility { get; set; }
        public string? Bc09Facility { get; set; }
        public string? WestfloReceiptPoint { get; set; }
        public string? ReceiptPoint { get; set; }
        public string? WatertonPlant { get; set; }
        public string? DefaultS2DeliveryCode { get; set; }
        public string? CtpRegistryGovernmentCode { get; set; }
        public string? CtpRegistryProvince { get; set; }
        public string? CtpRegistryEntityType { get; set; }
        public string PlantFacilityId { get; set; } = null!;
        public string FacilityOperatorId { get; set; } = null!;
        public string PaResponsibleUserId { get; set; } = null!;
        public string? OnShoreTownship { get; set; }
        public string ProcessSafoafFlag { get; set; } = null!;
    }
}
