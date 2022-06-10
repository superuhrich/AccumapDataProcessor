using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TractMaster
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
        public string LegalPresentation { get; set; } = null!;
        public string? ReportLiquidAsCondensate { get; set; }
        public string? CostCentreCode { get; set; }
        public string TractId { get; set; } = null!;
        public decimal CrownMineralPercent { get; set; }
        public decimal FreeholdMineralPercent { get; set; }
        public decimal FederalMineralPercent { get; set; }
    }
}
