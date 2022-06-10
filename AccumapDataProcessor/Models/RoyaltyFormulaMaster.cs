using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class RoyaltyFormulaMaster
    {
        public string? CreateUser { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public decimal? Version { get; set; }
        public decimal? SysId { get; set; }
        public decimal? ProductionDate { get; set; }
        public string? Description { get; set; }
        public string? RoyaltyFormulaId { get; set; }
        public string? CreateProgram { get; set; }
        public string? LastUpdateProgram { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public string? RoyaltyFormulaType { get; set; }
    }
}
