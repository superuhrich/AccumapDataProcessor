using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class UnitTract
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
        public decimal ProductionPercent { get; set; }
        public decimal? CrownPercent { get; set; }
        public decimal? FreeholdPercent { get; set; }
        public decimal? CrownAcquiredPercent { get; set; }
        public decimal? FederalPercent { get; set; }
        public string? UnitizedWellId { get; set; }
        public string TractId { get; set; } = null!;
        public string? ProductCode { get; set; }
        public string UnitId { get; set; } = null!;
    }
}
