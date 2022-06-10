using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VEwfWellboreInfo
    {
        public string? Wellbore { get; set; }
        public string? WellName { get; set; }
        public string? District { get; set; }
        public string? Area { get; set; }
        public string? Facility { get; set; }
        public string? LicenseNumber { get; set; }
        public DateTime? LicenseDate { get; set; }
        public string? SurfaceLocation { get; set; }
        public string? BottomHoleLocation { get; set; }
        public string? CurrentLicensee { get; set; }
        public string? ProductionFacility { get; set; }
        public string? ConfidentialIndicator { get; set; }
        public string? Lahee { get; set; }
        public string? CurrentUwi { get; set; }
        public string? CurrentEventSequence { get; set; }
        public DateTime? SpudDate { get; set; }
        public DateTime? RigReleaseDate { get; set; }
        public DateTime? LastStatusUpdateDate { get; set; }
        public string? Field { get; set; }
        public string? FormattedWbid { get; set; }
        public string? SortedWbid { get; set; }
        public string? PrimaryProduct { get; set; }
        public long? RowId { get; set; }
    }
}
