using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsWellDescription1
    {
        public string Uwi { get; set; } = null!;
        public string? Location { get; set; }
        public string? WellId { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? Class { get; set; }
        public string? ClassDesc { get; set; }
        public string? Crstatus { get; set; }
        public string? CrstatusDesc { get; set; }
        public string? Operator { get; set; }
        public string? OperatorDesc { get; set; }
        public string? Field { get; set; }
        public string? FieldDesc { get; set; }
        public string? Pool { get; set; }
        public string? PoolDesc { get; set; }
        public string? Unit { get; set; }
        public string? UnitDesc { get; set; }
        public string? SurfLocation { get; set; }
        public decimal? KbElev { get; set; }
        public decimal? GroundElev { get; set; }
        public decimal? TotalDepth { get; set; }
        public decimal? TvdDepth { get; set; }
        public string? NodeId { get; set; }
        public string? BaseNodeId { get; set; }
        public string? WellName { get; set; }
        public string? FormAtTd { get; set; }
        public decimal? FormAtTdTop { get; set; }
        public string? FormAtTdDesc { get; set; }
        public DateTime? SpudDate { get; set; }
        public DateTime? RigRelease { get; set; }
        public DateTime? LicenseDate { get; set; }
        public string? LicenseNo { get; set; }
        public string? DeviationFlag { get; set; }
        public string? Battery { get; set; }
        public string? Licensee { get; set; }
        public string? LicenseeDesc { get; set; }
        public string? OperatorAbrev { get; set; }
        public string? OldestForm { get; set; }
        public decimal? OldestFormTop { get; set; }
        public string? OldestFormDesc { get; set; }
        public string? Zone { get; set; }
        public decimal? ZoneTop { get; set; }
        public string? ZoneDesc { get; set; }
        public string? Zone2 { get; set; }
        public decimal? Zone2Top { get; set; }
        public string? Zone2Desc { get; set; }
        public string? Zone3 { get; set; }
        public decimal? Zone3Top { get; set; }
        public string? Zone3Desc { get; set; }
        public string? Zone4 { get; set; }
        public decimal? Zone4Top { get; set; }
        public string? Zone4Desc { get; set; }
        public string? Zone5 { get; set; }
        public decimal? Zone5Top { get; set; }
        public string? Zone5Desc { get; set; }
        public string? Zone6 { get; set; }
        public decimal? Zone6Top { get; set; }
        public string? Zone6Desc { get; set; }
        public string? Zone7 { get; set; }
        public decimal? Zone7Top { get; set; }
        public string? Zone7Desc { get; set; }
        public string? Source { get; set; }
        public string ProvinceState { get; set; } = null!;
        public string? RowChangedBy { get; set; }
        public string? RowCreatedBy { get; set; }
        public string? RowQuality { get; set; }
        public string? StratNameSetId { get; set; }
    }
}
