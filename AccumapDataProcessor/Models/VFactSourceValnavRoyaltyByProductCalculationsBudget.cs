using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceValnavRoyaltyByProductCalculationsBudget
    {
        public string? EntityId { get; set; }
        public int? ActivityDateKey { get; set; }
        public int? ProductId { get; set; }
        public string? Uwi { get; set; }
        public string? ReserveCategoryId { get; set; }
        public string Accounts { get; set; } = null!;
        public string ScenarioType { get; set; } = null!;
        public string? Scenario { get; set; }
        public string? NormalizedTimeKey { get; set; }
        public double GrossRevenue { get; set; }
        public double WiRevenue { get; set; }
        public double RiRevenue { get; set; }
        public double FiRevenue { get; set; }
        public double NetRevenue { get; set; }
        public double? RoyAdjCrown { get; set; }
        public double? RoyAdjFreehold { get; set; }
        public double? RoyAdjGor { get; set; }
        public double? RoyAdjIndian { get; set; }
        public double? RoyGrGor { get; set; }
        public double? UnadjustedGorRoyalty { get; set; }
        public double? GorRoyalty { get; set; }
        public double? GorRoyaltyDeductions { get; set; }
        public double FreeholdRoyalty { get; set; }
        public double UnadjustedFreeholdRoyalty { get; set; }
        public double FreeholdRoyaltyDeductions { get; set; }
        public double IndianRoyalty { get; set; }
        public double CrownRoyalty { get; set; }
        public double UnadjustedCrownRoyalty { get; set; }
        public double CrownRoyaltyDeductions { get; set; }
        public double? MineralTaxRoyalty { get; set; }
        public double? SaskCapSurchargeRoyalty { get; set; }
    }
}
