using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VQbyteCorpHierarchy
    {
        public string? HierarchyCode { get; set; }
        public string? ReportingCodeLevel1 { get; set; }
        public string? ReportingEntityLocation1 { get; set; }
        public string? CorpCode { get; set; }
        public string? CorpName { get; set; }
        public string? ReportingCodeLevel2 { get; set; }
        public string? ReportingEntityLocation2 { get; set; }
        public string? RegionCode { get; set; }
        public string? RegionName { get; set; }
        public string? ReportingCodeLevel3 { get; set; }
        public string? ReportingEntityLocation3 { get; set; }
        public string? DistrictCode { get; set; }
        public string? DistrictName { get; set; }
        public string? ReportingCodeLevel4 { get; set; }
        public string? ReportingEntityLocation4 { get; set; }
        public string? AreaCode { get; set; }
        public string? AreaName { get; set; }
        public decimal? AreaEntityId { get; set; }
        public string? AreaSelect { get; set; }
        public string? ReportingCodeLevel5 { get; set; }
        public string? ReportingEntityLocation5 { get; set; }
        public string? FacilityCode { get; set; }
        public string? FacilityName { get; set; }
        public decimal? FacilityEntityId { get; set; }
        public string? ReportingCodeLevel6 { get; set; }
        public string? ReportingEntityLocation6 { get; set; }
        public string? CostCentre { get; set; }
        public string? CostCentreName { get; set; }
        public string SortKey { get; set; } = null!;
    }
}
