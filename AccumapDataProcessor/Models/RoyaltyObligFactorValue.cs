using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class RoyaltyObligFactorValue
    {
        public decimal? SysId { get; set; }
        public string? CreateUser { get; set; }
        public string? CreateProgram { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string? LastUpdateUser { get; set; }
        public string? LastUpdateProgram { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal? Version { get; set; }
        public decimal? ProductionDate { get; set; }
        public string? RoyaltyGlobalFactorId { get; set; }
        public decimal? RoyaltyObligationSysId { get; set; }
        public decimal? Factor { get; set; }
        public string? RequiredFlag { get; set; }
        public string? OblGlobalFactorId { get; set; }
    }
}
