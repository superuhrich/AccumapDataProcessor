using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntReservesCategory
    {
        public string ObjectId { get; set; } = null!;
        public string ParentId { get; set; } = null!;
        public string EntityId { get; set; } = null!;
        public string PlanDefinitionId { get; set; } = null!;
        public int ReserveCategoryId { get; set; }
        public string? PriceSetId { get; set; }
        public long ForecastChangeDate { get; set; }
        public long EconChangeDate { get; set; }
        public long? CalculationDate { get; set; }
        public byte? AutocalcProcessLoss { get; set; }
        public double? ChanceOfSuccess { get; set; }
        public double? ChanceOfOccurrence { get; set; }
        public byte? EconomicLimitApply { get; set; }
        public DateTime? TerminationDate { get; set; }
        public int AbandonmentDelay { get; set; }
        public double AbandonmentValue { get; set; }
        public int SalvageDelay { get; set; }
        public double SalvageValue { get; set; }
        public string? ForecastChangeUserId { get; set; }
        public byte? HasEconomicResults { get; set; }
        public DateTime? ProjectStart { get; set; }
        public int? EconomicLimitDelay { get; set; }
    }
}
