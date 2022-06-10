using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class IndianRoyaltyEntity
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
        public string RoyaltyEntityId { get; set; } = null!;
        public string RoyaltyEntityType { get; set; } = null!;
    }
}
