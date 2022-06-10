using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBasedeclineFiscScenarioParam
    {
        public string ObjectId { get; set; } = null!;
        public string ParentId { get; set; } = null!;
        public string PlanId { get; set; } = null!;
        public byte? EnableAbandonment { get; set; }
        public byte? EnableSaskSurcharge { get; set; }
        public byte? EnableEconLimit { get; set; }
        public byte? EscalatePrice { get; set; }
        public string? PriceDeckId { get; set; }
        public string? CapCostTemplateId { get; set; }
        public string? OpCostTemplateId { get; set; }
        public string? PriceTemplateId { get; set; }
        public double? CosOverride { get; set; }
        public double? CooOverride { get; set; }
        public double? PriceFactor { get; set; }
        public double? OpCostFactor { get; set; }
        public double? CapCostFactor { get; set; }
        public double? ProductionFactor { get; set; }
        public DateTime? ReferenceDate { get; set; }
        public DateTime? DiscountDate { get; set; }
        public double? InflationOverride { get; set; }
        public byte? UseOverlappingHistory { get; set; }
        public int? EconLimitDiscount { get; set; }
        public int? EconLimitCalcType { get; set; }
        public byte? AllowNegWedge { get; set; }
        public int? CapActEconCalcOpt { get; set; }
        public int? EconLimitDelay { get; set; }
        public byte? EnableSharedCalculation { get; set; }
    }
}
