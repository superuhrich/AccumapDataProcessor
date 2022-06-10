using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceValnavEconomicsGljreserf
    {
        public string? EntityGuid { get; set; }
        public DateTime? ActvyDate { get; set; }
        public double? RoyAdjTotal { get; set; }
        public double? NetOpIncome { get; set; }
        public double? OpVariable { get; set; }
        public double? OpFixed { get; set; }
        public double? BtaxNetRevenue { get; set; }
        public double? BtaxNpv1 { get; set; }
        public double? BtaxNpv2 { get; set; }
        public double? BtaxNpv3 { get; set; }
        public double? BtaxNpv4 { get; set; }
        public double? BtaxNpv5 { get; set; }
        public double? BtaxPayoutMonths { get; set; }
        public double? BtaxRor { get; set; }
        public double? BtaxProfitRatio { get; set; }
        public double? CapWiAbandonmentSalvage { get; set; }
        public string? EntityId { get; set; }
        public string? FormattedId { get; set; }
        public string? Uwi { get; set; }
        public int? ReserveCategoryId { get; set; }
        public string ScenarioType { get; set; } = null!;
        public string? Scenario { get; set; }
        public int Section { get; set; }
    }
}
