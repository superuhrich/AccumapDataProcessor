using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceValnavProductionBudgetFinal
    {
        public string? EntityKey { get; set; }
        public int? ActivityDateKey { get; set; }
        public string AccountKey { get; set; } = null!;
        public string? ReserveCategoryId { get; set; }
        public string? ScenarioKey { get; set; }
        public string ScenarioType { get; set; } = null!;
        public string GrossNetKey { get; set; } = null!;
        public string NormalizedTimeKey { get; set; } = null!;
        public double? ImperialVolume { get; set; }
        public double? BoeVolume { get; set; }
        public double? MetricVolume { get; set; }
        public double? McfeVolume { get; set; }
    }
}
