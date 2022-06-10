using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class WDetail1
    {
        public string FileNumber { get; set; } = null!;
        public string WellUwi { get; set; } = null!;
        public string FileStatus { get; set; } = null!;
        public DateTime StatusDate { get; set; }
        public string WellName { get; set; } = null!;
        public string WellStatus { get; set; } = null!;
        public string WellType { get; set; } = null!;
        public DateTime WellStatusDate { get; set; }
        public string? Penalty { get; set; }
        public string? GovernmentStatus { get; set; }
        public string? DirectionDrilled { get; set; }
        public string? LessorType { get; set; }
        public string WellLicensee { get; set; } = null!;
        public string? ConfidentFlag { get; set; }
        public string? GovernAgmtOper { get; set; }
        public string? GoverningContract { get; set; }
        public string AdminCompany { get; set; } = null!;
        public string Area { get; set; } = null!;
        public string? District { get; set; }
        public string Division { get; set; } = null!;
        public DateTime? SpudDate { get; set; }
        public DateTime? RigReleaseDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? OnProductionDate { get; set; }
        public DateTime? PayoutDate { get; set; }
        public DateTime? AbandonedDate { get; set; }
        public DateTime? ShutinDate { get; set; }
        public string? ShutinReason { get; set; }
        public DateTime? InjectionDate { get; set; }
        public DateTime? LastProdDate { get; set; }
        public string SortedUwi { get; set; } = null!;
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal? MapLat { get; set; }
        public decimal? MapLong { get; set; }
    }
}
