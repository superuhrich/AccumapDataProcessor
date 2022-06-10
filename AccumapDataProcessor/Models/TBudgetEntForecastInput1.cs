using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntForecastInput1
    {
        public string ObjectId { get; set; } = null!;
        public string ParentId { get; set; } = null!;
        public string? EntityId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? PlanDefinitionId { get; set; }
        public int ReservesCategoryId { get; set; }
        public int BasedOn { get; set; }
        public string? ForecastSourceId { get; set; }
        public double? ForecastSourceFactor { get; set; }
        public long ForecastCreateDate { get; set; }
        public string? ForecastCreateUserId { get; set; }
        public long ForecastChangeDate { get; set; }
        public string? ForecastChangeUserId { get; set; }
        public byte HasError { get; set; }
        public DateTime? HistoryCutoff { get; set; }
    }
}
