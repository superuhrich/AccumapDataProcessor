using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsAttribute
    {
        public string Uwi { get; set; } = null!;
        public string? CrstatusDesc { get; set; }
        public string? LicenseNo { get; set; }
        public string? SurfLocation { get; set; }
        public decimal? TvdDepth { get; set; }
        public decimal? TotalDepth { get; set; }
        public string? ZoneDesc { get; set; }
        public DateTime? SpudDate { get; set; }
        public DateTime? RigRelease { get; set; }
        public DateTime? OnProductionDate { get; set; }
        public string? DeviationFlag { get; set; }
        public string? StratUnitId { get; set; }
        public string? PrimaryProduct { get; set; }
        public string ProvinceState { get; set; } = null!;
        public string? Location { get; set; }
        public string? WellName { get; set; }
        public decimal? BottomHoleLatitude { get; set; }
        public decimal? BottomHoleLongitude { get; set; }
        public decimal? SurfaceLatitude { get; set; }
        public decimal? SurfaceLongitude { get; set; }
        public DateTime? LastProductionDate { get; set; }
        public string? CurrentLicensee { get; set; }
        public string? OriginalLicensee { get; set; }
        public string? Operator { get; set; }
        public string? Mode { get; set; }
    }
}
