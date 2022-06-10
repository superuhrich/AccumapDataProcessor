using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class IndianReserveWellDetail
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
        public string IncludedExcluded { get; set; } = null!;
        public decimal? TotalSalesValue { get; set; }
        public decimal? TotalRoyaltyValue { get; set; }
        public decimal? GrossRoyaltyPercent { get; set; }
        public decimal? TotalGcaDeduction { get; set; }
        public decimal? RoyaltyNetAmount { get; set; }
        public decimal? WellTractSysId { get; set; }
        public string? UnitId { get; set; }
        public string IndianReserveId { get; set; } = null!;
        public string? ConfidentialWellFlag { get; set; }
    }
}
