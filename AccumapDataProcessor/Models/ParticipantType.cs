using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class ParticipantType
    {
        public string CreateUser { get; set; } = null!;
        public string? CreateProgram { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LastUpdateUser { get; set; } = null!;
        public string? LastUpdateProgram { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal Version { get; set; }
        public string Description { get; set; } = null!;
        public string? ShortDescription { get; set; }
        public decimal? SortOrder { get; set; }
        public string ActiveValue { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? InTransitUsage { get; set; }
        public string? StorageCrownRoyaltyUsage { get; set; }
        public string? LinePackUsage { get; set; }
        public string? InventoryUsage { get; set; }
        public string? OtherPurchaserUsage { get; set; }
    }
}
