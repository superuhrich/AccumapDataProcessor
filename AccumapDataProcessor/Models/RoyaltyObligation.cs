using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class RoyaltyObligation
    {
        public string CreateUser { get; set; } = null!;
        public DateTime CreateDateTime { get; set; }
        public string LastUpdateUser { get; set; } = null!;
        public DateTime LastUpdateDateTime { get; set; }
        public decimal Version { get; set; }
        public decimal SysId { get; set; }
        public string RoyaltyObligationId { get; set; } = null!;
        public decimal WellTractSysId { get; set; }
        public string ProductCode { get; set; } = null!;
        public string? CreateProgram { get; set; }
        public string? LastUpdateProgram { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
    }
}
