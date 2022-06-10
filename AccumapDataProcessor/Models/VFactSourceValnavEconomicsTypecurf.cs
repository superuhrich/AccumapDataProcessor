using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceValnavEconomicsTypecurf
    {
        public string? EntityGuid { get; set; }
        public DateTime? StepDate { get; set; }
        public double? RoyAdjTotal { get; set; }
        public double? NetOpIncome { get; set; }
        public double? Npv2 { get; set; }
        public double? Npv3 { get; set; }
        public double? Npv4 { get; set; }
        public double? OpWiWiVariable { get; set; }
        public double? OpWiWiFixed { get; set; }
        public double? BtaxPayoutMonths { get; set; }
        public double? BtaxRor { get; set; }
        public double? BtaxProfitRatio { get; set; }
        public string? EntityId { get; set; }
        public string? FormattedId { get; set; }
        public string? Uwi { get; set; }
        public int? ReserveCategoryId { get; set; }
        public string ScenarioType { get; set; } = null!;
        public string? Scenario { get; set; }
    }
}
