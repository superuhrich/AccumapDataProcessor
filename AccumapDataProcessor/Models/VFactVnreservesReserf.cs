using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactVnreservesReserf
    {
        public string? EntityKey { get; set; }
        public int? ActivityDateKey { get; set; }
        public string? AccountKey { get; set; }
        public string? ReserveCategoryKey { get; set; }
        public string? ScenarioKey { get; set; }
        public string? GrossNetKey { get; set; }
        public string? NormalizedTimeKey { get; set; }
        public int? ReserveRealizedDateKey { get; set; }
        public double? ImperialVolume { get; set; }
        public double? BoeVolume { get; set; }
        public double? MetricVolume { get; set; }
        public double? McfeVolume { get; set; }
        public int? NumberOfDays { get; set; }
    }
}
