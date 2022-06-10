using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TFactSourceLeaseopsValnavVolume
    {
        public string? EntityKey { get; set; }
        public string? AccountKey { get; set; }
        public int? AccountingMonthKey { get; set; }
        public int? ActivityMonthKey { get; set; }
        public int? GrossNetKey { get; set; }
        public int? VendorKey { get; set; }
        public string? ScenarioKey { get; set; }
        public int? SpudDateKey { get; set; }
        public int? RigReleaseDateKey { get; set; }
        public int? OnProductionDateKey { get; set; }
        public int? CcCreateDateKey { get; set; }
        public int? CcTerminationDateKey { get; set; }
        public double? MetricVolume { get; set; }
        public double? ImperialVolume { get; set; }
        public double? BoeVolume { get; set; }
        public double? McfeVolume { get; set; }
        public int? LastProductionDateKey { get; set; }
    }
}
